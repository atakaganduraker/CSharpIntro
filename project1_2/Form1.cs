


namespace project1_2
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
            string[] products = new string[] { "Laptop", "Masaüstü Pc", "Klavye", "Ram", "Ekran Kartý" };
            var addToCartButtonText = "Sepete Ekle";
            string  cartText = "Sepetiniz";
            var removeFromCart = "Sepetten Çýkar";


            foreach (string product in products)
            {
                lbxProducts.Items.Add(product);
            }

            lblProducts.Text = productsText;
            lblCart.Text = cartText;
            btnAddToCart.Text = addToCartButtonText;
            btnRemoveFromCart.Text = removeFromCart;

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;

            }
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lbxProducts.SelectedItem.ToString());

            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;

            }
            else
            {
                MessageBox.Show("Öncelikle Bir Ürün Seçmelisiniz");
            }

            }

            private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            
            
            
            if ( lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncelikle bir ürün seçmelisin dostum");
            }

            if (lbxCart.Items.Count == 0 )
            {
                btnRemoveFromCart.Enabled = false;

            }
            

        }
    }
}