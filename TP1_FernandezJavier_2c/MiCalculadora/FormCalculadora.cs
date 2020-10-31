using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Persionar el boton limpiar reinicia los valores de operandos, operador y resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textNumero1.Text = "";
            this.textNumero2.Text = "";
            this.comboBoxOperador.Text = "";
            this.labelResultado.Text = "";
        }

        /// <summary>
        /// Realiza una operacion matemática entre 2 numeros. Reemplazará los operandos invalidos por 0 y operadores invalidos por +
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }


        /// <summary>
        /// Clickear el boton realiza la operacion seleccionada del combo entre los operandos ingresados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            this.labelResultado.Text = Operar(this.textNumero1.Text, this.textNumero2.Text, this.comboBoxOperador.Text).ToString();

            //Si alguno de los campos es invalido, dado que serán reemplazados por los valores por defecto,
            //seteo los mismos en los campos invalidos para que sea visible la operación realizada.
            int aux;
            if (this.textNumero1.Text == "" || !int.TryParse(this.textNumero1.Text, out aux))
                this.textNumero1.Text = "0";

            if (this.textNumero2.Text == "" || !int.TryParse(this.textNumero2.Text, out aux))
                this.textNumero2.Text = "0";

            if (this.comboBoxOperador.Text == "" || (this.comboBoxOperador.Text != "-" && 
                this.comboBoxOperador.Text != "*" && this.comboBoxOperador.Text != "/" &&
                this.comboBoxOperador.Text != "+"))
            {
                this.comboBoxOperador.Text = "+";
            }
                
                
        }
   
        /// <summary>
        /// Al clickear el boton cerrar, pregunta si quiere cerrarse la aplicación. Se cierra de clickear el boton yes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }
            
                
        /// <summary>
        /// Clickear el boton convierte el label resultado en binario. escribe Valor invalido, en caso de serlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvertirEnBinario_Click(object sender, EventArgs e)
        {
            this.labelResultado.Text = Numero.DecimalBinario(this.labelResultado.Text).ToString();
        }

        /// <summary>
        /// /// Clickear el boton convierte el label resultado en decimal. escribe Valor invalido, en caso de serlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvertirEnDecimal_Click(object sender, EventArgs e)
        {
            this.labelResultado.Text = Numero.BinarioDecimal(this.labelResultado.Text).ToString();
        }

            
    }
}
