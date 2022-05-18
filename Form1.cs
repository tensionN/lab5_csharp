namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "D:\\c#\\lab5\\WinFormsApp1\\WinFormsApp1\\medicines.txt";
            Functions.ReadFile(path, GlobalVars.medicines);
            foreach(Medicine it in GlobalVars.medicines)
            {
                dataGridView1.Rows.Add(it.Name, it.ExpirationDate, it.ProductionDate, it.Count, it.Price);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddtionalForm addtionalForm = new AddtionalForm(this);
            addtionalForm.Show();
        }
    }
}

