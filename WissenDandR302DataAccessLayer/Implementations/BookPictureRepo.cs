using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer.ContextInfo;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302DataAccessLayer.Implementations
{
    public class BookPictureRepo : Repository<BookPicture, int>, IBookPictureRepo
    {
        public BookPictureRepo(MyContext myContext) : base(myContext)
        {
        }
    }
}
