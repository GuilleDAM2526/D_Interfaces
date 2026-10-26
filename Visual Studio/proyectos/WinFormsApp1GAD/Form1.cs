namespace WinFormsApp1GAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has hecho click");
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


       // Random r =new Random();int x = (int)(this.ClientRectangle.Right * r.NextDouble()) - 30;int y = (int)(this.ClientRectangle.Bottom * r.NextDouble()) - 10;this.button1.Location =new Point(x, y);//

        }
    }
}
