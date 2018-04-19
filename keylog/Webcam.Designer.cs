namespace keylog
{
    partial class Webcam
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.devicesCombo = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_minutes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_hours = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cb_enable = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnMR_OK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(724, 350);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.Font = new System.Drawing.Font("FontAwesome", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(716, 308);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Webcam";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.bt_test);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.devicesCombo);
            this.groupBox2.Controls.Add(this.videoSourcePlayer);
            this.groupBox2.Location = new System.Drawing.Point(0, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 208);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 169);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(238, 116);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(106, 40);
            this.bt_test.TabIndex = 3;
            this.bt_test.Text = "Test";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source:";
            // 
            // devicesCombo
            // 
            this.devicesCombo.FormattingEnabled = true;
            this.devicesCombo.Items.AddRange(new object[] {
            ""});
            this.devicesCombo.Location = new System.Drawing.Point(112, 68);
            this.devicesCombo.Name = "devicesCombo";
            this.devicesCombo.Size = new System.Drawing.Size(232, 27);
            this.devicesCombo.TabIndex = 1;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(375, 25);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(307, 167);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_minutes);
            this.groupBox1.Controls.Add(this.tb_hours);
            this.groupBox1.Controls.Add(this.cb_enable);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enable/Disable";
            // 
            // tb_minutes
            // 
            this.tb_minutes.Depth = 0;
            this.tb_minutes.Hint = "";
            this.tb_minutes.Location = new System.Drawing.Point(476, 34);
            this.tb_minutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_minutes.Name = "tb_minutes";
            this.tb_minutes.PasswordChar = '\0';
            this.tb_minutes.SelectedText = "";
            this.tb_minutes.SelectionLength = 0;
            this.tb_minutes.SelectionStart = 0;
            this.tb_minutes.Size = new System.Drawing.Size(43, 23);
            this.tb_minutes.TabIndex = 4;
            this.tb_minutes.Text = "1";
            this.tb_minutes.UseSystemPasswordChar = false;
            // 
            // tb_hours
            // 
            this.tb_hours.Depth = 0;
            this.tb_hours.Hint = "";
            this.tb_hours.Location = new System.Drawing.Point(394, 34);
            this.tb_hours.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_hours.Name = "tb_hours";
            this.tb_hours.PasswordChar = '\0';
            this.tb_hours.SelectedText = "";
            this.tb_hours.SelectionLength = 0;
            this.tb_hours.SelectionStart = 0;
            this.tb_hours.Size = new System.Drawing.Size(42, 23);
            this.tb_hours.TabIndex = 3;
            this.tb_hours.Text = "0";
            this.tb_hours.UseSystemPasswordChar = false;
            // 
            // cb_enable
            // 
            this.cb_enable.AutoSize = true;
            this.cb_enable.Checked = true;
            this.cb_enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_enable.Depth = 0;
            this.cb_enable.Font = new System.Drawing.Font("Roboto", 10F);
            this.cb_enable.Location = new System.Drawing.Point(157, 30);
            this.cb_enable.Margin = new System.Windows.Forms.Padding(0);
            this.cb_enable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_enable.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_enable.Name = "cb_enable";
            this.cb_enable.Ripple = true;
            this.cb_enable.Size = new System.Drawing.Size(414, 30);
            this.cb_enable.TabIndex = 0;
            this.cb_enable.Text = "Capture webcam snapshot every               hours              minutes";
            this.cb_enable.UseVisualStyleBackColor = true;
            // 
            // btnMR_OK
            // 
            this.btnMR_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMR_OK.Depth = 0;
            this.btnMR_OK.Location = new System.Drawing.Point(586, 368);
            this.btnMR_OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMR_OK.Name = "btnMR_OK";
            this.btnMR_OK.Primary = true;
            this.btnMR_OK.Size = new System.Drawing.Size(130, 40);
            this.btnMR_OK.TabIndex = 8;
            this.btnMR_OK.Text = "OK";
            this.btnMR_OK.UseVisualStyleBackColor = true;
            this.btnMR_OK.Click += new System.EventHandler(this.btnMR_OK_Click);
            // 
            // Webcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMR_OK);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Webcam";
            this.Size = new System.Drawing.Size(730, 424);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckBox cb_enable;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnMR_OK;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_minutes;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_hours;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox devicesCombo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
