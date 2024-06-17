using AltoControls;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var button = new AltoButton();
            button.Text = "Click me!";
            button.Location = new Point(100, 100);

            var upDown = new AltoNMUpDown();
            upDown.Location = new Point(200, 100);

            var progressBar = new AltoPB();
            progressBar.Location = new Point(300, 100);

            var slidingLabel = new AltoSlidingLabel();
            slidingLabel.Text = "Slide me!";
            slidingLabel.Location = new Point(500, 100);

            var circularProgressBar = new CircularPB();
            circularProgressBar.Location = new Point(100, 300);

            var processingControl = new ProcessingControl();
            processingControl.Location = new Point(100, 350);

            var switchButton = new SlideButton();
            switchButton.Location = new Point(100, 400);

            var circles = new SpinningCircles();
            circles.Location = new Point(100, 450);

            // Create an array to hold all the control variables
            var controls = new Control[]
            {
                    button,
                    upDown,
                    progressBar,
                    slidingLabel,
                    circularProgressBar,
                    processingControl,
                    switchButton,
                    circles
            };
            Controls.AddRange(controls);
        }
    }
}
