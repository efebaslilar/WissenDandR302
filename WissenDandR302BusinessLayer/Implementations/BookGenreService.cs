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
    public class BookGenreService:Service<BookGenreViewModel,BookGenre,byte>,
        IBookGenreService
    {
        public BookGenreService(IMapper mapper,IBookGenreRepo repo)
            :base(mapper,repo)
        {

        }
    }
}
