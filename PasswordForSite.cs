using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class PasswordForSite
    {
		private string site;
		public string Site
		{
			get { return site; }
			set { site = value; }
		}

		private string password;
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		private string mail;
		public string Mail
		{
			get { return mail; }
			set { mail = value; }
		}

		public PasswordForSite(string _s, string _m, string _p)
		{
			site = _s;
			mail = _m;
			password = _p;
		}
		public PasswordForSite()
		{


		}

		public override string ToString()
		{
			return site;
		}
	}
}
