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
            bookmark newBookmark = new bookmark();

            newBookmark.number = Convert.ToInt16(txtID.Text.ToString());
            newBookmark.frontFabric = txtFrontFabric.Text.ToString();
            newBookmark.backFabric = txtBackFabric.Text.ToString();
            newBookmark.charm = txtCharm.Text.ToString();
            newBookmark.condition = txtCondition.Text.ToString();
            newBookmark.location = txtLocation.Text.ToString();
            newBookmark.dateCreated = txtDate.Text.ToString();
            newBookmark.cost = Convert.ToDouble(txtCost.Text.ToString());
            newBookmark.price = Convert.ToDouble(txtPrice.Text.ToString());

            newBookmark.addToInventory(main);

            this.Close();
        }
    }


}
