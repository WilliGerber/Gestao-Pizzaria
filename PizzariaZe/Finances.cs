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
    public partial class Finances : Form
    {
        public Finances()
        {
            InitializeComponent();
        }

        private void add_pizza_sizes_Click(object sender, EventArgs e)
        {
            CreateEditPizzaSizes createEditPizzaSizes = new CreateEditPizzaSizes();
            createEditPizzaSizes.ShowDialog();
        }
    }
}
