using PizzariaDoZe;
using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaZe
{
    public partial class CreateEditPizzaSizes : Form
    {
        private ValorDAO valorDAO;

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

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);

            CarregaEnumListBox();
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

        #region Handler KeyPress Masks

        private void valor_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.valor_textBox);
        }
        private void valor_borda_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.valor_borda_textBox);
        }

        #endregion
        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(valor_textBox.Text, NumberStyles.Currency),
                ValorBorda = decimal.Parse(valor_borda_textBox.Text, NumberStyles.Currency),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
