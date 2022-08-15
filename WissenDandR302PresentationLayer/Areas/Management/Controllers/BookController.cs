using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WissenDandR302BusinessLayer;
using WissenDandR302EntityLayer.Helpers;
using WissenDandR302EntityLayer.ViewModels;

namespace WissenDandR302PresentationLayer.Areas.Management.Controllers
{
    [Area("Management")]
    [Route("b/[Controller]/[Action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IBookGenreService _bookGenreService;
        private readonly IBookPictureService _pictureService;
        private const int pageSize = 5;
        public BookController(IBookService bookService, IAuthorService authorService, IBookGenreService bookGenreService, IBookPictureService pictureService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _bookGenreService = bookGenreService;
            _pictureService = pictureService;
        }



        public IActionResult Index(int? page=1, string search="")
        {
            //Todo sayfalama yapısı eklenecek
            var books = _bookService.GetAll(x => !x.IsDeleted).Data;
            ViewBag.TotalBooks = books.Count; // toplam kitap sayısı
            ViewBag.TotalPages = (int)Math
                .Ceiling(ViewBag.TotalBooks / (double)pageSize); // toplam kaç sayfa olacak
            ViewBag.PageSize = pageSize;

            //frenleme 1. yöntem
            if (page < 1)
            {
                page = 1;
            }
            if (page > ViewBag.TotalPages)
            {
                page = ViewBag.TotalPages;
            }


            ////frenleme 2. yöntem
            //page = page < 1 ? // eğer page küçükse 1den
            //            1 // page' 1 ata
            //            : // değilse
            //            page > ViewBag.TotalPages ? //acaba Büyük mü toplam sayfadan
            //            ViewBag.TotalPages // evetse toplamsayfa neyse onu page'e ata
            //            : // 1 <page <15 page 1den büyük ama toplam sayfa sayıısndan küçükse 
            //            page; //kendi değeri neyse onu page'e ata.



            ViewBag.CurrentPage = page; // Kaçıncı sayfada olduğum bilgisini tutsun


            //Paging 1. Yöntem
            books = books.Skip((page.Value < 1 ? 1 : page.Value-1) * pageSize)
                .Take(pageSize).ToList();
                

            return View(books);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.BookGenres = _bookGenreService.GetAll(x => !x.IsDeleted).Data;
            ViewBag.Authors = _authorService.GetAll(x => !x.IsDeleted).Data;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookViewModel model)
        {
            try
            {
                //Todo aynı kitaptan var mı?

                ViewBag.BookGenres = _bookGenreService.GetAll(x => !x.IsDeleted).Data;
                ViewBag.Authors = _authorService.GetAll(x => !x.IsDeleted).Data;

                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                model.CreatedDate = DateTime.Now;
                var bookResult = _bookService.Add(model);
                if (bookResult.IsSuccess)
                {
                    if (model.Files!=null && model.Files[0] != null)
                    {
                        int pictureResult = 0;
                        foreach (var item in model.Files)
                        {
                            if (item != null && item.ContentType.Contains("image") && item.Length > 0)
                            {
                                //karamazov-kardesler
                                string bookName = Helper.StringCharacterConverter(model.BookName);

                                string extensionName = Path.GetExtension(item.FileName);
                                string guid = Guid.NewGuid().
                                    ToString().Replace("-", "");

                                // .../PresentationLayer/wwwroot/BookPictures
                                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "BookPictures");
                                //karamazovkardesler-guid.jpeg
                                string fileName = bookName + "-" + guid + extensionName;

                                string filePath = Path.Combine(directoryPath, fileName);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                using (var stream = new FileStream(filePath, FileMode.Create))
                                {
                                    item.CopyTo(stream);
                                }
                                BookPictureViewModel picModel = new BookPictureViewModel()
                                {
                                    BookId = bookResult.Data.Id,
                                    CreatedDate = DateTime.Now,
                                    IsDeleted = false,
                                    Picture = $"/BookPictures/{fileName}"
                                };
                                pictureResult = _pictureService.Add(picModel).IsSuccess ?            (pictureResult+1) : pictureResult;

                            }
                        }
                        //pictureResult kontrol edilecek
                        if (pictureResult>0 && 
                            model.Files.Count(x=> x.ContentType.Contains("image"))==pictureResult)
                        {
                            //bütün resimler eklenmiş..
                            TempData["CreateBookSuccessMessage"] = bookResult.Message;
                            return RedirectToAction("Index", "Book");
                        }
                        else if(pictureResult>0 && model.Files.Count !=pictureResult)
                        {
                            TempData["CreateBookWarningMessage"] = "Yeni kitap eklendi. Ancak kitaba ait resimlerden hepsi yüklenemedi! Eklenmeyen resimleri tekrar ekleyiniz!";
                            return RedirectToAction("Index", "Book");
                        }
                        else
                        {
                            TempData["CreateBookWarningMessage"] = "Yeni kitap eklendi. Ancak kitap resimleri eklenemedi! Tekrar deneyiniz!";
                            return RedirectToAction("Index", "Book");
                        }
                    }

                    TempData["CreateBookSuccessMessage"] = bookResult.Message;
                    return RedirectToAction("Index", "Book");
                }
                else
                {
                    ModelState.AddModelError("", "Beklenmedik bir hata oluştu!");
                    return View(model);
                }

                return View();
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Beklenmedik bir hata oluştu!");
                return View();
            }
        }
    }
}
