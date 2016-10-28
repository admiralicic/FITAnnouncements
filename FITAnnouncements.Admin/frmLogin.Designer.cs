namespace FITAnnouncements.Admin
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.PassMaskCheckBox = new System.Windows.Forms.CheckBox();
            this.WrongUsernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(103, 19);
            this.tboxUsername.MaxLength = 50;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(202, 20);
            this.tboxUsername.TabIndex = 0;
            this.tboxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUsername_KeyPress);
            // 
            // PassMaskCheckBox
            // 
            this.PassMaskCheckBox.AutoSize = true;
            this.PassMaskCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PassMaskCheckBox.Checked = true;
            this.PassMaskCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PassMaskCheckBox.Location = new System.Drawing.Point(103, 75);
            this.PassMaskCheckBox.Name = "PassMaskCheckBox";
            this.PassMaskCheckBox.Size = new System.Drawing.Size(87, 17);
            this.PassMaskCheckBox.TabIndex = 2;
            this.PassMaskCheckBox.Text = "Maskiraj šifru";
            this.PassMaskCheckBox.UseVisualStyleBackColor = false;
            this.PassMaskCheckBox.CheckedChanged += new System.EventHandler(this.PassMaskCheckBox_CheckedChanged);
            // 
            // WrongUsernameLabel
            // 
            this.WrongUsernameLabel.AutoSize = true;
            this.WrongUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.WrongUsernameLabel.Location = new System.Drawing.Point(100, 95);
            this.WrongUsernameLabel.Name = "WrongUsernameLabel";
            this.WrongUsernameLabel.Size = new System.Drawing.Size(0, 13);
            this.WrongUsernameLabel.TabIndex = 28;
            this.WrongUsernameLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Korisničko ime: ";
            // 
            // tboxPassword
            // 
            this.tboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxPassword.Location = new System.Drawing.Point(103, 48);
            this.tboxPassword.MaxLength = 50;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(202, 21);
            this.tboxPassword.TabIndex = 1;
            this.tboxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::FITAnnouncements.Admin.Properties.Resources.User32x32;
            this.btnLogin.Location = new System.Drawing.Point(149, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.LoginCheckButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::FITAnnouncements.Admin.Properties.Resources.Cancel_32;
            this.btnCancel.Location = new System.Drawing.Point(230, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 60);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Izlaz";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.LoginCancelButton_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FITAnnouncements.Admin.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(316, 188);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.PassMaskCheckBox);
            this.Controls.Add(this.WrongUsernameLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FITAnnouncements - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.CheckBox PassMaskCheckBox;
        private System.Windows.Forms.Label WrongUsernameLabel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPassword;
    }
}