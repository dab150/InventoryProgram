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
            bool found = false;

            for (int i = main.dataSetInventory.Tables["currentInventory"].Rows.Count; i > 0; i--)
            {

                if (Convert.ToInt16(txtID.Text.ToString()) == Convert.ToInt16(main.dataSetInventory.Tables["currentInventory"].Rows[i - 1]["Item Number"].ToString()))
                {
                    DataRow row = main.dataSetInventory.Tables["currentInventory"].Rows[i - 1];
                    main.dataSetInventory.Tables["currentInventory"].Rows.Remove(row);
                    
                    //set grid display to currentInventory
                    main.dataGridAllInventory.DataSource = main.dataSetInventory.currentInventory;

                    MessageBox.Show("Item " + txtID.Text.ToString() + " removed from inventory!");

                    found = true;
                }
            }

            if (found)
                this.Close();
            else
                MessageBox.Show("Item " + txtID.Text.ToString() + " not found!");

        }
    }
}
