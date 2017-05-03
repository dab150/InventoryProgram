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
    public partial class RegisterForm : Form
    {
        private mainForm main;
        private DataSet cartDataSet;

        public RegisterForm(mainForm f)
        {
            InitializeComponent();
            this.main = f;

            cartDataSet = new DataSet();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool duplicate = false;

            if (txtAddItemID.Text.ToString() == "")
            {
                MessageBox.Show("Please enter a valid item ID");
            }
            else
            {
                //find the item
                string sql = @"Select * FROM inventory WHERE InventoryNumber = " + txtAddItemID.Text.ToString();

                //create a temp dataset to search
                //this allows us to detect if we found no results
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(sql, main.m_dbConnection);
                da.Fill(ds);

                //make sure it isn't already in the cart
                if (cartDataSet.Tables.Count > 0)
                {
                    foreach (DataRow row in cartDataSet.Tables[0].Rows)
                    {
                        if (txtAddItemID.Text.ToString() == row["InventoryNumber"].ToString())
                            duplicate = true;
                    }
                }

                //if we found it and it isn't duplicate, add to cart
                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("Item " + txtAddItemID.Text.ToString() + " not found!");
                else if (duplicate)
                    MessageBox.Show("Item " + txtAddItemID.Text.ToString() + " is already in the cart!");
                else
                {
                    da.Fill(cartDataSet);
                    dataGridCart.DataSource = cartDataSet.Tables[0].DefaultView;
                    updateTotals();
                }

                //clear the addItem text for cleanliness
                txtAddItemID.Text = "";
            }
        }

        private void updateTotals()
        {
            double subtotal = 0;
            double taxRate = 0;
            double tax = 0;
            double total = 0;

            //gather our subtotal
            foreach(DataRow row in cartDataSet.Tables[0].Rows)
                subtotal += Convert.ToDouble(row["Price"].ToString());
            txtSubtotal.Text = subtotal.ToString();

            //add tax
            if(!double.TryParse(txtTaxRate.Text.ToString(), out taxRate))
                taxRate = 0.0;
            txtTaxRate.Text = taxRate.ToString();
            tax = subtotal * (taxRate * .01);
            txtTax.Text = tax.ToString();

            //calculate total
            total = subtotal + tax;
            txtTotal.Text = total.ToString();
        }

        private void txtTaxRate_TextChanged(object sender, EventArgs e)
        {
            updateTotals();
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            double total = 0;
            double paid = 0;
            double change = 0;

            //calculate change
            if (!double.TryParse(txtTotal.Text.ToString(), out total) || !double.TryParse(txtPaid.Text.ToString(), out paid))
            {
                paid = 0.0;
                total = 0.0;
            }

            change = paid - total;

            //update change field
            txtChange.Text = change.ToString();
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            cartDataSet.Clear();
            updateTotals();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //copy the items from inventory to soldItems table
            foreach (DataRow row in cartDataSet.Tables[0].Rows)
            {
                string sql = @"INSERT INTO soldItems SELECT * FROM inventory WHERE InventoryNumber = " + row["InventoryNumber"].ToString();

                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(sql, main.m_dbConnection);
                da.Fill(ds);
            }

            //delete them from the inventory database
            foreach (DataRow row in cartDataSet.Tables[0].Rows)
            {
                string sql = @"DELETE FROM inventory WHERE InventoryNumber = " + row["InventoryNumber"].ToString();

                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(sql, main.m_dbConnection);
                da.Fill(ds);
            }

            main.dataGridAllInventory.Refresh();
            cartDataSet.Clear();
            updateTotals();
        }
    }
}
