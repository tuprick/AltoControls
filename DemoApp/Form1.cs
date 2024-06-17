

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var progressBar = new AltoControls.AltoButton();
            this.Controls.Add(progressBar);
            progressBar.Location = new Point(10, 10);
            progressBar.Size = new Size(100, 30);
            progressBar.Text = "Click Me";

        }
    }
}
