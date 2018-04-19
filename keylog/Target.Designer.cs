namespace keylog
{
    partial class Target
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtn_ByFollowingApp = new System.Windows.Forms.RadioButton();
            this.radBtn_ByAllApp = new System.Windows.Forms.RadioButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabC_Target = new System.Windows.Forms.TabControl();
            this.tab_Byapp = new System.Windows.Forms.TabPage();
            this.lb_Byapp = new System.Windows.Forms.ListBox();
            this.tab_Byname = new System.Windows.Forms.TabPage();
            this.lb_Byname = new System.Windows.Forms.ListBox();
            this.btnMR_OK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabC_Target.SuspendLayout();
            this.tab_Byapp.SuspendLayout();
            this.tab_Byname.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(723, 365);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.Font = new System.Drawing.Font("FontAwesome", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(715, 323);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Target";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radBtn_ByFollowingApp);
            this.groupBox1.Controls.Add(this.radBtn_ByAllApp);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tabC_Target);
            this.groupBox1.Location = new System.Drawing.Point(4, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Setting";
            // 
            // radBtn_ByFollowingApp
            // 
            this.radBtn_ByFollowingApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtn_ByFollowingApp.AutoSize = true;
            this.radBtn_ByFollowingApp.Location = new System.Drawing.Point(99, 51);
            this.radBtn_ByFollowingApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radBtn_ByFollowingApp.Name = "radBtn_ByFollowingApp";
            this.radBtn_ByFollowingApp.Size = new System.Drawing.Size(330, 23);
            this.radBtn_ByFollowingApp.TabIndex = 10;
            this.radBtn_ByFollowingApp.Text = "Enable logging in the following application only.";
            this.radBtn_ByFollowingApp.UseVisualStyleBackColor = true;
            // 
            // radBtn_ByAllApp
            // 
            this.radBtn_ByAllApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtn_ByAllApp.AutoSize = true;
            this.radBtn_ByAllApp.Checked = true;
            this.radBtn_ByAllApp.Location = new System.Drawing.Point(99, 26);
            this.radBtn_ByAllApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radBtn_ByAllApp.Name = "radBtn_ByAllApp";
            this.radBtn_ByAllApp.Size = new System.Drawing.Size(234, 23);
            this.radBtn_ByAllApp.TabIndex = 9;
            this.radBtn_ByAllApp.TabStop = true;
            this.radBtn_ByAllApp.Text = "Enable logging in all application.";
            this.radBtn_ByAllApp.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(608, 207);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(92, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(608, 131);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(92, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabC_Target
            // 
            this.tabC_Target.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabC_Target.Controls.Add(this.tab_Byapp);
            this.tabC_Target.Controls.Add(this.tab_Byname);
            this.tabC_Target.Location = new System.Drawing.Point(28, 84);
            this.tabC_Target.Name = "tabC_Target";
            this.tabC_Target.SelectedIndex = 0;
            this.tabC_Target.Size = new System.Drawing.Size(556, 212);
            this.tabC_Target.TabIndex = 2;
            // 
            // tab_Byapp
            // 
            this.tab_Byapp.Controls.Add(this.lb_Byapp);
            this.tab_Byapp.Location = new System.Drawing.Point(4, 29);
            this.tab_Byapp.Name = "tab_Byapp";
            this.tab_Byapp.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Byapp.Size = new System.Drawing.Size(548, 179);
            this.tab_Byapp.TabIndex = 0;
            this.tab_Byapp.Text = "By application";
            this.tab_Byapp.UseVisualStyleBackColor = true;
            // 
            // lb_Byapp
            // 
            this.lb_Byapp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Byapp.FormattingEnabled = true;
            this.lb_Byapp.ItemHeight = 19;
            this.lb_Byapp.Location = new System.Drawing.Point(3, 3);
            this.lb_Byapp.Name = "lb_Byapp";
            this.lb_Byapp.Size = new System.Drawing.Size(542, 173);
            this.lb_Byapp.TabIndex = 0;
            // 
            // tab_Byname
            // 
            this.tab_Byname.Controls.Add(this.lb_Byname);
            this.tab_Byname.Location = new System.Drawing.Point(4, 29);
            this.tab_Byname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Byname.Name = "tab_Byname";
            this.tab_Byname.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Byname.Size = new System.Drawing.Size(548, 179);
            this.tab_Byname.TabIndex = 1;
            this.tab_Byname.Text = "By name";
            this.tab_Byname.UseVisualStyleBackColor = true;
            // 
            // lb_Byname
            // 
            this.lb_Byname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Byname.FormattingEnabled = true;
            this.lb_Byname.ItemHeight = 19;
            this.lb_Byname.Location = new System.Drawing.Point(2, 2);
            this.lb_Byname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_Byname.Name = "lb_Byname";
            this.lb_Byname.Size = new System.Drawing.Size(544, 175);
            this.lb_Byname.TabIndex = 0;
            // 
            // btnMR_OK
            // 
            this.btnMR_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMR_OK.Depth = 0;
            this.btnMR_OK.Location = new System.Drawing.Point(580, 375);
            this.btnMR_OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMR_OK.Name = "btnMR_OK";
            this.btnMR_OK.Primary = true;
            this.btnMR_OK.Size = new System.Drawing.Size(130, 45);
            this.btnMR_OK.TabIndex = 6;
            this.btnMR_OK.Text = "OK";
            this.btnMR_OK.UseVisualStyleBackColor = true;
            this.btnMR_OK.Click += new System.EventHandler(this.btnMR_OK_Click);
            // 
            // Target
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMR_OK);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Target";
            this.Size = new System.Drawing.Size(730, 424);
            this.Load += new System.EventHandler(this.Target_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabC_Target.ResumeLayout(false);
            this.tab_Byapp.ResumeLayout(false);
            this.tab_Byname.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnMR_OK;
        private System.Windows.Forms.TabControl tabC_Target;
        private System.Windows.Forms.TabPage tab_Byapp;
        private System.Windows.Forms.ListBox lb_Byapp;
        private System.Windows.Forms.TabPage tab_Byname;
        private System.Windows.Forms.ListBox lb_Byname;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.RadioButton radBtn_ByFollowingApp;
        private System.Windows.Forms.RadioButton radBtn_ByAllApp;
    }
}
