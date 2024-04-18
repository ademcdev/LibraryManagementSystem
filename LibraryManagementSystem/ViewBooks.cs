using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class ViewBooks : Form
    {
        private database.dbConfig db;
        private DataTable dataTable;

        public ViewBooks()
        {
            InitializeComponent();
            db = new database.dbConfig();
        }

        private void dataGridViewBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewBook.Columns[e.ColumnIndex].Name == "bookDate")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("yyyy-MM-dd");
                    e.FormattingApplied = true;
                }
            }
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBook.Rows[e.RowIndex];

                textBoxBookId.Text = row.Cells["bookId"].Value.ToString();
                textBoxbName.Text = row.Cells["bookName"].Value.ToString();
                textBoxbAuthor.Text = row.Cells["bookAuthor"].Value.ToString();
                textBoxbPublic.Text = row.Cells["bookPublic"].Value.ToString();
                dateTimePickerbDate.Text = row.Cells["bookDate"].Value.ToString();
                textBoxbPrice.Text = row.Cells["bookPrice"].Value.ToString();
                numericUpDownbQuantity.Text = row.Cells["bookQuantity"].Value.ToString();

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxBookId.Text))
            {
                int bookId = int.Parse(textBoxBookId.Text);
                string updatedbName = textBoxbName.Text;
                string updatedbAuthor = textBoxbAuthor.Text;
                string updatedbPublic = textBoxbPublic.Text;
                string updatedbDate = dateTimePickerbDate.Value.ToString("yyyy-MM-dd");
                string bPriceStr = textBoxbPrice.Text;
                string bQuantityStr = numericUpDownbQuantity.Text;

                int.TryParse(bPriceStr, out int updatedbPrice);
                int.TryParse(bQuantityStr, out int updatedbQuantity);

                bool bookUpdated = db.UpdateBook(bookId, updatedbName, updatedbAuthor, updatedbPublic, updatedbDate, updatedbPrice, updatedbQuantity);

                if (bookUpdated)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Veri Güncellendi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Veri güncellerken bir hata meydana geldi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBoxBookId.Text);

            bool bookDeleted = db.DeleteBook(bookId);

            if (bookDeleted)
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
            dataTable = db.GetBook();
            dataGridViewBook.DataSource = dataTable;
        }
    }
}