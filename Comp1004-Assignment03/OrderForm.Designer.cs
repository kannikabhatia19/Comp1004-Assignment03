namespace Comp1004_Assignment03
{
    partial class OrderForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamButton = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.MovieSelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.MovieCategoryLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.DVDCheckBox = new System.Windows.Forms.CheckBox();
            this.DVDLabel = new System.Windows.Forms.Label();
            this.DVDTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.MovieCostTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.MovieCostLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderMenuStrip.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieSelectedPictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(487, 431);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(662, 28);
            this.OrderMenuStrip.TabIndex = 1;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.PrintToolStripMenuItem,
            this.StreamToolStripMenuItem,
            this.CancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.PrintToolStripMenuItem.Text = "&Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // StreamToolStripMenuItem
            // 
            this.StreamToolStripMenuItem.Name = "StreamToolStripMenuItem";
            this.StreamToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.StreamToolStripMenuItem.Text = "Strea&m";
            this.StreamToolStripMenuItem.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.CancelToolStripMenuItem.Text = "Canc&el";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamButton.Location = new System.Drawing.Point(583, 431);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(75, 23);
            this.StreamButton.TabIndex = 2;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieCategoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieSelectedPictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieCategoryLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieTitleLabel);
            this.MovieSelectedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(12, 38);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(299, 431);
            this.MovieSelectedGroupBox.TabIndex = 3;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.BackColor = System.Drawing.Color.White;
            this.MovieTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovieTitleTextBox.Location = new System.Drawing.Point(11, 42);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(262, 22);
            this.MovieTitleTextBox.TabIndex = 4;
            // 
            // MovieCategoryTextBox
            // 
            this.MovieCategoryTextBox.BackColor = System.Drawing.Color.White;
            this.MovieCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovieCategoryTextBox.Location = new System.Drawing.Point(11, 87);
            this.MovieCategoryTextBox.Name = "MovieCategoryTextBox";
            this.MovieCategoryTextBox.ReadOnly = true;
            this.MovieCategoryTextBox.Size = new System.Drawing.Size(262, 22);
            this.MovieCategoryTextBox.TabIndex = 3;
            // 
            // MovieSelectedPictureBox
            // 
            this.MovieSelectedPictureBox.Location = new System.Drawing.Point(11, 125);
            this.MovieSelectedPictureBox.Name = "MovieSelectedPictureBox";
            this.MovieSelectedPictureBox.Size = new System.Drawing.Size(262, 291);
            this.MovieSelectedPictureBox.TabIndex = 2;
            this.MovieSelectedPictureBox.TabStop = false;
            // 
            // MovieCategoryLabel
            // 
            this.MovieCategoryLabel.AutoSize = true;
            this.MovieCategoryLabel.Location = new System.Drawing.Point(10, 71);
            this.MovieCategoryLabel.Name = "MovieCategoryLabel";
            this.MovieCategoryLabel.Size = new System.Drawing.Size(73, 16);
            this.MovieCategoryLabel.TabIndex = 0;
            this.MovieCategoryLabel.Text = "Category";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(10, 26);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(39, 16);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "Title";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.DVDCheckBox);
            this.OrderGroupBox.Controls.Add(this.DVDLabel);
            this.OrderGroupBox.Controls.Add(this.DVDTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.OrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.MovieCostTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.OrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.OrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.OrderGroupBox.Controls.Add(this.MovieCostLabel);
            this.OrderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGroupBox.Location = new System.Drawing.Point(317, 38);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(342, 285);
            this.OrderGroupBox.TabIndex = 4;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order";
            // 
            // DVDCheckBox
            // 
            this.DVDCheckBox.AutoSize = true;
            this.DVDCheckBox.Location = new System.Drawing.Point(9, 241);
            this.DVDCheckBox.Name = "DVDCheckBox";
            this.DVDCheckBox.Size = new System.Drawing.Size(327, 20);
            this.DVDCheckBox.TabIndex = 10;
            this.DVDCheckBox.Text = "Order the DVD (add $10.00 to your order)";
            this.DVDCheckBox.UseVisualStyleBackColor = true;
            this.DVDCheckBox.CheckedChanged += new System.EventHandler(this.DVDCheckBox_CheckedChanged);
            // 
            // DVDLabel
            // 
            this.DVDLabel.AutoSize = true;
            this.DVDLabel.Location = new System.Drawing.Point(104, 82);
            this.DVDLabel.Name = "DVDLabel";
            this.DVDLabel.Size = new System.Drawing.Size(43, 16);
            this.DVDLabel.TabIndex = 9;
            this.DVDLabel.Text = "DVD";
            this.DVDLabel.Visible = false;
            // 
            // DVDTextBox
            // 
            this.DVDTextBox.Location = new System.Drawing.Point(164, 79);
            this.DVDTextBox.Name = "DVDTextBox";
            this.DVDTextBox.Size = new System.Drawing.Size(100, 22);
            this.DVDTextBox.TabIndex = 8;
            this.DVDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DVDTextBox.Visible = false;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.BackColor = System.Drawing.Color.White;
            this.GrandTotalTextBox.Location = new System.Drawing.Point(164, 189);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.GrandTotalTextBox.TabIndex = 7;
            this.GrandTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.BackColor = System.Drawing.Color.White;
            this.SalesTaxTextBox.Location = new System.Drawing.Point(164, 150);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.SalesTaxTextBox.TabIndex = 6;
            this.SalesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.BackColor = System.Drawing.Color.White;
            this.SubTotalTextBox.Location = new System.Drawing.Point(164, 111);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.SubTotalTextBox.TabIndex = 5;
            this.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MovieCostTextBox
            // 
            this.MovieCostTextBox.BackColor = System.Drawing.Color.White;
            this.MovieCostTextBox.Location = new System.Drawing.Point(164, 41);
            this.MovieCostTextBox.Name = "MovieCostTextBox";
            this.MovieCostTextBox.ReadOnly = true;
            this.MovieCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.MovieCostTextBox.TabIndex = 4;
            this.MovieCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(55, 192);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(92, 16);
            this.GrandTotalLabel.TabIndex = 3;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(18, 153);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(129, 16);
            this.SalesTaxLabel.TabIndex = 2;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(75, 114);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(72, 16);
            this.SubTotalLabel.TabIndex = 1;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // MovieCostLabel
            // 
            this.MovieCostLabel.AutoSize = true;
            this.MovieCostLabel.Location = new System.Drawing.Point(106, 44);
            this.MovieCostLabel.Name = "MovieCostLabel";
            this.MovieCostLabel.Size = new System.Drawing.Size(41, 16);
            this.MovieCostLabel.TabIndex = 0;
            this.MovieCostLabel.Text = "Cost";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(339, 431);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(662, 465);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieSelectedPictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.TextBox MovieCategoryTextBox;
        private System.Windows.Forms.PictureBox MovieSelectedPictureBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label MovieCategoryLabel;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox MovieCostTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label MovieCostLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label DVDLabel;
        private System.Windows.Forms.TextBox DVDTextBox;
        private System.Windows.Forms.CheckBox DVDCheckBox;
        private System.Windows.Forms.ToolStripMenuItem StreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
    }
}