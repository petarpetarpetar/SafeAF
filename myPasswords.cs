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
    public partial class myPasswords : Form
    {
        appForm parent;
        List<PasswordForSite> pws = new List<PasswordForSite>();
        BindingList<PasswordForSite> filter = new BindingList<PasswordForSite>();
        public myPasswords(appForm _p, List<PasswordForSite> a)
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            parent = _p;
            pws = a;
            filter = new BindingList<PasswordForSite>(new List<PasswordForSite>(pws));
            mainList.DataSource = filter;
        }

        private void mainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            siteTB.Text = "";
            mailTB.Text = "";
            passwordTB.Text = "";
            if (mainList.SelectedItem == null)
                return;
            siteTB.Text = ((PasswordForSite)mainList.SelectedItem).Site;
            mailTB.Text = ((PasswordForSite)mainList.SelectedItem).Mail;
            passwordTB.Text = ((PasswordForSite)mainList.SelectedItem).Password;
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

            filter.Clear();
            foreach (PasswordForSite u in (pws.FindAll(x => x.Site.ToLower().Contains(searchTB.Text.ToLower()))))
            {
                filter.Add(u);
            }
        }

        private void myPasswords_Load(object sender, EventArgs e)
        {

        }
    }
}
