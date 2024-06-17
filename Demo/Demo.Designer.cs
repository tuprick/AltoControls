namespace Demo
{
    partial class Demo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            altoButton1 = new AltoControls.AltoButton();
            altonmUpDown1 = new AltoControls.AltoNMUpDown();
            altopb1 = new AltoControls.AltoPB();
            altoSlidingLabel1 = new AltoControls.AltoSlidingLabel();
            altoTextBox1 = new AltoControls.AltoTextBox();
            circularpb1 = new AltoControls.CircularPB();
            processingControl1 = new AltoControls.ProcessingControl();
            slideButton1 = new AltoControls.SlideButton();
            spinningCircles1 = new AltoControls.SpinningCircles();
            SuspendLayout();
            // 
            // altoButton1
            // 
            altoButton1.Active1 = Color.FromArgb(64, 168, 183);
            altoButton1.Active2 = Color.FromArgb(36, 164, 183);
            altoButton1.BackColor = Color.Transparent;
            altoButton1.DialogResult = DialogResult.OK;
            altoButton1.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            altoButton1.ForeColor = Color.Black;
            altoButton1.Inactive1 = Color.FromArgb(44, 188, 210);
            altoButton1.Inactive2 = Color.FromArgb(33, 167, 188);
            altoButton1.Location = new Point(101, 69);
            altoButton1.Name = "altoButton1";
            altoButton1.Radius = 10;
            altoButton1.Size = new Size(65, 30);
            altoButton1.Stroke = false;
            altoButton1.StrokeColor = Color.Gray;
            altoButton1.TabIndex = 0;
            altoButton1.Text = "New Button";
            altoButton1.Transparency = false;
            // 
            // altonmUpDown1
            // 
            altonmUpDown1.Font = new Font("Comic Sans MS", 12F);
            altonmUpDown1.Location = new Point(101, 127);
            altonmUpDown1.Name = "altonmUpDown1";
            altonmUpDown1.SignColor = Color.White;
            altonmUpDown1.Size = new Size(160, 46);
            altonmUpDown1.TabIndex = 1;
            altonmUpDown1.Text = "altonmUpDown1";
            altonmUpDown1.Value = 0D;
            // 
            // altopb1
            // 
            altopb1.Location = new Point(435, 79);
            altopb1.MaxValue = 100;
            altopb1.MinValue = 0;
            altopb1.Name = "altopb1";
            altopb1.ProgressColor = Color.LightBlue;
            altopb1.Size = new Size(100, 20);
            altopb1.TabIndex = 2;
            altopb1.Text = "altopb1";
            altopb1.Value = 0;
            // 
            // altoSlidingLabel1
            // 
            altoSlidingLabel1.Location = new Point(435, 58);
            altoSlidingLabel1.Name = "altoSlidingLabel1";
            altoSlidingLabel1.Size = new Size(100, 15);
            altoSlidingLabel1.Slide = false;
            altoSlidingLabel1.TabIndex = 3;
            altoSlidingLabel1.Text = "A scrolling label for long labels that look bad.";
            //altoSlidingLabel1.Click += altoSlidingLabel1_Click;
            // 
            // altoTextBox1
            // 
            altoTextBox1.BackColor = Color.Transparent;
            altoTextBox1.Br = Color.White;
            altoTextBox1.Font = new Font("Comic Sans MS", 11F);
            altoTextBox1.ForeColor = Color.DimGray;
            altoTextBox1.Location = new Point(227, 66);
            altoTextBox1.Name = "altoTextBox1";
            altoTextBox1.Size = new Size(135, 33);
            altoTextBox1.TabIndex = 4;
            altoTextBox1.Text = "New text box";
            // 
            // circularpb1
            // 
            circularpb1.AllowText = true;
            circularpb1.AutomaticFontCalculation = true;
            circularpb1.BackColor = Color.Transparent;
            circularpb1.Location = new Point(368, 151);
            circularpb1.MaxValue = 100;
            circularpb1.MinimumSize = new Size(60, 60);
            circularpb1.MinValue = 0;
            circularpb1.Name = "circularpb1";
            circularpb1.ProgressColor = Color.LightBlue;
            circularpb1.Size = new Size(100, 60);
            circularpb1.Stroke = 10;
            circularpb1.TabIndex = 5;
            circularpb1.Text = "circularpb1";
            circularpb1.Transparency = true;
            circularpb1.Value = 0;
            // 
            // processingControl1
            // 
            processingControl1.BackColor = Color.Transparent;
            processingControl1.IndexColor = Color.Gray;
            processingControl1.Interval = 500;
            processingControl1.Location = new Point(642, 164);
            processingControl1.Name = "processingControl1";
            processingControl1.NCircle = 6;
            processingControl1.Others = Color.LightGray;
            processingControl1.Radius = 10;
            processingControl1.Size = new Size(85, 85);
            processingControl1.Spin = true;
            processingControl1.TabIndex = 6;
            processingControl1.Text = "processingControl1";
            // 
            // slideButton1
            // 
            slideButton1.BorderColor = Color.LightGray;
            slideButton1.IsOn = true;
            slideButton1.Location = new Point(101, 213);
            slideButton1.Name = "slideButton1";
            slideButton1.Size = new Size(60, 35);
            slideButton1.TabIndex = 7;
            slideButton1.Text = "slideButton1";
            slideButton1.TextEnabled = true;
            // 
            // spinningCircles1
            // 
            spinningCircles1.BackColor = Color.Transparent;
            spinningCircles1.FullTransparent = true;
            spinningCircles1.Increment = 1F;
            spinningCircles1.Location = new Point(637, 58);
            spinningCircles1.N = 8;
            spinningCircles1.Name = "spinningCircles1";
            spinningCircles1.Radius = 2.5F;
            spinningCircles1.Size = new Size(90, 100);
            spinningCircles1.TabIndex = 8;
            spinningCircles1.Text = "spinningCircles1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 285);
            Controls.Add(spinningCircles1);
            Controls.Add(slideButton1);
            Controls.Add(processingControl1);
            Controls.Add(circularpb1);
            Controls.Add(altoTextBox1);
            Controls.Add(altoSlidingLabel1);
            Controls.Add(altopb1);
            Controls.Add(altonmUpDown1);
            Controls.Add(altoButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AltoControls.AltoButton altoButton1;
        private AltoControls.AltoNMUpDown altonmUpDown1;
        private AltoControls.AltoPB altopb1;
        private AltoControls.AltoSlidingLabel altoSlidingLabel1;
        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.CircularPB circularpb1;
        private AltoControls.ProcessingControl processingControl1;
        private AltoControls.SlideButton slideButton1;
        private AltoControls.SpinningCircles spinningCircles1;
    }
}
