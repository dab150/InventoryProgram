﻿namespace InventoryProgram
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
            this.dataSetInventory = new InventoryProgram.dataSetInventory();
            this.dataSetInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentInventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelAllInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryBindingSource1)).BeginInit();
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
            this.openRegisterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openRegisterToolStripMenuItem.Text = "Open Register";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addNewItemToolStripMenuItem.Text = "Add New Item";
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            // 
            // findItemToolStripMenuItem
            // 
            this.findItemToolStripMenuItem.Name = "findItemToolStripMenuItem";
            this.findItemToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.findItemToolStripMenuItem.Text = "Find Item";
            // 
            // viewAllItemsToolStripMenuItem
            // 
            this.viewAllItemsToolStripMenuItem.Name = "viewAllItemsToolStripMenuItem";
            this.viewAllItemsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewAllItemsToolStripMenuItem.Text = "View All Items";
            // 
            // addItemsFromCSVToolStripMenuItem
            // 
            this.addItemsFromCSVToolStripMenuItem.Name = "addItemsFromCSVToolStripMenuItem";
            this.addItemsFromCSVToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addItemsFromCSVToolStripMenuItem.Text = "Add Items From CSV";
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
            this.dataGridAllInventory.AutoGenerateColumns = false;
            this.dataGridAllInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumberDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.dataGridAllInventory.DataSource = this.currentInventoryBindingSource1;
            this.dataGridAllInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAllInventory.Location = new System.Drawing.Point(0, 0);
            this.dataGridAllInventory.Name = "dataGridAllInventory";
            this.dataGridAllInventory.Size = new System.Drawing.Size(1063, 594);
            this.dataGridAllInventory.TabIndex = 0;
            // 
            // dataSetInventory
            // 
            this.dataSetInventory.DataSetName = "dataSetInventory";
            this.dataSetInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetInventoryBindingSource
            // 
            this.dataSetInventoryBindingSource.DataSource = this.dataSetInventory;
            this.dataSetInventoryBindingSource.Position = 0;
            // 
            // currentInventoryBindingSource
            // 
            this.currentInventoryBindingSource.DataMember = "currentInventory";
            this.currentInventoryBindingSource.DataSource = this.dataSetInventory;
            // 
            // itemNumberDataGridViewTextBoxColumn
            // 
            this.itemNumberDataGridViewTextBoxColumn.DataPropertyName = "Item Number";
            this.itemNumberDataGridViewTextBoxColumn.HeaderText = "Item Number";
            this.itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // currentInventoryBindingSource1
            // 
            this.currentInventoryBindingSource1.DataMember = "currentInventory";
            this.currentInventoryBindingSource1.DataSource = this.dataSetInventory;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridAllInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource currentInventoryBindingSource;
        private dataSetInventory dataSetInventory;
        private System.Windows.Forms.BindingSource dataSetInventoryBindingSource;
        private System.Windows.Forms.BindingSource currentInventoryBindingSource1;
    }
}
