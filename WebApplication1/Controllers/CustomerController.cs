using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("customers/{action}/{id?}")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Route("test/export")]
        public IActionResult Test()
        {
            return View();
        }
    }
}
