namespace keylog
{
    partial class _Clipboard
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
            this.bt_change2 = new System.Windows.Forms.Button();
            this.bt_change = new System.Windows.Forms.Button();
            this.bt_file = new MaterialSkin.Controls.MaterialFlatButton();
            this.bt_image = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb2_clipboard = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(5, 5);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(964, 442);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.bt_change2);
            this.metroTabPage1.Controls.Add(this.bt_change);
            this.metroTabPage1.Controls.Add(this.bt_file);
            this.metroTabPage1.Controls.Add(this.bt_image);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tb2_clipboard);
            this.metroTabPage1.Font = new System.Drawing.Font("FontAwesome", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(956, 400);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Clipboard";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // bt_change2
            // 
            this.bt_change2.Location = new System.Drawing.Point(764, 241);
            this.bt_change2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change2.Name = "bt_change2";
            this.bt_change2.Size = new System.Drawing.Size(100, 43);
            this.bt_change2.TabIndex = 8;
            this.bt_change2.Text = "Change";
            this.bt_change2.UseVisualStyleBackColor = true;
            this.bt_change2.Click += new System.EventHandler(this.bt_change2_Click);
            // 
            // bt_change
            // 
            this.bt_change.Location = new System.Drawing.Point(764, 241);
            this.bt_change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(100, 43);
            this.bt_change.TabIndex = 7;
            this.bt_change.Text = "Change";
            this.bt_change.UseVisualStyleBackColor = true;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // bt_file
            // 
            this.bt_file.AutoSize = true;
            this.bt_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_file.Depth = 0;
            this.bt_file.Location = new System.Drawing.Point(655, 326);
            this.bt_file.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.bt_file.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_file.Name = "bt_file";
            this.bt_file.Primary = false;
            this.bt_file.Size = new System.Drawing.Size(143, 36);
            this.bt_file.TabIndex = 6;
            this.bt_file.Text = "Clipboard File";
            this.bt_file.UseVisualStyleBackColor = true;
            this.bt_file.Click += new System.EventHandler(this.bt_file_Click);
            // 
            // bt_image
            // 
            this.bt_image.AutoSize = true;
            this.bt_image.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_image.Depth = 0;
            this.bt_image.Location = new System.Drawing.Point(160, 326);
            this.bt_image.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.bt_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_image.Name = "bt_image";
            this.bt_image.Primary = false;
            this.bt_image.Size = new System.Drawing.Size(162, 36);
            this.bt_image.TabIndex = 5;
            this.bt_image.Text = "Clipboard Image";
            this.bt_image.UseVisualStyleBackColor = true;
            this.bt_image.Click += new System.EventHandler(this.bt_image_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(79, 17);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Clipboard text Value:";
            // 
            // tb2_clipboard
            // 
            this.tb2_clipboard.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb2_clipboard.Location = new System.Drawing.Point(67, 48);
            this.tb2_clipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb2_clipboard.Multiline = true;
            this.tb2_clipboard.Name = "tb2_clipboard";
            this.tb2_clipboard.ReadOnly = true;
            this.tb2_clipboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb2_clipboard.Size = new System.Drawing.Size(820, 237);
            this.tb2_clipboard.TabIndex = 3;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(759, 465);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(205, 43);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "OK";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // _Clipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "_Clipboard";
            this.Size = new System.Drawing.Size(973, 522);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Button bt_change;
        private MaterialSkin.Controls.MaterialFlatButton bt_file;
        private MaterialSkin.Controls.MaterialFlatButton bt_image;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb2_clipboard;
        private System.Windows.Forms.Button bt_change2;
    }
}
