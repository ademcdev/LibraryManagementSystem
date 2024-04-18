using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace LibraryManagementSystem.database
{
    internal class dbConfig
    {

        public void startConn()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=librarysystemdb;Username=root;Password="))
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void endConn()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=librarysystemdb;Username=root;Password="))
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public MySqlConnection GetConn()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=librarysystemdb;Username=root;Password="))
            {
                try
                {
                    return connection;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public bool AddBook(string bookName, string bookAuthor, string bookPublic, string bookDate, int bookPrice, int bookQuantity)
        {
            string query = "INSERT INTO books (bookName, bookAuthor, bookPublic, bookDate, bookPrice, bookQuantity) VALUES (@bookName, @bookAuthor, @bookPublic, @bookDate, @bookPrice, @bookQuantity)";
            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@bookName", bookName);
                    cmd.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                    cmd.Parameters.AddWithValue("@bookPublic", bookPublic);
                    cmd.Parameters.AddWithValue("@bookDate", bookDate);
                    cmd.Parameters.AddWithValue("@bookPrice", bookPrice);
                    cmd.Parameters.AddWithValue("@bookQuantity", bookQuantity);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }


        public DataTable GetBook()
        {
            string query = "SELECT bookName, bookAuthor, bookPublic, bookDate, bookPrice, bookQuantity FROM books";
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = GetConn())
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataTable.Columns.Add("ParsedDate", typeof(DateTime));

            foreach (DataRow row in dataTable.Rows)
            {
                DateTime parsedDate;
                if (DateTime.TryParseExact(row["bookDate"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    row["ParsedDate"] = parsedDate;
                }
                else
                {
                    row["ParsedDate"] = DateTime.MinValue;
                }
            }

            dataTable.Columns.Remove("bookDate");

            dataTable.Columns["ParsedDate"].ColumnName = "bookDate";

            return dataTable;
        }

        public bool AddStudent(int studentNo, string studentName, string studentSurname, string studentSection, int studentPhone)
        {
            string query = "INSERT INTO students (studentNo, studentName, studentSurname, studentSection, studentPhone) VALUES (@studentNo, @studentName, @studentSurname, @studentSection, @studentPhone)";
            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@studentNo", studentNo);
                    cmd.Parameters.AddWithValue("@studentName", studentName);
                    cmd.Parameters.AddWithValue("@studentSurname", studentSurname);
                    cmd.Parameters.AddWithValue("@studentSection", studentSection);
                    cmd.Parameters.AddWithValue("@studentPhone", studentPhone);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
    }
}