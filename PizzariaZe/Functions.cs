using PizzariaZe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzariaDoZe
{
    internal class Functions
    {
        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado,
        /// executando o método ApplyResources em cada um dos componentes localizados.
        /// O ApplyResources realiza a leitura do satellite assembly, ou seja, do arquivo de resource que foi ativo
        /// conforme o idioma escolhido pelo usuário,
        /// e com base no nome do campo ajusta todos os parâmetros contidos no resource para aquele campo,
        /// por exemplo Text, Font, Size, PasswordChar, Location etc.
        /// O objetivo principal aqui é ajustar o Control, por exemplo o Form, para o Idioma e Cultura escolhido pelo usuário.
        /// Deve possuir, em Properties, um arquivo de resources para cada idioma desejado, devendo ser alimentado na
        /// coluna nome o nome do campo e a propriedade que deseja ajustar.
        /// Por exemplo, em cadeias de caracteres labelLogin.Text, em outros textBoxSenha.PasswordChar, ou seja,
        /// todas as propriedades podem ser ajustadas conforme o idioma e região em uso.
        /// </summary>
        /// <param name="container">Informar o container inicial, geralmente this para pegar todos os campos da tela,
        /// ou então, por exemplo, o nome de um panel ou usercontrol.
        /// </param>
        public static void AjustaResourcesControl(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesControl(c);
                ComponentResourceManager resources = new(typeof(PizzariaZe.Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }

        /// <summary>
        /// Altera a cor do BackGroud quando o campo ganha o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Enter += new System.EventHandler(ClassFuncoes.CampoEventoEnter); </example>
        public static void CampoEventoEnter(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                txt.BackColor = Color.LightCyan;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightCyan;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightCyan;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightGreen;
            }
        }
        /// <summary>
        /// Alterar a cor do BackGroup quando o campo perde o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Leave += new System.EventHandler(ClassFuncoes.CampoEventoLeave); </example>
        public static void CampoEventoLeave(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.White;
            }
        }

        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado,
        /// adicionando nos tipos informados os eventos Enter e Leave,
        /// e vinculando aos manipuladores criados.
        /// </summary>
        /// <param name="container">Informar o container inicial,
        /// geralmente this para pegar todos os campos da tela, ou então, por exemplo, o nome de um panel ou usercontrol.
        /// </param>
        public static void EventoFocoCampos(Control container)
        {
            foreach (Control c in container.Controls)
            {
                EventoFocoCampos(c);
                if (c is TextBoxBase || c is ComboBox || c is RadioButton || c is CheckBox || c is ButtonBase)
                {
                    // adiciona eventos ganhar e perder o foco
                    c.Enter += new EventHandler(CampoEventoEnter!);
                    c.Leave += new EventHandler(CampoEventoLeave!);
                }
            }
        }


        /// <summary>
        /// Tratar eventos de teclado, no caso tecla ENTER funcionando com TAB e tecla ESC para fechar
        /// </summary>
        /// <remarks>KeyPreview do formulário para true.</remarks>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example>No construtor do formulário:
        /// this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
        ///</example>
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            Menu menu;
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                //subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                if(form.GetType() == typeof(Menu))
                {
                    Application.Exit();
                } else
                {
                    form.Close();
                }
            }
        }

        /* Estilo moeda em TextBox, conforme o usuário vai digitando, a formatação do campo já vai sendo realizada.
        * TextBox : TextBoxBase | MaskedTextBox : TextBoxBase
        *
        * ClassFuncoes.AplicaMascaraMoeda2( textBoxValor2 ); */
        static string valor;
        static int lastDigit;
        static string lastDigitString;

        //private static void Aplica_KeyDown_Mascara(object sender, KeyEventArgs e)
        //{
        //    lastDigit = (int)e.KeyChar;
        //    lastDigitString = lastDigit.ToString();
        //}
        private static void Aplica_KeyPress_Mascara(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            int maxLength = txt.MaxLength;
            int currentLength = txt.Text.Length;
            lastDigit = Convert.ToInt16(e.KeyChar.ToString());
            lastDigitString = lastDigit.ToString();
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
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
            else if (currentLength >= maxLength && e.KeyChar != Convert.ToChar(Keys.Back))
            {

                MessageBox.Show("Quantidade máxima de caracteres atingida", "Valor máximo excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string valorString = valor.ToString();
                valorString = valorString.Substring(1) + lastDigitString;
                txt.Text = "R$" + valorString;
                e.Handled = true;

            }
        }
        private static void Aplica_Leave_Mascara(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            valor = txt.Text.Replace("R$", "");
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }
        private static void Aplica_KeyUp_Mascara(object sender, KeyEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;

            valor = txt.Text.Replace("R$", "").Replace(",", "").Replace(" ", "");
            //if (valor.Length > 6)
            //{
            //    const double MAX_VALUE = 9999.99;
            //    double value = Convert.ToDouble(valor);
            //    if (value > MAX_VALUE)
            //    {
            //        MessageBox.Show("O valor máximo permitido é R$ " + MAX_VALUE.ToString("N2"), "Valor máximo excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    string valorString = valor.ToString();
            //    valorString = valorString.Substring(0, valorString.Length - 1);
            //    txt.Text = "R$" + valorString;
            //}
            if (valor.Length == 0)
            {
                txt.Text = "0,00" + valor;
            }
            else if (valor.Length == 1)
            {
                txt.Text = "0,0" + valor;
            }
            else if (valor.Length == 2)
            {
                txt.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt.Text.StartsWith("0,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt.Text.Contains("00,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txt.Text;
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txt.Select(txt.Text.Length, 0);
        }
        public static void AplicaMascaraMoeda2(TextBoxBase txt)
        {
            //txt.KeyDown += Aplica_KeyDown_Mascara;
            txt.KeyPress += Aplica_KeyPress_Mascara;
            txt.Leave += Aplica_Leave_Mascara;
            txt.KeyUp += Aplica_KeyUp_Mascara;
        }
    }
}
