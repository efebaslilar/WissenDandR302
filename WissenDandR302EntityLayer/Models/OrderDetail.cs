using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Models
{
    [Table("OrderDetails")]
    public class OrderDetail : Base<int>
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public bool IsCompleted { get; set; }
        //Todo ilişkiler
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
