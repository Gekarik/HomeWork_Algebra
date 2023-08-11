using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Algebra
{
    internal static partial class Database_Service
    {
        static readonly string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        public static DataTable GetDataFromDatabase()
        {
            var dataTable = new DataTable();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using var command = new SqlCommand(Environment.GetEnvironmentVariable("SQLUpload"), connection);
                using SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }
        public static void UpdateDatabase()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using var updateCommand = new SqlCommand(Environment.GetEnvironmentVariable("SQLUpdate"), connection);
                updateCommand.ExecuteNonQuery();
            }

            Console.WriteLine("Значения в базе данных обновлены.");
        }
        public static void ExportDataToTXT(DataTable data, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (DataRow row in data.Rows)
                {
                    writer.WriteLine(row[0]);
                }
            }

            Console.WriteLine("Данные выгружены в CSV файл.");
        }
    }
}
