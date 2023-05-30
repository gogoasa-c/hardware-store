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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taglineLabel = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripForm1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showStockButton
            // 
            this.showStockButton.Enabled = false;
            this.showStockButton.Location = new System.Drawing.Point(12, 321);
            this.showStockButton.Name = "showStockButton";
            this.showStockButton.Size = new System.Drawing.Size(239, 78);
            this.showStockButton.TabIndex = 0;
            this.showStockButton.Text = "Show Current Stock";
            this.showStockButton.UseVisualStyleBackColor = true;
            this.showStockButton.Click += new System.EventHandler(this.showStockButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.welcomeLabel.Location = new System.Drawing.Point(12, 37);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(156, 27);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome, ...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hardware_store.Properties.Resources.horse_logo;
            this.pictureBox1.Location = new System.Drawing.Point(573, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // taglineLabel
            // 
            this.taglineLabel.AutoSize = true;
            this.taglineLabel.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.taglineLabel.Location = new System.Drawing.Point(568, 203);
            this.taglineLabel.Name = "taglineLabel";
            this.taglineLabel.Size = new System.Drawing.Size(177, 25);
            this.taglineLabel.TabIndex = 3;
            this.taglineLabel.Text = "CALculatoare.ro";
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.sloganLabel.Location = new System.Drawing.Point(585, 241);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(144, 20);
            this.sloganLabel.TabIndex = 4;
            this.sloganLabel.Text = "Your Gateway to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.label1.Location = new System.Drawing.Point(541, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cutting-Edge Technology";
            // 
            // menuStripForm1
            // 
            this.menuStripForm1.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.menuStripForm1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripForm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStripForm1.Location = new System.Drawing.Point(0, 0);
            this.menuStripForm1.Name = "menuStripForm1";
            this.menuStripForm1.Size = new System.Drawing.Size(757, 28);
            this.menuStripForm1.TabIndex = 6;
            this.menuStripForm1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.taglineLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.showStockButton);
            this.Controls.Add(this.menuStripForm1);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.MainMenuStrip = this.menuStripForm1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Hardware Store";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripForm1.ResumeLayout(false);
            this.menuStripForm1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showStockButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label taglineLabel;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripForm1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

