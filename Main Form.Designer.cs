namespace Taki
{
    partial class Mainform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GAMEpanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Turn_label = new System.Windows.Forms.Label();
            this.enemy1label = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.enemy2label = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.topCard = new System.Windows.Forms.PictureBox();
            this.NOTGAMEpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.GAMEpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCard)).BeginInit();
            this.NOTGAMEpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GAMEpanel
            // 
            this.GAMEpanel.BackColor = System.Drawing.Color.Teal;
            this.GAMEpanel.BackgroundImage = global::Taki.Properties.Resources.greenBackground;
            this.GAMEpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GAMEpanel.Controls.Add(this.pictureBox6);
            this.GAMEpanel.Controls.Add(this.Turn_label);
            this.GAMEpanel.Controls.Add(this.enemy1label);
            this.GAMEpanel.Controls.Add(this.pictureBox9);
            this.GAMEpanel.Controls.Add(this.enemy2label);
            this.GAMEpanel.Controls.Add(this.pictureBox13);
            this.GAMEpanel.Controls.Add(this.topCard);
            this.GAMEpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GAMEpanel.Location = new System.Drawing.Point(0, 0);
            this.GAMEpanel.Name = "GAMEpanel";
            this.GAMEpanel.Size = new System.Drawing.Size(768, 535);
            this.GAMEpanel.TabIndex = 28;
            this.GAMEpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GAMEpanel_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Taki.Properties.Resources.taki_back;
            this.pictureBox6.Location = new System.Drawing.Point(12, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(117, 79);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // Turn_label
            // 
            this.Turn_label.AutoSize = true;
            this.Turn_label.BackColor = System.Drawing.Color.Transparent;
            this.Turn_label.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn_label.ForeColor = System.Drawing.Color.White;
            this.Turn_label.Location = new System.Drawing.Point(289, 12);
            this.Turn_label.Name = "Turn_label";
            this.Turn_label.Size = new System.Drawing.Size(190, 32);
            this.Turn_label.TabIndex = 11;
            this.Turn_label.Text = "Welcome to Taki";
            // 
            // enemy1label
            // 
            this.enemy1label.AutoSize = true;
            this.enemy1label.BackColor = System.Drawing.Color.Transparent;
            this.enemy1label.ForeColor = System.Drawing.Color.White;
            this.enemy1label.Location = new System.Drawing.Point(12, 97);
            this.enemy1label.Name = "enemy1label";
            this.enemy1label.Size = new System.Drawing.Size(0, 13);
            this.enemy1label.TabIndex = 26;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Taki.Properties.Resources.taki_back;
            this.pictureBox9.Location = new System.Drawing.Point(637, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(117, 79);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // enemy2label
            // 
            this.enemy2label.AutoSize = true;
            this.enemy2label.BackColor = System.Drawing.Color.Transparent;
            this.enemy2label.ForeColor = System.Drawing.Color.White;
            this.enemy2label.Location = new System.Drawing.Point(700, 97);
            this.enemy2label.Name = "enemy2label";
            this.enemy2label.Size = new System.Drawing.Size(0, 13);
            this.enemy2label.TabIndex = 25;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Taki.Properties.Resources.taki_back;
            this.pictureBox13.Location = new System.Drawing.Point(229, 66);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(117, 163);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // topCard
            // 
            this.topCard.Location = new System.Drawing.Point(352, 66);
            this.topCard.Name = "topCard";
            this.topCard.Size = new System.Drawing.Size(117, 163);
            this.topCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topCard.TabIndex = 24;
            this.topCard.TabStop = false;
            this.topCard.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // NOTGAMEpanel
            // 
            this.NOTGAMEpanel.BackgroundImage = global::Taki.Properties.Resources.greenBackground;
            this.NOTGAMEpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NOTGAMEpanel.Controls.Add(this.pictureBox2);
            this.NOTGAMEpanel.Controls.Add(this.pictureBox1);
            this.NOTGAMEpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOTGAMEpanel.Location = new System.Drawing.Point(0, 0);
            this.NOTGAMEpanel.Name = "NOTGAMEpanel";
            this.NOTGAMEpanel.Size = new System.Drawing.Size(768, 535);
            this.NOTGAMEpanel.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Taki.Properties.Resources.playButton;
            this.pictureBox2.Location = new System.Drawing.Point(242, 390);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 55);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Taki.Properties.Resources.TAKIheader;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(222, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(768, 535);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GAMEpanel);
            this.Controls.Add(this.NOTGAMEpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taki";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GAMEpanel.ResumeLayout(false);
            this.GAMEpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCard)).EndInit();
            this.NOTGAMEpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label Turn_label;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox topCard;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label enemy2label;
        private System.Windows.Forms.Label enemy1label;
        public System.Windows.Forms.Panel GAMEpanel;
        public System.Windows.Forms.Panel NOTGAMEpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

