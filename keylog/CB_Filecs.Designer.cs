namespace keylog
{
    partial class CB_Filecs
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_change = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(4, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(831, 148);
            this.listBox1.TabIndex = 0;
            // 
            // bt_change
            // 
            this.bt_change.Location = new System.Drawing.Point(677, 185);
            this.bt_change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(159, 39);
            this.bt_change.TabIndex = 2;
            this.bt_change.Text = "CHANGE";
            this.bt_change.UseSelectable = true;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // CB_Filecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 228);
            this.Controls.Add(this.bt_change);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CB_Filecs";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton bt_change;
    }
}