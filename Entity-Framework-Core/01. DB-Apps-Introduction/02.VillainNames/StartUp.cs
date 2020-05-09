using System;
using Microsoft.Data.SqlClient;

namespace _02.VillainNames
{
    class StartUp
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=MinionsDB;Integrated Security=True";

        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string selectCommand =
                    "SELECT v.Name, COUNT(*) AS Count FROM MinionsVillains mv " +
                    "JOIN Villains v ON v.Id = mv.VillainId GROUP BY v.Id, v.Name " +
                    "HAVING COUNT(*) > 3 ORDER BY Count DESC";

                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} - {reader[1]}");
                        }
                    }

                }

                connection.Close();
            }
        }
    }
}
