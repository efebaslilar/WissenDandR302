using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class BookDiscountViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int BookId { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public  Book? Book { get; set; }
    }
}
