using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* This Program will use an IDS-UI-3130CP2-M-GL USB3.0 camera to acquire 
   at the laser repetition rate of 1 kHz. The AOI of the camera should be adjusted to allow
   for both acquisition and processing of images at this rate. 
   Image processing will involve thresholding, object detection and filtering, and centroiding of hits 
   for a VMI image corresponding to each laser shot. Integration of these shots will allow for fast, 
   low background acquisition. 
   It will also interact with an XPS-Q8 Motion Controller which will scan the time delay between a pump
   and probe pulse, allowing for time-resolved studies with reasonable acquisition rates. */

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public uEye.Camera camera;
        private bool preview = false;
        private bool guiup2date = false;
        private bool camup2date = true;

        private int nframes = 1024;

        private Point pboxorigin;

        private double exptime;
        private int aoix0;
        private int aoiy0;
        private int aoiwidth;
        private int aoiheight;

        private uEye.Types.Range<double> etrange;
        private uEye.Types.Range<int> aoix0range;
        private uEye.Types.Range<int> aoiy0range;
        private uEye.Types.Range<int> aoiwidthrange;
        private uEye.Types.Range<int> aoiheightrange;


        public Form1()
        {
            InitializeComponent();
        }

        // Initialization Routine for Camera object etc.
        private void Form1_Load(object sender, EventArgs e)
        {
            camera = new uEye.Camera();

            // Initialize Camera
            uEye.Defines.Status statusRet = 0;
            statusRet = camera.Init();
            if (statusRet != uEye.Defines.Status.Success)
            {
                camStatusLabel.Text = "Failed to initialize camera";
                return;
            }

            // Get information about AOI, Exposure Time, Framerate etc.
            statusRet = camera.Timing.Exposure.GetRange(out etrange);
            statusRet = camera.Size.AOI.GetPosRange(out aoix0range, out aoiy0range);
            statusRet = camera.Size.AOI.GetSizeRange(out aoiwidthrange, out aoiheightrange);

            statusRet = camera.Size.AOI.Get(out aoix0, out aoiy0, out aoiwidth, out aoiheight);
            statusRet = camera.Timing.Exposure.Get(out exptime);


            if (statusRet != uEye.Defines.Status.Success)
            {
                camStatusLabel.Text = "Failed to retrieve parameters";
                return;
            }

            // Allocate memory
            statusRet = camera.Memory.Allocate();
            if (statusRet != uEye.Defines.Status.Success)
            {
                camStatusLabel.Text = "Failed to allocate memory";
                return;
            }

            // Update graphics etc.
            aoiX0NumericUpDown.Maximum = aoix0range.Maximum;
            aoiX0NumericUpDown.Minimum = aoix0range.Minimum;
            aoiX0NumericUpDown.Increment = aoix0range.Increment;
            aoiX0NumericUpDown.Value = aoix0;

            aoiY0NumericUpDown.Maximum = aoiy0range.Maximum;
            aoiY0NumericUpDown.Minimum = aoiy0range.Minimum;
            aoiY0NumericUpDown.Increment = aoiy0range.Increment;
            aoiY0NumericUpDown.Value = aoiy0;

            aoiWidthNumericUpDown.Maximum = aoiwidthrange.Maximum;
            aoiWidthNumericUpDown.Minimum = aoiwidthrange.Minimum;
            aoiWidthNumericUpDown.Increment = aoiwidthrange.Increment;
            aoiWidthNumericUpDown.Value = aoiwidth;

            aoiHeightNumericUpDown.Maximum = aoiheightrange.Maximum;
            aoiHeightNumericUpDown.Minimum = aoiheightrange.Minimum;
            aoiHeightNumericUpDown.Increment = aoiheightrange.Increment;
            aoiHeightNumericUpDown.Value = aoiheight;

            expTimeNumericUpDown.Maximum = System.Convert.ToDecimal(etrange.Maximum);
            expTimeNumericUpDown.Minimum = System.Convert.ToDecimal(etrange.Minimum);
            expTimeNumericUpDown.Increment = System.Convert.ToDecimal(etrange.Increment);
            expTimeNumericUpDown.Value = System.Convert.ToDecimal(exptime);

            expTimeTrackBar.Maximum = (int) ((etrange.Maximum - etrange.Minimum)/etrange.Increment);
            expTimeTrackBar.Minimum = 0;
            expTimeTrackBar.Value = (int) ((exptime - etrange.Minimum)/etrange.Increment);

            pboxorigin = aoiPictureBox.Location;

            camStatusLabel.Text = "Camera Ready";
            guiup2date = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            camera.Exit();
        }


        private void startPreviewButton_Click(object sender, EventArgs e)
        {
            if ( preview == false)
            {
                preview = true;
                startPreviewButton.Text = "Stop Preview";
            }
            else
            {
                preview = false;
                startPreviewButton.Text = "Start Preview";
            }
        }

        private void expTimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if ( guiup2date ) // basically mutex to stop repeated callbacks
            {
                guiup2date = false;
                exptime = System.Convert.ToDouble(expTimeNumericUpDown.Value);
                uEye.Defines.Status statusRet = 0;
                statusRet = camera.Timing.Exposure.Set(exptime);
                statusRet = camera.Timing.Exposure.Get(out exptime);
                expTimeNumericUpDown.Value = System.Convert.ToDecimal(exptime);
                expTimeTrackBar.Value = (int) ((exptime - etrange.Minimum) / etrange.Increment);
                guiup2date = true;
            }
        }

        private void expTimeTrackBar_Scroll(object sender, EventArgs e)
        {
            if ( guiup2date )
            {
                guiup2date = false;
                exptime = expTimeTrackBar.Value * etrange.Increment + etrange.Minimum;
                uEye.Defines.Status statusRet = 0;
                statusRet = camera.Timing.Exposure.Set(exptime);
                statusRet = camera.Timing.Exposure.Get(out exptime);
                expTimeNumericUpDown.Value = System.Convert.ToDecimal(exptime);
                expTimeTrackBar.Value = (int)((exptime - etrange.Minimum) / etrange.Increment);
                guiup2date = true;
            }
        }

        private void aoiX0NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateAOI();
        }

        private void aoiY0NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateAOI();
        }

        private void aoiWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateAOI();
        }

        private void aoiHeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateAOI();
        }

        private void updateAOI()
        {
            if ( guiup2date )
            {
                guiup2date = false;
                // Use new slider values to update camera parameters
                aoix0 = System.Convert.ToInt32(aoiX0NumericUpDown.Value);
                aoiy0 = System.Convert.ToInt32(aoiY0NumericUpDown.Value);
                aoiwidth = System.Convert.ToInt32(aoiWidthNumericUpDown.Value);
                aoiheight = System.Convert.ToInt32(aoiHeightNumericUpDown.Value);

                uEye.Defines.Status statusRet = 0;
                statusRet = camera.Size.AOI.Set(aoix0, aoiy0, aoiwidth, aoiheight);

                // ranges and position etc may have changed, update the sliders accordingly
                statusRet = camera.Size.AOI.GetPosRange(out aoix0range, out aoiy0range);
                statusRet = camera.Size.AOI.Get(out aoix0, out aoiy0, out aoiwidth, out aoiheight);

                camStatusLabel.Text = new Rectangle(aoix0, aoiy0, aoiwidth, aoiheight).ToString();



                aoiY0NumericUpDown.Maximum = aoiy0range.Maximum;
                aoiY0NumericUpDown.Minimum = aoiy0range.Minimum;
                aoiY0NumericUpDown.Increment = aoiy0range.Increment;
                aoiY0NumericUpDown.Value = aoiy0;

                aoiX0NumericUpDown.Maximum = aoix0range.Maximum;
                aoiX0NumericUpDown.Minimum = aoix0range.Minimum;
                aoiX0NumericUpDown.Increment = aoix0range.Increment;
                aoiX0NumericUpDown.Value = aoix0;

                aoiWidthNumericUpDown.Maximum = aoiwidthrange.Maximum;
                aoiWidthNumericUpDown.Minimum = aoiwidthrange.Minimum;
                aoiWidthNumericUpDown.Increment = aoiwidthrange.Increment;
                aoiWidthNumericUpDown.Value = aoiwidth;

                aoiHeightNumericUpDown.Maximum = aoiheightrange.Maximum;
                aoiHeightNumericUpDown.Minimum = aoiheightrange.Minimum;
                aoiHeightNumericUpDown.Increment = aoiheightrange.Increment;
                aoiHeightNumericUpDown.Value = aoiheight;


                aoiPictureBox.Location = new Point(aoix0 + pboxorigin.X, aoiy0 + pboxorigin.Y);
                aoiPictureBox.Size = new Size(aoiwidth, aoiheight);

                guiup2date = true;
            }
        }

    }
}
