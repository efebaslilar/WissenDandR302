using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer.ContextInfo;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302DataAccessLayer.Implementations
{
    public class OrderRepo:Repository<Order,int>,IOrderRepo
         // efe interface'i unutma
         // unutmadım hocam :)
    {
        public OrderRepo(MyContext myContext):base(myContext)
        {

        }

        public List<Order> Betul(string ad)
        {// adı x (betül) olarak verilen müşterinin son 3 gündür aldığı kitapların listesi
         
            List<Order> data = new List<Order>();
            var d = from o in _myContext.Orders
                    join c in _myContext.Customers
                    on o.CustomerId equals c.Id
                    where c.AppUser.Name == ad 
                    && o.CreatedDate > DateTime.Now.AddDays(-3)
                    select new { Books=o.OrderDetailList};

            return data;
        }
}
}
