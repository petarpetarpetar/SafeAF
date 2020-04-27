namespace PasswordManager
{
    partial class appForm
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
            System.Windows.Forms.Panel panel3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appForm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.loggedInHolder = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.showPwsBtn = new System.Windows.Forms.Label();
            this.newPwBtn = new System.Windows.Forms.Label();
            this.pwGeneratorBtn = new System.Windows.Forms.Label();
            this.logsBtn = new System.Windows.Forms.Label();
            this.accountBtn = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Label();
            this.workingPanel = new System.Windows.Forms.Panel();
            this.keyPicBox = new System.Windows.Forms.PictureBox();
            this.plusPicBox = new System.Windows.Forms.PictureBox();
            this.dicePicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.logPicBox = new System.Windows.Forms.PictureBox();
            this.accPicBox = new System.Windows.Forms.PictureBox();
            this.infoPixBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPixBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            panel3.Controls.Add(this.logoutBtn);
            panel3.Controls.Add(this.loggedInHolder);
            panel3.Controls.Add(this.exitBtn);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel3.Location = new System.Drawing.Point(202, 0);
            panel3.Margin = new System.Windows.Forms.Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(978, 19);
            panel3.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(944, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 19);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.workingPanel);
            this.panel1.Controls.Add(panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 621);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 621);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 621);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.keyPicBox);
            this.panel5.Controls.Add(this.showPwsBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 88);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 88);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.plusPicBox);
            this.panel6.Controls.Add(this.newPwBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 176);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 88);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dicePicBox);
            this.panel7.Controls.Add(this.pwGeneratorBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 264);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(202, 88);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Controls.Add(this.logPicBox);
            this.panel8.Controls.Add(this.logsBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 352);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 88);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.accPicBox);
            this.panel9.Controls.Add(this.accountBtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 440);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(202, 88);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.infoPixBox);
            this.panel10.Controls.Add(this.aboutBtn);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 528);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(202, 93);
            this.panel10.TabIndex = 5;
            // 
            // loggedInHolder
            // 
            this.loggedInHolder.AutoSize = true;
            this.loggedInHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInHolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loggedInHolder.Location = new System.Drawing.Point(619, 1);
            this.loggedInHolder.Name = "loggedInHolder";
            this.loggedInHolder.Size = new System.Drawing.Size(202, 15);
            this.loggedInHolder.TabIndex = 2;
            this.loggedInHolder.Text = "Logged in as: example@gmail.com";
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Gold;
            this.logoutBtn.Location = new System.Drawing.Point(873, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(59, 16);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // showPwsBtn
            // 
            this.showPwsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPwsBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPwsBtn.ForeColor = System.Drawing.Color.Aqua;
            this.showPwsBtn.Location = new System.Drawing.Point(0, 0);
            this.showPwsBtn.Name = "showPwsBtn";
            this.showPwsBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.showPwsBtn.Size = new System.Drawing.Size(202, 88);
            this.showPwsBtn.TabIndex = 0;
            this.showPwsBtn.Text = "My passwords";
            this.showPwsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showPwsBtn.Click += new System.EventHandler(this.showPwsBtn_Click);
            // 
            // newPwBtn
            // 
            this.newPwBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPwBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPwBtn.ForeColor = System.Drawing.Color.Aqua;
            this.newPwBtn.Location = new System.Drawing.Point(0, 0);
            this.newPwBtn.Name = "newPwBtn";
            this.newPwBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.newPwBtn.Size = new System.Drawing.Size(202, 88);
            this.newPwBtn.TabIndex = 1;
            this.newPwBtn.Text = "Add a new pasword";
            this.newPwBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newPwBtn.Click += new System.EventHandler(this.newPwBtn_Click);
            // 
            // pwGeneratorBtn
            // 
            this.pwGeneratorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwGeneratorBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwGeneratorBtn.ForeColor = System.Drawing.Color.Aqua;
            this.pwGeneratorBtn.Location = new System.Drawing.Point(0, 0);
            this.pwGeneratorBtn.Name = "pwGeneratorBtn";
            this.pwGeneratorBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.pwGeneratorBtn.Size = new System.Drawing.Size(202, 88);
            this.pwGeneratorBtn.TabIndex = 2;
            this.pwGeneratorBtn.Text = "Password Generator";
            this.pwGeneratorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pwGeneratorBtn.Click += new System.EventHandler(this.pwGeneratorBtn_Click);
            // 
            // logsBtn
            // 
            this.logsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsBtn.ForeColor = System.Drawing.Color.Aqua;
            this.logsBtn.Location = new System.Drawing.Point(0, 0);
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.logsBtn.Size = new System.Drawing.Size(202, 88);
            this.logsBtn.TabIndex = 3;
            this.logsBtn.Text = "Logs";
            this.logsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logsBtn.Click += new System.EventHandler(this.logsBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBtn.ForeColor = System.Drawing.Color.Aqua;
            this.accountBtn.Location = new System.Drawing.Point(0, 0);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.accountBtn.Size = new System.Drawing.Size(202, 88);
            this.accountBtn.TabIndex = 4;
            this.accountBtn.Text = "My account";
            this.accountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.Aqua;
            this.aboutBtn.Location = new System.Drawing.Point(0, 0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.aboutBtn.Size = new System.Drawing.Size(202, 93);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "About us";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // workingPanel
            // 
            this.workingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(211)))), ((int)(((byte)(206)))));
            this.workingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workingPanel.Location = new System.Drawing.Point(202, 19);
            this.workingPanel.Name = "workingPanel";
            this.workingPanel.Size = new System.Drawing.Size(978, 602);
            this.workingPanel.TabIndex = 2;
            // 
            // keyPicBox
            // 
            this.keyPicBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.keyPicBox.Image = ((System.Drawing.Image)(resources.GetObject("keyPicBox.Image")));
            this.keyPicBox.Location = new System.Drawing.Point(0, 41);
            this.keyPicBox.Name = "keyPicBox";
            this.keyPicBox.Padding = new System.Windows.Forms.Padding(85, 0, 0, 15);
            this.keyPicBox.Size = new System.Drawing.Size(202, 47);
            this.keyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.keyPicBox.TabIndex = 1;
            this.keyPicBox.TabStop = false;
            this.keyPicBox.Click += new System.EventHandler(this.showPwsBtn_Click);
            // 
            // plusPicBox
            // 
            this.plusPicBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plusPicBox.Image = ((System.Drawing.Image)(resources.GetObject("plusPicBox.Image")));
            this.plusPicBox.Location = new System.Drawing.Point(0, 41);
            this.plusPicBox.Name = "plusPicBox";
            this.plusPicBox.Padding = new System.Windows.Forms.Padding(85, 0, 0, 15);
            this.plusPicBox.Size = new System.Drawing.Size(202, 47);
            this.plusPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.plusPicBox.TabIndex = 2;
            this.plusPicBox.TabStop = false;
            this.plusPicBox.Click += new System.EventHandler(this.newPwBtn_Click);
            // 
            // dicePicBox
            // 
            this.dicePicBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dicePicBox.Image = ((System.Drawing.Image)(resources.GetObject("dicePicBox.Image")));
            this.dicePicBox.Location = new System.Drawing.Point(0, 41);
            this.dicePicBox.Name = "dicePicBox";
            this.dicePicBox.Padding = new System.Windows.Forms.Padding(85, 0, 0, 15);
            this.dicePicBox.Size = new System.Drawing.Size(202, 47);
            this.dicePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dicePicBox.TabIndex = 3;
            this.dicePicBox.TabStop = false;
            this.dicePicBox.Click += new System.EventHandler(this.pwGeneratorBtn_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(65, 142);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // logPicBox
            // 
            this.logPicBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logPicBox.Image")));
            this.logPicBox.Location = new System.Drawing.Point(0, 41);
            this.logPicBox.Name = "logPicBox";
            this.logPicBox.Padding = new System.Windows.Forms.Padding(85, 0, 0, 15);
            this.logPicBox.Size = new System.Drawing.Size(202, 47);
            this.logPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logPicBox.TabIndex = 4;
            this.logPicBox.TabStop = false;
            this.logPicBox.Click += new System.EventHandler(this.logsBtn_Click);
            // 
            // accPicBox
            // 
            this.accPicBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accPicBox.Image = ((System.Drawing.Image)(resources.GetObject("accPicBox.Image")));
            this.accPicBox.Location = new System.Drawing.Point(0, 41);
            this.accPicBox.Name = "accPicBox";
            this.accPicBox.Padding = new System.Windows.Forms.Padding(85, 0, 0, 15);
            this.accPicBox.Size = new System.Drawing.Size(202, 47);
            this.accPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.accPicBox.TabIndex = 5;
            this.accPicBox.TabStop = false;
            this.accPicBox.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // infoPixBox
            // 
            this.infoPixBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPixBox.Image = ((System.Drawing.Image)(resources.GetObject("infoPixBox.Image")));
            this.infoPixBox.Location = new System.Drawing.Point(0, 46);
            this.infoPixBox.Name = "infoPixBox";
            this.infoPixBox.Padding = new System.Windows.Forms.Padding(85, 0, 0, 15);
            this.infoPixBox.Size = new System.Drawing.Size(202, 47);
            this.infoPixBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infoPixBox.TabIndex = 6;
            this.infoPixBox.TabStop = false;
            this.infoPixBox.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 621);
            this.Controls.Add(this.panel1);
            this.Name = "appForm";
            this.Text = "appForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPixBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label logoutBtn;
        private System.Windows.Forms.Label loggedInHolder;
        private System.Windows.Forms.Label showPwsBtn;
        private System.Windows.Forms.Label newPwBtn;
        private System.Windows.Forms.Label pwGeneratorBtn;
        private System.Windows.Forms.Label logsBtn;
        private System.Windows.Forms.Label accountBtn;
        private System.Windows.Forms.Label aboutBtn;
        private System.Windows.Forms.Panel workingPanel;
        private System.Windows.Forms.PictureBox keyPicBox;
        private System.Windows.Forms.PictureBox plusPicBox;
        private System.Windows.Forms.PictureBox dicePicBox;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox logPicBox;
        private System.Windows.Forms.PictureBox accPicBox;
        private System.Windows.Forms.PictureBox infoPixBox;
    }
}