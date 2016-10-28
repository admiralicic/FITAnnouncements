namespace FITAnnouncements.Admin
{
    partial class frmEditNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditNews));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExpire = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNewsText = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpExpire);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxNewsText);
            this.groupBox1.Location = new System.Drawing.Point(5, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 204);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vijest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum i vrijeme isteka:";
            // 
            // dtpExpire
            // 
            this.dtpExpire.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpire.Location = new System.Drawing.Point(128, 25);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.Size = new System.Drawing.Size(160, 20);
            this.dtpExpire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tekst vijesti:";
            // 
            // tboxNewsText
            // 
            this.tboxNewsText.Location = new System.Drawing.Point(128, 51);
            this.tboxNewsText.MaxLength = 5000;
            this.tboxNewsText.Multiline = true;
            this.tboxNewsText.Name = "tboxNewsText";
            this.tboxNewsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxNewsText.Size = new System.Drawing.Size(552, 147);
            this.tboxNewsText.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::FITAnnouncements.Admin.Properties.Resources.floppy_disk_321;
            this.btnSave.Location = new System.Drawing.Point(538, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Snimi";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::FITAnnouncements.Admin.Properties.Resources.Cancel_321;
            this.btnExit.Location = new System.Drawing.Point(619, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Izlaz";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEditNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FITAnnouncements.Admin.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FITAnnouncements - Edit vijesti";
            this.Load += new System.EventHandler(this.frmEditNews_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExpire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNewsText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}