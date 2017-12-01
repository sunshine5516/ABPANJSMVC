using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPARJS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPARJSControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}