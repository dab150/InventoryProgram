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
        public mainForm()
        {
            InitializeComponent();
            //create a craft object for testing
            craft newCraft = new craft(0001);

            //create a dataset
            //dataSetInventory inventory = new dataSetInventory();
            //create a new row

            dataSetInventory.currentInventoryRow newRow = dataSetInventory.currentInventory.NewcurrentInventoryRow();
            //add information to the row
            newRow.Item_Number = newCraft.number;
            newRow.Group = newCraft.group;
            newRow.Cost = newCraft.cost;
            newRow.Price = newCraft.price;
            newRow.Location = newCraft.location;
            newRow.Date_Created = newCraft.dateCreated;
            //add row to the table
            dataSetInventory.currentInventory.Rows.Add(newRow);
        }
    }

    public class craft
    {
        /*Constructor*/
        public craft() { }

        public craft(int newItemNumber)
        {
            number = newItemNumber;
            group = "Craft";
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
