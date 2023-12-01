using Timer = System.Windows.Forms.Timer;

namespace Lesson_03_01
{
    public partial class Form1 : Form
    {
        Timer timer = null;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            UpdateColor();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            else
                progressBar1.Value++;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void goToTopBtn_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;

            decimal max = (numericUpDown1.Value > progressBar1.Maximum ? progressBar1.Minimum : numericUpDown1.Value);

            while (progressBar1.Value < max)
            {
                progressBar1.Value++;
                progressBar1.Update();
                Thread.Sleep(50);
            }
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void UpdateColor()
        {
            Color color = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            BackColor = color;
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trackBar4.Value / 100.0;
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowsToolStripMenuItem.Text = "Hello world";
        }
    }
}