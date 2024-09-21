using Data;
using Microsoft.Data.SqlClient;
using Models;

namespace Data
{
    public class DataEmployees
    {
        public static List<Employee> GetList()
        {
            String query = @"
            SELECT [empid],
            CONCAT(firstname, ' ', lastname) AS fullname
            FROM [HR].[Employees]
            ";
            List<Employee> employees = new List<Employee>();

            List<object[]> results = SqlProvider.ExecuteReader(query);

            foreach (object[] result in results)
            {
                employees.Add(new Employee()
                {
                    Id = Convert.ToInt32(result[0]),
                    FullName = Convert.ToString(result[1])!
                });
            }

            return employees;
        }
    }
}