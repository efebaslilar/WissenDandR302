using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Models
{
    [Table("BookActions")]
    public class BookAction:Base<int>
    {
        public int BookId { get; set; }
        public int Count { get; set; }

        // todo ilişkiler
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
