using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer;
using WissenDandR302EntityLayer.Models;
using WissenDandR302EntityLayer.ViewModels;

namespace WissenDandR302BusinessLayer.Implementations
{
    public class BookPictureService : Service<BookPictureViewModel, BookPicture, int>, IBookPictureService
    {
        public BookPictureService(IMapper mapper, IBookPictureRepo repo) : base(mapper, repo,"Book")
        {
        }
    }
}
