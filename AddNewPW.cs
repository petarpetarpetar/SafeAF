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
    public partial class AddNewPW : Form
    {
        appForm parent;
        List<PasswordForSite> pws;
        public AddNewPW(appForm _p,List<PasswordForSite> a)
        {
            InitializeComponent();
            parent = _p;
            pws = a;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void randomPwBtn_Click(object sender, EventArgs e)
        {
            RandomGenerator generator = new RandomGenerator();

            this.newPwTB.Text = generator.RandomString(64,false);

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            parent.parent.writeToServer("n100");
            string res = parent.parent.readFromServer();
            parent.parent.writeToServer(this.newSiteTB.Text);
            res = parent.parent.readFromServer();
            parent.parent.writeToServer(this.newMailTB.Text);
            res = parent.parent.readFromServer();
            parent.parent.writeToServer(this.newPwTB.Text);
            res = parent.parent.readFromServer();

            pws.Add(new PasswordForSite(this.newSiteTB.Text, this.newMailTB.Text, this.newPwTB.Text));
        }
    }
}
