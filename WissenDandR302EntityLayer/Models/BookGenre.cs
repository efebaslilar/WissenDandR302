using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Models
{
    [Table("BookGenres")]
    public class BookGenre : Base<byte>
    {
        [StringLength(50, ErrorMessage = "Tür adı en fazla 50 karakter olmalıdır!")]
        public string GenreName { get; set; }

    }
}
