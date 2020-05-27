namespace PasswordManager
{
    partial class myPasswords
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
            this.searchTB = new System.Windows.Forms.TextBox();
            this.siteTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchTB.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(149, 32);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(207, 23);
            this.searchTB.TabIndex = 2;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // siteTB
            // 
            this.siteTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.siteTB.Location = new System.Drawing.Point(9, 53);
            this.siteTB.Name = "siteTB";
            this.siteTB.ReadOnly = true;
            this.siteTB.Size = new System.Drawing.Size(251, 26);
            this.siteTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordTB.Location = new System.Drawing.Point(10, 215);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.ReadOnly = true;
            this.passwordTB.Size = new System.Drawing.Size(250, 63);
            this.passwordTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Site";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.siteTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(377, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 290);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password info";
            // 
            // mailTB
            // 
            this.mailTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mailTB.Location = new System.Drawing.Point(8, 137);
            this.mailTB.Name = "mailTB";
            this.mailTB.ReadOnly = true;
            this.mailTB.Size = new System.Drawing.Size(251, 26);
            this.mailTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search by site name";
            // 
            // mainList
            // 
            this.mainList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mainList.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainList.FormattingEnabled = true;
            this.mainList.ItemHeight = 16;
            this.mainList.Location = new System.Drawing.Point(15, 67);
            this.mainList.Name = "mainList";
            this.mainList.Size = new System.Drawing.Size(341, 484);
            this.mainList.TabIndex = 8;
            this.mainList.SelectedIndexChanged += new System.EventHandler(this.mainList_SelectedIndexChanged);
            // 
            // myPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(654, 620);
            this.Controls.Add(this.mainList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchTB);
            this.Name = "myPasswords";
            this.Text = "myPasswords";
            this.Load += new System.EventHandler(this.myPasswords_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.TextBox siteTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox mainList;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Label label4;
    }
}