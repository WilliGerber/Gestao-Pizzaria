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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }
        private void ClearPanelContent()
        {
            // Remove todos os controles do pannelContent
            while (pannelContent.Controls.Count > 0)
            {
                pannelContent.Controls[0].Dispose();
            }
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

        private void btn_add_flavours_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            CreateEditOrders pedidos = new CreateEditOrders();
            DisposeAllButThis(this);
            pedidos.TopLevel = false;
            pannelContent.Controls.Add(pedidos);
            pedidos.Show();
        }
    }
}
