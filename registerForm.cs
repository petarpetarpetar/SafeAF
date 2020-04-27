using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security.Cryptography;


namespace PasswordManager
{
    public partial class registerForm : Form
    {
        Form1 parentForm;
        public registerForm(Form1 _parent)
        {
            parentForm = _parent;
            parentForm.connectToServer(Dns.GetHostName(), 1234);
            parentForm.writeToServer("r100");

            InitializeComponent();
        }

        #region looks
        private void registerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void registerForm_Paint(object sender, PaintEventArgs e)
        {

            Graphics l = e.Graphics;
            Pen p = new Pen(Color.DarkTurquoise, 2);
            l.DrawLine(p, inpMail.Location.X, inpMail.Location.Y + 4 + inpMail.Size.Height, inpMail.Location.X + inpMail.Size.Width, inpMail.Location.Y + inpMail.Size.Height + 4);
            l.DrawLine(p, inpPw.Location.X, inpPw.Location.Y + 4 + inpPw.Size.Height, inpPw.Location.X + inpPw.Size.Width, inpPw.Location.Y + inpPw.Size.Height + 4);
            l.DrawLine(p, inpPw2.Location.X, inpPw2.Location.Y + 4 + inpPw2.Size.Height, inpPw2.Location.X + inpPw2.Size.Width, inpPw2.Location.Y + inpPw2.Size.Height + 4);
            l.DrawLine(p, inpCode.Location.X, inpCode.Location.Y + 4 + inpCode.Size.Height, inpCode.Location.X + inpCode.Size.Width, inpCode.Location.Y + inpCode.Size.Height + 4);

            l.Dispose();
            this.Update();
        }
#endregion

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


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            bool checkPasswords(string pw1, string pw2)
            {
                if(pw1 != pw2)
                {
                    lblStatus.Text = "Password do not match";
                    lblStatus.ForeColor = Color.Red;
                    return false;
                }
                if (pw2.Length < 8)
                {
                    lblStatus.Text = "Password is too short. Must be at least 8 characters long.";
                    lblStatus.ForeColor = Color.Red;
                    return false;
                }
                return true;
            }

            if(IsValidEmail(inpMail.Text) && checkPasswords(inpPw.Text, inpPw2.Text) && inpCode.Text.Length == 4)
            {
                lblStatus.ForeColor = Color.Yellow;
                parentForm.writeToServer("r120");
                var encData = parentForm.EncryptData(inpMail.Text+"$"+inpCode.Text+"$"+inpPw.Text, parentForm.serverPubKey);
                parentForm.writeToServer(encData);

                lblStatus.Text = "Sent, waiting for server response.";
                lblStatus.ForeColor = Color.Green;
                
            }
            else
            {
                lblStatus.Text = "Check your form and try again.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            string response = parentForm.readFromServer();

            if(response == "r200")
            {
                lblStatus.Text = "Okay, now close this form and login.";
                lblStatus.ForeColor = Color.Green;
            }
            else if(response =="r300")
            {
                lblStatus.Text = "Your code is probably wrong, check it again.";
                lblStatus.ForeColor = Color.Red;
            }
            return;
        }


        private void codeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(inpMail.Text))
            {
                lblStatus.Text = "Please provide valid email";
                lblStatus.ForeColor = Color.Red;
                return;
            }
            lblStatus.Text = "Check email for code";
            lblStatus.ForeColor = Color.Blue;

            parentForm.connectToServer(Dns.GetHostName(), 1234);
            parentForm.writeToServer("r110");
          
            String serverPUBKEYSTR = parentForm.readFromServer();
            MessageBox.Show(serverPUBKEYSTR);

            var sr = new System.IO.StringReader(serverPUBKEYSTR);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            parentForm.serverPubKey = (RSAParameters)xs.Deserialize(sr);

            var cypherText = parentForm.EncryptData(inpMail.Text, parentForm.serverPubKey);
            parentForm.writeToServer(cypherText);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            parentForm.writeToServer("e100");
            parentForm.sock.Close();
            parentForm.Opacity = 100;
            parentForm.ShowInTaskbar = true;
            parentForm.Activate();
            parentForm.BringToFront();
            this.Close();
        }
    }
}
