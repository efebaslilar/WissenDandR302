using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        [StringLength(8, MinimumLength = 8, ErrorMessage = "Sipariş numarası 8 haneli olmalıdır!")]
        public string CONumber { get; set; } // Sipariş numarası
        public string CustomerId { get; set; }
        public bool IsCompleted { get; set; }
        public  Customer? Customer { get; set; }
        public  List<OrderDetail>? OrderDetailList { get; set; }
    }
}
