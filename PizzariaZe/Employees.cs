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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            CreateEditEmployee createEditEmployee = new CreateEditEmployee();
            createEditEmployee.ShowDialog();
        }
    }
}
