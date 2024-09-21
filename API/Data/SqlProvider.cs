using Microsoft.Data.SqlClient;

namespace Data
{
    public class SqlProvider
    {
        public static List<object[]> ExecuteReader(string query, Dictionary<string, object>? parameters = null)
        {
            string connectionString = "Server=CRISTIAN\\SQLEXPRESS; Database=StoreSample; Trusted_Connection=True; TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        List<object[]> results = new List<object[]>();

                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            reader.GetValues(row);
                            results.Add(row);
                        }

                        return results;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error en la base de datos: {ex.Message}");
                    }
                }
            }
        }
    }
}
