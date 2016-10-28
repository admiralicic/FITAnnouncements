namespace FITAnnouncements.Admin
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.objaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvAnnouncements = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAnnouncements)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vijestiToolStripMenuItem,
            this.objaveToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.animationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vijestiToolStripMenuItem
            // 
            this.vijestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem1,
            this.dodajToolStripMenuItem1});
            this.vijestiToolStripMenuItem.Name = "vijestiToolStripMenuItem";
            this.vijestiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.vijestiToolStripMenuItem.Text = "Vijesti";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Image = global::FITAnnouncements.Admin.Properties.Resources.binoculars_icon;
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.pregledToolStripMenuItem1_Click);
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Image = global::FITAnnouncements.Admin.Properties.Resources.Add1;
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // objaveToolStripMenuItem
            // 
            this.objaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem2,
            this.dodajToolStripMenuItem2});
            this.objaveToolStripMenuItem.Name = "objaveToolStripMenuItem";
            this.objaveToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.objaveToolStripMenuItem.Text = "Objave";
            // 
            // pregledToolStripMenuItem2
            // 
            this.pregledToolStripMenuItem2.Image = global::FITAnnouncements.Admin.Properties.Resources.binoculars_icon;
            this.pregledToolStripMenuItem2.Name = "pregledToolStripMenuItem2";
            this.pregledToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.pregledToolStripMenuItem2.Text = "Pregled";
            this.pregledToolStripMenuItem2.Click += new System.EventHandler(this.pregledToolStripMenuItem2_Click);
            // 
            // dodajToolStripMenuItem2
            // 
            this.dodajToolStripMenuItem2.Image = global::FITAnnouncements.Admin.Properties.Resources.Add;
            this.dodajToolStripMenuItem2.Name = "dodajToolStripMenuItem2";
            this.dodajToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.dodajToolStripMenuItem2.Text = "Dodaj";
            this.dodajToolStripMenuItem2.Click += new System.EventHandler(this.dodajToolStripMenuItem2_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Image = global::FITAnnouncements.Admin.Properties.Resources.binoculars_icon;
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Image = global::FITAnnouncements.Admin.Properties.Resources.Add;
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // animationToolStripMenuItem
            // 
            this.animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            this.animationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.animationToolStripMenuItem.Text = "Pokreni prezentaciju";
            this.animationToolStripMenuItem.Click += new System.EventHandler(this.animationToolStripMenuItem_Click);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblLoggedInUser.Location = new System.Drawing.Point(674, 6);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(50, 13);
            this.lblLoggedInUser.TabIndex = 19;
            this.lblLoggedInUser.Text = "Korisnik: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtvAnnouncements);
            this.groupBox1.Location = new System.Drawing.Point(7, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 478);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutno aktivne objave";
            // 
            // dtvAnnouncements
            // 
            this.dtvAnnouncements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvAnnouncements.Location = new System.Drawing.Point(3, 16);
            this.dtvAnnouncements.MultiSelect = false;
            this.dtvAnnouncements.Name = "dtvAnnouncements";
            this.dtvAnnouncements.ReadOnly = true;
            this.dtvAnnouncements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnnouncements.Size = new System.Drawing.Size(858, 459);
            this.dtvAnnouncements.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::FITAnnouncements.Admin.Properties.Resources.rsz_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(838, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FITAnnouncements.Admin.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 545);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FITAnnouncements - Glavni meni";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvAnnouncements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem objaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem2;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvAnnouncements;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem animationToolStripMenuItem;
    }
}

