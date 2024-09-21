using Microsoft.Data.SqlClient;
using Models;
using System.Reflection.PortableExecutable;

namespace Data
{
    public class DataProducts
    {
        public static List<Product> GetList()
        {
            String query = @"
            SELECT [productid]
            ,[productname]
            FROM [Production].[Products]";
            List<Product> products = new List<Product>();

            List<object[]> results = SqlProvider.ExecuteReader(query);

            foreach (object[] result in results)
            {
                products.Add(new Product()
                {
                    Id = Convert.ToInt32(result[0]),
                    ProductName = Convert.ToString(result[1])!,
                });
            }

            return products;
        }
    }
}
