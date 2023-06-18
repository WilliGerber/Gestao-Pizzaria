using PizzariaDoZe;
using PizzariaZe.Properties;
using System.ComponentModel;
using System.Configuration;

namespace PizzariaZe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            #region initializer
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Functions.EventoFocoCampos(this);

            this.Resize += new EventHandler(Menu_Resize!);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing!);

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Functions.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
            #endregion

            #region sprip menu geral clicks manager

            startToolStripMenuItem.Click += new EventHandler(dashboard_nav_bar_Click!);
            startToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            ordersToolStripMenuItem.Click += new EventHandler(orders_nav_bar_Click!);
            ordersToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            pizzasToolStripMenuItem.Click += new EventHandler(products_nav_bar_Click!);
            pizzasToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            supplyToolStripMenuItem.Click += new EventHandler(supply_nav_bar_Click!);
            supplyToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            financesToolStripMenuItem.Click += new EventHandler(finances_nav_bar_Click!);
            financesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            clientsToolStripMenuItem.Click += new EventHandler(clients_nav_bar_Click!);
            clientsToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            employeesToolStripMenuItem.Click += new EventHandler(employees_nav_bar_Click!);
            employeesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            settingsToolStripMenuItem.Click += new EventHandler(settings_nav_bar_Click!);
            settingsToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F8;
            exitToolStripMenuItem.ShortcutKeys = Keys.F9;

            #endregion

            Functions.ValidaConexaoDB();

        }
        private void ClearPanelContent()
        {
            // Remove todos os controles do pannelContent
            while (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls[0].Dispose();
            }
        }


        #region nav bar clicks manager
        private void clients_nav_bar_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            DisposeAllButThis(this);
            clients.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(clients);
            clients.Show();
        }

        public void dashboard_nav_bar_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            DisposeAllButThis(this);
            dashboard.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void orders_nav_bar_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            Pedidos pedidos = new Pedidos();
            DisposeAllButThis(this);
            pedidos.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(pedidos);
            pedidos.Show();
        }

        private void products_nav_bar_Click(object sender, EventArgs e)
        {
            Flavours products = new Flavours();
            DisposeAllButThis(this);
            products.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(products);
            products.Show();
        }

        private void supply_nav_bar_Click(object sender, EventArgs e)
        {
            Supply supply = new Supply();
            DisposeAllButThis(this);
            supply.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(supply);
            supply.Show();
        }

        private void finances_nav_bar_Click(object sender, EventArgs e)
        {
            Finances finances = new Finances();
            DisposeAllButThis(this);
            finances.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(finances);
            finances.Show();
        }

        private void employees_nav_bar_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            DisposeAllButThis(this);
            employees.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(employees);
            employees.Show();
        }

        private void settings_nav_bar_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            DisposeAllButThis(this);
            settings.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(settings);
            settings.Show();
        }
        #endregion
        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica se há mudança de idioma pendente
            if (Program.isChangingLanguage)
            {
                // Se houver uma mudança de idioma pendente, aguarde o usuário reiniciar a aplicação antes de fechar a janela
                e.Cancel = true;
                return;
            }

            // Verifica se o formulário pode ser fechado
            CloseForm closeForm = new CloseForm();
            closeForm.ShowDialog();
            if (closeForm.DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        //private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    CloseForm closeForm = new CloseForm();

        //    // Mostra o formulário closeForm para gerenciar o fechamento
        //    closeForm.ShowDialog();

        //    // Verifica o resultado do diálogo e cancela o fechamento se necessário
        //    if (closeForm.DialogResult == DialogResult.Yes)
        //    {
        //        e.Cancel = false;
        //    }
        //    else if (closeForm.DialogResult == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //    else if (closeForm.DialogResult == DialogResult.OK)
        //    {
        //        this.WindowState = FormWindowState.Minimized;
        //        e.Cancel = true;
        //    }



        //    //switch (e.CloseReason)
        //    //{
        //    //    case CloseReason.UserClosing:
        //    //        DialogResult result = MessageBox.Show("Deseja fechar a aplicação?",
        //    //                                "Sair?",
        //    //                                MessageBoxButtons.YesNoCancel,
        //    //                                MessageBoxIcon.Question,
        //    //                                MessageBoxDefaultButton.Button2);

        //    //        Button btnCancelar = new Button();
        //    //        btnCancelar.DialogResult = DialogResult.Cancel;
        //    //        this.CancelButton = btnCancelar;
        //    //        btnCancelar.Text = "Minimizar";
        //    //        btnCancelar.Click += new EventHandler(Menu_Resize!);
        //    //        this.ControlBox = false;
        //    //        this.Controls.Add(btnCancelar);

        //    //        switch (result)
        //    //        {
        //    //            case DialogResult.Cancel:
        //    //                ((Form)sender).WindowState = FormWindowState.Minimized;
        //    //                e.Cancel = true; // Cancela o evento de fechamento
        //    //                break;
        //    //            case DialogResult.Yes:
        //    //                e.Cancel = false;
        //    //                break;
        //    //            case DialogResult.No:
        //    //                e.Cancel = true;
        //    //                break;


        //    //        }

        //    //if (result == DialogResult.Cancel)
        //    //{
        //    //    Menu_Resize(null, null);
        //    //    e.Cancel = true;
        //    //}
        //    //else if (result == DialogResult.Yes)
        //    //{
        //    //    e.Cancel = false;
        //    //}
        //    //break;
        //    //}
        //}

        #region sprip menu geral clicks manager 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region strip menu trail clicks manager
        private void exitToolStripMenuItemSystemTray_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void openAppToolStripMenuItemSystemTray_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }

        #endregion


        private void contextMenuStripSystem_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
