namespace WinFormsApp_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obForm = new Form3();
            obForm.ShowDialog();
        }
    }
}
