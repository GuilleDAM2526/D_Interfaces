namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();
            formulario2.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();
            formulario3.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
