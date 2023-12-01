using System.Text;

namespace Lesson_02_01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearTextBox()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }
        private void ClearMaskedTextBox()
        {
            foreach (var item in this.Controls.OfType<MaskedTextBox>())
            {
                item.Text = "";
            }
        }
        private void ClearCheckBox()
        {
            foreach (var item in this.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
        }
        private void ClearRadioButton()
        {
            foreach (var item in this.Controls.OfType<RadioButton>())
            {
                item.Checked = false;
            }
        }
        private void ClearNumericUpDown()
        {
            foreach (var item in this.Controls.OfType<NumericUpDown>())
            {
                item.Value = 1;
            }
        }
        private void ClearMonthCalendar()
        {
            foreach (var item in this.Controls.OfType<MonthCalendar>())
            {
                item.SelectionStart = DateTime.Today;
                item.SelectionEnd = DateTime.Today;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            ClearMaskedTextBox();
            ClearCheckBox();
            ClearRadioButton();
            ClearNumericUpDown();
            ClearMonthCalendar();
        }

        private bool IsSelectedType()
        {
            return economRadioBtn.Checked || standartRadioBtn.Checked || luxeRadioBtn.Checked;
        }
        private bool IsCheckedBox()
        {
            return agreeCheckBox.Checked;
        }
        private bool IsEnteredDetails()
        {
            return nameTextBox.TextLength >= 3 && surnameTextBox.TextLength >= 3 && phoneMaskedTextBox.TextLength >= 10;
        }
        private bool IsEnteredAddInfo()
        {
            return addInfoTextBox.Text.Length > 0;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedType() || !IsCheckedBox() || !IsEnteredDetails())
            {
                MessageBox.Show("Enter all the details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StringBuilder res = new StringBuilder("========== Order ==========\n");

                res.AppendLine("Contact info: ");
                res.AppendLine("Name: " + nameTextBox.Text);
                res.AppendLine("Surname: " + surnameTextBox.Text);
                res.AppendLine("Phone: " + phoneMaskedTextBox.Text + "\n");

                res.AppendLine("Order details: ");
                res.Append("Hotel room type: ");
                if (economRadioBtn.Enabled)
                    res.AppendLine("Econom");
                else if (standartRadioBtn.Enabled)
                    res.AppendLine("Standart");
                else if (luxeRadioBtn.Enabled)
                    res.AppendLine("Luxe");
                res.AppendLine("Number of people: " + peopleNumericUpDown.Value);
                res.AppendLine("Staying date from: " + dateMonthCalendar.SelectionStart.ToShortDateString() + " to "
                    + dateMonthCalendar.SelectionEnd.ToShortDateString());
                if (IsEnteredAddInfo())
                {
                    res.AppendLine("Additional info: " + addInfoTextBox.Text);
                }

                MessageBox.Show(res.ToString());
            }
        }

        private void agreeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsCheckedBox())
            {
                orderBtn.Enabled = true;
            }
            else
            {
                orderBtn.Enabled = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}