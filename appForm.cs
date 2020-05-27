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
        public Form1 parent;
        public static List<PasswordForSite> allPasswords = new List<PasswordForSite>();
        public appForm(Form1 parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            this.loggedInHolder.Text = "Logged in as: " + parent.usrMail;
            this.FormBorderStyle = FormBorderStyle.None;
            parent.writeToServer("g100");
            bool login = parent.checkLogin(parent.usrMail, parent.usrPassword, false);
            if(login)
            {
                MessageBox.Show("Test");
                return;
            }
            string res = parent.readFromServer();
            string temp;

            PasswordForSite tempPFS = new PasswordForSite();
            while (true)
            {
                tempPFS = new PasswordForSite();
                temp = parent.readFromServer();
                if (temp == "g300")
                    break;
                tempPFS.Site = temp;
                parent.writeToServer("ok");
                tempPFS.Mail = parent.readFromServer();
                parent.writeToServer("ok");
                tempPFS.Password = parent.readFromServer();
                parent.writeToServer("OK");
                allPasswords.Add(tempPFS);
            }

        }


        #region mouseEvents
        private bool mouseDown;

        private Point lastLocation;
        private void WINDOW_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void WINDOW_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void WINDOW_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion


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

            myPasswords active = new myPasswords(this,allPasswords);

            active.TopLevel = false;
            active.AutoScroll = true;
            workingPanel.Controls.Clear();
            workingPanel.Controls.Add(active);
            active.Show();
        }

        private void newPwBtn_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            newPwBtn.BackColor = Color.FromArgb(60, 60, 60);
            plusPicBox.BackColor = Color.FromArgb(60, 60, 60);

            AddNewPW active = new AddNewPW(this, allPasswords);

            active.TopLevel = false;
            active.AutoScroll = true;
            workingPanel.Controls.Clear();
            workingPanel.Controls.Add(active);
            active.Show();
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

            myLogs active = new myLogs(this);

            active.TopLevel = false;
            active.AutoScroll = true;
            workingPanel.Controls.Clear();
            workingPanel.Controls.Add(active);
            active.Show();
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

        private void workingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void appForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SAF_circle;
        }
    }
}
