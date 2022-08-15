using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.Models
{
    [Table("BookPictures")]
    public class BookPicture : Base<int>
    {
        public int BookId { get; set; }

        [StringLength(400, ErrorMessage = "Kitap resim yolu en fazla 400 karakter olmalıdır!")]
        public string Picture { get; set; }

        //Todo İlişki
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
