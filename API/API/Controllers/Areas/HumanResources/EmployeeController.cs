using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers.Areas.HumanResources
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            try
            {
                return Ok(DataEmployees.GetList());
            }
            catch (Exception)
            {
                return StatusCode(500, MessageConst.EmployeesGetListError);
            }
        }
    }
}
