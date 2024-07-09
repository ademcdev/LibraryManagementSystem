namespace LibraryManagementSystem
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencileriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBookCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMemberCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.borrowBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1301, 70);
            this.menuStripMain.TabIndex = 8;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.showBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(91, 66);
            this.booksToolStripMenuItem.Text = "Kitaplar";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addBookToolStripMenuItem.Image")));
            this.addBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.addBookToolStripMenuItem.Text = "Kitap Ekle";
            this.addBookToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // showBooksToolStripMenuItem
            // 
            this.showBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showBooksToolStripMenuItem.Image")));
            this.showBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showBooksToolStripMenuItem.Name = "showBooksToolStripMenuItem";
            this.showBooksToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.showBooksToolStripMenuItem.Text = "Kitapları Görüntüle";
            this.showBooksToolStripMenuItem.Click += new System.EventHandler(this.showBooksToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudentToolStripMenuItem,
            this.öğrencileriGörüntüleToolStripMenuItem});
            this.studentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsToolStripMenuItem.Image")));
            this.studentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(106, 66);
            this.studentsToolStripMenuItem.Text = "Öğrenciler";
            // 
            // AddStudentToolStripMenuItem
            // 
            this.AddStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddStudentToolStripMenuItem.Image")));
            this.AddStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem";
            this.AddStudentToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.AddStudentToolStripMenuItem.Text = "Öğrenci Ekle";
            this.AddStudentToolStripMenuItem.Click += new System.EventHandler(this.AddStudentToolStripMenuItem_Click);
            // 
            // öğrencileriGörüntüleToolStripMenuItem
            // 
            this.öğrencileriGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrencileriGörüntüleToolStripMenuItem.Image")));
            this.öğrencileriGörüntüleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öğrencileriGörüntüleToolStripMenuItem.Name = "öğrencileriGörüntüleToolStripMenuItem";
            this.öğrencileriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.öğrencileriGörüntüleToolStripMenuItem.Text = "Öğrencileri Görüntüle";
            this.öğrencileriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.öğrencileriGörüntüleToolStripMenuItem_Click);
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrowBookToolStripMenuItem.Image")));
            this.borrowBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(136, 66);
            this.borrowBookToolStripMenuItem.Text = "Kitap Ödünç Ver";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.borrowBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBookToolStripMenuItem.Image")));
            this.returnBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(130, 66);
            this.returnBookToolStripMenuItem.Text = "Kitap Geri Getir";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoSize = false;
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 66);
            this.exitToolStripMenuItem.Text = "Çıkış Yap";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.labelBookCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(62, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 129);
            this.panel2.TabIndex = 9;
            // 
            // labelBookCount
            // 
            this.labelBookCount.AutoSize = true;
            this.labelBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBookCount.Location = new System.Drawing.Point(155, 75);
            this.labelBookCount.Name = "labelBookCount";
            this.labelBookCount.Size = new System.Drawing.Size(23, 31);
            this.labelBookCount.TabIndex = 1;
            this.labelBookCount.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.labelMemberCount);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(62, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 129);
            this.panel4.TabIndex = 10;
            // 
            // labelMemberCount
            // 
            this.labelMemberCount.AutoSize = true;
            this.labelMemberCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMemberCount.Location = new System.Drawing.Point(155, 74);
            this.labelMemberCount.Name = "labelMemberCount";
            this.labelMemberCount.Size = new System.Drawing.Size(23, 31);
            this.labelMemberCount.TabIndex = 3;
            this.labelMemberCount.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(102, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Üye Sayısı";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 733);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(1930, 1040);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencileriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBookCount;
        private System.Windows.Forms.Label labelMemberCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem showBooksToolStripMenuItem;
    }
}

