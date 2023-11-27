namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.Suma obj = new Clases.Suma();
        Clases.Resta obj2 = new Clases.Resta();
        Clases.Multiplicacion obj3 = new Clases.Multiplicacion();
        Clases.Division obj4 = new Clases.Division();


        private void B0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Bpunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Bresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Bmulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Bdivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Bigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            double sum;
            double rest;
            double multipl;
            double divisi;

            switch (operador)
            {
                case "+":
                    sum = obj.suma((primero), (segundo));
                    Pantalla.Text = sum.ToString();
                    break;
                case "-":
                    rest = obj2.Restar((primero), (segundo));
                    Pantalla.Text = rest.ToString();
                    break;
                case "*":
                    multipl = obj3.multiplicacion((primero), (segundo));
                    Pantalla.Text = multipl.ToString();
                    break;
                case "/":
                    divisi = obj4.division((primero), (segundo));
                    Pantalla.Text = divisi.ToString();
                    break;
            }


        }

        private void Blimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();

          
        }

        private void Bborrar_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1)
                Pantalla.Text = "";
            else
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }
    }
}