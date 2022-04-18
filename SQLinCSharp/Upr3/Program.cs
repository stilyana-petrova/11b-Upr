using System;
using System.Data.SqlClient;

namespace Upr3
{
    class Program
    {
        static void Main(string[] args)
        {
            int villainID = int.Parse(Console.ReadLine());
            
            using(var conn= new SqlConnection(@"Server=DESKTOP-G29VUF0\SQLEXPRESS;Database=Minions;Integrated Security=true"))
            {
                conn.Open();
                SqlCommand sql = new SqlCommand
                    (
                    "SELECT minions.name "+
                    "FROM minionsvillains "+
                    "JOIN minions on minionsvillains.MinionId = minions.id "+
                    $"WHERE minionsvillains.VillainId = @villainID",conn
                    );

                sql.Parameters.AddWithValue("@villainID", villainID);
                var reader = sql.ExecuteReader();

                bool hasNames = false;
                int i = 1;
                while (reader.Read())
                {
                    hasNames = true;
                    Console.WriteLine($"{0}. {1}", i++, reader[0]);
                }
                if (hasNames==false)
                {
                    Console.WriteLine($"No villain with ID {villainID} exists in the database.");
                }
            }
        }
    }
}
