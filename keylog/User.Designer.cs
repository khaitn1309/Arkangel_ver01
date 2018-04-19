namespace keylog
{
    partial class User
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
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabC_User = new System.Windows.Forms.TabPage();
            this.lstUser_Users = new System.Windows.Forms.ListView();
            this.mchkExclude_Users = new MetroFramework.Controls.MetroCheckBox();
            this.mradAll_Users = new MetroFramework.Controls.MetroRadioButton();
            this.mradCurrent_Users = new MetroFramework.Controls.MetroRadioButton();
            this.btn_OK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl1.SuspendLayout();
            this.tabC_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabC_User);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // tabC_User
            // 
            this.tabC_User.Controls.Add(this.lstUser_Users);
            this.tabC_User.Controls.Add(this.mchkExclude_Users);
            this.tabC_User.Controls.Add(this.mradAll_Users);
            this.tabC_User.Controls.Add(this.mradCurrent_Users);
            this.tabC_User.Location = new System.Drawing.Point(4, 38);
            this.tabC_User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabC_User.Name = "tabC_User";
            this.tabC_User.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabC_User.Size = new System.Drawing.Size(717, 321);
            this.tabC_User.TabIndex = 1;
            this.tabC_User.Text = "User";
            this.tabC_User.UseVisualStyleBackColor = true;
            // 
            // lstUser_Users
            // 
            this.lstUser_Users.CheckBoxes = true;
            this.lstUser_Users.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUser_Users.Location = new System.Drawing.Point(54, 90);
            this.lstUser_Users.Name = "lstUser_Users";
            this.lstUser_Users.Size = new System.Drawing.Size(612, 228);
            this.lstUser_Users.TabIndex = 23;
            this.lstUser_Users.UseCompatibleStateImageBehavior = false;
            this.lstUser_Users.View = System.Windows.Forms.View.List;
            // 
            // mchkExclude_Users
            // 
            this.mchkExclude_Users.AutoSize = true;
            this.mchkExclude_Users.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkExclude_Users.Location = new System.Drawing.Point(54, 58);
            this.mchkExclude_Users.Name = "mchkExclude_Users";
            this.mchkExclude_Users.Size = new System.Drawing.Size(344, 25);
            this.mchkExclude_Users.TabIndex = 22;
            this.mchkExclude_Users.Text = "Exclude selected users from monitoring:";
            this.mchkExclude_Users.UseSelectable = true;
            this.mchkExclude_Users.CheckedChanged += new System.EventHandler(this.mchkExclude_Users_CheckedChanged);
            // 
            // mradAll_Users
            // 
            this.mradAll_Users.AutoSize = true;
            this.mradAll_Users.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mradAll_Users.Location = new System.Drawing.Point(54, 31);
            this.mradAll_Users.Name = "mradAll_Users";
            this.mradAll_Users.Size = new System.Drawing.Size(160, 25);
            this.mradAll_Users.TabIndex = 21;
            this.mradAll_Users.Text = "Monitor all users";
            this.mradAll_Users.UseSelectable = true;
            // 
            // mradCurrent_Users
            // 
            this.mradCurrent_Users.AutoSize = true;
            this.mradCurrent_Users.BackColor = System.Drawing.SystemColors.Control;
            this.mradCurrent_Users.Checked = true;
            this.mradCurrent_Users.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mradCurrent_Users.Location = new System.Drawing.Point(54, 6);
            this.mradCurrent_Users.Name = "mradCurrent_Users";
            this.mradCurrent_Users.Size = new System.Drawing.Size(229, 25);
            this.mradCurrent_Users.TabIndex = 20;
            this.mradCurrent_Users.TabStop = true;
            this.mradCurrent_Users.Text = "Monitor current user only";
            this.mradCurrent_Users.UseSelectable = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Depth = 0;
            this.btn_OK.Location = new System.Drawing.Point(541, 370);
            this.btn_OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Primary = true;
            this.btn_OK.Size = new System.Drawing.Size(129, 48);
            this.btn_OK.TabIndex = 24;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "User";
            this.Size = new System.Drawing.Size(730, 424);
            this.Load += new System.EventHandler(this.User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabC_User.ResumeLayout(false);
            this.tabC_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabC_User;
        private System.Windows.Forms.ListView lstUser_Users;
        private MetroFramework.Controls.MetroCheckBox mchkExclude_Users;
        private MetroFramework.Controls.MetroRadioButton mradAll_Users;
        private MetroFramework.Controls.MetroRadioButton mradCurrent_Users;
        private MaterialSkin.Controls.MaterialRaisedButton btn_OK;
        private MetroFramework.Controls.MetroTabControl tabControl1;
    }
}
