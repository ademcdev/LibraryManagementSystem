using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
    }
}