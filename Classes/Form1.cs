namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    List<string> ogrenciler = new List<string>() { "Engin", "Derin ", "Salih" ,"Ahmet"};
        //    List<int> yaslar = new List<int>() { 35, 6, 23 ,28};
        //    List<string> mailler = new List<string>() { "Engin@gmail.com", "Derin@gmail.com ", "Salih@gmail.com", "Ahmet@gmail.com" };

            Student ogrenci1 = new Student();
            ogrenci1.FirstName = "Engin";
            ogrenci1.Age = 35;
            ogrenci1.Mail = "Engin@gmail.com";

            Student ogrenci2 = new Student();
            ogrenci2.FirstName = "Derin";
            ogrenci2.Age = 6;
            ogrenci2.Mail = "Derin@gmail.com";

            Student ogrenci3 = new Student();
            ogrenci3.FirstName = "Salih";
            ogrenci3.Age = 15;
            ogrenci3.Mail = "Salih@gmail.com";

            List<Student> students = new List<Student>(){ ogrenci1, ogrenci2, ogrenci3};

            foreach (var student in students)
            {
                // MessageBox.Show(student.FirstName + "  " + student.Age + "   " + student.Mail);
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}