﻿using PizzariaDoZe.DAO;
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
    public partial class Tamanhos : Form
    {
        private ValorDAO valorDAO;

        public Tamanhos()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);
            AtualizarTela();
        }

        private void btn_pizzas_sizes_Click(object sender, EventArgs e)
        {
            CreateEditPizzaSizes createEditPizzaSizes = new CreateEditPizzaSizes();
            createEditPizzaSizes.ShowDialog();
        }
        public void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Valor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = valorDAO.Buscar(sabor);
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
