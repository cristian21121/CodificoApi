using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers.Areas.Production
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            try
            {
                return Ok(DataProducts.GetList());
            }
            catch (Exception)
            {
                return StatusCode(500, MessageConst.ProductsGetListError);
            }
        }
    }
}
