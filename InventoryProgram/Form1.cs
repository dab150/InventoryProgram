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
    public partial class mainForm : Form
    {
        //create a list of crafts to store all current inventory
        //public List<craft> listInventory = new List<craft>();

        //create the SQLite connection object as a member variable
        public SQLiteConnection m_dbConnection;
        
        public mainForm()
        {
            InitializeComponent();

            //setup the connection on initialization
            const string filename = @"C:\Users\cironid12\Documents\Sourcetree\InventoryProgram\InventoryProgram\SQLLiteDatabase.db";
            m_dbConnection = new SQLiteConnection("Data Source=" + filename + "; Version=3;");
            m_dbConnection.Open();

            updateInventoryGrid();

            //string sqlinput = "insert into inventory (Type, InventoryNumber) values ('New Test', 50)";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //command.ExecuteNonQuery();
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm newAddItem = new AddItemForm(this);
            newAddItem.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_dbConnection.Close();
            this.Close();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItemForm removeItem = new RemoveItemForm(this);
            removeItem.Show();
        }

        private void viewAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateInventoryGrid();
        }

        public void updateInventoryGrid()
        {
            DataSet ds = new DataSet();
            string sql = "select * from inventory;";

            var da = new SQLiteDataAdapter(sql, m_dbConnection);
            da.Fill(ds);
            dataGridAllInventory.DataSource = ds.Tables[0].DefaultView;
        }

        private void findItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindItemForm findItem = new FindItemForm(this);
            findItem.Show();
        }

        private void openRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm(this);
            reg.Show();
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
