using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302DataAccessLayer
{
    public interface IUnitOfWork
    {
        //bütün repoları tek bir yere toplamak amacıyla bu interface'i yazdık.
        IBookRepo BookRepo { get; }
        IBookActionRepo BookActionRepo { get; }
        IBookDiscountRepo BookDiscountRepo { get; }
        IBookPictureRepo BookPictureRepo { get; }
        IBookGenreRepo BookGenreRepo { get; }
        IAuthorRepo AuthorRepo { get;  }
        IOrderRepo OrderRepo { get; }   
        IOrderDetailRepo OrderDetailRepo { get; }   
    }
}
