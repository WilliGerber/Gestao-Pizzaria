using PizzariaDoZe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaZe
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Functions.EventoFocoCampos(this);

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Functions.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private void add_order_Click(object sender, EventArgs e)
        {

        }
    }
}
