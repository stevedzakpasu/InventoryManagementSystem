namespace desktop_app
{
    partial class NewItem
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
            this.header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(189, 67);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(48, 13);
            this.header.TabIndex = 0;
            this.header.Text = "Add item";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reorderTextBox);
            this.panel1.Controls.Add(this.stockTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.categoryTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 373);
            this.panel1.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(126, 142);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(126, 91);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item Category";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(138, 322);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 6;
            this.button.Text = "Add";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(126, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item name";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(167, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.Visible = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(126, 204);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 11;
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(126, 265);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(100, 20);
            this.reorderTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Available Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Reorder Level";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.idTextBox);
            this.Name = "NewItem";
            this.Text = "New Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoryTextBox;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
    }
}