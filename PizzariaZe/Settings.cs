using PizzariaDoZe;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Functions.EventoFocoCampos(this);

            //seleciona no comboBox o idioma/cultura atual
            comboBox_language.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            cmb_box_provider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            txt_box_connection_string.Text = connectionStringSettings.ConnectionString;
        }


        private void btn_save_settings_Click_Click(object sender, EventArgs e)
        {
            Program.isChangingLanguage = true;

            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBox_language.Text);

            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = cmb_box_provider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = txt_box_connection_string.Text;

            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("appSettings");
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");
            Close();
            _ = MessageBox.Show("Dados alterados com sucesso!");
            if (checkBox_language_restart.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
