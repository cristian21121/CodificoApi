using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers.Areas.Sales
{
    [ApiController]
    [Route("Shipper")]
    public class ShipperController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            try
            {
                return Ok(DataShippers.GetList());
            }
            catch (Exception)
            {
                return StatusCode(500, MessageConst.ShippersGetListError);
            }
        }
    }
}
