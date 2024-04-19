using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{

    public partial class ViewStudent : Form
    {
        private database.dbConfig db;
        private DataTable dataTable;

        public ViewStudent()
        {
            InitializeComponent();
            db = new database.dbConfig();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {

            RefreshDataGridView();
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];

                textBoxId.Text = row.Cells["id"].Value.ToString();
                textBoxNumber.Text = row.Cells["studentNo"].Value.ToString();
                textBoxName.Text = row.Cells["studentName"].Value.ToString();
                textBoxSurname.Text = row.Cells["studentSurname"].Value.ToString();
                textBoxBolum.Text = row.Cells["studentSection"].Value.ToString();
                textBoxTel.Text = row.Cells["studentPhone"].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            long updatedStudentNo = long.Parse(textBoxNumber.Text);
            string updatedName = textBoxName.Text;
            string updatedSurname = textBoxSurname.Text;
            string updatedBolum = textBoxBolum.Text;
            long studentPhone = long.Parse(textBoxTel.Text);

            bool StudentUpdated = db.UpdateStudent(id, updatedStudentNo, updatedName, updatedSurname, updatedBolum, studentPhone);
            if (StudentUpdated)
            {
                RefreshDataGridView();
                MessageBox.Show("Öğrenci Güncellendi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci güncellenirken bir hata meydana geldi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);

            bool StudentDeleted = db.DeleteStudent(id);

            if (StudentDeleted)
            {
                RefreshDataGridView();
                MessageBox.Show("Veri Silinti!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri Silerken bir hata meydana geldi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshDataGridView()
        {
            dataTable = db.GetStudent();
            dataGridViewStudent.DataSource = dataTable;
        }
    }
}
