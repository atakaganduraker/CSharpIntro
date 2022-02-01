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

            string productsText = "�r�nler";
            var addToCarTButtonText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var removeFromCartButtonText = "Sepetten ��kar";

            
            btnAddToCart.Text = addToCarTButtonText;
            lblProducts.Text = productsText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text= removeFromCartButtonText;


            string[] products = new string[] {"Laptop" , "Masa�st� Pc", "Klavye" };

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
                MessageBox.Show("�ncelikle bir eleman se�melisiniz");
            }
            // MessageBox.Show("T�kland�");
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
                MessageBox.Show("�ncelikle bir �r�n se�melisiniz");
            }
           
        }
    }
}