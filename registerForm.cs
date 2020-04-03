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
            parentForm.connectToServer(Dns.GetHostName(),1234);
            parentForm.writeToServer("r100");
            
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void regBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "asd";
        }
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
        private void codeBtn_Click(object sender, EventArgs e)
        {
            if (inpMail.Text == "")
            {
                lblStatus.Text = "Please provide valid email";
                lblStatus.ForeColor = Color.Red;
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

            var cypherText = parentForm.EncryptData(inpMail.Text + "$" + inpPw.Text, parentForm.serverPubKey);
            parentForm.writeToServer(cypherText);
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
