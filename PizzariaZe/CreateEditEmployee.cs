using PizzariaDoZe;
using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaZe
{
    public partial class CreateEditEmployee : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;
        public CreateEditEmployee()
        {
            InitializeComponent();

            #region
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Functions.EventoFocoCampos(this);

            //configurção atalho teclas
            this.KeyDown += new KeyEventHandler(Functions.FormEventoKeyDown!);
            #endregion

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Functions.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            #region conexão com db
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            #endregion

            cmb_box_grupo.DataSource = Enum.GetValues(typeof(EnumFuncionarioGrupo));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void msk_text_box_cep_Leave(object sender, EventArgs e)
        {
            if (this.msk_text_box_cep.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = this.msk_text_box_cep.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                this.txt_box_id.Text = "";
                //this.maskedTextBoxCep.Text = "";
                this.street_textBox.Text = "";
                this.neighborhood_textBox.Text = "";
                this.txt_box_city.Text = "";
                this.txt_box_uf.Text = "";
                this.txt_box_country.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    this.txt_box_id.Text = row["id"].ToString(); ;
                    this.msk_text_box_cep.Text = row["cep"].ToString(); ;
                    this.street_textBox.Text = row["logradouro"].ToString(); ;
                    this.neighborhood_textBox.Text = row["bairro"].ToString(); ;
                    this.txt_box_city.Text = row["cidade"].ToString(); ;
                    this.txt_box_uf.Text = row["uf"].ToString(); ;
                    this.txt_box_country.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// string hash = ClassFuncoes.Sha256Hash(textBoxSenha.Text);


        private void btn_save_Click(object sender, EventArgs e)
        {
            string cpf = "";

            if (this.msk_text_box_cep.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }

            if (this.cpf_textBox.Text.Length >= 0)
            {
                foreach (char c in cpf_textBox.Text)
                {
                    if (char.IsDigit(c))
                    {
                        cpf += c;
                    }
                }
            }

            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = name_textBox.Text,
                Cpf = cpf,
                Matricula = txt_box_matricula.Text,
                Senha = Functions.Sha256Hash(password_textBox.Text),
                Grupo = (cmb_box_grupo.SelectedIndex == 3) ? '1' : (cmb_box_grupo.SelectedIndex == 2) ? '2' : '1',
                Motorista = txt_box_cnh.Text,
                Validade = dateTime_cnh_validade.Value,
                Observacao = txt_box_observacao.Text,
                Telefone = celphone_textBox.Text,
                Email = email_textBox.Text,
                EnderecoId = int.Parse(txt_box_id.Text),
                Numero = txt_house_number.Text,
                Complemento = adress_complement_textBox.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Employees employee = new Employees();
            employee.AtualizarTela();
        }

        private void cpf_textBox_TextChanged(object sender, EventArgs e)
        {
            Masks.AplicaMascaraCPF(cpf_textBox);
        }
    }
}
