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
            this.listView1 = new System.Windows.Forms.ListView();
            this.currStockLabel = new System.Windows.Forms.Label();
            this.itemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemColumn,
            this.quantityColumn});
            this.listView1.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 271);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // currStockLabel
            // 
            this.currStockLabel.AutoSize = true;
            this.currStockLabel.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.currStockLabel.Location = new System.Drawing.Point(145, 9);
            this.currStockLabel.Name = "currStockLabel";
            this.currStockLabel.Size = new System.Drawing.Size(155, 25);
            this.currStockLabel.TabIndex = 1;
            this.currStockLabel.Text = "Current Stock";
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
            // newItemButton
            // 
            this.newItemButton.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.newItemButton.Location = new System.Drawing.Point(12, 353);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(167, 35);
            this.newItemButton.TabIndex = 2;
            this.newItemButton.Text = "Add New Item";
            this.newItemButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.removeItemButton.Location = new System.Drawing.Point(285, 353);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(167, 35);
            this.removeItemButton.TabIndex = 3;
            this.removeItemButton.Text = "Remove Existing Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // editItemButton
            // 
            this.editItemButton.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.editItemButton.Location = new System.Drawing.Point(185, 353);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(94, 35);
            this.editItemButton.TabIndex = 4;
            this.editItemButton.Text = "Edit";
            this.editItemButton.UseVisualStyleBackColor = true;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 412);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.newItemButton);
            this.Controls.Add(this.currStockLabel);
            this.Controls.Add(this.listView1);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader itemColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.Label currStockLabel;
        private System.Windows.Forms.Button newItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button editItemButton;
    }
}