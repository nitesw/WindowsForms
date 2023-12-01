namespace Lesson_05_01
{
    public partial class MainForm : Form
    {
        List<Product> products = new List<Product>();

        public MainForm()
        {
            InitializeComponent();
            UpdateProductsListBox();
        }
        private void UpdateProductsListBox()
        {
            productsLB.DataSource = null;
            productsLB.DataSource = products;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductForm form = new ProductForm(product);
            if (form.ShowDialog() == DialogResult.OK)
            {
                products.Add(new Product(product.Name, product.Price, product.Quantity, product.Discount, product.Country));
            }
            UpdateProductsListBox();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (productsLB.SelectedItems.Count == 0)
            {
                MessageBox.Show("There is no selected item!");
                return;
            }
            foreach (var selectedItem in productsLB.SelectedItems)
            {
                products.Remove((selectedItem as Product)!);
            }

            UpdateProductsListBox();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (productsLB.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            Product selectedProduct = (Product)productsLB.SelectedItem;
            ProductForm form = new ProductForm(selectedProduct);
            form.ShowDialogInfo(selectedProduct);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (productsLB.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            Product selectedProduct = (Product)productsLB.SelectedItem;
            ProductForm form = new ProductForm(selectedProduct);

            DialogResult result = form.ShowDialogEdit(selectedProduct);
            if (result == DialogResult.OK)
            {
                int selectedIndex = productsLB.SelectedIndex;
                products[selectedIndex] = form.Product;

                UpdateProductsListBox();
            }
        }

    }
}