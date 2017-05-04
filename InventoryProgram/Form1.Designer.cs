namespace InventoryProgram
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAllInventory = new System.Windows.Forms.Panel();
            this.dataGridAllInventory = new System.Windows.Forms.DataGridView();
            this.currentInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInventory = new InventoryProgram.dataSetInventory();
            this.menuStrip1.SuspendLayout();
            this.panelAllInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripInventory";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRegisterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openRegisterToolStripMenuItem
            // 
            this.openRegisterToolStripMenuItem.Name = "openRegisterToolStripMenuItem";
            this.openRegisterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openRegisterToolStripMenuItem.Text = "Open Register";
            this.openRegisterToolStripMenuItem.Click += new System.EventHandler(this.openRegisterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.removeItemToolStripMenuItem,
            this.findItemToolStripMenuItem,
            this.viewAllItemsToolStripMenuItem,
            this.addItemsFromCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.fileToolStripMenuItem.Text = "Inventory";
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addNewItemToolStripMenuItem.Text = "Add New Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItemToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // findItemToolStripMenuItem
            // 
            this.findItemToolStripMenuItem.Name = "findItemToolStripMenuItem";
            this.findItemToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.findItemToolStripMenuItem.Text = "Find Item";
            this.findItemToolStripMenuItem.Click += new System.EventHandler(this.findItemToolStripMenuItem_Click);
            // 
            // viewAllItemsToolStripMenuItem
            // 
            this.viewAllItemsToolStripMenuItem.Name = "viewAllItemsToolStripMenuItem";
            this.viewAllItemsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewAllItemsToolStripMenuItem.Text = "View Inventory Items";
            this.viewAllItemsToolStripMenuItem.Click += new System.EventHandler(this.viewAllItemsToolStripMenuItem_Click);
            // 
            // addItemsFromCSVToolStripMenuItem
            // 
            this.addItemsFromCSVToolStripMenuItem.Name = "addItemsFromCSVToolStripMenuItem";
            this.addItemsFromCSVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addItemsFromCSVToolStripMenuItem.Text = "View Sold Items";
            this.addItemsFromCSVToolStripMenuItem.Click += new System.EventHandler(this.addItemsFromCSVToolStripMenuItem_Click);
            // 
            // panelAllInventory
            // 
            this.panelAllInventory.Controls.Add(this.dataGridAllInventory);
            this.panelAllInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllInventory.Location = new System.Drawing.Point(0, 24);
            this.panelAllInventory.Name = "panelAllInventory";
            this.panelAllInventory.Size = new System.Drawing.Size(1063, 594);
            this.panelAllInventory.TabIndex = 1;
            // 
            // dataGridAllInventory
            // 
            this.dataGridAllInventory.AllowUserToAddRows = false;
            this.dataGridAllInventory.AllowUserToDeleteRows = false;
            this.dataGridAllInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAllInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAllInventory.Location = new System.Drawing.Point(0, 0);
            this.dataGridAllInventory.Name = "dataGridAllInventory";
            this.dataGridAllInventory.ReadOnly = true;
            this.dataGridAllInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridAllInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAllInventory.ShowEditingIcon = false;
            this.dataGridAllInventory.Size = new System.Drawing.Size(1063, 594);
            this.dataGridAllInventory.TabIndex = 0;
            // 
            // currentInventoryBindingSource
            // 
            this.currentInventoryBindingSource.DataMember = "currentInventory";
            this.currentInventoryBindingSource.DataSource = this.dataSetInventory;
            // 
            // dataSetInventory
            // 
            this.dataSetInventory.DataSetName = "dataSetInventory";
            this.dataSetInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 618);
            this.Controls.Add(this.panelAllInventory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Inventory Management Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAllInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemsFromCSVToolStripMenuItem;
        private System.Windows.Forms.Panel panelAllInventory;
        public dataSetInventory dataSetInventory;
        public System.Windows.Forms.DataGridView dataGridAllInventory;
        private System.Windows.Forms.BindingSource currentInventoryBindingSource;
    }
}

