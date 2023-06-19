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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaZe
{
    public partial class CreateEditOrders : Form
    {
        public EnderecoDAO enderecoDAO;
        public ClienteDAO clienteDAO;
        public SaborDAO saborDAO;
        public ProdutoDAO produtoDAO;
        public decimal valorTotalPizzas;
        public decimal valorTotal;
        public List<Pizza> pizzas = new List<Pizza>();
        public ValorDAO valorDAO;
        public decimal valorProdutos;

        public CreateEditOrders()
        {
            InitializeComponent();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            produtoDAO = new ProdutoDAO(provider, strConnection);
            valorDAO = new ValorDAO(provider, strConnection);
            valorTotalPizzas = 0;
            valorTotal = 0;
            valorProdutos = 0;


            tamanho_combo_box.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            borda_combo_box.DataSource = Enum.GetValues(typeof(EnumBorda));
            //tamanho_combo_box.DataSource = Enum.GetValues(typeof(EnumValorTamanho));

            CarregaSaboresCheckedListBox();
            CarregaProdutosCheckedListBox();
        }
        public void CarregaSaboresCheckedListBox()
        {
            var sabor = new Sabor();
            try
            {
                DataTable linhas = saborDAO.Buscar(sabor);
                checkedListBox_sabores.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    string descricao = row["Nome"].ToString();
                    sabor = new Sabor();
                    sabor.Descricao = descricao; // Atribui o valor da coluna "Nome" à propriedade Descricao do objeto sabor
                    checkedListBox_sabores.Items.Add(new Sabor(
                        int.Parse(row["ID"].ToString()),
                        row["Nome"].ToString(),
                        char.Parse(row["Categoria"].ToString())
                        )); ;
                }
                checkedListBox_sabores.DisplayMember = "Descricao";
                checkedListBox_sabores.ValueMember = "Sabor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CarregaProdutosCheckedListBox()
        {
            var produto = new Produto();
            try
            {
                DataTable linhas = produtoDAO.Buscar(produto);
                checkedListBox_produtos.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    string descricao = row["Descricao"].ToString();
                    produto = new Produto();
                    produto.Descricao = descricao; // Atribui o valor da coluna "Nome" à propriedade Descricao do objeto sabor
                    checkedListBox_produtos.Items.Add(new Produto(
                        int.Parse(row["ID"].ToString()),
                        row["Descricao"].ToString(),
                        decimal.Parse(row["Valor"].ToString())
                        )); ;
                }
                checkedListBox_produtos.DisplayMember = "Descricao";
                checkedListBox_produtos.ValueMember = "Sabor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                this.street_textBox.Text = "";
                this.neighborhood_textBox.Text = "";
                this.txt_house_number.Text = "";
                this.adress_complement_textBox.Text = "";


                foreach (DataRow row in linhas.Rows)
                {
                    this.celphone_textBox.Text = row["telefone"].ToString(); ;
                    this.cpf_textBox.Text = row["cpf"].ToString(); ;
                    this.street_textBox.Text = row["logradouro"].ToString(); ;
                    this.neighborhood_textBox.Text = row["bairro"].ToString(); ;
                    this.txt_house_number.Text = row["numero"].ToString(); ;
                    this.adress_complement_textBox.Text = row["complemento"].ToString(); ;
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
                this.street_textBox.Text = "";
                this.neighborhood_textBox.Text = "";
                this.txt_house_number.Text = "";
                this.adress_complement_textBox.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    this.nome_textBox.Text = row["nome"].ToString(); ;
                    this.cpf_textBox.Text = row["cpf"].ToString(); ;
                    this.street_textBox.Text = row["logradouro"].ToString(); ;
                    this.neighborhood_textBox.Text = row["bairro"].ToString(); ;
                    this.txt_house_number.Text = row["numero"].ToString(); ;
                    this.adress_complement_textBox.Text = row["complemento"].ToString(); ;
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
                this.street_textBox.Text = "";
                this.neighborhood_textBox.Text = "";
                this.txt_house_number.Text = "";
                this.adress_complement_textBox.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    this.nome_textBox.Text = row["nome"].ToString(); ;
                    this.celphone_textBox.Text = row["telefone"].ToString(); ;
                    this.street_textBox.Text = row["logradouro"].ToString(); ;
                    this.neighborhood_textBox.Text = row["bairro"].ToString(); ;
                    this.txt_house_number.Text = row["numero"].ToString(); ;
                    this.adress_complement_textBox.Text = row["complemento"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_pizza_button_Click(object sender, EventArgs e)
        {
            List<Sabor> saboresLista = checkedListBox_sabores.CheckedItems.OfType<Sabor>().ToList();

            List<Sabor> saboresSelecionados = new List<Sabor>();

            int valorPizza = 0;
            int valorBorda = 0;

            foreach (Sabor itemSelecionado in checkedListBox_sabores.CheckedItems)
            {
                saboresSelecionados.Add(itemSelecionado);
            }

            char categ = ' ';
            foreach (var sabor in saboresLista)
            {
                if (sabor.Categoria == 'E')
                    categ = 'E';
                else
                    categ = 'T';
            }

            char tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), tamanho_combo_box.Text);

            DataTable valor = valorDAO.BuscarTT(tamanho, categ);

            foreach (DataRow row in valor.Rows)
            {
                valorPizza = int.Parse(row["valor"].ToString());
                if (borda_combo_box.Text != "Nao")
                {
                    valorBorda = int.Parse(row["valor_borda"].ToString());
                }
            }

            valorTotalPizzas = valorTotalPizzas + valorPizza + valorBorda;

            //decimal valorCampo = valor.ValorPizza.value();

            pizzas.Add(new Pizza
            {
                Sabores = saboresLista,
                Tamanho = tamanho,
                Borda = (char)(EnumBorda)Enum.Parse(typeof(EnumBorda), borda_combo_box.Text),
                Observacao = textBox_observacao.Text,
                Valor = valorPizza,
                ValorBorda = valorBorda
            });
            AtualizarPizzas();
            atualizarValorTotal();
        }
        private void AtualizarPizzas()
        {
            dataGridViewPizzas.Columns.Clear();

            dataGridViewPizzas.Columns.Add("SaboresColumn", "Sabores");
            dataGridViewPizzas.Columns.Add("TamanhoColumn", "Tamanho");
            dataGridViewPizzas.Columns.Add("ValorPizzaColumn", "Valor Pizza");
            dataGridViewPizzas.Columns.Add("ValorBordaColumn", "Valor Borda");

            foreach (var pizza in pizzas)
            {
                string sabores = string.Join(", ", pizza.Sabores.Select(s => s.Descricao)); // Obtém os sabores separados por vírgula
                string tamanho = pizza.Tamanho.ToString();
                string valorPizza = pizza.Valor.ToString();
                string valorBorda = pizza.ValorBorda.ToString();

                dataGridViewPizzas.Rows.Add(sabores, tamanho, valorPizza, valorBorda);
            }

            // Ajuste as configurações do DataGridView, se necessário
            dataGridViewPizzas.AutoResizeColumns();

            valorPizzas.Text = valorTotalPizzas.ToString();
        }
        private void checkedListBox_produto_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            valorProdutos = 0;
            var elementosSelecionados = checkedListBox_produtos.SelectedItems;
            foreach (var itemSelecionado in elementosSelecionados)
            {
                Produto produtoSelecionado = (Produto)itemSelecionado;
                decimal valor = produtoSelecionado.Valor;
                valorProdutos = valorProdutos + valor;
            }
            atualizarValorTotal();
        }

        private void atualizarValorTotal()
        {
            valorTotal = valorTotalPizzas + valorProdutos;
            textBox_valortotal.Text = valorTotal.ToString();
        }
    }
}

