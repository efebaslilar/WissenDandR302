using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public bool IsCompleted { get; set; }
        public  Order? Order { get; set; }
        public  Book? Book { get; set; }
    }
}
