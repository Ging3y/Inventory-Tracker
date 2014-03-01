namespace Inventory
{
    partial class MainPage
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
            this.Button_sellers = new System.Windows.Forms.Button();
            this.Button_financing = new System.Windows.Forms.Button();
            this.Button_inventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_sellers
            // 
            this.Button_sellers.Location = new System.Drawing.Point(12, 12);
            this.Button_sellers.Name = "Button_sellers";
            this.Button_sellers.Size = new System.Drawing.Size(151, 77);
            this.Button_sellers.TabIndex = 0;
            this.Button_sellers.Text = "Sellers";
            this.Button_sellers.UseVisualStyleBackColor = true;
            this.Button_sellers.Click += new System.EventHandler(this.Button_sellers_Click);
            // 
            // Button_financing
            // 
            this.Button_financing.Location = new System.Drawing.Point(169, 12);
            this.Button_financing.Name = "Button_financing";
            this.Button_financing.Size = new System.Drawing.Size(151, 77);
            this.Button_financing.TabIndex = 1;
            this.Button_financing.Text = "Financing";
            this.Button_financing.UseVisualStyleBackColor = true;
            this.Button_financing.Click += new System.EventHandler(this.Button_financing_Click);
            // 
            // Button_inventory
            // 
            this.Button_inventory.Location = new System.Drawing.Point(326, 12);
            this.Button_inventory.Name = "Button_inventory";
            this.Button_inventory.Size = new System.Drawing.Size(151, 77);
            this.Button_inventory.TabIndex = 2;
            this.Button_inventory.Text = "Inventory";
            this.Button_inventory.UseVisualStyleBackColor = true;
            this.Button_inventory.Click += new System.EventHandler(this.Button_inventory_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 360);
            this.Controls.Add(this.Button_inventory);
            this.Controls.Add(this.Button_financing);
            this.Controls.Add(this.Button_sellers);
            this.Name = "MainPage";
            this.Text = "Just in Case";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_sellers;
        private System.Windows.Forms.Button Button_financing;
        private System.Windows.Forms.Button Button_inventory;
    }
}

