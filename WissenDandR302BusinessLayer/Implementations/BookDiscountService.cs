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
    public class BookDiscountService : Service<BookDiscountViewModel, BookDiscount    , int>,
        IBookDiscountService
    {
        public BookDiscountService(IMapper mapper, IBookDiscountRepo repo)
            : base(mapper, repo, "Book")
        {

        }
    }
}
