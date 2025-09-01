using Ejercicio1.Models;
using System.Collections;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList listaFiguras = new ArrayList();
        private void btnCrearFigura_Click(object sender, EventArgs e)
        {


            if (rbOrtoedro.Checked == true)
            {
                double alto = Convert.ToDouble(tbAltoOrto.Text);
                double ancho = Convert.ToDouble(tbAncho.Text);
                double largo = Convert.ToDouble(tbLargo.Text);
                Figura ortoedro = new Ortoedro(ancho, largo, alto);
                listaFiguras.Add(ortoedro);
            }
            else
            {
                double alto = Convert.ToDouble(tbAltoCilindro.Text);
                double radio = Convert.ToDouble(tbRadio.Text);
                Figura cilindro = new Cilindro(radio, alto);
                listaFiguras.Add(cilindro);
            }

            rbOrtoedro.Checked = false;
            rbCilindro.Checked = false;
            tbAltoCilindro.Clear();
            tbAncho.Clear();
            tbLargo.Clear();
            tbAltoOrto.Clear();
            tbRadio.Clear();

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int idxSeleccionado = lsbResultado.SelectedIndex;


            lbInfo.Text = "";
            if (idxSeleccionado >= 0)
            {
                lbInfo.Text = listaFiguras[idxSeleccionado].ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un índice de la lista");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Ordeno por volumen.
        private void btnOrdenarAreas_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();

            listaFiguras.Sort();
            foreach (Figura f in listaFiguras)
            {
                lsbResultado.Items.Add(f);
            }
        }

        private void btnActualizarListado_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();
            foreach (Figura f in listaFiguras)
            {
                lsbResultado.Items.Add(f);
            }
        }
    }
}
