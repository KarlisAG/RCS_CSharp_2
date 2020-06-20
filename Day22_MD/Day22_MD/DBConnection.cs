using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Day22_MD
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
            database = "ofice";
            user = "root";
            password = "Students!Programme";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; " +
                "SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                connection.Open();

                Console.WriteLine("Success");

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public MySqlDataAdapter GetEmployees()
        {
            string stm = "SELECT * FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            return dataAdapter;
        }

        public void AddEmployees(String name, String surname, String departmentID, String salary, String jobID)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO employees(employeeName, employeeLastName, departmentID, salary, jobID) VALUES(@employeeName, @employeeLastName, @departmentID, @salary, @jobID)";
                
                cmd.Parameters.AddWithValue("@employeeName", $"{name}");
                cmd.Parameters.AddWithValue("@employeeLastName", $"{surname}");
                cmd.Parameters.AddWithValue("@departmentID", $"{departmentID}");
                cmd.Parameters.AddWithValue("@salary", $"{salary}");
                cmd.Parameters.AddWithValue("@jobID", $"{jobID}");
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void DeleteEmployees(int ID)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = $"DELETE FROM employees WHERE employeeID= {ID};";
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public MySqlDataAdapter MinMaxSalary(String jobID)
        {
            string stm = "SELECT minSalary, maxSalary " + 
                         "FROM employees " +
                         "INNER JOIN jobs " +
                         "ON jobs.jobId = employees.jobId " +
                         $"WHERE jobs.jobId = {jobID};";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            return dataAdapter;
        }

    }
}