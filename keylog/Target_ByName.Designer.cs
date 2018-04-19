namespace keylog
{
    partial class Target_ByName
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
            this.tbTitle_TargetAddTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose_TargetAddTitle = new System.Windows.Forms.Button();
            this.btnAdd_TargetAddTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle_TargetAddTitle
            // 
            this.tbTitle_TargetAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle_TargetAddTitle.Location = new System.Drawing.Point(71, 14);
            this.tbTitle_TargetAddTitle.Multiline = true;
            this.tbTitle_TargetAddTitle.Name = "tbTitle_TargetAddTitle";
            this.tbTitle_TargetAddTitle.Size = new System.Drawing.Size(368, 43);
            this.tbTitle_TargetAddTitle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title : ";
            // 
            // btnClose_TargetAddTitle
            // 
            this.btnClose_TargetAddTitle.Location = new System.Drawing.Point(269, 84);
            this.btnClose_TargetAddTitle.Name = "btnClose_TargetAddTitle";
            this.btnClose_TargetAddTitle.Size = new System.Drawing.Size(111, 61);
            this.btnClose_TargetAddTitle.TabIndex = 5;
            this.btnClose_TargetAddTitle.Text = "Close";
            this.btnClose_TargetAddTitle.UseVisualStyleBackColor = true;
            this.btnClose_TargetAddTitle.Click += new System.EventHandler(this.btnClose_TargetAddTitle_Click);
            // 
            // btnAdd_TargetAddTitle
            // 
            this.btnAdd_TargetAddTitle.Location = new System.Drawing.Point(92, 84);
            this.btnAdd_TargetAddTitle.Name = "btnAdd_TargetAddTitle";
            this.btnAdd_TargetAddTitle.Size = new System.Drawing.Size(111, 61);
            this.btnAdd_TargetAddTitle.TabIndex = 4;
            this.btnAdd_TargetAddTitle.Text = "Add";
            this.btnAdd_TargetAddTitle.UseVisualStyleBackColor = true;
            this.btnAdd_TargetAddTitle.Click += new System.EventHandler(this.btnAdd_TargetAddTitle_Click);
            // 
            // Target_ByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 154);
            this.Controls.Add(this.tbTitle_TargetAddTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose_TargetAddTitle);
            this.Controls.Add(this.btnAdd_TargetAddTitle);
            this.Name = "Target_ByName";
            this.Text = "Target_ByName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle_TargetAddTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose_TargetAddTitle;
        private System.Windows.Forms.Button btnAdd_TargetAddTitle;
    }
}