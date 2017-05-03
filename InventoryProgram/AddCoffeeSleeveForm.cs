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
            string sql = @"insert into inventory (Type, InventoryNumber, FabricFront, FabricBack, Button, HairTie, Condition, Location, DateCreated, Cost, Price) values ("
                + "'Coffee Sleeve'" + ","
                + Convert.ToInt16(txtID.Text.ToString()) + ","
                + "'" + txtFrontFabric.Text.ToString() + "'" + ","
                + "'" + txtBackFabric.Text.ToString() + "'" + ","
                + "'" + txtButton.Text.ToString() + "'" + ","
                + "'" + txtHairTie.Text.ToString() + "'" + ","
                + "'" + txtCondition.Text.ToString() + "'" + ","
                + "'" + txtLocation.Text.ToString() + "'" + ","
                + "'" + txtDate.Text.ToString() + "'" + ","
                + Convert.ToDouble(txtCost.Text.ToString()) + ","
                + Convert.ToDouble(txtPrice.Text.ToString()) + ")";

            SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            command.ExecuteNonQuery();

            MessageBox.Show("Coffee Sleeve, item " + txtID.Text.ToString() + " added to inventory!");

            //update datasource for the changed dataset
            main.updateInventoryGrid();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
