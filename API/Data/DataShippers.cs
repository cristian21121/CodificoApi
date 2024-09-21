using Microsoft.Data.SqlClient;
using Models;

namespace Data
{
    public class DataShippers
    {
        public static List<Shipper> GetList()
        {
            String query = @"
            SELECT [shipperid]
            ,[companyname]
            FROM [StoreSample].[Sales].[Shippers]
            ";
            List<Shipper> shippers = new List<Shipper>();

            List<object[]> results = SqlProvider.ExecuteReader(query);

            foreach (object[] result in results)
            {
                shippers.Add(new Shipper()
                {
                    Id = Convert.ToInt32(result[0]),
                    CompanyName = Convert.ToString(result[1])!,
                });
            }

            return shippers;
        }
    }
}
