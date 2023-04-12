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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            CreateEditClients createEditClients = new CreateEditClients();
            createEditClients.ShowDialog();
        }
    }
}
