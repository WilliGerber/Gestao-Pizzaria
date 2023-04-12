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
    public partial class CreateEditPizzaSizes : Form
    {
        public CreateEditPizzaSizes()
        {
            InitializeComponent();
        }

        private void add_flavours_Click(object sender, EventArgs e)
        {
            CreateEditFlavours createEditFlavours = new CreateEditFlavours();
            createEditFlavours.ShowDialog();
        }
    }
}
