using System.Web.Mvc;
using FibCalculator;
using NextFib.Models;

namespace NextFib.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new FibViewModel {SequenceNumber = 1});
        }

        [HttpPost]
        public ActionResult Index(FibViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.FibNumber = Benet.NthNumber(model.SequenceNumber);
            }
            else
            {
                model.FibNumber = 0;
            }

            return View(model);
        }      
    }
}