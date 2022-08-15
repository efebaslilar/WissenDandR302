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
    public class OrderDetailService : Service<OrderDetailViewModel, OrderDetail, int>, IOrderDetailService
    {
        public OrderDetailService(IMapper mapper, IOrderDetailRepo repo) : base(mapper, repo, "Order,Book")
        {
        }
    }
}
