using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;

namespace JuveApp.Core
{
    public abstract class BaseController : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            var ci = GetCurrentCulture(requestContext);
            SetCulture(ci);
        }

        private static void SetCulture(CultureInfo ci)
        {
            if (ci == null)
                return;

            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        private static CultureInfo GetCurrentCulture(RequestContext requestContext)
        {
            string culture;

            if (requestContext.HttpContext.Session == null)
                return null;

            if (requestContext.HttpContext.Session[Constants.SessionKeys.CurrentCulture] == null)
            {
                culture = Constants.DefaultCulture;
                requestContext.HttpContext.Session[Constants.SessionKeys.CurrentCulture] = culture;
            }
            else
            {
                culture = (string) requestContext.HttpContext.Session[Constants.SessionKeys.CurrentCulture];
            }

            var ci = CultureInfo.GetCultureInfo(culture);
            return ci;
        }


    }
}