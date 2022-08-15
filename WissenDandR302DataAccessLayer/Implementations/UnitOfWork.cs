using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer.ContextInfo;

namespace WissenDandR302DataAccessLayer.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _myContext;
        public UnitOfWork(MyContext myContext)
        {
            _myContext = myContext;
            BookRepo = new BookRepo(_myContext);
            BookActionRepo = new BookActionRepo(_myContext);
            BookGenreRepo = new BookGenreRepo(_myContext);
            BookDiscountRepo=new BookDiscountRepo(_myContext);
            AuthorRepo = new AuthorRepo(_myContext);
            BookPictureRepo= new BookPictureRepo(_myContext);
            OrderRepo= new OrderRepo(_myContext);
            OrderDetailRepo = new OrderDetailRepo(_myContext);          
        }

        public IBookRepo BookRepo {get; private set;}

        public IBookActionRepo BookActionRepo {get; private set;}

        public IBookDiscountRepo BookDiscountRepo {get; private set;}

        public IBookPictureRepo BookPictureRepo {get; private set;}

        public IBookGenreRepo BookGenreRepo {get; private set;}

        public IAuthorRepo AuthorRepo {get; private set;}

        public IOrderRepo OrderRepo {get; private set;}

        public IOrderDetailRepo OrderDetailRepo {get; private set;}
    }
}
