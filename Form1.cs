using System;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        #region variables

        public TcpClient sock = new TcpClient();

        static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);

        static RSAParameters privKey;

        static RSAParameters pubKey;

        public RSAParameters serverPubKey;

        static string pubKeyStr;
        
        private bool mouseDown;

        public string usrMail;
        public string usrPassword;

        private Point lastLocation;
        #endregion

        public Form1()
        {
            RSASETUP();   
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inpPw.BorderStyle = BorderStyle.None;
            inpMail.BorderStyle = BorderStyle.None;
        }

        #region mouseEvents
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        { 
            //this is exit button
            Cursor.Current = Cursors.WaitCursor;
            this.Close();
            Cursor.Current = Cursors.WaitCursor;
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            registerForm regform = new registerForm(this);
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            regform.ShowDialog();

        }
        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            checkLogin(inpMail.Text, inpPw.Text);
        }
        #endregion

        #region RSAstuff
        public string EncryptData(string data, RSAParameters key, bool reset = true)
        {
            var bytesPlainData = System.Text.Encoding.Unicode.GetBytes(data);
            if(reset)
                csp.ImportParameters(key);
            var bytesCypherText = csp.Encrypt(bytesPlainData, false);
            var cypherText = Convert.ToBase64String(bytesCypherText);

            return cypherText;
        }
        private void RSASETUP()
        {
            privKey = csp.ExportParameters(true);
            pubKey = csp.ExportParameters(false);
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, pubKey);
            pubKeyStr = sw.ToString();


            //RSA TEST below:
            /*
            {
                //encrypt:
                string plain = "test_plain123plain";
                var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plain);
                csp.ImportParameters(pubKey);
                var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);
                var cypherText = Convert.ToBase64String(bytesCypherText);

                //decrypt:
                bytesCypherText = Convert.FromBase64String(cypherText);
                csp = new RSACryptoServiceProvider();
                csp.ImportParameters(privKey);
                bytesPlainTextData = csp.Decrypt(bytesCypherText, false);
                var end = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
                //MessageBox.Show(end);
            }
            */
        }
        #endregion

        #region mouseEnterAndLeaveStuff
        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.ForeColor = Color.FromArgb(140, 0, 0);
            this.Update();
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.ForeColor = Color.FromArgb(192, 0, 0);
            this.Update();
        }
        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.ForeColor = Color.AliceBlue;
            this.Update();
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.ForeColor = Color.Cyan;
            this.Update();
        }

        private void registerBtn_MouseEnter(object sender, EventArgs e)
        {
            registerBtn.ForeColor = Color.Bisque;
        }

        private void registerBtn_MouseLeave(object sender, EventArgs e)
        {
            registerBtn.ForeColor = Color.Gainsboro;
        }
        #endregion

        #region comms
        public void connectToServer(string _ip, int _port)
        {
            if (sock.Connected == false)
            {
                sock = new TcpClient();
                sock.Connect(_ip, _port);
            }
        }
        
        public bool writeToServer(string _data)
        {
            try{
                NetworkStream stm = sock.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();

                byte[] sendBuff = asen.GetBytes(_data);
                stm.Write(sendBuff, 0, sendBuff.Length);
            }
            catch (Exception e) { MessageBox.Show("ERROR OCCURED IN WRITESERVER\n"+e.ToString()); }
            
            return true;
        }

        public string readFromServer()
        {

            try
            {
                NetworkStream stm = sock.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();

                byte[] recBuffer = new byte[1024];
                String recText = String.Empty;
                Int32 bytes = stm.Read(recBuffer, 0, recBuffer.Length);
                return System.Text.Encoding.ASCII.GetString(recBuffer, 0, bytes);
            }
            catch (Exception e){
                MessageBox.Show(e.ToString());
                return "error"; }
            
        }
        #endregion

        private void checkLogin(string name, string password)
        {
            try
            {
                connectToServer(Dns.GetHostName(), 1234);

                //sending login request to the server: ("c100" is a code for login request comand)
                writeToServer("c100");

                //recieving server's public key as string:
                String serverPubKeyString = readFromServer();

                //converting server's public key (string) to server key (RSAPARAM):
                var sr = new System.IO.StringReader(serverPubKeyString);
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                serverPubKey = (RSAParameters)xs.Deserialize(sr);

                //sending ecrypted mail and password:
                var cypherText = EncryptData(inpMail.Text + "$" + inpPw.Text, serverPubKey);
                writeToServer(cypherText);

                //now waiting for response. Am I logged in?
                String loginStatus = readFromServer();

                if(String.Equals(loginStatus,"c105"))
                {
                    this.usrMail = this.inpMail.Text;
                    this.usrPassword = this.inpPw.Text;
                    this.Opacity = 0;
                    this.ShowInTaskbar = false;
                    appForm aForm = new appForm(this);
                    aForm.Show();
                }
            }
            catch(Exception e){MessageBox.Show(e.ToString());}

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Aqua, 3);
            l.DrawLine(p, inpMail.Location.X, inpMail.Location.Y +4+ inpMail.Size.Height, inpMail.Location.X + inpMail.Size.Width, inpMail.Location.Y + inpMail.Size.Height + 4);
            l.DrawLine(p, inpPw.Location.X, inpPw.Location.Y +4+ inpPw.Size.Height, inpPw.Location.X + inpPw.Size.Width, inpPw.Location.Y + inpPw.Size.Height + 4);
            l.Dispose();
            this.Update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeToServer("e100");
            sock.Close();
        }
    }
}
