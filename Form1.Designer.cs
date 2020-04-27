namespace PasswordManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inpPw = new System.Windows.Forms.TextBox();
            this.inpEmailLabel = new System.Windows.Forms.Label();
            this.inpPwLabel = new System.Windows.Forms.Label();
            this.inpMail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.loginBtn = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PasswordManager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.inpPw, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.inpEmailLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inpPwLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.inpMail, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 115);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 116);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // inpPw
            // 
            this.inpPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inpPw.BackColor = System.Drawing.Color.Black;
            this.inpPw.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPw.ForeColor = System.Drawing.Color.Aqua;
            this.inpPw.Location = new System.Drawing.Point(116, 77);
            this.inpPw.Margin = new System.Windows.Forms.Padding(3, 10, 60, 3);
            this.inpPw.Name = "inpPw";
            this.inpPw.PasswordChar = '*';
            this.inpPw.Size = new System.Drawing.Size(202, 27);
            this.inpPw.TabIndex = 3;
            this.inpPw.Text = "safeafpassword1";
            this.inpPw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.inpPw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.inpPw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // inpEmailLabel
            // 
            this.inpEmailLabel.AutoSize = true;
            this.inpEmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inpEmailLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpEmailLabel.ForeColor = System.Drawing.Color.Cyan;
            this.inpEmailLabel.Location = new System.Drawing.Point(0, 0);
            this.inpEmailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.inpEmailLabel.Name = "inpEmailLabel";
            this.inpEmailLabel.Size = new System.Drawing.Size(113, 58);
            this.inpEmailLabel.TabIndex = 0;
            this.inpEmailLabel.Text = "eMail:";
            this.inpEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inpEmailLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.inpEmailLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.inpEmailLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // inpPwLabel
            // 
            this.inpPwLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpPwLabel.AutoSize = true;
            this.inpPwLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPwLabel.ForeColor = System.Drawing.Color.Cyan;
            this.inpPwLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inpPwLabel.Location = new System.Drawing.Point(3, 58);
            this.inpPwLabel.Name = "inpPwLabel";
            this.inpPwLabel.Size = new System.Drawing.Size(107, 58);
            this.inpPwLabel.TabIndex = 1;
            this.inpPwLabel.Text = "pword:";
            this.inpPwLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inpPwLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.inpPwLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.inpPwLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // inpMail
            // 
            this.inpMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inpMail.BackColor = System.Drawing.Color.Black;
            this.inpMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpMail.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMail.ForeColor = System.Drawing.Color.Aqua;
            this.inpMail.Location = new System.Drawing.Point(116, 20);
            this.inpMail.Margin = new System.Windows.Forms.Padding(3, 12, 60, 3);
            this.inpMail.Name = "inpMail";
            this.inpMail.Size = new System.Drawing.Size(202, 27);
            this.inpMail.TabIndex = 2;
            this.inpMail.Text = "example@safeaf.com";
            this.inpMail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.inpMail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.inpMail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.loginBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.registerBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.exitBtn, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.1307F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.93465F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.93465F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 111);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tableLayoutPanel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.AutoSize = true;
            this.loginBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Cyan;
            this.loginBtn.Location = new System.Drawing.Point(304, 0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(65, 22);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            this.loginBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            this.loginBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.loginBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // registerBtn
            // 
            this.registerBtn.AutoSize = true;
            this.registerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.registerBtn.Location = new System.Drawing.Point(100, 22);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(172, 44);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Don\'t have an account yet? Register now.";
            this.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            this.registerBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.registerBtn.MouseEnter += new System.EventHandler(this.registerBtn_MouseEnter);
            this.registerBtn.MouseLeave += new System.EventHandler(this.registerBtn_MouseLeave);
            this.registerBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.registerBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.Location = new System.Drawing.Point(150, 76);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(150, 10, 150, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(72, 25);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.label1_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(378, 348);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SafeAF - Password Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label inpEmailLabel;
        private System.Windows.Forms.TextBox inpPw;
        private System.Windows.Forms.Label inpPwLabel;
        private System.Windows.Forms.TextBox inpMail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label loginBtn;
        private System.Windows.Forms.Label registerBtn;
        private System.Windows.Forms.Label exitBtn;
    }
}

