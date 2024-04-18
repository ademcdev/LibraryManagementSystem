using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            database.dbConfig db = new database.dbConfig();
            DataTable dataTable = db.GetStudent();

            dataGridViewStudent.DataSource = dataTable;
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];

                textBoxNumber.Text = row.Cells["studentNo"].Value.ToString();
                textBoxName.Text = row.Cells["studentName"].Value.ToString();
                textBoxSurname.Text = row.Cells["studentSurname"].Value.ToString();
                textBoxBolum.Text = row.Cells["studentSection"].Value.ToString();
                textBoxTel.Text = row.Cells["studentPhone"].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
