using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lesson_04_02
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            UpdateCarsListBox();
        }
        private void UpdateCarsListBox()
        {
            carListBox.DataSource = null;
            carListBox.DataSource = cars;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            cars.Add(new Car(modelTextBox.Text, (int)yearNumericUpDown.Value, (int)mileNumericUpDown.Value,
                volumeNumericUpDown.Value));
            UpdateCarsListBox();
        }

        private void deleteSelectedBtn_Click(object sender, EventArgs e)
        {
            if (carListBox.SelectedIndex == -1)
            {
                MessageBox.Show("There is no selected items!");
                return;
            }
            foreach (var selectedItem in carListBox.SelectedItems)
            {
                cars.Remove((selectedItem as Car)!);
            }

            UpdateCarsListBox();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string res = "========== Selected Cars ==========\n";
            foreach (var selectedItem in carListBox.SelectedItems)
            {
                res += selectedItem + Environment.NewLine;
            }
            MessageBox.Show(res);
        }

        private void saveToFileBtn_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));

            try
            {
                using (Stream stream = File.Create("Cars.xml"))
                {
                    xmlSerializer.Serialize(stream, cars);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadFromFileBtn_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));

            try
            {
                List<Car> newList = null;

                using (Stream stream = File.OpenRead("Cars.xml"))
                {
                    newList = (List<Car>)xmlSerializer.Deserialize(stream);
                }
                cars = newList;
                UpdateCarsListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}