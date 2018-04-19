using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keylog
{
    public partial class Target_ByApp : Form
    {
        private Target _form = null;
        public Target_ByApp(Target form)
        {
            InitializeComponent();
            this._form = form;
        }

        private void btnAdd_FormAddByApp_Click(object sender, EventArgs e)
        {
            this.Show();
            _form.AddListBoxItem(lbListApp_FormAddByApp.SelectedItem.ToString(), "App");
            lbListApp_FormAddByApp.Items.Remove(lbListApp_FormAddByApp.SelectedItem);
            if (lbListApp_FormAddByApp.Items.Count > 0)
                lbListApp_FormAddByApp.SelectedIndex = 0;
            this.Close();
        }

        private void btnClose_FormAddByApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Target_ByApp_Load(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();

            foreach (Process p in processlist)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    lbListApp_FormAddByApp.Items.Add(p.MainWindowTitle);
                }
            }
        }
    }
}
