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
using PizzariaDoZe.DAO;
using System.Configuration;
using System.Globalization;

namespace PizzariaZe
{
    public partial class CreateEditProducts : Form
    {
        private ProdutoDAO produtoDAO;
        public CreateEditProducts()
        {
            InitializeComponent();
            CarregaEnumListBox();
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Functions.EventoFocoCampos(this);

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Functions.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBoxProductPrice_TextChanged(object sender, EventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.tBoxProductPrice);
        }
        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            cBoxProductType.Items.Clear();
            cBoxProductType.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = tBoxProductName.Text,
                Valor = decimal.Parse(tBoxProductPrice.Text, NumberStyles.Currency),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), cBoxProductType.Text),
                ML = cBoxProductUnit.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
