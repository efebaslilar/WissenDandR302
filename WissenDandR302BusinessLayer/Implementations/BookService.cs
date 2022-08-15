using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer;
using WissenDandR302DataAccessLayer.Implementations;
using WissenDandR302EntityLayer.Models;
using WissenDandR302EntityLayer.ResultModels;
using WissenDandR302EntityLayer.ViewModels;

namespace WissenDandR302BusinessLayer.Implementations
{
    public class BookService : Service<BookViewModel,Book,int>, IBookService
        
    {
        public BookService(IMapper mapper, IBookRepo repo )
            :base(mapper,repo, "Author,BookGenre,BookPictures")
        {

        }
    }
}
