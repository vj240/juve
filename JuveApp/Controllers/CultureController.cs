using System.Web.Mvc;
using JuveApp.Core;
using JuveApp.Models;

namespace JuveApp.Controllers
{
    public class CultureController : Controller
    {
        public ActionResult Index()
        {
            var model = new CultureModel();
            model.Culture = (string) HttpContext.Session[Constants.SessionKeys.CurrentCulture] ?? Constants.DefaultCulture;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string culture)
        {
            HttpContext.Session[Constants.SessionKeys.CurrentCulture] = culture;
            return new EmptyResult();
        }
    }
}
