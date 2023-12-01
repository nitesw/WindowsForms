namespace Lesson_04
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));

            //orderComboBox.Items.AddRange(orders.ToArray());
            UpdateOrdersComboBox();
        }
        private void UpdateOrdersComboBox()
        {
            orderComboBox.DataSource = null;
            orderComboBox.DataSource = orders;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void showSelectedBtn_Click(object sender, EventArgs e)
        {
            if (orderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select order in list");
                return;
            }

            Order selectedOrder = (orderComboBox.SelectedItem as Order)!;
            MessageBox.Show($"Number: {selectedOrder.Number}\nDate: {selectedOrder.Date.ToShortDateString()}\n" +
                $"Total price: {selectedOrder.TotalPrice}$", "Order details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (orderComboBox.SelectedIndex == -1) return;

            orders.RemoveAt(orderComboBox.SelectedIndex);
            MessageBox.Show("Selected item is removed");
            UpdateOrdersComboBox();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            UpdateOrdersComboBox();
        }
    }
}