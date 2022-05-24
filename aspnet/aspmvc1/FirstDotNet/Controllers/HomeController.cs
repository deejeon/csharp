using Microsoft.AspNetCore.Mvc;

namespace HelloASP
{

    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [Route("")]
        [HttpGet]
        public string HelloFromController()
        {
            return "Hello From Controller";
        }

        //localhost:5000/hello
        [Route("hello")]
        [HttpGet]

        public RedirectToActionResult Hello() {
            return RedirectToAction("HelloFromController");
        }
    }
}