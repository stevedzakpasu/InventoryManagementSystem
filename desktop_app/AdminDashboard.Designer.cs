namespace desktop_app
{
    partial class AdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.manageCategoriesBtn = new System.Windows.Forms.Button();
            this.manageProductsBtn = new System.Windows.Forms.Button();
            this.ManageUsersBtn = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.manageCategories1 = new desktop_app.ManageCategories();
            this.manageUsers1 = new desktop_app.ManageUsers();
            this.manageStocks1 = new desktop_app.ManageStocks();
            this.manageProducts1 = new desktop_app.ManageItems();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // manageCategoriesBtn
            // 
            this.manageCategoriesBtn.Location = new System.Drawing.Point(25, 102);
            this.manageCategoriesBtn.Name = "manageCategoriesBtn";
            this.manageCategoriesBtn.Size = new System.Drawing.Size(146, 23);
            this.manageCategoriesBtn.TabIndex = 1;
            this.manageCategoriesBtn.Text = "Manage Categories";
            this.manageCategoriesBtn.UseVisualStyleBackColor = true;
            this.manageCategoriesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // manageProductsBtn
            // 
            this.manageProductsBtn.Location = new System.Drawing.Point(25, 293);
            this.manageProductsBtn.Name = "manageProductsBtn";
            this.manageProductsBtn.Size = new System.Drawing.Size(146, 23);
            this.manageProductsBtn.TabIndex = 2;
            this.manageProductsBtn.Text = "Manage Products";
            this.manageProductsBtn.UseVisualStyleBackColor = true;
            this.manageProductsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageUsersBtn
            // 
            this.ManageUsersBtn.Location = new System.Drawing.Point(25, 490);
            this.ManageUsersBtn.Name = "ManageUsersBtn";
            this.ManageUsersBtn.Size = new System.Drawing.Size(146, 23);
            this.ManageUsersBtn.TabIndex = 4;
            this.ManageUsersBtn.Text = "Manage Users";
            this.ManageUsersBtn.UseVisualStyleBackColor = true;
            this.ManageUsersBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ManageUsersBtn);
            this.panel2.Controls.Add(this.manageCategoriesBtn);
            this.panel2.Controls.Add(this.manageProductsBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 819);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // manageCategories1
            // 
            this.manageCategories1.BackColor = System.Drawing.SystemColors.Window;
            this.manageCategories1.Location = new System.Drawing.Point(238, 61);
            this.manageCategories1.Name = "manageCategories1";
            this.manageCategories1.Size = new System.Drawing.Size(1293, 677);
            this.manageCategories1.TabIndex = 7;
            this.manageCategories1.Load += new System.EventHandler(this.manageCategories1_Load);
            // 
            // manageUsers1
            // 
            this.manageUsers1.BackColor = System.Drawing.SystemColors.Window;
            this.manageUsers1.Location = new System.Drawing.Point(238, 61);
            this.manageUsers1.Name = "manageUsers1";
            this.manageUsers1.Size = new System.Drawing.Size(1293, 677);
            this.manageUsers1.TabIndex = 10;
            // 
            // manageStocks1
            // 
            this.manageStocks1.BackColor = System.Drawing.SystemColors.Window;
            this.manageStocks1.Location = new System.Drawing.Point(238, 61);
            this.manageStocks1.Name = "manageStocks1";
            this.manageStocks1.Size = new System.Drawing.Size(1293, 677);
            this.manageStocks1.TabIndex = 9;
            // 
            // manageProducts1
            // 
            this.manageProducts1.BackColor = System.Drawing.SystemColors.Window;
            this.manageProducts1.Location = new System.Drawing.Point(238, 61);
            this.manageProducts1.Name = "manageProducts1";
            this.manageProducts1.Size = new System.Drawing.Size(1293, 677);
            this.manageProducts1.TabIndex = 8;
            this.manageProducts1.Load += new System.EventHandler(this.manageProducts1_Load);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1810, 819);
            this.Controls.Add(this.manageCategories1);
            this.Controls.Add(this.manageUsers1);
            this.Controls.Add(this.manageStocks1);
            this.Controls.Add(this.manageProducts1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminDashboard";
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageCategoriesBtn;
        private System.Windows.Forms.Button manageProductsBtn;
        private System.Windows.Forms.Button ManageUsersBtn;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Panel panel2;
        private ManageCategories manageCategories1;
        private ManageItems manageProducts1;
        private ManageStocks manageStocks1;
        private ManageUsers manageUsers1;
        private System.Windows.Forms.Button button1;
    }
}