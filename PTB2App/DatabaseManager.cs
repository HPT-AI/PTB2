using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PTB2App_New
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task InitializeDatabaseAsync()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                string createDbQuery = @"
                    IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PTB2DB')
                    CREATE DATABASE PTB2DB";
                
                using (SqlCommand command = new SqlCommand(createDbQuery, connection))
                {
                    await command.ExecuteNonQueryAsync();
                }
            }

            string dbConnectionString = _connectionString.Replace("Database=master", "Database=PTB2DB");
            
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                await connection.OpenAsync();

                string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PhuongTrinhBac2')
                    CREATE TABLE PhuongTrinhBac2 (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        A FLOAT NOT NULL,
                        B FLOAT NOT NULL,
                        C FLOAT NOT NULL,
                        KetQua NVARCHAR(MAX) NOT NULL,
                        NgayGiai DATETIME NOT NULL
                    )";
                
                using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                {
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task SaveEquationAsync(double a, double b, double c, string result)
        {
            string dbConnectionString = _connectionString.Replace("Database=master", "Database=PTB2DB");
            
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                await connection.OpenAsync();

                string insertQuery = @"
                    INSERT INTO PhuongTrinhBac2 (A, B, C, KetQua, NgayGiai)
                    VALUES (@A, @B, @C, @KetQua, @NgayGiai)";
                
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@A", a);
                    command.Parameters.AddWithValue("@B", b);
                    command.Parameters.AddWithValue("@C", c);
                    command.Parameters.AddWithValue("@KetQua", result);
                    command.Parameters.AddWithValue("@NgayGiai", DateTime.Now);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<DataTable> GetHistoryAsync()
        {
            string dbConnectionString = _connectionString.Replace("Database=master", "Database=PTB2DB");
            DataTable dataTable = new DataTable();
            
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                await connection.OpenAsync();

                string selectQuery = "SELECT * FROM PhuongTrinhBac2 ORDER BY NgayGiai DESC";
                
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            
            return dataTable;
        }

        public async Task DeleteEquationAsync(int id)
        {
            string dbConnectionString = _connectionString.Replace("Database=master", "Database=PTB2DB");
            
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                await connection.OpenAsync();

                string deleteQuery = "DELETE FROM PhuongTrinhBac2 WHERE Id = @Id";
                
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
