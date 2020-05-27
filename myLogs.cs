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
    public partial class myLogs : Form
    {
        appForm parent;
        string logs;
        public myLogs(appForm _p)
        {
            InitializeComponent();
            parent = _p;
            this.FormBorderStyle = FormBorderStyle.None;
            parent.parent.writeToServer("l100");
            logs = parent.parent.readFromServer();
            this.mainTB.Text += logs;
        }

        private void myLogs_Load(object sender, EventArgs e)
        {

        }
    }
}
