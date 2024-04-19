namespace LibraryManagementSystem
{
    partial class ViewStudent
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
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelpNumber = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelStudentNumber = new System.Windows.Forms.Label();
            this.labelBolum = new System.Windows.Forms.Label();
            this.labelSutendtSurname = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(12, 79);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(1102, 350);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.textBoxTel);
            this.panel1.Controls.Add(this.labelpNumber);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.textBoxNumber);
            this.panel1.Controls.Add(this.textBoxBolum);
            this.panel1.Controls.Add(this.textBoxSurname);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelStudentNumber);
            this.panel1.Controls.Add(this.labelBolum);
            this.panel1.Controls.Add(this.labelSutendtSurname);
            this.panel1.Controls.Add(this.labelStudentName);
            this.panel1.Location = new System.Drawing.Point(12, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 314);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.Location = new System.Drawing.Point(512, 209);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 63);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTel.Location = new System.Drawing.Point(752, 78);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(327, 35);
            this.textBoxTel.TabIndex = 37;
            // 
            // labelpNumber
            // 
            this.labelpNumber.AutoSize = true;
            this.labelpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelpNumber.Location = new System.Drawing.Point(539, 81);
            this.labelpNumber.Name = "labelpNumber";
            this.labelpNumber.Size = new System.Drawing.Size(140, 29);
            this.labelpNumber.TabIndex = 36;
            this.labelpNumber.Text = "Telefon No:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCancel.Location = new System.Drawing.Point(680, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 63);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "İptal Et";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.Location = new System.Drawing.Point(348, 209);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(127, 63);
            this.buttonUpdate.TabIndex = 34;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNumber.Location = new System.Drawing.Point(185, 21);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(327, 35);
            this.textBoxNumber.TabIndex = 33;
            // 
            // textBoxBolum
            // 
            this.textBoxBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBolum.Location = new System.Drawing.Point(440, 133);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(327, 35);
            this.textBoxBolum.TabIndex = 30;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSurname.Location = new System.Drawing.Point(752, 21);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(327, 35);
            this.textBoxSurname.TabIndex = 28;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxName.Location = new System.Drawing.Point(185, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(327, 35);
            this.textBoxName.TabIndex = 26;
            // 
            // labelStudentNumber
            // 
            this.labelStudentNumber.AutoSize = true;
            this.labelStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStudentNumber.Location = new System.Drawing.Point(22, 24);
            this.labelStudentNumber.Name = "labelStudentNumber";
            this.labelStudentNumber.Size = new System.Drawing.Size(143, 29);
            this.labelStudentNumber.TabIndex = 32;
            this.labelStudentNumber.Text = "Öğrenci No:";
            // 
            // labelBolum
            // 
            this.labelBolum.AutoSize = true;
            this.labelBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBolum.Location = new System.Drawing.Point(340, 133);
            this.labelBolum.Name = "labelBolum";
            this.labelBolum.Size = new System.Drawing.Size(94, 29);
            this.labelBolum.TabIndex = 31;
            this.labelBolum.Text = "Bölüm: ";
            // 
            // labelSutendtSurname
            // 
            this.labelSutendtSurname.AutoSize = true;
            this.labelSutendtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSutendtSurname.Location = new System.Drawing.Point(539, 24);
            this.labelSutendtSurname.Name = "labelSutendtSurname";
            this.labelSutendtSurname.Size = new System.Drawing.Size(207, 29);
            this.labelSutendtSurname.TabIndex = 29;
            this.labelSutendtSurname.Text = "Öğrerenci Soyadı:";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStudentName.Location = new System.Drawing.Point(19, 81);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(146, 29);
            this.labelStudentName.TabIndex = 27;
            this.labelStudentName.Text = "Öğrenci Adı:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 73);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(341, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrencileri Görüntüle";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxId.Location = new System.Drawing.Point(14, 264);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(126, 35);
            this.textBoxId.TabIndex = 39;
            this.textBoxId.Visible = false;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 801);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewStudent);
            this.Name = "ViewStudent";
            this.Text = "ViewStıdent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelpNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelStudentNumber;
        private System.Windows.Forms.Label labelBolum;
        private System.Windows.Forms.Label labelSutendtSurname;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
    }
}
