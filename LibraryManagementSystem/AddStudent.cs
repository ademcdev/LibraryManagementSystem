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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            database.dbConfig db = new database.dbConfig();

            string studentNostr = textBoxNumber.Text;
            string studentName = textBoxName.Text;
            string studentSurname = textBoxSurname.Text;
            string studentSection = textBoxBolum.Text;
            string studentPhonestr = textBoxTel.Text;
            long.TryParse(studentNostr, out long studentNo);
            long.TryParse(studentPhonestr, out long studentPhone);

            bool studentAdded = db.AddStudent(studentNo, studentName, studentSurname, studentSection, studentPhone);

            if (studentAdded)
            {
                clearInputs();
                MessageBox.Show("Veri kaydedildi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kitap eklerken bir hata meydana geldi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearInputs()
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
            }
        }
    }
}
