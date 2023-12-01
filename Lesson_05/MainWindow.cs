namespace Lesson_05
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            //Open form
            //SecondForm form = new SecondForm();
            //form.ShowDialog(); //modal mode
            //form.Show(); //no modal mode

            //1 - use ctor
            //string name = textBox1.Text;
            //SecondForm form = new SecondForm(name);
            //form.Show();

            //2 - use properties of child class
            //SecondForm form = new SecondForm();
            //form.UserName = textBox1.Text;
            //form.Show();

            //3 - using custom Show/ShowDialog method
            string name = textBox1.Text;
            SecondForm form = new SecondForm();
            form.Show(name);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //1 - using child form properties
            //User user = null; //empty refernce
            //LoginForm loginForm = new LoginForm();
            //
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    user = loginForm.User;
            //
            //    loginTb.Text = user.Login;
            //    passwordTb.Text = user.Password;
            //}

            //2 - using reference to the object
            User user = new User();
            LoginForm form = new LoginForm(user);
            if(form.ShowDialog() == DialogResult.OK)
            {
                loginTb.Text = user.Login;
                passwordTb.Text = user.Password;
            }
        }
    }
}