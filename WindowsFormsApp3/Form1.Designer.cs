namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullPictureBox = new System.Windows.Forms.PictureBox();
            this.expTimeTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.startPreviewButton = new System.Windows.Forms.Button();
            this.aoiPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aoiHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aoiWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aoiY0NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aoiX0NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.expTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.thresholdTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.thresholdCheckBox = new System.Windows.Forms.CheckBox();
            this.prefilterCheckBox = new System.Windows.Forms.CheckBox();
            this.flatFieldCheckBox = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.camStatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fullPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTimeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aoiHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiY0NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiX0NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTimeNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullPictureBox
            // 
            this.fullPictureBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.fullPictureBox.Location = new System.Drawing.Point(25, 22);
            this.fullPictureBox.Name = "fullPictureBox";
            this.fullPictureBox.Size = new System.Drawing.Size(800, 600);
            this.fullPictureBox.TabIndex = 0;
            this.fullPictureBox.TabStop = false;
            // 
            // expTimeTrackBar
            // 
            this.expTimeTrackBar.Location = new System.Drawing.Point(32, 173);
            this.expTimeTrackBar.Name = "expTimeTrackBar";
            this.expTimeTrackBar.Size = new System.Drawing.Size(245, 45);
            this.expTimeTrackBar.TabIndex = 1;
            this.expTimeTrackBar.Scroll += new System.EventHandler(this.expTimeTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exposure Time (ms)";
            // 
            // startPreviewButton
            // 
            this.startPreviewButton.Location = new System.Drawing.Point(61, 81);
            this.startPreviewButton.Name = "startPreviewButton";
            this.startPreviewButton.Size = new System.Drawing.Size(158, 32);
            this.startPreviewButton.TabIndex = 3;
            this.startPreviewButton.Text = "Start Preview";
            this.startPreviewButton.UseVisualStyleBackColor = true;
            this.startPreviewButton.Click += new System.EventHandler(this.startPreviewButton_Click);
            // 
            // aoiPictureBox
            // 
            this.aoiPictureBox.BackColor = System.Drawing.Color.SpringGreen;
            this.aoiPictureBox.Location = new System.Drawing.Point(25, 22);
            this.aoiPictureBox.Name = "aoiPictureBox";
            this.aoiPictureBox.Size = new System.Drawing.Size(800, 600);
            this.aoiPictureBox.TabIndex = 9;
            this.aoiPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.aoiHeightNumericUpDown);
            this.groupBox1.Controls.Add(this.aoiWidthNumericUpDown);
            this.groupBox1.Controls.Add(this.aoiY0NumericUpDown);
            this.groupBox1.Controls.Add(this.aoiX0NumericUpDown);
            this.groupBox1.Controls.Add(this.expTimeNumericUpDown);
            this.groupBox1.Controls.Add(this.thresholdTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.thresholdCheckBox);
            this.groupBox1.Controls.Add(this.prefilterCheckBox);
            this.groupBox1.Controls.Add(this.flatFieldCheckBox);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.camStatusLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.startPreviewButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.expTimeTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(852, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 365);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Max Framerate (Hz):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(329, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "height";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "width";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "y0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "x0";
            // 
            // aoiHeightNumericUpDown
            // 
            this.aoiHeightNumericUpDown.Location = new System.Drawing.Point(332, 114);
            this.aoiHeightNumericUpDown.Name = "aoiHeightNumericUpDown";
            this.aoiHeightNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.aoiHeightNumericUpDown.TabIndex = 27;
            this.aoiHeightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aoiHeightNumericUpDown.ValueChanged += new System.EventHandler(this.aoiHeightNumericUpDown_ValueChanged);
            // 
            // aoiWidthNumericUpDown
            // 
            this.aoiWidthNumericUpDown.Location = new System.Drawing.Point(248, 114);
            this.aoiWidthNumericUpDown.Name = "aoiWidthNumericUpDown";
            this.aoiWidthNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.aoiWidthNumericUpDown.TabIndex = 26;
            this.aoiWidthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aoiWidthNumericUpDown.ValueChanged += new System.EventHandler(this.aoiWidthNumericUpDown_ValueChanged);
            // 
            // aoiY0NumericUpDown
            // 
            this.aoiY0NumericUpDown.Location = new System.Drawing.Point(332, 68);
            this.aoiY0NumericUpDown.Name = "aoiY0NumericUpDown";
            this.aoiY0NumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.aoiY0NumericUpDown.TabIndex = 25;
            this.aoiY0NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aoiY0NumericUpDown.ValueChanged += new System.EventHandler(this.aoiY0NumericUpDown_ValueChanged);
            // 
            // aoiX0NumericUpDown
            // 
            this.aoiX0NumericUpDown.Location = new System.Drawing.Point(248, 68);
            this.aoiX0NumericUpDown.Name = "aoiX0NumericUpDown";
            this.aoiX0NumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.aoiX0NumericUpDown.TabIndex = 24;
            this.aoiX0NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aoiX0NumericUpDown.ValueChanged += new System.EventHandler(this.aoiX0NumericUpDown_ValueChanged);
            // 
            // expTimeNumericUpDown
            // 
            this.expTimeNumericUpDown.DecimalPlaces = 4;
            this.expTimeNumericUpDown.Location = new System.Drawing.Point(289, 174);
            this.expTimeNumericUpDown.Name = "expTimeNumericUpDown";
            this.expTimeNumericUpDown.Size = new System.Drawing.Size(97, 20);
            this.expTimeNumericUpDown.TabIndex = 23;
            this.expTimeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expTimeNumericUpDown.ValueChanged += new System.EventHandler(this.expTimeNumericUpDown_ValueChanged);
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Location = new System.Drawing.Point(115, 235);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(75, 20);
            this.thresholdTextBox.TabIndex = 22;
            this.thresholdTextBox.Text = "0-1";
            this.thresholdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Threshold:";
            // 
            // thresholdCheckBox
            // 
            this.thresholdCheckBox.AutoSize = true;
            this.thresholdCheckBox.Location = new System.Drawing.Point(248, 235);
            this.thresholdCheckBox.Name = "thresholdCheckBox";
            this.thresholdCheckBox.Size = new System.Drawing.Size(87, 17);
            this.thresholdCheckBox.TabIndex = 20;
            this.thresholdCheckBox.Text = "Thresholding";
            this.thresholdCheckBox.UseVisualStyleBackColor = true;
            // 
            // prefilterCheckBox
            // 
            this.prefilterCheckBox.AutoSize = true;
            this.prefilterCheckBox.Location = new System.Drawing.Point(248, 258);
            this.prefilterCheckBox.Name = "prefilterCheckBox";
            this.prefilterCheckBox.Size = new System.Drawing.Size(75, 17);
            this.prefilterCheckBox.TabIndex = 19;
            this.prefilterCheckBox.Text = "Prefiltering";
            this.prefilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // flatFieldCheckBox
            // 
            this.flatFieldCheckBox.AutoSize = true;
            this.flatFieldCheckBox.Location = new System.Drawing.Point(248, 281);
            this.flatFieldCheckBox.Name = "flatFieldCheckBox";
            this.flatFieldCheckBox.Size = new System.Drawing.Size(120, 17);
            this.flatFieldCheckBox.TabIndex = 18;
            this.flatFieldCheckBox.Text = "Flat FIeld Correction";
            this.flatFieldCheckBox.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Location = new System.Drawing.Point(32, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 32);
            this.button6.TabIndex = 17;
            this.button6.Text = "Acquire Flat Field";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // camStatusLabel
            // 
            this.camStatusLabel.AutoSize = true;
            this.camStatusLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.camStatusLabel.Location = new System.Drawing.Point(15, 336);
            this.camStatusLabel.Name = "camStatusLabel";
            this.camStatusLabel.Size = new System.Drawing.Size(50, 13);
            this.camStatusLabel.TabIndex = 15;
            this.camStatusLabel.Text = "STATUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Area Of Interest";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(852, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 231);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stage Controls";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 6;
            this.numericUpDown4.Location = new System.Drawing.Point(209, 187);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown4.TabIndex = 35;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "step";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 6;
            this.numericUpDown3.Location = new System.Drawing.Point(321, 98);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown3.TabIndex = 33;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "maximum";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 6;
            this.numericUpDown2.Location = new System.Drawing.Point(224, 98);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown2.TabIndex = 31;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "minimum";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 6;
            this.numericUpDown1.Location = new System.Drawing.Point(224, 49);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 136);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(379, 45);
            this.trackBar1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PaleGreen;
            this.label10.Location = new System.Drawing.Point(347, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "STATUS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Absolute Position:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 32);
            this.button4.TabIndex = 17;
            this.button4.Text = "Travel To Time Zero";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Set Time Zero";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(25, 628);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1239, 219);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Acquisition";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(128, 108);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(75, 20);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "1024";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Frames Per Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Scan Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 164);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1187, 22);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Value = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Scan Range:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Run Acquisition";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 855);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aoiPictureBox);
            this.Controls.Add(this.fullPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTimeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aoiHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiY0NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiX0NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTimeNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fullPictureBox;
        private System.Windows.Forms.TrackBar expTimeTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startPreviewButton;
        private System.Windows.Forms.PictureBox aoiPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label camStatusLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox prefilterCheckBox;
        private System.Windows.Forms.CheckBox flatFieldCheckBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox thresholdTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox thresholdCheckBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown aoiX0NumericUpDown;
        private System.Windows.Forms.NumericUpDown expTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown aoiHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown aoiWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown aoiY0NumericUpDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}

