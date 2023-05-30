using PizzariaDoZe;
using PizzariaDoZe.DAO;
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
    public partial class CreateEditEmployee : Form
    {
        private readonly EnderecoDAO enderecoDAO;
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
    }
}
