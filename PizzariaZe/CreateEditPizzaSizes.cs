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
    public partial class CreateEditPizzaSizes : Form
    {
        public CreateEditPizzaSizes()
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

        private void add_flavours_Click(object sender, EventArgs e)
        {
            CreateEditFlavours createEditFlavours = new CreateEditFlavours();
            createEditFlavours.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Handler TextChanged Masks
        private void PizzaP_TextChanged(object sender, EventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.PizzaP);
        }
        private void PizzaM_TextChanged(object sender, EventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.PizzaM);
        }
        private void PizzaG_TextChanged(object sender, EventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.PizzaG);
        }
        private void PizzaGG_TextChanged(object sender, EventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.PizzaGG);
        }
        #endregion
    }
}
