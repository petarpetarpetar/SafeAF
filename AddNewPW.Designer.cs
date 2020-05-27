namespace PasswordManager
{
    partial class AddNewPW
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomPwBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.newPwTB = new System.Windows.Forms.TextBox();
            this.newMailTB = new System.Windows.Forms.TextBox();
            this.newSiteTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.randomPwBtn);
            this.groupBox1.Controls.Add(this.okBtn);
            this.groupBox1.Controls.Add(this.newPwTB);
            this.groupBox1.Controls.Add(this.newMailTB);
            this.groupBox1.Controls.Add(this.newSiteTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(193, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new password";
            // 
            // randomPwBtn
            // 
            this.randomPwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomPwBtn.Location = new System.Drawing.Point(38, 371);
            this.randomPwBtn.Name = "randomPwBtn";
            this.randomPwBtn.Size = new System.Drawing.Size(138, 32);
            this.randomPwBtn.TabIndex = 7;
            this.randomPwBtn.Text = "Random PW";
            this.randomPwBtn.UseVisualStyleBackColor = true;
            this.randomPwBtn.Click += new System.EventHandler(this.randomPwBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(182, 371);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(50, 32);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // newPwTB
            // 
            this.newPwTB.Location = new System.Drawing.Point(36, 221);
            this.newPwTB.Multiline = true;
            this.newPwTB.Name = "newPwTB";
            this.newPwTB.Size = new System.Drawing.Size(196, 133);
            this.newPwTB.TabIndex = 5;
            // 
            // newMailTB
            // 
            this.newMailTB.Location = new System.Drawing.Point(36, 147);
            this.newMailTB.Name = "newMailTB";
            this.newMailTB.Size = new System.Drawing.Size(196, 26);
            this.newMailTB.TabIndex = 4;
            // 
            // newSiteTB
            // 
            this.newSiteTB.Location = new System.Drawing.Point(36, 76);
            this.newSiteTB.Name = "newSiteTB";
            this.newSiteTB.Size = new System.Drawing.Size(196, 26);
            this.newSiteTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site";
            // 
            // AddNewPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(654, 620);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewPW";
            this.Text = "AddNewPW";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button randomPwBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox newPwTB;
        private System.Windows.Forms.TextBox newMailTB;
        private System.Windows.Forms.TextBox newSiteTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}