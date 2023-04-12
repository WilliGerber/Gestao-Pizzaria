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
    public partial class Flavours : Form
    {
        public Flavours()
        {
            InitializeComponent();
        }

        private void add_ingredients_Click(object sender, EventArgs e)
        {
            CreateEditIngredients createEditIngredients = new CreateEditIngredients();
            createEditIngredients.ShowDialog();
        }

        private void add_flavours_Click(object sender, EventArgs e)
        {
            CreateEditFlavours createEditFlavours = new CreateEditFlavours();
            createEditFlavours.ShowDialog();
        }

        private void pizzas_sizes_Click(object sender, EventArgs e)
        {
            CreateEditPizzaSizes createEditPizzaSizes = new CreateEditPizzaSizes();
            createEditPizzaSizes.ShowDialog();
        }
    }
}
