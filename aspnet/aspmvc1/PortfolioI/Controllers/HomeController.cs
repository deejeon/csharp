using Microsoft.AspNetCore.Mvc;

namespace PortfolioPractice {

    public class HomeController : Controller {

        [HttpGet("")]
        public string IndexPage() {
            return "This is my Index!";
        }

        [HttpGet("projects")]
        public string ProjectsPage() {
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string ContactPage() {
            return "This is my Contact!";
        }
    }
}