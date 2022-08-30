namespace desktop_app
{
    partial class NewCategory
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
            this.AddCat = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.addCatBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.AddCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category";
            // 
            // AddCat
            // 
            this.AddCat.Controls.Add(this.idTextBox);
            this.AddCat.Controls.Add(this.addCatBtn);
            this.AddCat.Controls.Add(this.label2);
            this.AddCat.Controls.Add(this.txtCat);
            this.AddCat.Location = new System.Drawing.Point(37, 132);
            this.AddCat.Name = "AddCat";
            this.AddCat.Size = new System.Drawing.Size(381, 257);
            this.AddCat.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(165, 61);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(45, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.Visible = false;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // addCatBtn
            // 
            this.addCatBtn.Location = new System.Drawing.Point(148, 187);
            this.addCatBtn.Name = "addCatBtn";
            this.addCatBtn.Size = new System.Drawing.Size(75, 23);
            this.addCatBtn.TabIndex = 2;
            this.addCatBtn.Text = "Add";
            this.addCatBtn.UseVisualStyleBackColor = true;
            this.addCatBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // txtCat
            // 
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCat.Location = new System.Drawing.Point(121, 147);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(150, 20);
            this.txtCat.TabIndex = 0;
            this.txtCat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 471);
            this.Controls.Add(this.AddCat);
            this.Controls.Add(this.label1);
            this.Name = "NewCategory";
            this.Text = "Add Category";
            this.AddCat.ResumeLayout(false);
            this.AddCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddCat;
        private System.Windows.Forms.Button addCatBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox idTextBox;
    }
}