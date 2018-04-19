namespace keylog
{
    partial class Alert
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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckb_MakeScreenShot = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckb_sendEmail = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbKeywordList = new System.Windows.Forms.ListBox();
            this.btn_Del = new Bunifu.Framework.UI.BunifuTileButton();
            this.bt_add = new Bunifu.Framework.UI.BunifuTileButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.btnMR_OK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroTabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(716, 304);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Alert";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_MakeScreenShot);
            this.groupBox2.Controls.Add(this.ckb_sendEmail);
            this.groupBox2.Location = new System.Drawing.Point(34, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Option";
            // 
            // ckb_MakeScreenShot
            // 
            this.ckb_MakeScreenShot.AutoSize = true;
            this.ckb_MakeScreenShot.Depth = 0;
            this.ckb_MakeScreenShot.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckb_MakeScreenShot.Location = new System.Drawing.Point(88, 61);
            this.ckb_MakeScreenShot.Margin = new System.Windows.Forms.Padding(0);
            this.ckb_MakeScreenShot.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckb_MakeScreenShot.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckb_MakeScreenShot.Name = "ckb_MakeScreenShot";
            this.ckb_MakeScreenShot.Ripple = true;
            this.ckb_MakeScreenShot.Size = new System.Drawing.Size(147, 30);
            this.ckb_MakeScreenShot.TabIndex = 1;
            this.ckb_MakeScreenShot.Text = "Make a screenshot";
            this.ckb_MakeScreenShot.UseVisualStyleBackColor = true;
            // 
            // ckb_sendEmail
            // 
            this.ckb_sendEmail.AutoSize = true;
            this.ckb_sendEmail.Depth = 0;
            this.ckb_sendEmail.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckb_sendEmail.Location = new System.Drawing.Point(88, 37);
            this.ckb_sendEmail.Margin = new System.Windows.Forms.Padding(0);
            this.ckb_sendEmail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckb_sendEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckb_sendEmail.Name = "ckb_sendEmail";
            this.ckb_sendEmail.Ripple = true;
            this.ckb_sendEmail.Size = new System.Drawing.Size(172, 30);
            this.ckb_sendEmail.TabIndex = 0;
            this.ckb_sendEmail.Text = "Send email notification";
            this.ckb_sendEmail.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKeywordList);
            this.groupBox1.Controls.Add(this.btn_Del);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Location = new System.Drawing.Point(34, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyword list";
            // 
            // lbKeywordList
            // 
            this.lbKeywordList.FormattingEnabled = true;
            this.lbKeywordList.ItemHeight = 24;
            this.lbKeywordList.Location = new System.Drawing.Point(71, 51);
            this.lbKeywordList.Margin = new System.Windows.Forms.Padding(2);
            this.lbKeywordList.Name = "lbKeywordList";
            this.lbKeywordList.Size = new System.Drawing.Size(494, 100);
            this.lbKeywordList.TabIndex = 5;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.color = System.Drawing.Color.Transparent;
            this.btn_Del.colorActive = System.Drawing.Color.Transparent;
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.Font = new System.Drawing.Font("FontAwesome", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.Black;
            this.btn_Del.Image = null;
            this.btn_Del.ImagePosition = 0;
            this.btn_Del.ImageZoom = 0;
            this.btn_Del.LabelPosition = 37;
            this.btn_Del.LabelText = "Del";
            this.btn_Del.Location = new System.Drawing.Point(574, 119);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(48, 41);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.Transparent;
            this.bt_add.color = System.Drawing.Color.Transparent;
            this.bt_add.colorActive = System.Drawing.Color.Transparent;
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.Font = new System.Drawing.Font("FontAwesome", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Black;
            this.bt_add.Image = null;
            this.bt_add.ImagePosition = 0;
            this.bt_add.ImageZoom = 0;
            this.bt_add.LabelPosition = 37;
            this.bt_add.LabelText = "Add";
            this.bt_add.Location = new System.Drawing.Point(571, 69);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(65, 40);
            this.bt_add.TabIndex = 1;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 9);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(724, 346);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // btnMR_OK
            // 
            this.btnMR_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMR_OK.Depth = 0;
            this.btnMR_OK.Location = new System.Drawing.Point(550, 370);
            this.btnMR_OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMR_OK.Name = "btnMR_OK";
            this.btnMR_OK.Primary = true;
            this.btnMR_OK.Size = new System.Drawing.Size(130, 40);
            this.btnMR_OK.TabIndex = 5;
            this.btnMR_OK.Text = "OK";
            this.btnMR_OK.UseVisualStyleBackColor = true;
            this.btnMR_OK.Click += new System.EventHandler(this.btnMR_OK_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btnMR_OK);
            this.Name = "Alert";
            this.Size = new System.Drawing.Size(730, 424);
            this.Load += new System.EventHandler(this.Alert_Load);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialCheckBox ckb_MakeScreenShot;
        private MaterialSkin.Controls.MaterialCheckBox ckb_sendEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuTileButton bt_add;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MaterialSkin.Controls.MaterialRaisedButton btnMR_OK;
        private Bunifu.Framework.UI.BunifuTileButton btn_Del;
        private System.Windows.Forms.ListBox lbKeywordList;
    }
}
