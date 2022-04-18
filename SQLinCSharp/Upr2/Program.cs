using System;
using System.Data.SqlClient;

namespace Upr2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var conn = new SqlConnection(@"Server=DESKTOP-G29VUF0\SQLEXPRESS;Database=Minions;Integrated Security=true"))
            {
                conn.Open();

                SqlCommand command1 = new SqlCommand
                    (
                    "SELECT V.Name, COUNT(MV.VillainId) "+
                    "FROM Villains as V "+
                    "JOIN MinionsVillains AS MV on MV.VillainId=V.Id "+
                    "GROUP BY MV.VillainId, V.Name "+
                    "HAVING COUNT(MV.VillainId) > 3", conn
                    );
                var reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} -> {reader[1]}");
                }
            }
        }
    }
}
