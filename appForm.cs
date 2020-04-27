using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class appForm : Form
    {
        Form1 parent;
        public appForm(Form1 parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            this.loggedInHolder.Text = "Logged in as: " + parent.usrMail;
            this.FormBorderStyle = FormBorderStyle.None;   
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            parent.Opacity = 100;
            parent.ShowInTaskbar = true;
            parent.Show();
            parent.BringToFront();
            this.Close();
        }

        private void showPwsBtn_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            showPwsBtn.BackColor = Color.FromArgb(60, 60, 60);
            keyPicBox.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void newPwBtn_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            newPwBtn.BackColor = Color.FromArgb(60, 60, 60);
            plusPicBox.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void pwGeneratorBtn_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            pwGeneratorBtn.BackColor = Color.FromArgb(60, 60, 60);
            dicePicBox.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            logsBtn.BackColor = Color.FromArgb(60, 60, 60);
            logPicBox.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            accountBtn.BackColor = Color.FromArgb(60, 60, 60); 
            accPicBox.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            aboutBtn.BackColor = Color.FromArgb(60, 60, 60);
            infoPixBox.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void resetBtnColors()
        {
            aboutBtn.BackColor = Color.FromArgb(20, 20, 20);
            infoPixBox.BackColor = Color.FromArgb(20, 20, 20);
            accountBtn.BackColor = Color.FromArgb(20, 20, 20);
            accPicBox.BackColor = Color.FromArgb(20, 20, 20);
            logsBtn.BackColor = Color.FromArgb(20, 20, 20);
            logPicBox.BackColor = Color.FromArgb(20, 20, 20);
            pwGeneratorBtn.BackColor = Color.FromArgb(20, 20, 20);
            dicePicBox.BackColor = Color.FromArgb(20, 20, 20);
            newPwBtn.BackColor = Color.FromArgb(20, 20, 20);
            plusPicBox.BackColor = Color.FromArgb(20, 20, 20);
            showPwsBtn.BackColor = Color.FromArgb(20, 20, 20);
            keyPicBox.BackColor = Color.FromArgb(20, 20, 20);
        }

    }
}
