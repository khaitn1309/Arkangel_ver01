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

namespace keylog
{
    public partial class Target : UserControl
    {
        public Target()
        {
            InitializeComponent();
        }
        delegate void AddListBoxItemCallback(string text, string to);
        public void AddListBoxItem(string item, string to)
        {
            if (this.InvokeRequired)
            {
                AddListBoxItemCallback callback = new AddListBoxItemCallback(AddListBoxItem);
                this.Invoke(callback, new string[] { item });

            }
            else
            {
                if(to == "Name")
                    this.lb_Byname.Items.Add(item);
                if (to == "App")
                    this.lb_Byapp.Items.Add(item);
                //alertList.Add(item);
            }

        }

        private void btnMR_OK_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> conf = new Dictionary<string, string>();
            if (radBtn_ByAllApp.Checked)
            {
                conf.Add("AllApplication", "true");
                conf.Add("ByFollowingApp", "false");
            }
            else
            {
                conf.Add("AllApplication", "false");
                conf.Add("ByFollowingApp", "true");
            }
            using (StreamWriter file = new StreamWriter("targets_conf.ini"))
                foreach (var entry in conf)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);

            using (StreamWriter file = new StreamWriter("targets_ListByApp.ini"))
                foreach (var item in lb_Byapp.Items)
                {
                    file.WriteLine(item);
                }

            using (StreamWriter file = new StreamWriter("targets_ListByTitle.ini"))
                foreach (var item in lb_Byname.Items)
                {
                    file.WriteLine(item);
                }
        }

        private void Target_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> conf = new Dictionary<string, string>();
            if (File.Exists("targets_conf.ini"))
            {
                StreamReader sr = new StreamReader("targets_conf.ini");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    conf.Add(arr[0], arr[1]);
                }
                sr.Close();

                radBtn_ByAllApp.Checked = Boolean.Parse(conf["AllApplication"]);
                radBtn_ByFollowingApp.Checked = Boolean.Parse(conf["ByFollowingApp"]);
            }

            if (File.Exists("targets_ListByApp.ini"))
            {
                StreamReader sr = new StreamReader("targets_ListByApp.ini");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    lb_Byapp.Items.Add(line);
                }

                sr.Close();
            }


            if (File.Exists("targets_ListByTitle.ini"))
            {
                StreamReader sr = new StreamReader("targets_ListByTitle.ini");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    lb_Byname.Items.Add(line);
                }

                sr.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // by app
            if (radBtn_ByFollowingApp.Checked == true)
            {
                if (tabC_Target.SelectedTab == tab_Byapp)
                {
                    Target_ByApp frm1 = new Target_ByApp(this);
                    frm1.ShowDialog();
                }// by following app
                else if (tabC_Target.SelectedTab == tab_Byname)
                {
                    Target_ByName frm2 = new Target_ByName(this);
                    frm2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Auto choose Enable logging by the following applications!", "Notification");
                radBtn_ByFollowingApp.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (tabC_Target.SelectedTab == tab_Byapp)
            {
                //tabTarget_panelTarget.SelectedTab = tabByApp;

                if (lb_Byapp.SelectedIndex != -1)
                {

                    int index = lb_Byapp.SelectedIndex;
                    //MessageBox.Show(alertList.ElementAt(index) + "\r\n" );
                    // remove from listbox ListKey
                    lb_Byapp.Items.RemoveAt(index);
                    if (index - 1 >= 0)
                        lb_Byapp.SelectedIndex = index - 1;
                    else if (lb_Byapp.Items.Count > 0)
                        lb_Byapp.SelectedIndex = 0;
                }
            }
            else if (tabC_Target.SelectedTab == tab_Byname)
            {
                //tabTarget_panelTarget.SelectedTab = tabByWinTitle;
                if (lb_Byname.SelectedIndex != -1)
                {

                    int index = lb_Byname.SelectedIndex;
                    //MessageBox.Show(alertList.ElementAt(index) + "\r\n" );
                    // remove from listbox ListKey
                    lb_Byname.Items.RemoveAt(index);
                    if (index - 1 >= 0)
                        lb_Byname.SelectedIndex = index - 1;
                    else if (lb_Byname.Items.Count > 0)
                        lb_Byname.SelectedIndex = 0;
                }
            }
        }
    }
}
