namespace FractalTree
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
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.trbAngle = new System.Windows.Forms.TrackBar();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.cmbFractal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbxImage.Location = new System.Drawing.Point(0, 50);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(654, 267);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            this.pbxImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trbAngle
            // 
            this.trbAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbAngle.LargeChange = 15;
            this.trbAngle.Location = new System.Drawing.Point(0, 0);
            this.trbAngle.Maximum = 360;
            this.trbAngle.Name = "trbAngle";
            this.trbAngle.Size = new System.Drawing.Size(653, 45);
            this.trbAngle.SmallChange = 5;
            this.trbAngle.TabIndex = 1;
            this.trbAngle.TickFrequency = 5;
            this.trbAngle.ValueChanged += new System.EventHandler(this.trbAngle_ValueChanged);
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(0, 51);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(57, 20);
            this.nudAngle.TabIndex = 2;
            this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            this.nudAngle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudAngle_KeyUp);
            // 
            // cmbFractal
            // 
            this.cmbFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFractal.DisplayMember = "Fractal tree";
            this.cmbFractal.FormattingEnabled = true;
            this.cmbFractal.Items.AddRange(new object[] {
            "Fractal tree",
            "Mandelbrot"});
            this.cmbFractal.Location = new System.Drawing.Point(532, 51);
            this.cmbFractal.Name = "cmbFractal";
            this.cmbFractal.Size = new System.Drawing.Size(121, 21);
            this.cmbFractal.TabIndex = 3;
            this.cmbFractal.Text = "Fractal tree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 318);
            this.Controls.Add(this.cmbFractal);
            this.Controls.Add(this.nudAngle);
            this.Controls.Add(this.trbAngle);
            this.Controls.Add(this.pbxImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.TrackBar trbAngle;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.ComboBox cmbFractal;
    }
}

