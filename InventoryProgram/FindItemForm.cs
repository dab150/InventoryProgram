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
            string sql = @"Select * FROM inventory WHERE InventoryNumber = " + txtID.Text.ToString();

            DataSet ds = new DataSet();

            var da = new SQLiteDataAdapter(sql, main.m_dbConnection);
            da.Fill(ds);
            main.dataGridAllInventory.DataSource = ds.Tables[0].DefaultView;

            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("Item " + txtID.Text.ToString() + " not found!");

            this.Close();
        }
    }
}
