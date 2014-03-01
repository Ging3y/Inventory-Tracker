namespace Inventory
{
    partial class Sellers
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
            this.ComboBox_sellers = new System.Windows.Forms.ComboBox();
            this.Label_sellers = new System.Windows.Forms.Label();
            this.Button_addseller = new System.Windows.Forms.Button();
            this.Button_deleteseller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBox_sellers
            // 
            this.ComboBox_sellers.FormattingEnabled = true;
            this.ComboBox_sellers.Location = new System.Drawing.Point(140, 32);
            this.ComboBox_sellers.Name = "ComboBox_sellers";
            this.ComboBox_sellers.Size = new System.Drawing.Size(135, 28);
            this.ComboBox_sellers.TabIndex = 0;
            // 
            // Label_sellers
            // 
            this.Label_sellers.AutoSize = true;
            this.Label_sellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_sellers.Location = new System.Drawing.Point(12, 23);
            this.Label_sellers.Name = "Label_sellers";
            this.Label_sellers.Size = new System.Drawing.Size(122, 37);
            this.Label_sellers.TabIndex = 1;
            this.Label_sellers.Text = "Sellers:";
            // 
            // Button_addseller
            // 
            this.Button_addseller.Location = new System.Drawing.Point(290, 25);
            this.Button_addseller.Name = "Button_addseller";
            this.Button_addseller.Size = new System.Drawing.Size(120, 42);
            this.Button_addseller.TabIndex = 2;
            this.Button_addseller.Text = "Add Seller";
            this.Button_addseller.UseVisualStyleBackColor = true;
            this.Button_addseller.Click += new System.EventHandler(this.Button_addseller_Click);
            // 
            // Button_deleteseller
            // 
            this.Button_deleteseller.Location = new System.Drawing.Point(416, 25);
            this.Button_deleteseller.Name = "Button_deleteseller";
            this.Button_deleteseller.Size = new System.Drawing.Size(120, 42);
            this.Button_deleteseller.TabIndex = 3;
            this.Button_deleteseller.Text = "Delete Seller";
            this.Button_deleteseller.UseVisualStyleBackColor = true;
            this.Button_deleteseller.Click += new System.EventHandler(this.Button_deleteseller_Click);
            // 
            // Sellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.Button_deleteseller);
            this.Controls.Add(this.Button_addseller);
            this.Controls.Add(this.Label_sellers);
            this.Controls.Add(this.ComboBox_sellers);
            this.Name = "Sellers";
            this.Text = "Sellers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_sellers;
        private System.Windows.Forms.Label Label_sellers;
        private System.Windows.Forms.Button Button_addseller;
        private System.Windows.Forms.Button Button_deleteseller;
    }
}