using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class AddBookPage : Form
    {
        public AddBookPage()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            database.dbConfig db = new database.dbConfig();

            string bookName = textBoxbName.Text;
            string bookAuthor = textBoxbAuthor.Text;
            string bookPublic = textBoxbPublic.Text;
            string bookDate = dateTimePickerbDate.Value.ToString("yyyy-mm-dd");
            string bPriceStr = textBoxbPrice.Text;
            string bQuantityStr = numericUpDownbQuantity.Text;
            int bookPrice;
            int.TryParse(bPriceStr, out bookPrice);
            int bookQuantity;
            int.TryParse(bQuantityStr, out bookQuantity);

            bool bookAdded = db.AddBook(bookName, bookAuthor, bookPublic, bookDate, bookPrice, bookQuantity);

            if (bookAdded)
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
            dateTimePickerbDate.Value = DateTime.Now;
            numericUpDownbQuantity.Value = 0;
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
