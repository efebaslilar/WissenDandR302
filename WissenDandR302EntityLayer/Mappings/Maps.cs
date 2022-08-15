using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;
using WissenDandR302EntityLayer.ViewModels;

namespace WissenDandR302EntityLayer.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            //CreateMap<Book, BookViewModel>();
            //CreateMap<BookViewModel, Book>();
            CreateMap<Book, BookViewModel>().ReverseMap();
            CreateMap<BookAction, BookActionViewModel>().ReverseMap();
            CreateMap<BookDiscount, BookDiscountViewModel>().ReverseMap();
            CreateMap<Author, AuthorViewModel>().ReverseMap();
            CreateMap<Order, OrderViewModel>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailViewModel>().ReverseMap();
            CreateMap<BookPicture, BookPictureViewModel>().ReverseMap();
            CreateMap<BookGenre, BookGenreViewModel>().ReverseMap();
        }
    }
}
