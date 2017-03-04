namespace Comp1004_Assignment03
{
    partial class AboutForm
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
            this.ProgrammerNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WebSitelabel2 = new System.Windows.Forms.Label();
            this.WebSiteLabel = new System.Windows.Forms.LinkLabel();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgrammerNameLabel
            // 
            this.ProgrammerNameLabel.AutoSize = true;
            this.ProgrammerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerNameLabel.Location = new System.Drawing.Point(27, 41);
            this.ProgrammerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProgrammerNameLabel.Name = "ProgrammerNameLabel";
            this.ProgrammerNameLabel.Size = new System.Drawing.Size(304, 20);
            this.ProgrammerNameLabel.TabIndex = 0;
            this.ProgrammerNameLabel.Text = "Programmer\'s name:  Kannika Bhatia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version:  0.0.1";
            // 
            // WebSitelabel2
            // 
            this.WebSitelabel2.AutoSize = true;
            this.WebSitelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebSitelabel2.Location = new System.Drawing.Point(25, 133);
            this.WebSitelabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WebSitelabel2.Name = "WebSitelabel2";
            this.WebSitelabel2.Size = new System.Drawing.Size(89, 20);
            this.WebSitelabel2.TabIndex = 2;
            this.WebSitelabel2.Text = "Website:  ";
            // 
            // WebSiteLabel
            // 
            this.WebSiteLabel.AutoSize = true;
            this.WebSiteLabel.Location = new System.Drawing.Point(108, 130);
            this.WebSiteLabel.Name = "WebSiteLabel";
            this.WebSiteLabel.Size = new System.Drawing.Size(191, 24);
            this.WebSiteLabel.TabIndex = 3;
            this.WebSiteLabel.TabStop = true;
            this.WebSiteLabel.Text = "http://www.imdb.com/";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(27, 182);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(244, 20);
            this.ContactLabel.TabIndex = 4;
            this.ContactLabel.Text = "Contact Number:  111111111";
            // 
            // AboutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(364, 246);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.WebSiteLabel);
            this.Controls.Add(this.WebSitelabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgrammerNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgrammerNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WebSitelabel2;
        private System.Windows.Forms.LinkLabel WebSiteLabel;
        private System.Windows.Forms.Label ContactLabel;
    }
}