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
    public partial class Flavours : Form
    {
        public Flavours()
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

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }
        private void ClearPanelContent()
        {
            // Remove todos os controles do pannelContent
            while (pannelContent.Controls.Count > 0)
            {
                pannelContent.Controls[0].Dispose();
            }
        }

        private void add_ingredients_Click(object sender, EventArgs e)
        {
            CreateEditIngredients createEditIngredients = new CreateEditIngredients();
            createEditIngredients.ShowDialog();
        }

        private void add_flavours_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            Sabores sabores = new Sabores();
            DisposeAllButThis(this);
            sabores.TopLevel = false;
            pannelContent.Controls.Add(sabores);
            sabores.Show();
        }
        
        private void pizzas_sizes_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            Tamanhos tamanhos = new Tamanhos();
            DisposeAllButThis(this);
            tamanhos.TopLevel = false;
            pannelContent.Controls.Add(tamanhos);
            tamanhos.Show();
        }
        private void btn_ingredients_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            Ingredients ingredients = new Ingredients();
            DisposeAllButThis(this);
            ingredients.TopLevel = false;
            pannelContent.Controls.Add(ingredients);
            ingredients.Show();
        }
    }
}
