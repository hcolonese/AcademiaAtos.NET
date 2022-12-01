using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace primeiroMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //get: /HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
        public string Soma2Valores(int n1= 0,int n2= 0)
        {
            return "A soma dos 2 valores digitados foi " + (n1 + n2);
        }
    }
}
