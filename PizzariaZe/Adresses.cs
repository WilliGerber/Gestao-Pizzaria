using PizzariaDoZe;
using System.Data;
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
using System.Runtime.ConstrainedExecution;

namespace PizzariaZe
{
    public partial class Adresses : Form
    {
        private EnderecoDAO enderecoDAO;

        public Adresses()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);

            AtualizarTela();
        }
        public void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var endereco = new Endereco
            {
                Id = 0,
                Cep = ""
            };
            try
            {

                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
