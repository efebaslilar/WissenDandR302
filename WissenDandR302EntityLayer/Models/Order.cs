using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Models
{
    [Table("Orders")]
    public class Order:Base<int>
    {
        [StringLength(8,MinimumLength =8, ErrorMessage ="Sipariş numarası 8 haneli olmalıdır!")]
        public string CONumber { get; set; } // Sipariş numarası

        public string CustomerId { get; set; }
        public bool IsCompleted { get; set; }

        //Todo ilişki
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public virtual List<OrderDetail> OrderDetailList { get; set; }

    }
}
