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
    public partial class AddBookmarkForm : Form
    {
        private mainForm main;
        public AddBookmarkForm(mainForm f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            /* The below SQL insert needs modified to insert a bookmark
            /  This may involve creating seperate tables for bookmarks, coffee sleeves, etc.
            /  Needs to be thought out more
            */

            //string sql = @"insert into inventory (Type, InventoryNumber, FabricFront, FabricBack, Button, HairTie, Condition, Location, DateCreated, Cost, Price) values ("
            //    + "'Bookmark'" + ","
            //    + Convert.ToInt16(txtID.Text.ToString()) + ","
            //    + "'" + txtFrontFabric.Text.ToString() + "'" + ","
            //    + "'" + txtBackFabric.Text.ToString() + "'" + ","
            //    + "'" + txtButton.Text.ToString() + "'" + ","
            //    + "'" + txtHairTie.Text.ToString() + "'" + ","
            //    + "'" + txtCondition.Text.ToString() + "'" + ","
            //    + "'" + txtLocation.Text.ToString() + "'" + ","
            //    + "'" + txtDate.Text.ToString() + "'" + ","
            //    + Convert.ToDouble(txtCost.Text.ToString()) + ","
            //    + Convert.ToDouble(txtPrice.Text.ToString()) + ")";

            //SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            //command.ExecuteNonQuery();

            //MessageBox.Show("Coffee Sleeve, item " + txtID.Text.ToString() + " added to inventory!");

            ////update datasource for the changed dataset
            //main.updateInventoryGrid();

            //this.Close();
        }
    }


}
