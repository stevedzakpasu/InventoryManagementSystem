namespace desktop_app
{
    partial class NewUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(194, 32);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(76, 13);
            this.header.TabIndex = 0;
            this.header.Text = "Manage Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(80, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Username";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(183, 76);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 5;
            this.IDTextBox.Visible = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(62, 71);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(62, 200);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(62, 284);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoleTextBox.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(74, 349);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.RoleTextBox);
            this.panel1.Controls.Add(this.UsernameTextBox);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(121, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 476);
            this.panel1.TabIndex = 10;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 597);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel1;
    }
}