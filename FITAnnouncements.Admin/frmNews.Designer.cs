namespace FITAnnouncements.Admin
{
    partial class frmNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNews));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvNews = new System.Windows.Forms.DataGridView();
            this.lblClear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPretraga = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNews)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtvNews);
            this.groupBox1.Location = new System.Drawing.Point(3, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 397);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled vijesti";
            // 
            // dtvNews
            // 
            this.dtvNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvNews.Location = new System.Drawing.Point(3, 16);
            this.dtvNews.MultiSelect = false;
            this.dtvNews.Name = "dtvNews";
            this.dtvNews.ReadOnly = true;
            this.dtvNews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvNews.Size = new System.Drawing.Size(807, 378);
            this.dtvNews.TabIndex = 0;
            this.dtvNews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvNews_CellDoubleClick);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.ForeColor = System.Drawing.Color.Blue;
            this.lblClear.Location = new System.Drawing.Point(251, 67);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(33, 13);
            this.lblClear.TabIndex = 100;
            this.lblClear.Text = "Očisti";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Pretraga";
            // 
            // tboxPretraga
            // 
            this.tboxPretraga.Location = new System.Drawing.Point(6, 63);
            this.tboxPretraga.Name = "tboxPretraga";
            this.tboxPretraga.Size = new System.Drawing.Size(244, 20);
            this.tboxPretraga.TabIndex = 0;
            this.tboxPretraga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPretraga_KeyPress);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = global::FITAnnouncements.Admin.Properties.Resources.Add;
            this.btnDodaj.Location = new System.Drawing.Point(498, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 60);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::FITAnnouncements.Admin.Properties.Resources.cancel1;
            this.btnDelete.Location = new System.Drawing.Point(660, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 60);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Briši";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::FITAnnouncements.Admin.Properties.Resources.Cancel_321;
            this.btnExit.Location = new System.Drawing.Point(741, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Izlaz";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::FITAnnouncements.Admin.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(417, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 60);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Traži";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::FITAnnouncements.Admin.Properties.Resources.Settings32x32;
            this.btnEdit.Location = new System.Drawing.Point(579, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 60);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FITAnnouncements.Admin.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPretraga);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FITAnnouncements - Vijesti";
            this.Load += new System.EventHandler(this.frmNews_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvNews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvNews;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPretraga;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
    }
}