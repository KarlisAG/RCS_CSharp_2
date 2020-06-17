using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Day21_MD
{

    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        public DBConnection()
        {
            server = "127.0.0.1";
            database = "university";
            user = "root";
            password = "Students!Programme";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; " +
                "SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
        }

        public bool Connect()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public void GetEmployees()
        {
            string stm = "SELECT * FROM students";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            Console.WriteLine("ID| Vards  | Uzvards  | Kurss");
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(row.Field<int>(0) + " | " + row.Field<String>(1) + " | " + row.Field<String>(2) + " | " + row.Field<int>(3));
            }
        }

        public void AddStudent()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();

                Console.WriteLine("Ievadiet studenta vardu!");
                String name = Console.ReadLine();
                Console.WriteLine("Ievadiet studenta uzvardu!");
                String surname = Console.ReadLine();
                Console.WriteLine("Ievadiet studenta kursu!");
                try
                {
                    int course = Convert.ToInt32(Console.ReadLine());

                    if (course < 1 || course > 3)
                    {
                        Console.WriteLine("Ievaditajam ciparam bija jabut no 1 lidz 3!");
                    }
                    else
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO students (studentName, studentSurname, studentCourse) VALUES(@studentName, @studentSurname, @studentCourse)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@studentName", $"{name}");
                        cmd.Parameters.AddWithValue("@studentSurname", $"{surname}");
                        cmd.Parameters.AddWithValue("@studentCourse", course);
                        
                        cmd.ExecuteNonQuery();
                    }  
                }
                catch (Exception e)
                {
                    Console.WriteLine("Jums ir jaievada cipars!" + e.Message);
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void DeleteStudent()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                Console.WriteLine("Lai dzestu studentus Jums ir jaizveltas tos dzest vai nu pec ID (1), ");
                Console.WriteLine("vai nu varda/uzvarda (2), ");
                Console.WriteLine("vai nu kursa (3) ");
                Console.WriteLine("[tiks dzesti VISI studenti, kuriem ievadita informacija sakritis]");
                    

                String choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Ievadiet studenta ID numuru, kuru velaties izdzest no datubazes");
                        try
                        {
                            int deleteID = Convert.ToInt32(Console.ReadLine());
                            cmd.CommandText = $"DELETE FROM students WHERE studentId = {deleteID};";
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Jums bija jaievada cipars!" + e.Message);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ievadiet studenta vardu VAI uzvardu, kuru velaties izdzest no datubazes [tiks izdzesti VISI studenti ar ievadito vardu/uzvardu!!]");
                        String deleteChoice = Console.ReadLine();
                        cmd.CommandText = $"DELETE FROM students WHERE studentName = '{deleteChoice}' OR studentSurname = '{deleteChoice}';";
                        cmd.ExecuteNonQuery();
                        break;
                    case "3":
                        Console.WriteLine("Ievadiet studenta kursu, kuru velaties izdzest no datubazes [tiks izdzesti VISI studenti ar ievadito kursu!!]");

                        try
                        {
                            int deleteCourse = Convert.ToInt32(Console.ReadLine());

                            if (deleteCourse < 1 || deleteCourse > 3)
                            {
                                Console.WriteLine("Ievaditajam kursam bija jabut no 1 lidz 3!");
                            }
                            else
                            {
                                cmd.CommandText = $"DELETE FROM students WHERE studentCourse = {deleteCourse};";
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Jums ir jaievada cipars!" + e.Message);
                        }

                        break;
                    default:
                        Console.WriteLine("Jums bija jaievada kads no cipariem (1, 2 vai 3)");
                        break;
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }
    }
}