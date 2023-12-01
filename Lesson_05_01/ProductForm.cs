using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lesson_05_01
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
            Product = new Product();
            InitializeCountriesComboBox();
        }
        public ProductForm(Product product)
        {
            InitializeComponent();
            Product = product;
            InitializeCountriesComboBox();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter proper name");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select the country first");
                return;
            }
            Product.Name = textBox1.Text;
            Product.Price = (int)numericUpDown3.Value;
            Product.Quantity = (int)numericUpDown2.Value;
            Product.Discount = (int)numericUpDown1.Value;
            Product.Country = comboBox1.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void ShowDialogInfo(Product product)
        {
            textBox1.ReadOnly = true;
            numericUpDown3.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown1.Enabled = false;
            comboBox1.Enabled = false;

            textBox1.Text = product.Name;
            numericUpDown3.Value = product.Price;
            numericUpDown2.Value = product.Quantity;
            numericUpDown1.Value = product.Discount;
            comboBox1.SelectedItem = product.Country;
            this.ShowDialog();
        }
        public DialogResult ShowDialogEdit(Product product)
        {
            textBox1.Text = product.Name;
            numericUpDown3.Value = product.Price;
            numericUpDown2.Value = product.Quantity;
            numericUpDown1.Value = product.Discount;
            comboBox1.SelectedItem = product.Country;
            return this.ShowDialog();
        }


        private void InitializeCountriesComboBox()
        {
            string[] countries = { "Ukraine", "Poland", "Germany", "Austria", "Australia", "USA", "Canada", "China", "France" };
            comboBox1.Items.AddRange(countries);
        }
    }
}
