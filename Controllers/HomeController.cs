using System.Web.Mvc;
using Services;
using ServiceStack.Mvc;
using TestServiceStack.Models.Home;

namespace TestServiceStack.Controllers
{
    public class HomeController : ServiceStackController
    {
        public ActionResult Index()
        {
            var response = Gateway.Send<TestServiceResponse>(new TestServiceRequest());
            IndexModel model = new IndexModel { Message = response.Message };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}