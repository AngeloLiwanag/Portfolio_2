using Microsoft.AspNetCore.Mvc;
namespace Home
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [Route("/projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet]
        [Route("/contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}