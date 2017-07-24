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
            const string filename = "SQLLiteDatabase.db";//@"C:\Users\cironid12\Documents\Sourcetree\InventoryProgram\InventoryProgram\SQLLiteDatabase.db";
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

        private void addItemsFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "select * from soldItems;";

            var da = new SQLiteDataAdapter(sql, m_dbConnection);
            da.Fill(ds);
            dataGridAllInventory.DataSource = ds.Tables[0].DefaultView;
        }
    }

    public class craft
    {
        /*Constructor*/

        public craft() { }

        /*class members */
        public int number; //unique number to identify each item
        public string type;  //identifies what type of 
        public double cost; //cost of the item
        public double price; //price of the item
        public string location; //physical location of the item (ex. Antique Store)
        public string condition; //describes the condition of the item
        public string dateCreated; //date the item was added to inventory

        /*class methods*/
        public virtual void addToInventory(mainForm main)
        {
            string sql = @"insert into inventory (Type, InventoryNumber, Condition, Location, DateCreated, Cost, Price) values ("
              + "'General Craft'" + ","
              + Convert.ToInt16(this.number.ToString()) + ","
              + "'" + this.condition.ToString() + "'" + ","
              + "'" + this.location.ToString() + "'" + ","
              + "'" + this.dateCreated.ToString() + "'" + ","
              + Convert.ToDouble(this.cost.ToString()) + ","
              + Convert.ToDouble(this.price.ToString()) + ")";

            SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            command.ExecuteNonQuery();
            main.updateInventoryGrid();
        }

        public void removeFromInventory(int inventoryNum, mainForm main)
        {
            string sql = @"DELETE FROM inventory WHERE InventoryNumber = " + inventoryNum.ToString();

            SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            command.ExecuteNonQuery();

            MessageBox.Show("Item " + inventoryNum.ToString() + " removed from inventory!");

            //update datasource for the changed dataset
            main.updateInventoryGrid();
        }

        public void findInInventory(int inventoryNum, mainForm main)
        {
            string sql = @"Select * FROM inventory WHERE InventoryNumber = " + inventoryNum.ToString();

            DataSet ds = new DataSet();

            var da = new SQLiteDataAdapter(sql, main.m_dbConnection);
            da.Fill(ds);
            main.dataGridAllInventory.DataSource = ds.Tables[0].DefaultView;

            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("Item " + inventoryNum.ToString() + " not found!");
        }
    }

    public class coffeeSleeve : craft
    {
        /*Constructor*/
        public coffeeSleeve() { }

        /*class members*/
        public string type = "Coffee Sleeve";
        public string frontFabric; //describes the front fabric pattern
        public string backFabric; //describes the back fabric pattern
        public string buttonColor; //describes the button color
        public string hairTieColor; //describes the elastic strap color

        public override void addToInventory(mainForm main)
        {
            string sql = @"insert into inventory (Type, InventoryNumber, FabricFront, FabricBack, 
                            Button, HairTie, Condition, Location, DateCreated, Cost, Price) values ("
               + "'Coffee Sleeve'" + ","
               + Convert.ToInt16(this.number.ToString()) + ","
               + "'" + this.frontFabric.ToString() + "'" + ","
               + "'" + this.backFabric.ToString() + "'" + ","
               + "'" + this.buttonColor.ToString() + "'" + ","
               + "'" + this.hairTieColor.ToString() + "'" + ","
               + "'" + this.condition.ToString() + "'" + ","
               + "'" + this.location.ToString() + "'" + ","
               + "'" + this.dateCreated.ToString() + "'" + ","
               + Convert.ToDouble(this.cost.ToString()) + ","
               + Convert.ToDouble(this.price.ToString()) + ")";

            SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            command.ExecuteNonQuery();
            main.updateInventoryGrid();
        }
    }

    public class bookmark : craft
    {
        /*Constructor*/
        public bookmark() { }

        /*class members*/
        public string type = "Bookmark";
        public string frontFabric; //describes the front fabric pattern
        public string backFabric; //describes the back fabric pattern
        public string charm; //describes the color of the ribbon

        public override void addToInventory(mainForm main)
        {
            string sql = @"insert into inventory (Type, InventoryNumber, FabricFront, FabricBack, Charm, Condition, Location, DateCreated, Cost, Price) values ("
               + "'Bookmark'" + ","
               + Convert.ToInt16(this.number.ToString()) + ","
               + "'" + this.frontFabric.ToString() + "'" + ","
               + "'" + this.backFabric.ToString() + "'" + ","
               + "'" + this.charm.ToString() + "'" + ","
               + "'" + this.condition.ToString() + "'" + ","
               + "'" + this.location.ToString() + "'" + ","
               + "'" + this.dateCreated.ToString() + "'" + ","
               + Convert.ToDouble(this.cost.ToString()) + ","
               + Convert.ToDouble(this.price.ToString()) + ")";

            SQLiteCommand command = new SQLiteCommand(sql, main.m_dbConnection);
            command.ExecuteNonQuery();
            main.updateInventoryGrid();
        }

    }
}
