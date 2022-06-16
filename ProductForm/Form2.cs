using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductForm
{
    public partial class Form2 : Form
    {
        public Product? Product { get; set; } = new();
        public Product EditProduct { get; set; }=new();
        public Form2()
        {
            InitializeComponent();
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            var rx = new Regex(@"^[a-zA-Z]+$");
            var rxNum = new Regex("[0-9]$");
            if (!string.IsNullOrWhiteSpace(prd_Name.Text) && !string.IsNullOrWhiteSpace(prd_Country.Text) && !string.IsNullOrWhiteSpace(prd_Cost.Text) && rx.IsMatch(prd_Name.Text) && rx.IsMatch(prd_Country.Text) && rxNum.IsMatch(prd_Cost.Text))
            {
                if (form1.Edit == false)
                {
                    var prd = new Product();
                    prd.Name = prd_Name.Text;
                    prd.OriginCountry = prd_Country.Text;
                    prd.Cost = prd_Cost.Text;
                    Product = prd;
                    form1.products.Add(Product);
                }
                else if (form1.Edit == true)
                {
                    foreach (var item in form1.products)
                    {
                        if (item == form1.listBox1.SelectedItem as Product)
                        {
                            item.Name = prd_Name.Text;
                            item.OriginCountry = prd_Country.Text;
                            item.Cost = prd_Cost.Text;
                        }
                    }
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Texts is not correctly", "Warning", MessageBoxButtons.OK);
                prd_Name.Text = null;
                prd_Country.Text = null;
                prd_Cost.Text = null;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void prd_Name_TextChanged(object sender, EventArgs e)
        {
            var txb = sender as TextBox;
            var rx = new Regex(@"^[a-zA-Z]+$");
            if (rx.IsMatch(txb.Text))
            {
                txb.ForeColor = Color.Green;
            }
            else
                txb.ForeColor = Color.Red;
        }

        private void prd_Cost_TextChanged(object sender, EventArgs e)
        {
            var rx = new Regex("[0-9]$");
            if (rx.IsMatch(prd_Cost.Text))
            {
                prd_Cost.ForeColor = Color.Green;
            }
            else
                prd_Cost.ForeColor = Color.Red;
        }
    }
}
