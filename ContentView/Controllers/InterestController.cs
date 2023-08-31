using Microsoft.AspNetCore.Mvc;
using ContentView.Models;
using System.Text;
using System.Reflection;

namespace ContentView.Controllers
{
    public class InterestController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(InterstModel im)
        {
            decimal simpleInterst = (im.Amount * im.Year * im.Rate) / 100;

            StringBuilder sbInterst= new StringBuilder();
            sbInterst.Append("Amount :" + im.Amount + "\n");
            sbInterst.Append("Rate :" + im.Rate + "\n");
            sbInterst.Append("Time(year) :" + im.Year + "\n");
            sbInterst.Append("Interest :" + simpleInterst);

            return Content(sbInterst.ToString());
        }
    }
}
