/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 26/10/2026
 * Hora: 05:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */


using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class MainForm : Form
    {
        private double primerNumero = 0;
        private string operacion = "";
        private bool nuevaEntrada = true;

        public MainForm()
        {
            InitializeComponent();

            txtDisplay.Text = "0";

            // Botones numericos
            btn0.Click += Numero_Click;
            btn1.Click += Numero_Click;
            btn2.Click += Numero_Click;
            btn3.Click += Numero_Click;
            btn4.Click += Numero_Click;
            btn5.Click += Numero_Click;
            btn6.Click += Numero_Click;
            btn7.Click += Numero_Click;
            btn8.Click += Numero_Click;
            btn9.Click += Numero_Click;

            // Operaciones
            btnSuma.Click += Operacion_Click;
            btnResta.Click += Operacion_Click;
            btnMultiplicar.Click += Operacion_Click;
            btnDividir.Click += Operacion_Click;

            // Resultado y limpieza
            btnIgual.Click += Igual_Click;
            btnC.Click += Limpiar_Click;
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevaEntrada || txtDisplay.Text == "0")
            {
                txtDisplay.Text = boton.Text;
                nuevaEntrada = false;
            }
            else
            {
                txtDisplay.Text += boton.Text;
            }
        }

        private void Operacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (!double.TryParse(
                txtDisplay.Text,
                NumberStyles.Float,
                CultureInfo.CurrentCulture,
                out primerNumero))
            {
                MessageBox.Show("Introduce un numero valido.");
                return;
            }

            operacion = boton.Text;
            nuevaEntrada = true;
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            double segundoNumero;

            if (operacion == "")
                return;

            if (!double.TryParse(
                txtDisplay.Text,
                NumberStyles.Float,
                CultureInfo.CurrentCulture,
                out segundoNumero))
            {
                MessageBox.Show("Introduce un numero valido.");
                return;
            }

            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;

                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;

                case "*":
                case "x":
                case "X":
                    resultado = primerNumero * segundoNumero;
                    break;

                case "/":
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show(
                            "No se puede dividir entre cero.");
                        return;
                    }

                    resultado = primerNumero / segundoNumero;
                    break;

                default:
                    MessageBox.Show(
                        "Revisa el texto del boton de operacion.");
                    return;
            }

            txtDisplay.Text = resultado.ToString(
                "G15", CultureInfo.CurrentCulture);

            operacion = "";
            nuevaEntrada = true;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            primerNumero = 0;
            operacion = "";
            nuevaEntrada = true;
        }
    }
}
