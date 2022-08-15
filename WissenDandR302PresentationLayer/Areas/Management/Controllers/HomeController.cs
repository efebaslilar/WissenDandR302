using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WissenDandR302PresentationLayer.Areas.Management.Controllers
{
    [Area("Management")]
    [Route("efe/[Controller]/[Action]/{id?}")]
    public class HomeController : Controller
    {
        [Authorize(Roles ="Admin,Author")]
        public IActionResult Index()
        {
            //TODO: LayoutManagement'ı tasarlayıp geri döneceğiz.
            return View();
        }
    }
}
