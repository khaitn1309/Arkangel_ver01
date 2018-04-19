namespace keylog
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bunifu.Framework.UI.BunifuTileButton btn_webcam;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.hello = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_alert = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_email = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_facebook = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_screenshot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_user = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ftp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_general = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clipboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_websiteusage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_target = new Bunifu.Framework.UI.BunifuFlatButton();
            btn_webcam = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btn_webcam
            // 
            btn_webcam.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            btn_webcam.AutoSize = true;
            btn_webcam.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            btn_webcam.BackColor = System.Drawing.Color.SeaGreen;
            btn_webcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_webcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            btn_webcam.CausesValidation = false;
            btn_webcam.color = System.Drawing.Color.SeaGreen;
            btn_webcam.colorActive = System.Drawing.Color.MediumSeaGreen;
            btn_webcam.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_webcam.Font = new System.Drawing.Font("FontAwesome", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_webcam.ForeColor = System.Drawing.Color.White;
            btn_webcam.Image = ((System.Drawing.Image)(resources.GetObject("btn_webcam.Image")));
            btn_webcam.ImagePosition = 19;
            btn_webcam.ImageZoom = 50;
            btn_webcam.ImeMode = System.Windows.Forms.ImeMode.Disable;
            btn_webcam.LabelPosition = 40;
            btn_webcam.LabelText = " Webcam ";
            btn_webcam.Location = new System.Drawing.Point(40, 196);
            btn_webcam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btn_webcam.Name = "btn_webcam";
            btn_webcam.Size = new System.Drawing.Size(100, 100);
            btn_webcam.TabIndex = 57;
            btn_webcam.Click += new System.EventHandler(this.btn_webcam_Click);
            // 
            // hello
            // 
            this.hello.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hello.AutoSize = true;
            this.hello.Font = new System.Drawing.Font("FontAwesome", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.Location = new System.Drawing.Point(261, 19);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(212, 37);
            this.hello.TabIndex = 58;
            this.hello.Text = "Good Morning";
            // 
            // btn_alert
            // 
            this.btn_alert.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_alert.color = System.Drawing.Color.DarkGreen;
            this.btn_alert.colorActive = System.Drawing.Color.SeaGreen;
            this.btn_alert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alert.Font = new System.Drawing.Font("FontAwesome", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alert.ForeColor = System.Drawing.Color.White;
            this.btn_alert.Image = ((System.Drawing.Image)(resources.GetObject("btn_alert.Image")));
            this.btn_alert.ImagePosition = 17;
            this.btn_alert.ImageZoom = 50;
            this.btn_alert.LabelPosition = 34;
            this.btn_alert.LabelText = "Alert";
            this.btn_alert.Location = new System.Drawing.Point(591, 305);
            this.btn_alert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_alert.Name = "btn_alert";
            this.btn_alert.Size = new System.Drawing.Size(100, 100);
            this.btn_alert.TabIndex = 54;
            this.btn_alert.Click += new System.EventHandler(this.btn_alert_Click);
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_email.color = System.Drawing.Color.RoyalBlue;
            this.btn_email.colorActive = System.Drawing.Color.DodgerBlue;
            this.btn_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_email.Font = new System.Drawing.Font("FontAwesome", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.ForeColor = System.Drawing.Color.White;
            this.btn_email.Image = ((System.Drawing.Image)(resources.GetObject("btn_email.Image")));
            this.btn_email.ImagePosition = 17;
            this.btn_email.ImageZoom = 50;
            this.btn_email.LabelPosition = 34;
            this.btn_email.LabelText = "Email";
            this.btn_email.Location = new System.Drawing.Point(479, 305);
            this.btn_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(100, 100);
            this.btn_email.TabIndex = 55;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // btn_facebook
            // 
            this.btn_facebook.BackColor = System.Drawing.Color.Purple;
            this.btn_facebook.color = System.Drawing.Color.Purple;
            this.btn_facebook.colorActive = System.Drawing.Color.Violet;
            this.btn_facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_facebook.Font = new System.Drawing.Font("FontAwesome", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facebook.ForeColor = System.Drawing.Color.White;
            this.btn_facebook.Image = ((System.Drawing.Image)(resources.GetObject("btn_facebook.Image")));
            this.btn_facebook.ImagePosition = 19;
            this.btn_facebook.ImageZoom = 50;
            this.btn_facebook.LabelPosition = 39;
            this.btn_facebook.LabelText = "Facebook";
            this.btn_facebook.Location = new System.Drawing.Point(151, 196);
            this.btn_facebook.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(100, 100);
            this.btn_facebook.TabIndex = 56;
            // 
            // btn_screenshot
            // 
            this.btn_screenshot.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_screenshot.BackColor = System.Drawing.Color.Maroon;
            this.btn_screenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_screenshot.BorderRadius = 0;
            this.btn_screenshot.ButtonText = "Screen Shot";
            this.btn_screenshot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_screenshot.DisabledColor = System.Drawing.Color.Gray;
            this.btn_screenshot.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_screenshot.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_screenshot.Iconimage")));
            this.btn_screenshot.Iconimage_right = null;
            this.btn_screenshot.Iconimage_right_Selected = null;
            this.btn_screenshot.Iconimage_Selected = null;
            this.btn_screenshot.IconMarginLeft = 0;
            this.btn_screenshot.IconMarginRight = 0;
            this.btn_screenshot.IconRightVisible = true;
            this.btn_screenshot.IconRightZoom = 0D;
            this.btn_screenshot.IconVisible = true;
            this.btn_screenshot.IconZoom = 90D;
            this.btn_screenshot.IsTab = false;
            this.btn_screenshot.Location = new System.Drawing.Point(261, 305);
            this.btn_screenshot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_screenshot.Name = "btn_screenshot";
            this.btn_screenshot.Normalcolor = System.Drawing.Color.Maroon;
            this.btn_screenshot.OnHovercolor = System.Drawing.Color.Red;
            this.btn_screenshot.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_screenshot.selected = false;
            this.btn_screenshot.Size = new System.Drawing.Size(212, 100);
            this.btn_screenshot.TabIndex = 47;
            this.btn_screenshot.Text = "Screen Shot";
            this.btn_screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_screenshot.Textcolor = System.Drawing.Color.White;
            this.btn_screenshot.TextFont = new System.Drawing.Font("FontAwesome", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_screenshot.Click += new System.EventHandler(this.btn_screenshot_Click);
            // 
            // btn_user
            // 
            this.btn_user.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.BorderRadius = 0;
            this.btn_user.ButtonText = "User";
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.DisabledColor = System.Drawing.Color.Gray;
            this.btn_user.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_user.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_user.Iconimage")));
            this.btn_user.Iconimage_right = null;
            this.btn_user.Iconimage_right_Selected = null;
            this.btn_user.Iconimage_Selected = null;
            this.btn_user.IconMarginLeft = 0;
            this.btn_user.IconMarginRight = 0;
            this.btn_user.IconRightVisible = true;
            this.btn_user.IconRightZoom = 0D;
            this.btn_user.IconVisible = true;
            this.btn_user.IconZoom = 90D;
            this.btn_user.IsTab = false;
            this.btn_user.Location = new System.Drawing.Point(479, 196);
            this.btn_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_user.Name = "btn_user";
            this.btn_user.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_user.OnHovercolor = System.Drawing.Color.Lime;
            this.btn_user.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_user.selected = false;
            this.btn_user.Size = new System.Drawing.Size(212, 100);
            this.btn_user.TabIndex = 48;
            this.btn_user.Text = "User";
            this.btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_user.Textcolor = System.Drawing.Color.White;
            this.btn_user.TextFont = new System.Drawing.Font("FontAwesome", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_ftp
            // 
            this.btn_ftp.Activecolor = System.Drawing.Color.Blue;
            this.btn_ftp.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_ftp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ftp.BorderRadius = 0;
            this.btn_ftp.ButtonText = "FTP";
            this.btn_ftp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ftp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ftp.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ftp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ftp.Iconimage")));
            this.btn_ftp.Iconimage_right = null;
            this.btn_ftp.Iconimage_right_Selected = null;
            this.btn_ftp.Iconimage_Selected = null;
            this.btn_ftp.IconMarginLeft = 0;
            this.btn_ftp.IconMarginRight = 0;
            this.btn_ftp.IconRightVisible = true;
            this.btn_ftp.IconRightZoom = 0D;
            this.btn_ftp.IconVisible = true;
            this.btn_ftp.IconZoom = 90D;
            this.btn_ftp.IsTab = false;
            this.btn_ftp.Location = new System.Drawing.Point(479, 87);
            this.btn_ftp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ftp.Name = "btn_ftp";
            this.btn_ftp.Normalcolor = System.Drawing.Color.MediumBlue;
            this.btn_ftp.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btn_ftp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ftp.selected = false;
            this.btn_ftp.Size = new System.Drawing.Size(212, 100);
            this.btn_ftp.TabIndex = 49;
            this.btn_ftp.Text = "FTP";
            this.btn_ftp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ftp.Textcolor = System.Drawing.Color.White;
            this.btn_ftp.TextFont = new System.Drawing.Font("FontAwesome", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ftp.Click += new System.EventHandler(this.btn_ftp_Click);
            // 
            // btn_general
            // 
            this.btn_general.Activecolor = System.Drawing.Color.Blue;
            this.btn_general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_general.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_general.BorderRadius = 0;
            this.btn_general.ButtonText = "General";
            this.btn_general.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_general.DisabledColor = System.Drawing.Color.Gray;
            this.btn_general.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_general.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_general.Iconimage")));
            this.btn_general.Iconimage_right = null;
            this.btn_general.Iconimage_right_Selected = null;
            this.btn_general.Iconimage_Selected = null;
            this.btn_general.IconMarginLeft = 0;
            this.btn_general.IconMarginRight = 0;
            this.btn_general.IconRightVisible = true;
            this.btn_general.IconRightZoom = 0D;
            this.btn_general.IconVisible = true;
            this.btn_general.IconZoom = 90D;
            this.btn_general.IsTab = false;
            this.btn_general.Location = new System.Drawing.Point(40, 87);
            this.btn_general.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_general.Name = "btn_general";
            this.btn_general.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_general.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_general.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_general.selected = false;
            this.btn_general.Size = new System.Drawing.Size(212, 100);
            this.btn_general.TabIndex = 50;
            this.btn_general.Text = "General";
            this.btn_general.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_general.Textcolor = System.Drawing.Color.White;
            this.btn_general.TextFont = new System.Drawing.Font("FontAwesome", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_general.Click += new System.EventHandler(this.btn_general_Click);
            // 
            // btn_clipboard
            // 
            this.btn_clipboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_clipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clipboard.BorderRadius = 0;
            this.btn_clipboard.ButtonText = "Clipboard";
            this.btn_clipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clipboard.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clipboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clipboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_clipboard.Iconimage")));
            this.btn_clipboard.Iconimage_right = null;
            this.btn_clipboard.Iconimage_right_Selected = null;
            this.btn_clipboard.Iconimage_Selected = null;
            this.btn_clipboard.IconMarginLeft = 0;
            this.btn_clipboard.IconMarginRight = 0;
            this.btn_clipboard.IconRightVisible = true;
            this.btn_clipboard.IconRightZoom = 0D;
            this.btn_clipboard.IconVisible = true;
            this.btn_clipboard.IconZoom = 90D;
            this.btn_clipboard.IsTab = false;
            this.btn_clipboard.Location = new System.Drawing.Point(261, 87);
            this.btn_clipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clipboard.Name = "btn_clipboard";
            this.btn_clipboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clipboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clipboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clipboard.selected = false;
            this.btn_clipboard.Size = new System.Drawing.Size(212, 100);
            this.btn_clipboard.TabIndex = 51;
            this.btn_clipboard.Text = "Clipboard";
            this.btn_clipboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clipboard.Textcolor = System.Drawing.Color.White;
            this.btn_clipboard.TextFont = new System.Drawing.Font("FontAwesome", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clipboard.Click += new System.EventHandler(this.btn_clipboard_Click);
            // 
            // btn_websiteusage
            // 
            this.btn_websiteusage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_websiteusage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_websiteusage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_websiteusage.BorderRadius = 0;
            this.btn_websiteusage.ButtonText = "Website Usage";
            this.btn_websiteusage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_websiteusage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_websiteusage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_websiteusage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_websiteusage.Iconimage")));
            this.btn_websiteusage.Iconimage_right = null;
            this.btn_websiteusage.Iconimage_right_Selected = null;
            this.btn_websiteusage.Iconimage_Selected = null;
            this.btn_websiteusage.IconMarginLeft = 0;
            this.btn_websiteusage.IconMarginRight = 0;
            this.btn_websiteusage.IconRightVisible = true;
            this.btn_websiteusage.IconRightZoom = 0D;
            this.btn_websiteusage.IconVisible = true;
            this.btn_websiteusage.IconZoom = 90D;
            this.btn_websiteusage.IsTab = false;
            this.btn_websiteusage.Location = new System.Drawing.Point(40, 305);
            this.btn_websiteusage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_websiteusage.Name = "btn_websiteusage";
            this.btn_websiteusage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_websiteusage.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_websiteusage.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_websiteusage.selected = false;
            this.btn_websiteusage.Size = new System.Drawing.Size(215, 100);
            this.btn_websiteusage.TabIndex = 52;
            this.btn_websiteusage.Text = "Website Usage";
            this.btn_websiteusage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_websiteusage.Textcolor = System.Drawing.Color.White;
            this.btn_websiteusage.TextFont = new System.Drawing.Font("FontAwesome", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_target
            // 
            this.btn_target.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_target.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_target.BorderRadius = 0;
            this.btn_target.ButtonText = "Target";
            this.btn_target.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_target.DisabledColor = System.Drawing.Color.Gray;
            this.btn_target.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_target.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_target.Iconimage")));
            this.btn_target.Iconimage_right = null;
            this.btn_target.Iconimage_right_Selected = null;
            this.btn_target.Iconimage_Selected = null;
            this.btn_target.IconMarginLeft = 0;
            this.btn_target.IconMarginRight = 0;
            this.btn_target.IconRightVisible = true;
            this.btn_target.IconRightZoom = 0D;
            this.btn_target.IconVisible = true;
            this.btn_target.IconZoom = 90D;
            this.btn_target.IsTab = false;
            this.btn_target.Location = new System.Drawing.Point(261, 196);
            this.btn_target.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_target.Name = "btn_target";
            this.btn_target.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_target.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_target.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_target.selected = false;
            this.btn_target.Size = new System.Drawing.Size(212, 100);
            this.btn_target.TabIndex = 53;
            this.btn_target.Text = "Target";
            this.btn_target.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_target.Textcolor = System.Drawing.Color.White;
            this.btn_target.TextFont = new System.Drawing.Font("FontAwesome", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(btn_webcam);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.btn_alert);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.btn_screenshot);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_ftp);
            this.Controls.Add(this.btn_general);
            this.Controls.Add(this.btn_clipboard);
            this.Controls.Add(this.btn_websiteusage);
            this.Controls.Add(this.btn_target);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(730, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel hello;
        private Bunifu.Framework.UI.BunifuTileButton btn_alert;
        private Bunifu.Framework.UI.BunifuTileButton btn_email;
        private Bunifu.Framework.UI.BunifuTileButton btn_facebook;
        private Bunifu.Framework.UI.BunifuFlatButton btn_screenshot;
        private Bunifu.Framework.UI.BunifuFlatButton btn_user;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ftp;
        private Bunifu.Framework.UI.BunifuFlatButton btn_general;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clipboard;
        private Bunifu.Framework.UI.BunifuFlatButton btn_websiteusage;
        private Bunifu.Framework.UI.BunifuFlatButton btn_target;
    }
}
