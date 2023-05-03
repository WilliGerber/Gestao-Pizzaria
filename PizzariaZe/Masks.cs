using PizzariaZe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzariaDoZe
{
    internal class Masks
    {
        /// <summary>
        ///Estilo moeda em TextBox, conforme o usuário vai digitando, a formatação do campo já vai sendo realizada.
        ///TextBox : TextBoxBase | MaskedTextBox : TextBoxBase
        ///ClassFuncoes.AplicaMascaraMoeda2( textBoxValor2 );
        /// </summary>
        static string valor;
        static int lastDigit;
        static string lastDigitString;
        static bool maxCatacters = false;

        #region R$ Mask
        private static void Aplica_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            int maxLength = txt.MaxLength;
            int currentLength = txt.Text.Length;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Enter))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(","));
                }
                else
                {
                    e.Handled = true;
                }
            }
            //else if (currentLength == maxLength && e.KeyChar != Convert.ToChar(Keys.Back))
            //{
            //    currentLength--;
            //    MessageBox.Show("Quantidade máxima de caracteres atingida", "Valor máximo excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    e.Handled = true;
            //    maxCatacters = true;
            //}
        }
        private static void Aplica_Leave(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            valor = txt.Text.Replace(Program.currencySymbol, "");
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }
        private static void Aplica_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;

            valor = txt.Text.Replace(Program.currencySymbol, "").Replace(Program.separadorDecimal, "").Replace(" ", "");

            if (valor.Length == 0)
            {
                txt.Text = "0" + Program.separadorDecimal+ "00" + valor;
            }
            else if (valor.Length == 1)
            {
                txt.Text = "0" + Program.separadorDecimal + "0" + valor;
            }
            else if (valor.Length == 2)
            {
                txt.Text = "0" + Program.separadorDecimal + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt.Text.StartsWith("0" + Program.separadorDecimal))
                {
                    txt.Text = valor.Insert(valor.Length - 2, Program.separadorDecimal).Replace("0" + Program.separadorDecimal, "");
                }
                else if (txt.Text.Contains("00" + Program.separadorDecimal))
                {
                    txt.Text = valor.Insert(valor.Length - 2, Program.separadorDecimal).Replace("00" + Program.separadorDecimal, "");
                }
                else
                {
                    txt.Text = valor.Insert(valor.Length - 2, Program.separadorDecimal);
                }
            }
            valor = txt.Text;

            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            System.Diagnostics.Debug.WriteLine(valor);

            txt.Select(txt.Text.Length, 0);
        }
        public static void AplicaMascaraMoeda2(TextBoxBase txt)
        {
            txt.KeyPress += Aplica_KeyPress;
            if (!maxCatacters)
            {
                txt.KeyUp += Aplica_KeyUp;
            }
            txt.Leave += Aplica_Leave;
        }

        #endregion


        #region CPF Mask
        private static void Aplica_KeyPress_CPF(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            int maxLength = 14; // Tamanho máximo com máscara: XXX.XXX.XXX-XX
            int currentLength = txt.Text.Length;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
            else if (currentLength >= maxLength && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Quantidade máxima de caracteres atingida", "Valor máximo excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private static void Aplica_Leave_CPF(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            string cpf = txt.Text.Replace(".", "").Replace("-", "");

            if (cpf.Length < 11)
            {
                cpf = cpf.PadLeft(11, '0');
            }

            cpf = cpf.Insert(9, "-").Insert(6, ".").Insert(3, ".");
            txt.Text = cpf;
        }

        public static void AplicaMascaraCPF(TextBoxBase txt)
        {
            txt.MaxLength = 14;
            txt.KeyPress += Aplica_KeyPress_CPF;
            txt.Leave += Aplica_Leave_CPF;
        }
        #endregion
    }
}


