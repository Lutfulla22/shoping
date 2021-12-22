using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shop.ViewModels;

namespace shop.Controllers
{
    [Route("[controller]")]
    public class CarsController : Controller
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("car")]
        public IActionResult Car()
        {
            return View();
        }

        [HttpPost("car")]
        public IActionResult Car(NewCarViewModel model)
        {
            return Ok();
        }
    }
}