namespace PrInteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Interes_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
                 double capital, razon, tiempo;
                     double interes, monto;
            // entrada de datos
              capital = double.Parse(textCapital.Text);
                 razon = double.Parse(textRazon.Text);
                     tiempo = double.Parse(textRazon.Text);
            //Proceso
                 monto = Math.Pow((1 + razon), tiempo) * capital;
                interes = monto - capital;
            //salida de informacion
                 textmontofinal.Text = Convert.ToString(monto);
                texttotalinteres.Text = Convert.ToString(interes);
                
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textmontofinal.Clear();
            textCapital.Clear();
            textRazon.Clear();
            textTiempo.Clear();
            texttotalinteres.Clear();
        }
    }
}