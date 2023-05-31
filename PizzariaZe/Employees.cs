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

namespace PizzariaZe
{
    public partial class Employees : Form
    {
        private FuncionarioDAO funcionarioDAO;
        public Employees()
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
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            AtualizarTela();

        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            CreateEditEmployee createEditEmployee = new CreateEditEmployee();
            createEditEmployee.ShowDialog();
        }

        public void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
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

        private void dataGridViewDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDados.Columns["colGroupName"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridViewDados.Rows[e.RowIndex].Cells[e.ColumnIndex];
                EnumFuncionarioGrupo group = (EnumFuncionarioGrupo)e.Value;
                string groupName = group.GetDescription();
                cell.Value = groupName;
            }
        }
    }
}
