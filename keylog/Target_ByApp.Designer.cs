namespace keylog
{
    partial class Target_ByApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose_FormAddByApp = new System.Windows.Forms.Button();
            this.btnAdd_FormAddByApp = new System.Windows.Forms.Button();
            this.lbListApp_FormAddByApp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose_FormAddByApp
            // 
            this.btnClose_FormAddByApp.Location = new System.Drawing.Point(458, 126);
            this.btnClose_FormAddByApp.Name = "btnClose_FormAddByApp";
            this.btnClose_FormAddByApp.Size = new System.Drawing.Size(133, 55);
            this.btnClose_FormAddByApp.TabIndex = 5;
            this.btnClose_FormAddByApp.Text = "Close";
            this.btnClose_FormAddByApp.UseVisualStyleBackColor = true;
            this.btnClose_FormAddByApp.Click += new System.EventHandler(this.btnClose_FormAddByApp_Click);
            // 
            // btnAdd_FormAddByApp
            // 
            this.btnAdd_FormAddByApp.Location = new System.Drawing.Point(457, 43);
            this.btnAdd_FormAddByApp.Name = "btnAdd_FormAddByApp";
            this.btnAdd_FormAddByApp.Size = new System.Drawing.Size(134, 50);
            this.btnAdd_FormAddByApp.TabIndex = 4;
            this.btnAdd_FormAddByApp.Text = "Add";
            this.btnAdd_FormAddByApp.UseVisualStyleBackColor = true;
            this.btnAdd_FormAddByApp.Click += new System.EventHandler(this.btnAdd_FormAddByApp_Click);
            // 
            // lbListApp_FormAddByApp
            // 
            this.lbListApp_FormAddByApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbListApp_FormAddByApp.FormattingEnabled = true;
            this.lbListApp_FormAddByApp.ItemHeight = 16;
            this.lbListApp_FormAddByApp.Location = new System.Drawing.Point(0, 0);
            this.lbListApp_FormAddByApp.Name = "lbListApp_FormAddByApp";
            this.lbListApp_FormAddByApp.Size = new System.Drawing.Size(424, 251);
            this.lbListApp_FormAddByApp.TabIndex = 3;
            // 
            // Target_ByApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 251);
            this.Controls.Add(this.btnClose_FormAddByApp);
            this.Controls.Add(this.btnAdd_FormAddByApp);
            this.Controls.Add(this.lbListApp_FormAddByApp);
            this.Name = "Target_ByApp";
            this.Text = "Target_ByApp";
            this.Load += new System.EventHandler(this.Target_ByApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose_FormAddByApp;
        private System.Windows.Forms.Button btnAdd_FormAddByApp;
        private System.Windows.Forms.ListBox lbListApp_FormAddByApp;
    }
}