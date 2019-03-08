namespace Lab5b
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorGroupBox = new System.Windows.Forms.GroupBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.actorTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.firstEpisodeTextBox = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.firstEpisodeLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.playedByLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.companionsListBox = new System.Windows.Forms.ListBox();
            this.TextOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.doctorGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // doctorGroupBox
            // 
            this.doctorGroupBox.Controls.Add(this.yearTextBox);
            this.doctorGroupBox.Controls.Add(this.actorTextBox);
            this.doctorGroupBox.Controls.Add(this.ageTextBox);
            this.doctorGroupBox.Controls.Add(this.seriesTextBox);
            this.doctorGroupBox.Controls.Add(this.firstEpisodeTextBox);
            this.doctorGroupBox.Controls.Add(this.doctorComboBox);
            this.doctorGroupBox.Controls.Add(this.firstEpisodeLabel);
            this.doctorGroupBox.Controls.Add(this.ageLabel);
            this.doctorGroupBox.Controls.Add(this.seriesLabel);
            this.doctorGroupBox.Controls.Add(this.playedByLabel);
            this.doctorGroupBox.Controls.Add(this.doctorLabel);
            this.doctorGroupBox.Location = new System.Drawing.Point(12, 43);
            this.doctorGroupBox.Name = "doctorGroupBox";
            this.doctorGroupBox.Size = new System.Drawing.Size(289, 189);
            this.doctorGroupBox.TabIndex = 1;
            this.doctorGroupBox.TabStop = false;
            this.doctorGroupBox.Text = "The Doctor";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(225, 39);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(57, 22);
            this.yearTextBox.TabIndex = 12;
            // 
            // actorTextBox
            // 
            this.actorTextBox.Location = new System.Drawing.Point(89, 72);
            this.actorTextBox.Name = "actorTextBox";
            this.actorTextBox.Size = new System.Drawing.Size(194, 22);
            this.actorTextBox.TabIndex = 11;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(225, 106);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(57, 22);
            this.ageTextBox.TabIndex = 11;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Location = new System.Drawing.Point(65, 106);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(57, 22);
            this.seriesTextBox.TabIndex = 10;
            // 
            // firstEpisodeTextBox
            // 
            this.firstEpisodeTextBox.Location = new System.Drawing.Point(10, 157);
            this.firstEpisodeTextBox.Name = "firstEpisodeTextBox";
            this.firstEpisodeTextBox.Size = new System.Drawing.Size(273, 22);
            this.firstEpisodeTextBox.TabIndex = 3;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(98, 39);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(121, 24);
            this.doctorComboBox.TabIndex = 5;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // firstEpisodeLabel
            // 
            this.firstEpisodeLabel.AutoSize = true;
            this.firstEpisodeLabel.Location = new System.Drawing.Point(7, 137);
            this.firstEpisodeLabel.Name = "firstEpisodeLabel";
            this.firstEpisodeLabel.Size = new System.Drawing.Size(115, 17);
            this.firstEpisodeLabel.TabIndex = 4;
            this.firstEpisodeLabel.Text = "First full episode:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(132, 106);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(87, 17);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age at Start:";
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Location = new System.Drawing.Point(7, 106);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(52, 17);
            this.seriesLabel.TabIndex = 2;
            this.seriesLabel.Text = "Series:";
            // 
            // playedByLabel
            // 
            this.playedByLabel.AutoSize = true;
            this.playedByLabel.Location = new System.Drawing.Point(7, 72);
            this.playedByLabel.Name = "playedByLabel";
            this.playedByLabel.Size = new System.Drawing.Size(75, 17);
            this.playedByLabel.TabIndex = 1;
            this.playedByLabel.Text = "Played By:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(42, 42);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(50, 17);
            this.doctorLabel.TabIndex = 0;
            this.doctorLabel.Text = "Doctor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.companionsListBox);
            this.groupBox2.Location = new System.Drawing.Point(317, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 433);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Companions and their first episode with this Doctor:";
            // 
            // companionsListBox
            // 
            this.companionsListBox.FormattingEnabled = true;
            this.companionsListBox.ItemHeight = 16;
            this.companionsListBox.Location = new System.Drawing.Point(7, 22);
            this.companionsListBox.Name = "companionsListBox";
            this.companionsListBox.Size = new System.Drawing.Size(338, 404);
            this.companionsListBox.TabIndex = 0;
            // 
            // TextOpenFileDialog
            // 
            this.TextOpenFileDialog.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.doctorGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DoctorWho";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.doctorGroupBox.ResumeLayout(false);
            this.doctorGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.GroupBox doctorGroupBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label firstEpisodeLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label playedByLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox companionsListBox;
        private System.Windows.Forms.TextBox firstEpisodeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox actorTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.OpenFileDialog TextOpenFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

