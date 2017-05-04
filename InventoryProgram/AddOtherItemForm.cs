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
    public partial class AddOtherItemForm : Form
    {
        //variable to pass in mainForm so I can access items on mainForm
        private mainForm main;

        public AddOtherItemForm(mainForm f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            craft c = new craft();

            c.number = Convert.ToInt16(txtID.Text.ToString());
            c.cost = Convert.ToDouble(txtCost.Text.ToString());
            c.price = Convert.ToDouble(txtPrice.Text.ToString());
            c.location = txtLocation.Text.ToString();
            c.dateCreated = txtDate.Text.ToString();
            c.condition = txtCondition.Text.ToString();

            c.addToInventory(main);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
