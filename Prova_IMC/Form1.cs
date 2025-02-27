namespace Prova_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.Tag = true;

                txtPeso.BackColor = Color.Red;
 
            txtAltura.Tag = false;
            if (txtAltura.Tag != null)
            {
                txtAltura.BackColor = Color.White;

            }
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtPeso.Tag = false;
            if (txtPeso.Tag != null)
            {
               txtPeso.BackColor = Color.White;

            }
            txtAltura.Tag = true;
          
            if (txtAltura.Tag != null)
            {
                txtAltura.BackColor = Color.Red;

            }
        }

 

        private void button13_Click(object sender, EventArgs e)
        {
            double pesou = double.Parse(txtPeso.Text);
            double altural = double.Parse(txtAltura.Text);
            
            double zCIMC = pesou / (altural * 2);
            txtImc.Text = zCIMC.ToString();

            if (zCIMC < 18.5)
            {
                lblResultImc.Text = "Baixo Peso";
                lblResultImc.Visible = true;

            }
            else if (zCIMC > 18.5 && zCIMC < 24.9)
            {

                lblResultImc.Text = "Peso Normal";
                lblResultImc.Visible = true;

            }

            else if (zCIMC > 25 && zCIMC < 29.9)
            {
                lblResultImc.Text = "Excesso de Peso";
                lblResultImc.Visible = true;
            }
            else if (zCIMC == 30)
            {
                lblResultImc.Text = "Obesidade";
                lblResultImc.Visible = true;
            }

            else if (zCIMC > 30 && zCIMC < 34.9)
            {
                lblResultImc.Text = "Obesidade Classe 1";
            }
            else if (zCIMC > 35 && zCIMC < 39.9)
            {
                lblResultImc.Text = "Obesidade Classe 2";
            }
            else
            {
                lblResultImc.Text = "Obesidade Classe 3";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
        }

        private void AdicionarNumeros1(object sender, EventArgs e)
        {
            Button numeros = sender as Button;

            if (numeros.Text == ",")
            {

                if (!txtAltura.Text.Contains(","))
                {
                    if (txtAltura.Tag.Equals(true))
                    {
                        txtAltura.Text += numeros.Text;
                    }
                    else
                    {
                        txtPeso.Text += numeros.Text;
                    }
                }
            }
            else
            {
                if (txtAltura.Tag.Equals(true))
                {
                    txtAltura.Text += numeros.Text;
                }
                else
                {
                    txtPeso.Text += numeros.Text;
                }
            }
        }

    }
}


