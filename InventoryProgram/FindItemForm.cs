using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace InventoryProgram
{
    public partial class FindItemForm : Form
    {
        private mainForm main = new mainForm();
        public FindItemForm(mainForm f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            craft c = new craft();

            c.number = Convert.ToInt16(txtID.Text.ToString());

            c.findInInventory(c.number, main);
          
            this.Close();
        }
    }
}
