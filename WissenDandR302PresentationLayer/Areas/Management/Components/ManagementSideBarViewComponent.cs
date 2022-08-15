using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WissenDandR302BusinessLayer;
using WissenDandR302EntityLayer.AllEnums;
using WissenDandR302EntityLayer.IdentityModels;

namespace WissenDandR302PresentationLayer.Areas.Management.Components
{
    public class ManagementSideBarViewComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBookService _bookService;

        public ManagementSideBarViewComponent(UserManager<AppUser> userManager, IBookService bookService)
        {
            _userManager = userManager;
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            try
            {
                var user = _userManager.FindByNameAsync(User.Identity?.Name).Result;

                ViewBag.BookCount = _bookService.GetAll(x => !x.IsDeleted && x.CreatedDate > DateTime.Now.AddMonths(-1)).Data.Count;

                if (_userManager.IsInRoleAsync(user,AllRoles.Admin.ToString()).Result)
                {
                    return View("AdminDefault");
                }

                if (_userManager.IsInRoleAsync(user, AllRoles.Author.ToString()).Result)
                {
                    return View("AuthorDefault");
                }

                return View();
            }
            catch (Exception)
            {
                // ex log
                return View();
              
            }
           
        }
    }
}
