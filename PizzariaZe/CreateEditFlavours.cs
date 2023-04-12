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
    public partial class CreateEditFlavours : Form
    {
        public CreateEditFlavours()
        {
            InitializeComponent();
        }

        private void add_ingredients_Click(object sender, EventArgs e)
        {
            CreateEditIngredients createEditIngredients = new CreateEditIngredients();
            createEditIngredients.ShowDialog();
        }
    }
}
