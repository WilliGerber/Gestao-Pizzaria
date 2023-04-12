using PizzariaDoZe;
using PizzariaZe.Properties;

namespace PizzariaZe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Functions.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

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
            Orders orders = new Orders();
            DisposeAllButThis(this);
            orders.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(orders);
            orders.Show();
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
    }
}
