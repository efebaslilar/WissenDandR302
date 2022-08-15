using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302DataAccessLayer
{
    public interface IOrderDetailRepo:IRepository<OrderDetail,int>
    {
    }
}
