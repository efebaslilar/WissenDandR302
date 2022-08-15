using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.ResultModels;
using WissenDandR302EntityLayer.ViewModels;

namespace WissenDandR302BusinessLayer
{
    public interface IBookService:IService<BookViewModel,int>
    {
       
    }
}
