using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string productsText = "Ürünler";
            var addToCarTButtonText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var removeFromCartButtonText = "Sepetten Çýkar";

            
            btnAddToCart.Text = addToCarTButtonText;
            lblProducts.Text = productsText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text= removeFromCartButtonText;


            string[] products = new string[] {"Laptop" , "Masaüstü Pc", "Klavye" };

            //for (int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);

            //}

            foreach (string item in products)
            {
                lbxProducts.Items.Add(item);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
           


        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            if ( lbxProducts.SelectedItem != null )
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;

            }
            else 
            {
                MessageBox.Show("Öncelikle bir eleman seçmelisiniz");
            }
            // MessageBox.Show("Týklandý");
            // MessageBox.Show(lbxProducts.SelectedItem.ToString()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                btnRemoveFromCart.Enabled = false;
                MessageBox.Show("Öncelikle bir ürün seçmelisiniz");
            }
           
        }
    }
}