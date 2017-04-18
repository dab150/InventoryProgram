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
            string sql = @"DELETE FROM inventory WHERE InventoryNumber = " + txtID.Text.ToString();

            SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            command.ExecuteNonQuery();

            MessageBox.Show("Item " + txtID.Text.ToString() + " removed from inventory!");

            //update datasource for the changed dataset
            main.updateInventoryGrid();

            this.Close();
        }
    }
}
