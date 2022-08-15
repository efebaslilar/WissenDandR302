using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Models
{
    [Table("BookDiscounts")]
    public class BookDiscount : Base<int>
    {
        public int BookId { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        //TODO  ilişki
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
