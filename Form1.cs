namespace appCalculatorPrueba
{
    public partial class Calculadora : Form // Clase del form
    {
        double aux1;
        double aux2;
        string operador; // variables globlales
        public Calculadora() // metodo del formulario
        {
            InitializeComponent(); // inicializa componente
        }
        Clases.classSuma objsuma = new Clases.classSuma(); // instanciando clases
        Clases.ClassResta objresta = new Clases.ClassResta();
        Clases.ClassProducto objproducto = new Clases.ClassProducto();
        Clases.ClassDiv objdiv = new Clases.ClassDiv();
        Clases.ClassMod objmod = new Clases.ClassMod();
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
        // eventos de operaciones
        private void btSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void brResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btProd_Click(object sender, EventArgs e)
        {
            operador = "*";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
        //resultados de operaciones
        private void btResultado_Click(object sender, EventArgs e)
        {
            aux2 = double.Parse(textBox1.Text);
            double OPSuma, OPResta, OPMultiplicar, OPDividir, OPModulo;
            switch (operador)
            {
                case "+":
                    OPSuma = objsuma.Suma(aux1, (aux2));
                    textBox1.Text = OPSuma.ToString();
                    break;
                case "-":
                    OPResta = objresta.Resta(aux1, (aux2));
                    textBox1.Text = OPResta.ToString();
                    break;
                case "*":
                    OPMultiplicar = objproducto.Producto(aux1, (aux2));
                    textBox1.Text = OPMultiplicar.ToString();
                    break;
                case "/":
                    OPDividir = objdiv.Division(aux1, (aux2));
                    textBox1.Text = OPDividir.ToString();
                    break;
                case "%":
                    OPModulo = objmod.Modulo(aux1, (aux2));
                    textBox1.Text = OPModulo.ToString();
                    break;
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";// se le asigna valor 1 a la tecla
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";// se le asigna valor 2 a la tecla
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";// se le asigna valor 3 a la tecla
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";// se le asigna valor 4 a la tecla
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";// se le asigna valor 5 a la tecla
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";// se le asigna valor 6 a la tecla
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";// se le asigna valor 7 a la tecla
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";// se le asigna valor 8 a la tecla
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";// se le asigna valor 9 a la tecla
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";// se le asigna valor 0 a la tecla
        }

        private void btRest_Click(object sender, EventArgs e)
        {
            operador = "%";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//limpia la caja
        }

        private void btMasM_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            x = ((x) * (-1));
            textBox1.Text = x.ToString();
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}