using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    public partial class AddItemForm : Form
    {
        //variable to pass in mainForm so I can access items on mainForm
        private mainForm main;

        public AddItemForm(mainForm f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create a craft object to add to the list
            craft newCraft = new craft();

            //add information to the new object
            newCraft.number = Convert.ToInt16(txtID.Text.ToString());
            newCraft.group = cmbItemType.Text.ToString();
            newCraft.cost = Convert.ToDouble(txtCost.Text.ToString());
            newCraft.price = Convert.ToDouble(txtPrice.Text.ToString());
            newCraft.location = txtLocation.Text.ToString();
            newCraft.dateCreated = Convert.ToDateTime(txtDate.Text.ToString());

            //listInventory.Add(newCraft);
            dataSetInventory.currentInventoryRow newRow = main.dataSetInventory.currentInventory.NewcurrentInventoryRow();

            //set the rows values
            newRow.Item_Number = newCraft.number;
            newRow.Group = newCraft.group;
            newRow.Cost = newCraft.cost;
            newRow.Price = newCraft.price;
            newRow.Location = newCraft.location;
            newRow.Date_Created = newCraft.dateCreated;

            //add the new row to current inventory
            main.dataSetInventory.currentInventory.AddcurrentInventoryRow(newRow);

            //set grid display to currentInventory
            main.dataGridAllInventory.DataSource = main.dataSetInventory.currentInventory;

            MessageBox.Show("Item " + txtID.Text.ToString() + " added to inventory!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
