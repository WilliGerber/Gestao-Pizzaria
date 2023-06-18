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
using PizzariaDoZe;
using System.Configuration;

namespace PizzariaZe
{
    public partial class CreateEditOrders : Form
    {
        public EnderecoDAO enderecoDAO;
        public ClienteDAO clienteDAO;
        public CreateEditOrders()
        {
            InitializeComponent();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
        }
        private void btn_add_client_Click(object sender, EventArgs e)
        {
            CreateEditClients createEditClients = new CreateEditClients();
            createEditClients.ShowDialog();
        }

        private void nome_textBox_Leave(object sender, EventArgs e)
        {
            if (this.nome_textBox.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Nome = nome_textBox.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                this.celphone_textBox.Text = "";
                this.cpf_textBox.Text = "";

                foreach (DataRow row in linhas.Rows)
                {
                    this.celphone_textBox.Text = row["telefone"].ToString(); ;
                    this.cpf_textBox.Text = row["cpf"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void celphone_textBox_Leave(object sender, EventArgs e)
        {
            if (this.celphone_textBox.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Telefone = celphone_textBox.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                this.nome_textBox.Text = "";
                this.cpf_textBox.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    this.nome_textBox.Text = row["nome"].ToString(); ;
                    this.cpf_textBox.Text = row["cpf"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cpf_textBox_Leave(object sender, EventArgs e)
        {
            if (this.cpf_textBox.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Cpf = cpf_textBox.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                this.nome_textBox.Text = "";
                this.celphone_textBox.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    this.nome_textBox.Text = row["nome"].ToString(); ;
                    this.celphone_textBox.Text = row["telefone"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

