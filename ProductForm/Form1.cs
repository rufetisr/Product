namespace ProductForm
{
    public partial class Form1 : Form
    {
        public List<Product> products = new();
        public Product? Product { get; set; }
        public bool Edit { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();
        private void add_btn_Click(object sender, EventArgs e)
        {
            Edit = false;
            form2.prd_Name.Text = null;
            form2.prd_Country.Text = null;
            form2.prd_Cost.Text = null;
            this.Hide();
            var result = form2.ShowDialog();
            this.Show();

            if (result == DialogResult.OK)
            {
                listBox1.Items.Add(form2.Product.Name);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            var product = listBox1.SelectedItem as Product;
            products.Remove(product);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Edit = true;
            var item = listBox1.SelectedItem as Product;
            foreach (var product in products)
            {
                if (item == product)
                {
                    form2.Product = item;
                }
            }

            form2.prd_Name.Text = form2.Product?.Name;
            form2.prd_Country.Text = form2.Product?.OriginCountry;
            form2.prd_Cost.Text = form2.Product?.Cost;
            var result = form2.ShowDialog();
        }
    }
}