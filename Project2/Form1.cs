namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<string> students;

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Engin demiroð", "Derin demiroð", "salih demiroð" };

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }


          }     
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            if (tbxStudentName.Text != "" && tbxStudentName.Text.Length > 5)
            {

                students.Add(tbxStudentName.Text);
                lbxStudentList.Items.Clear();


                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }

            else 
            {
                MessageBox.Show("ÖNCE DÜZGÜN YAZ SONRA EKLE ASLAN");
            }
        }


        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {



            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Önce seç sonra çýkarr ");
            }

        }





        private void lbxStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}