using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer.ContextInfo;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302DataAccessLayer.Implementations
{
    public class BookRepo:Repository<Book,int>,IBookRepo
    {
        public BookRepo(MyContext myContext):base(myContext)
        {

        }
    }
}
