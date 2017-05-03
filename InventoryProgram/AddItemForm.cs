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
        private mainForm main;

        public AddItemForm(mainForm f)
        {
            InitializeComponent();
            this.main = f;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //newAddItem.Show();

            if (cmbItemType.Text.ToString() == "General Craft")
                addOtherItem();
            else if (cmbItemType.Text.ToString() == "Coffee Sleeve")
                addCoffeeSleeve();
            else if (cmbItemType.Text.ToString() == "Bookmark")
                addBookmark();
        }


        private void addOtherItem()
        {
            AddOtherItemForm newOtherItem = new AddOtherItemForm(this.main);
            newOtherItem.Show();
            this.Close();
        }

        private void addCoffeeSleeve()
        {
            AddCoffeeSleeveForm newCoffeeSleeve = new AddCoffeeSleeveForm(this.main);
            newCoffeeSleeve.Show();
            this.Close();
        }

        private void addBookmark()
        {
            AddBookmarkForm newBookmark = new AddBookmarkForm(this.main);
            newBookmark.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
