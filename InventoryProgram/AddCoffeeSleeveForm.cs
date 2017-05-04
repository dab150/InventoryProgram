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
    public partial class AddCoffeeSleeveForm : Form
    {
        private mainForm main;

        public AddCoffeeSleeveForm(mainForm f)
        {
            InitializeComponent();
            this.main= f;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            coffeeSleeve newSleeve = new coffeeSleeve();

            newSleeve.number = Convert.ToInt16(txtID.Text.ToString());
            newSleeve.frontFabric = txtFrontFabric.Text.ToString();
            newSleeve.backFabric = txtBackFabric.Text.ToString();
            newSleeve.buttonColor = txtButton.Text.ToString();
            newSleeve.hairTieColor = txtHairTie.Text.ToString();
            newSleeve.condition = txtCondition.Text.ToString();
            newSleeve.location = txtLocation.Text.ToString();
            newSleeve.dateCreated = txtDate.Text.ToString();
            newSleeve.cost = Convert.ToDouble(txtCost.Text.ToString());
            newSleeve.price = Convert.ToDouble(txtPrice.Text.ToString());

            newSleeve.addToInventory(main);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
