namespace hardware_store
{
    partial class AddOrEditForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.componentTypeCombo = new System.Windows.Forms.ComboBox();
            this.custom1TextBox = new System.Windows.Forms.TextBox();
            this.custom2TextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.custom1Label = new System.Windows.Forms.Label();
            this.custom2Label = new System.Windows.Forms.Label();
            this.addEditButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(148, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(312, 18);
            this.nameTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.priceTextBox.Location = new System.Drawing.Point(148, 111);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(312, 18);
            this.priceTextBox.TabIndex = 1;
            // 
            // componentTypeCombo
            // 
            this.componentTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.componentTypeCombo.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.componentTypeCombo.FormattingEnabled = true;
            this.componentTypeCombo.Items.AddRange(new object[] {
            "Processor",
            "Graphics Card",
            "RAM",
            "Hard Drive"});
            this.componentTypeCombo.Location = new System.Drawing.Point(148, 155);
            this.componentTypeCombo.Name = "componentTypeCombo";
            this.componentTypeCombo.Size = new System.Drawing.Size(312, 28);
            this.componentTypeCombo.TabIndex = 2;
            this.componentTypeCombo.SelectedValueChanged += new System.EventHandler(this.componentTypeCombo_SelectedValueChanged);
            // 
            // custom1TextBox
            // 
            this.custom1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom1TextBox.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.custom1TextBox.Location = new System.Drawing.Point(148, 209);
            this.custom1TextBox.Name = "custom1TextBox";
            this.custom1TextBox.Size = new System.Drawing.Size(312, 18);
            this.custom1TextBox.TabIndex = 3;
            // 
            // custom2TextBox
            // 
            this.custom2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom2TextBox.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.custom2TextBox.Location = new System.Drawing.Point(148, 253);
            this.custom2TextBox.Name = "custom2TextBox";
            this.custom2TextBox.Size = new System.Drawing.Size(312, 18);
            this.custom2TextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.nameLabel.Location = new System.Drawing.Point(13, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.priceLabel.Location = new System.Drawing.Point(13, 111);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 20);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.typeLabel.Location = new System.Drawing.Point(13, 162);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(54, 20);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type:";
            // 
            // custom1Label
            // 
            this.custom1Label.AutoSize = true;
            this.custom1Label.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.custom1Label.Location = new System.Drawing.Point(13, 213);
            this.custom1Label.Name = "custom1Label";
            this.custom1Label.Size = new System.Drawing.Size(108, 20);
            this.custom1Label.TabIndex = 8;
            this.custom1Label.Text = "???????????";
            // 
            // custom2Label
            // 
            this.custom2Label.AutoSize = true;
            this.custom2Label.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.custom2Label.Location = new System.Drawing.Point(13, 259);
            this.custom2Label.Name = "custom2Label";
            this.custom2Label.Size = new System.Drawing.Size(108, 20);
            this.custom2Label.TabIndex = 9;
            this.custom2Label.Text = "???????????";
            // 
            // addEditButton
            // 
            this.addEditButton.Location = new System.Drawing.Point(148, 330);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(312, 54);
            this.addEditButton.TabIndex = 10;
            this.addEditButton.Text = "button1";
            this.addEditButton.UseVisualStyleBackColor = true;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTextBox.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.quantityTextBox.Location = new System.Drawing.Point(148, 297);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(312, 18);
            this.quantityTextBox.TabIndex = 11;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.quantityLabel.Location = new System.Drawing.Point(13, 297);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(99, 20);
            this.quantityLabel.TabIndex = 12;
            this.quantityLabel.Text = "Quanitity:";
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 506);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.custom2Label);
            this.Controls.Add(this.custom1Label);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.custom2TextBox);
            this.Controls.Add(this.custom1TextBox);
            this.Controls.Add(this.componentTypeCombo);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Cascadia Code", 8.5F);
            this.Name = "AddOrEditForm";
            this.Text = "AddOrEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox componentTypeCombo;
        private System.Windows.Forms.TextBox custom1TextBox;
        private System.Windows.Forms.TextBox custom2TextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label custom1Label;
        private System.Windows.Forms.Label custom2Label;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
    }
}