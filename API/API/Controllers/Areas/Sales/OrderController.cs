using Data.Orders;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers.Areas.Sales
{
    [ApiController]
    [Route("Order")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult Get(int custid)
        {
            try
            {
                return Ok(DataOrders.GetListByCustomer(custid));
            }
            catch (Exception)
            {
                return StatusCode(500, MessageConst.OrdersGetListByCustomerError);
            }
        }
    }
}
