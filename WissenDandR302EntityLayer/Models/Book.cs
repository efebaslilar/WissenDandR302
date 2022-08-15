using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Models
{
    [Table("Books")]
    public class Book:Base<int>
    {
        [StringLength(200,ErrorMessage ="Kitap adı en fazla 200 karakter olmalıdır!")]
        public string BookName { get; set; }
        public int  PageNumber { get; set; }
        public int?  PressYear { get; set; }
        public decimal Price { get; set; }
        public int  Quantity { get; set; }
        public int  AuthorId { get; set; }
        public byte  BookGenreId { get; set; }

        [ForeignKey("BookGenreId")]
        public virtual BookGenre  BookGenre { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        public virtual List<BookPicture> BookPictures { get; set; }
    }
}
