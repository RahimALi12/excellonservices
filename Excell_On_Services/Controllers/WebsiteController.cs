using Microsoft.AspNetCore.Mvc;

namespace Excell_On_Services.Controllers
{
    public class WebsiteController : Controller
    {

        private readonly ILogger<WebsiteController> _logger;

        public WebsiteController(ILogger<WebsiteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
