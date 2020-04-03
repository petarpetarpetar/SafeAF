namespace PasswordManager
{
    partial class registerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inpMail = new System.Windows.Forms.TextBox();
            this.inpPw = new System.Windows.Forms.TextBox();
            this.inpPw2 = new System.Windows.Forms.TextBox();
            this.inpCode = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Label();
            this.codeBtn = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PasswordManager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(87, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(55, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(25, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pwd confirm:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(19, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Security code:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseUp);
            // 
            // inpMail
            // 
            this.inpMail.BackColor = System.Drawing.Color.Black;
            this.inpMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpMail.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMail.ForeColor = System.Drawing.Color.Aqua;
            this.inpMail.Location = new System.Drawing.Point(162, 146);
            this.inpMail.Name = "inpMail";
            this.inpMail.Size = new System.Drawing.Size(193, 20);
            this.inpMail.TabIndex = 6;
            // 
            // inpPw
            // 
            this.inpPw.BackColor = System.Drawing.Color.Black;
            this.inpPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpPw.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPw.ForeColor = System.Drawing.Color.Aqua;
            this.inpPw.Location = new System.Drawing.Point(162, 194);
            this.inpPw.Name = "inpPw";
            this.inpPw.PasswordChar = '*';
            this.inpPw.Size = new System.Drawing.Size(193, 20);
            this.inpPw.TabIndex = 7;
            // 
            // inpPw2
            // 
            this.inpPw2.BackColor = System.Drawing.Color.Black;
            this.inpPw2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpPw2.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPw2.ForeColor = System.Drawing.Color.Aqua;
            this.inpPw2.Location = new System.Drawing.Point(162, 246);
            this.inpPw2.Name = "inpPw2";
            this.inpPw2.PasswordChar = '*';
            this.inpPw2.Size = new System.Drawing.Size(193, 20);
            this.inpPw2.TabIndex = 8;
            // 
            // inpCode
            // 
            this.inpCode.BackColor = System.Drawing.Color.Black;
            this.inpCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpCode.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpCode.ForeColor = System.Drawing.Color.Aqua;
            this.inpCode.Location = new System.Drawing.Point(162, 298);
            this.inpCode.Name = "inpCode";
            this.inpCode.Size = new System.Drawing.Size(193, 20);
            this.inpCode.TabIndex = 9;
            // 
            // regBtn
            // 
            this.regBtn.AutoSize = true;
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.regBtn.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.regBtn.Location = new System.Drawing.Point(301, 343);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(69, 24);
            this.regBtn.TabIndex = 10;
            this.regBtn.Text = "Register";
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // codeBtn
            // 
            this.codeBtn.AutoSize = true;
            this.codeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.codeBtn.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBtn.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.codeBtn.Location = new System.Drawing.Point(56, 343);
            this.codeBtn.Name = "codeBtn";
            this.codeBtn.Size = new System.Drawing.Size(169, 24);
            this.codeBtn.TabIndex = 11;
            this.codeBtn.Text = "Request Security code";
            this.codeBtn.Click += new System.EventHandler(this.codeBtn_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(5, 90);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 14);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "TEST";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(186, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 22);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(398, 437);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.codeBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.inpCode);
            this.Controls.Add(this.inpPw2);
            this.Controls.Add(this.inpPw);
            this.Controls.Add(this.inpMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "registerForm";
            this.Text = "registerForm";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.registerForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WINDOW_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpMail;
        private System.Windows.Forms.TextBox inpPw;
        private System.Windows.Forms.TextBox inpPw2;
        private System.Windows.Forms.TextBox inpCode;
        private System.Windows.Forms.Label regBtn;
        private System.Windows.Forms.Label codeBtn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label btnExit;
    }
}