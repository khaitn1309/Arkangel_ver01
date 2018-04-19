using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using tt;

namespace keylog
{
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            if (File.Exists("user_config.ini"))
            {
                StreamReader sr = new StreamReader("user_config.ini");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    d.Add(arr[0], arr[1]);
                }
                sr.Close();

                mradAll_Users.Checked = Boolean.Parse(d["All"].ToString());
                mradCurrent_Users.Checked = Boolean.Parse(d["Current"].ToString());
                mchkExclude_Users.Checked = Boolean.Parse(d["Exclude"].ToString());
            }

            //Functions.FindUsers();
            Dictionary<string, string> d1 = new Dictionary<string, string>();
            if (File.Exists("username.ini"))
            {
                StreamReader sr1 = new StreamReader("username.ini");
                string line1;

                while ((line1 = sr1.ReadLine()) != null)
                {
                    string[] arr = line1.Split(',');
                    d1.Add(arr[0], arr[1]);
                }
                sr1.Close();

                foreach (var x in d1)
                {
                    lstUser_Users.Items.Add(x.Key);
                }

                foreach (ListViewItem x in lstUser_Users.Items)
                {
                    foreach (var y in d1)
                    {
                        if (x.Text == y.Key)
                        {
                            x.Checked = Boolean.Parse(y.Value);
                        }
                    }
                }
            }

            mchkExclude_Users_CheckedChanged(sender, e);
        }

        private void mchkExclude_Users_CheckedChanged(object sender, EventArgs e)
        {
            if (mchkExclude_Users.CheckState == CheckState.Checked)
                lstUser_Users.Enabled = true;
            else
                lstUser_Users.Enabled = false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Current", mradCurrent_Users.Checked.ToString());
            d.Add("All", mradAll_Users.Checked.ToString());
            d.Add("Exclude", mchkExclude_Users.Checked.ToString());
            d.Add("Username", Environment.UserName);

            using (StreamWriter file = new StreamWriter("user_config.ini"))
                foreach (var entry in d)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);
            // add user on listbox to file
            Dictionary<string, string> d1 = new Dictionary<string, string>();
            foreach (ListViewItem x in lstUser_Users.Items)
            {
                d1.Add(x.Text, x.Checked.ToString());
            }

            using (StreamWriter file = new StreamWriter("username.ini"))
                foreach (var entry in d1)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);

        }
    }
}
