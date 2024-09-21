using Microsoft.Data.SqlClient;
using Models;

namespace Data.Orders
{
    public class DataOrders
    {
        public static List<Order> GetListByCustomer(int custid)
        {
            String query = @"
            SELECT [orderid]
            ,[requireddate]
            ,[shippeddate]
            ,[shipname]
            ,[shipaddress]
            ,[shipcity]
            FROM [Sales].[Orders] 
            WHERE custid = @custid
            ";
            List<Order> orders = new List<Order>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@custid",  custid }
            };
            List<object[]> results = SqlProvider.ExecuteReader(query, parameters);

            foreach (object[] result in results)
            {
                orders.Add(new Order()
                {
                    Id = Convert.ToInt32(result[0]),
                    DateRequired = Convert.ToDateTime(result[1]),
                    DateShipped = Convert.ToDateTime(result[2]),
                    ShipName = Convert.ToString(result[3])!,
                    ShipAddress = Convert.ToString(result[4])!,
                    ShipCity = Convert.ToString(result[5])!,
                });
            }

            return orders;
        }
    }
}
