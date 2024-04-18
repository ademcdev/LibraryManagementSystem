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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
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
            database.dbConfig db = new database.dbConfig();
            DataTable dataTable = db.GetBook();

            dataGridViewBook.DataSource = dataTable;
        }
    }
}