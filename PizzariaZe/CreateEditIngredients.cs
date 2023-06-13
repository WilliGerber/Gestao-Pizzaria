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
using System.Configuration;
using PizzariaDoZe.DAO;

namespace PizzariaZe
{
    public partial class CreateEditIngredients : Form
    {
        private readonly IngredientDAO dao;
        private IngredientDAO ingredientDAO;
        public CreateEditIngredients()
        {
            InitializeComponent();

            //pegar dados banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            //cria a instancia da classe da model
            dao = new IngredientDAO(provider, strConnection);
            //cria a instancia da classe da model
            ingredientDAO = new IngredientDAO(provider, strConnection);

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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
            Ingredients ingredients = new Ingredients();
            ingredients.AtualizarTela();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingredient = new Ingredient
            {
                Id = 0,
                Name = name_textBox.Text,
            };

            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(ingredient);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Ingredients ingredients = new Ingredients();
            ingredients.AtualizarTela();
        }
    }
}
