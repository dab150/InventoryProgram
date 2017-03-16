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
    public partial class mainForm : Form
    {
        //create a list of crafts to store all current inventory
        //public List<craft> listInventory = new List<craft>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm newAddItem = new AddItemForm(this);
            newAddItem.Show();

            //update datasource from the changed dataset
            dataSetInventory.currentInventory.AcceptChanges();
            dataGridAllInventory.Update();
            dataSetInventory.AcceptChanges();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItemForm removeItem = new RemoveItemForm(this);
            removeItem.Show();
        }
    }

    public class craft
    {
        /*Constructor*/
        public craft() { }

        public craft(int newItemNumber)
        {
            number = newItemNumber;
            group = "General Craft";
            cost = 0.00;
            price = 0.00;
            location = "Apartment";
            dateCreated = DateTime.Now;
        }

        /*class members */
        public int number { get; set; } //unique number to identify each item
        public String group { get; set; }  //identifies what type of 
        public double cost { get; set; } //cost of the item
        public double price { get; set; } //price of the item
        public String location { get; set; } //physical location of the item (ex. Antique Store)
        public DateTime dateCreated { get; set; } //date the item was added to inventory

        /*class methods*/
        public void addToInventory()
        {

        }
    }

    public class coffeeSleeve : craft
    {
        /*Constructor*/
        public coffeeSleeve() { }

        /*class members*/
        String Group = "Coffee Sleeve";
        String frontPattern; //describes the front fabric pattern
        String backPattern; //describes the back fabric pattern
        String buttonColor; //describes the button color
        String strapColor; //describes the elastic strap color
    }

    public class bookmark : craft
    {
        /*Constructor*/
        public bookmark() { }

        /*class members*/
        String Group = "Bookmark";
        String frontPattern; //describes the front fabric pattern
        String backPattern; //describes the back fabric pattern
        String ribbonColor; //describes the color of the ribbon
    }
}
