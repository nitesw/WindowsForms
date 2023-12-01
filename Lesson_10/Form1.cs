namespace Lesson_10
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            this.ShowInTaskbar = false;
            notifyIcon1.Click += NotifyIcon1_Click;
        }

        private void NotifyIcon1_Click(object? sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            label1.Text = (++count).ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "The timer started to tick";
            notifyIcon1.BalloonTipTitle = "Attention!";
            notifyIcon1.ShowBalloonTip(5);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startBtn.Enabled = true;
            stopBtn.Enabled = false;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipText = "The timer has been stopped";
            notifyIcon1.BalloonTipTitle = "Attention!";
            notifyIcon1.ShowBalloonTip(5);
        }
    }
}