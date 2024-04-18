namespace LibraryManagementSystem
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPswd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 33);
            this.panel1.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonExit.Location = new System.Drawing.Point(340, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 33);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.labelLogin.Location = new System.Drawing.Point(124, 48);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(134, 31);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Giriş Yap";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsername.Location = new System.Drawing.Point(66, 112);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(249, 24);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Kullanıcı Adı...";
            this.textBoxUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUsername_MouseClick);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.Location = new System.Drawing.Point(66, 260);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(249, 61);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(66, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(66, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 1);
            this.panel3.TabIndex = 15;
            // 
            // textBoxPswd
            // 
            this.textBoxPswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.textBoxPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPswd.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPswd.Location = new System.Drawing.Point(66, 182);
            this.textBoxPswd.Name = "textBoxPswd";
            this.textBoxPswd.Size = new System.Drawing.Size(249, 24);
            this.textBoxPswd.TabIndex = 2;
            this.textBoxPswd.Text = "Şifre...";
            this.textBoxPswd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPswd_MouseClick);
            this.textBoxPswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPswd_KeyPress);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(380, 370);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxPswd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxPswd;
    }
}