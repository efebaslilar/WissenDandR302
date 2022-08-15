using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer.ContextInfo;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302DataAccessLayer.Implementations
{
    public class OrderDetailRepo : Repository<OrderDetail, int>, IOrderDetailRepo
    {
        public OrderDetailRepo(MyContext myContext) : base(myContext)
        {
        }
    }
}
