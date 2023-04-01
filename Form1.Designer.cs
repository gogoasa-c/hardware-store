namespace hardware_store
{
    partial class MainForm
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
            this.showStockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showStockButton
            // 
            this.showStockButton.Location = new System.Drawing.Point(288, 357);
            this.showStockButton.Name = "showStockButton";
            this.showStockButton.Size = new System.Drawing.Size(172, 42);
            this.showStockButton.TabIndex = 0;
            this.showStockButton.Text = "Show Current Stock";
            this.showStockButton.UseVisualStyleBackColor = true;
            this.showStockButton.Click += new System.EventHandler(this.showStockButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 411);
            this.Controls.Add(this.showStockButton);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Hardware Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showStockButton;
    }
}

