using System;
using System.Data.SqlClient;

namespace DemoMsSql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft SQL Server:");
            Console.WriteLine(new string('-', 25));

            SqlConnection dbConn = new SqlConnection
                (
                @"Server=DESKTOP-G29VUF0\SQLEXPRESS;Database=master;Integrated Security=true"
                );
            dbConn.Open();

            using(dbConn)
            {
                SqlCommand command1 = new SqlCommand("CREATE DATABASE MinionsOne", dbConn);
                command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand("USE MinionsOne", dbConn); 
                command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand("CREATE TABLE minions (id INT, name VARCHAR(50), age INT)", dbConn);
                command3.ExecuteNonQuery();

                SqlCommand command4 = new SqlCommand
                    (
                    "INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');" +
                    "INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22');" +
                    "INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42');", dbConn
                    );
                command4.ExecuteNonQuery();

                SqlCommand command5 = new SqlCommand("SELECT name, age FROM minions;", dbConn);
                SqlDataReader reader = command5.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Name: {0}, Age: {1}", reader[0], reader[1]);
                }
            }
        }
    }
}
