namespace Lesson_01_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mose Position {e.X}:{e.Y}";
            Point mouse = e.Location;
            Random random = new Random();
            if (mouse.X >= btnCatch.Left - 5 && (mouse.X <= btnCatch.Right + btnCatch.Width + 1))
            {
                if (mouse.X >= btnCatch.Left + (btnCatch.Width / 2))
                {
                    btnCatch.Left = btnCatch.Left - 4;
                }
                else
                {
                    btnCatch.Left = btnCatch.Left + 4;
                }
            }
            if (btnCatch.Left < 0 || btnCatch.Right > this.ClientSize.Width)
            {
                btnCatch.Location = new Point(random.Next(this.Width - btnCatch.Width), random.Next(this.Height - btnCatch.Height));
            }

            if (mouse.Y >= btnCatch.Top - 5 && (mouse.Y <= btnCatch.Bottom + btnCatch.Height + 1))
            {
                if (mouse.Y >= btnCatch.Top + (btnCatch.Height / 2))
                {
                    btnCatch.Top = btnCatch.Top - 4;
                }
                else
                {
                    btnCatch.Top = btnCatch.Top + 4;
                }
            }
            if (btnCatch.Top < 0 || btnCatch.Bottom > this.ClientSize.Height)
            {
                btnCatch.Location = new Point(random.Next(this.Height - btnCatch.Height), random.Next(this.Width - btnCatch.Width));
            }
        }
    }
}