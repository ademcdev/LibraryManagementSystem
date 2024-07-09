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
using System.Net;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using LibraryManagementSystem.helpers;

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
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=librarysystemdb;Username=root;Password=; convert zero datetime=True"))
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
            string query = "SELECT * FROM books";
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

            return dataTable;
        }

        public bool AddStudent(long studentNo, string studentName, string studentSurname, string studentSection, long studentPhone)
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

        public DataTable GetStudent()
        {
            string query = "SELECT * FROM students";
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
            return dataTable;
        }

        public bool UpdateBook(int bookId, string bookName, string bookAuthor, string bookPublic, string bookDate, int bookPrice, int bookQuantity)
        {
            string query = "UPDATE books SET bookName = @bookName, bookAuthor = @bookAuthor, bookPublic = @bookPublic, bookDate = @bookDate, bookPrice = @bookPrice, bookQuantity = @bookQuantity WHERE bookId = @bookId";

            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
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
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }

        }

        public bool DeleteBook(int bookId)
        {
            string query = "DELETE FROM books WHERE bookId = @bookId";

            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public bool UpdateStudent(int id, long studentNo, string studentName, string studentSurname, string studentSection, long studentPhone)
        {
            string query = "UPDATE students SET studentNo = @studentNo, studentName = @studentName, studentSurname = @studentSurname, studentSection = @studentSection, studentPhone = @studentPhone WHERE id = @id";

            try
            {
                using (MySqlConnection connection = GetConn())

                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public bool DeleteStudent(int id)
        {
            string query = "DELETE FROM students WHERE id = @id";

            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public int GetTotalBookCount()
        {
            string query = "SELECT COUNT(*) FROM books";
            int totalBooks;

            using (MySqlConnection connection = GetConn())
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    totalBooks = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return totalBooks;
        }

        public int GetTotalStudentCount()
        {
            string query = "SELECT COUNT(*) FROM students";
            int totalStudents;

            using (MySqlConnection connection = GetConn())
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    totalStudents = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return totalStudents;
        }

        public bool BorrowBook(int studentId, int bookId, DateTime borrowDate, DateTime returnDate)
        {
            string borrowQuery = "INSERT INTO borrow (studentId, bookId, borrowDate, returnDate) VALUES (@studentId, @bookId, @borrowDate, @returnDate)";
            string checkAvailabilityQuery = "SELECT isAvailable FROM books WHERE bookId = @bookId";
            string updateBookQuery = "UPDATE books SET isAvailable = FALSE WHERE bookId = @bookId";

            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    MySqlCommand checkCmd = new MySqlCommand(checkAvailabilityQuery, connection);
                    checkCmd.Parameters.AddWithValue("@bookId", bookId);
                    bool isAvailable = Convert.ToBoolean(checkCmd.ExecuteScalar());

                    if (!isAvailable)
                    {
                        MessageBox.Show("Seçilen oyun şu anda alınabilir değil!");
                        return false;
                    }

                    MySqlCommand borrowCmd = new MySqlCommand(borrowQuery, connection);
                    borrowCmd.Parameters.AddWithValue("@studentId", studentId);
                    borrowCmd.Parameters.AddWithValue("@bookId", bookId);
                    borrowCmd.Parameters.AddWithValue("@borrowDate", borrowDate);
                    borrowCmd.Parameters.AddWithValue("@returnDate", returnDate);

                    int rowsAffected = borrowCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MySqlCommand updateCmd = new MySqlCommand(updateBookQuery, connection);
                        updateCmd.Parameters.AddWithValue("@bookId", bookId);
                        updateCmd.ExecuteNonQuery();
                    }

                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable GetAvailableBook()
        {
            string query = "SELECT bookId, bookName, bookAuthor, bookPublic, bookDate, bookPrice, bookQuantity FROM books WHERE isAvailable = TRUE";
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

            return dataTable;
        }

        public bool ReturnBook(int bookId, int borrowId)
        {
            string updateQuery = "UPDATE books SET isAvailable = TRUE WHERE bookId = @bookId";
            string deleteQuery = "DELETE FROM borrow WHERE borrowId = @borrowId";

            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@bookId", bookId);

                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@borrowId", borrowId);

                    int updateRowsAffected = updateCmd.ExecuteNonQuery();
                    int deleteRowsAffected = deleteCmd.ExecuteNonQuery();

                    return updateRowsAffected > 0 && deleteRowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable GetBorrowedBook()
        {
            string query = @"
                        SELECT 
                            b.borrowId,
                            bk.bookId,
                            st.studentId,
                            st.studentName,
                            st.studentSurname,
                            bk.bookName,
                            b.borrowDate,
                            b.returnDate
                        FROM 
                            borrow b
                        JOIN 
                            students st ON b.studentId = st.studentId
                        JOIN 
                            books bk ON b.bookId = bk.bookId";
            DataTable dataTable = new DataTable();

            try
            {
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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public bool AddManager(string managerName, string managerSurname, string managerPhone, string managerEmail, string managerPassword)
        {
            string query = "INSERT INTO manager (managerName, managerSurname, managerPhone, managerEmail, managerPassword) VALUES (@managerName, @managerSurname, @managerPhone, @managerEmail, @managerPassword)";
            string hashedPassword = PasswordHelper.HashPassword(managerPassword);
            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@managerName", managerName);
                    cmd.Parameters.AddWithValue("@managerSurname", managerSurname);
                    cmd.Parameters.AddWithValue("@managerPhone", managerPhone);
                    cmd.Parameters.AddWithValue("@managerEmail", managerEmail);
                    cmd.Parameters.AddWithValue("@managerPassword", hashedPassword);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public bool ValidateManager(string managerEmail, string managerPassword)
        {
            string query = "SELECT managerPassword FROM manager WHERE managerEmail = @managerEmail";
            string hashedPassword = PasswordHelper.HashPassword(managerPassword);
            try
            {
                using (MySqlConnection connection = GetConn())
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@managerEmail", managerEmail);

                    string storedHashedPassword = cmd.ExecuteScalar()?.ToString();

                    if (storedHashedPassword == null)
                    {
                        return false;
                    }

                    return storedHashedPassword == hashedPassword;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}