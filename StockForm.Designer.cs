namespace hardware_store
{
    partial class StockForm
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
            this.stocksListView = new System.Windows.Forms.ListView();
            this.itemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currStockLabel = new System.Windows.Forms.Label();
            this.newItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stocksListView
            // 
            this.stocksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemColumn,
            this.quantityColumn});
            this.stocksListView.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.stocksListView.HideSelection = false;
            this.stocksListView.Location = new System.Drawing.Point(16, 94);
            this.stocksListView.Margin = new System.Windows.Forms.Padding(4);
            this.stocksListView.Name = "stocksListView";
            this.stocksListView.Size = new System.Drawing.Size(585, 333);
            this.stocksListView.TabIndex = 0;
            this.stocksListView.UseCompatibleStateImageBehavior = false;
            this.stocksListView.View = System.Windows.Forms.View.Details;
            // 
            // itemColumn
            // 
            this.itemColumn.Text = "Item";
            this.itemColumn.Width = 311;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Quantity";
            this.quantityColumn.Width = 124;
            // 
            // currStockLabel
            // 
            this.currStockLabel.AutoSize = true;
            this.currStockLabel.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.currStockLabel.Location = new System.Drawing.Point(193, 11);
            this.currStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currStockLabel.Name = "currStockLabel";
            this.currStockLabel.Size = new System.Drawing.Size(196, 32);
            this.currStockLabel.TabIndex = 1;
            this.currStockLabel.Text = "Current Stock";
            // 
            // newItemButton
            // 
            this.newItemButton.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.newItemButton.Location = new System.Drawing.Point(16, 434);
            this.newItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(223, 43);
            this.newItemButton.TabIndex = 2;
            this.newItemButton.Text = "Add New Item";
            this.newItemButton.UseVisualStyleBackColor = true;
            this.newItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.removeItemButton.Location = new System.Drawing.Point(380, 434);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(223, 43);
            this.removeItemButton.TabIndex = 3;
            this.removeItemButton.Text = "Remove Existing Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.editItemButton.Location = new System.Drawing.Point(247, 434);
            this.editItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(125, 43);
            this.editItemButton.TabIndex = 4;
            this.editItemButton.Text = "Edit";
            this.editItemButton.UseVisualStyleBackColor = true;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 507);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.newItemButton);
            this.Controls.Add(this.currStockLabel);
            this.Controls.Add(this.stocksListView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView stocksListView;
        private System.Windows.Forms.ColumnHeader itemColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.Label currStockLabel;
        private System.Windows.Forms.Button newItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button editItemButton;
    }
}