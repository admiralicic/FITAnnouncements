namespace FITAnnouncements.Admin
{
    partial class frmAddAnnouncement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAnnouncement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectIcon = new System.Windows.Forms.Button();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.tboxIconPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.tboxImagePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExpire = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNewsText = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSelectIcon);
            this.groupBox1.Controls.Add(this.pcbIcon);
            this.groupBox1.Controls.Add(this.tboxIconPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.pcbImage);
            this.groupBox1.Controls.Add(this.tboxImagePath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboxTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpExpire);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxNewsText);
            this.groupBox1.Location = new System.Drawing.Point(4, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 431);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objava";
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectIcon.Location = new System.Drawing.Point(656, 193);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(29, 20);
            this.btnSelectIcon.TabIndex = 4;
            this.btnSelectIcon.Text = "...";
            this.btnSelectIcon.UseVisualStyleBackColor = true;
            this.btnSelectIcon.Click += new System.EventHandler(this.btnSelectIcon_Click);
            // 
            // pcbIcon
            // 
            this.pcbIcon.Location = new System.Drawing.Point(425, 217);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(260, 206);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 22;
            this.pcbIcon.TabStop = false;
            // 
            // tboxIconPath
            // 
            this.tboxIconPath.Location = new System.Drawing.Point(425, 193);
            this.tboxIconPath.MaxLength = 254;
            this.tboxIconPath.Name = "tboxIconPath";
            this.tboxIconPath.Size = new System.Drawing.Size(226, 20);
            this.tboxIconPath.TabIndex = 21;
            this.tboxIconPath.Text = "Izaberite ikonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ikona:";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectImage.Location = new System.Drawing.Point(333, 192);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(29, 20);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "...";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(121, 217);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(239, 206);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 15;
            this.pcbImage.TabStop = false;
            // 
            // tboxImagePath
            // 
            this.tboxImagePath.Location = new System.Drawing.Point(121, 191);
            this.tboxImagePath.MaxLength = 254;
            this.tboxImagePath.Name = "tboxImagePath";
            this.tboxImagePath.Size = new System.Drawing.Size(206, 20);
            this.tboxImagePath.TabIndex = 11;
            this.tboxImagePath.Text = "Izaberite sliku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Slika:";
            // 
            // tboxTitle
            // 
            this.tboxTitle.Location = new System.Drawing.Point(120, 51);
            this.tboxTitle.MaxLength = 254;
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.Size = new System.Drawing.Size(565, 20);
            this.tboxTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naslov:";
            // 
            // dtpExpire
            // 
            this.dtpExpire.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpire.Location = new System.Drawing.Point(121, 25);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.Size = new System.Drawing.Size(174, 20);
            this.dtpExpire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tekst vijesti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum i vrijeme isteka:";
            // 
            // tboxNewsText
            // 
            this.tboxNewsText.Location = new System.Drawing.Point(120, 77);
            this.tboxNewsText.MaxLength = 5000;
            this.tboxNewsText.Multiline = true;
            this.tboxNewsText.Name = "tboxNewsText";
            this.tboxNewsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxNewsText.Size = new System.Drawing.Size(566, 108);
            this.tboxNewsText.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::FITAnnouncements.Admin.Properties.Resources.floppy_disk_321;
            this.btnSave.Location = new System.Drawing.Point(542, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 60);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Snimi";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::FITAnnouncements.Admin.Properties.Resources.Cancel_321;
            this.btnExit.Location = new System.Drawing.Point(623, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Izlaz";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmAddAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FITAnnouncements.Admin.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddAnnouncement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FITAnnouncements - Dodavanje nove objave";
            this.Load += new System.EventHandler(this.frmAddAnnouncement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxNewsText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tboxTitle;
        private System.Windows.Forms.Button btnSelectIcon;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.TextBox tboxIconPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.TextBox tboxImagePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}