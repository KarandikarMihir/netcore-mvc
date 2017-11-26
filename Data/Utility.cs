using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using netcore_mvc.Models;

namespace netcore_mvc.SQL
{
    public class SqlUtility
    {
        // private readonly string _connString;
        private readonly SqlConnection _conn;
        public SqlUtility(/*IConfiguration config*/)
        {
            // _connString = config.GetConnectionString("DefaultConnection");
            _conn = new SqlConnection("Server=localhost;Database=Employee;User Id=SA;Password=Test_1234;");
        }

        public void Connect()
        {
            _conn.Open();
        }

        public void Disconnect()
        {
            _conn.Close();
        }

        public List<UserModel> GetUsers()
        {
            List<UserModel> Users = new List<UserModel>();
            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, _conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                UserModel u = new UserModel();
                u.id = (int)reader["id"];
                u.name = (string)reader["name"] ;
                u.email = (string)reader["email"];
                Users.Add(u);
            }
            return Users;
        }
    }
}