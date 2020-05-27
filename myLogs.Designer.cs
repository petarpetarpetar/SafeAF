namespace PasswordManager
{
    partial class myLogs
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
            this.mainTB = new System.Windows.Forms.TextBox();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainTB
            // 
            this.mainTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.mainTB.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTB.ForeColor = System.Drawing.Color.Aqua;
            this.mainTB.Location = new System.Drawing.Point(33, 33);
            this.mainTB.Margin = new System.Windows.Forms.Padding(0);
            this.mainTB.Multiline = true;
            this.mainTB.Name = "mainTB";
            this.mainTB.ReadOnly = true;
            this.mainTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTB.Size = new System.Drawing.Size(592, 466);
            this.mainTB.TabIndex = 0;
            // 
            // inputTB
            // 
            this.inputTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.inputTB.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputTB.Location = new System.Drawing.Point(33, 499);
            this.inputTB.Margin = new System.Windows.Forms.Padding(0);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(573, 23);
            this.inputTB.TabIndex = 1;
            // 
            // myLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(654, 620);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.mainTB);
            this.Name = "myLogs";
            this.Text = "myLogs";
            this.Load += new System.EventHandler(this.myLogs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTB;
        private System.Windows.Forms.TextBox inputTB;
    }
}