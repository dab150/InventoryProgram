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
    public partial class RemoveItemForm : Form
    {
        private mainForm main = new mainForm();
        public RemoveItemForm(mainForm f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            craft c = new craft();

            c.number = Convert.ToInt16(txtID.Text.ToString());

            c.removeFromInventory(c.number, main);

            this.Close();
        }
    }
}
