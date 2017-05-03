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


            string sql = @"insert into inventory (Type, InventoryNumber, Location, DateCreated, Cost, Price) values ("
                + "'" + cmbItemType.Text.ToString() + "'" + ","
                + Convert.ToInt16(txtID.Text.ToString()) + ","
                + "'" + txtLocation.Text.ToString() + "'" + ","
                + "'" + txtDate.Text.ToString() + "'" + ","
                + Convert.ToDouble(txtCost.Text.ToString()) + ","
                + Convert.ToDouble(txtPrice.Text.ToString()) + ")";

            SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            command.ExecuteNonQuery();

            MessageBox.Show("Item " + txtID.Text.ToString() + " added to inventory!");

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
