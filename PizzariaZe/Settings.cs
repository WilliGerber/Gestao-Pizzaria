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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Program.isChangingLanguage = true;

            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBox_language.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");
            if (checkBox_language_restart.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
