namespace U3_Practica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, cuadrado, cubo, zeta;
            for (i = 1; i <= 50; i++)
            {
                cuadrado = i * i;
                cubo = i * i * i;
                zeta = cuadrado + cubo;
                listBox1.Items.Add(i);
                listBox2.Items.Add(cuadrado);
                listBox3.Items.Add(cubo);
                listBox4.Items.Add(zeta);
            }

        }
    }
}