using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class BookPictureViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int BookId { get; set; }

        [StringLength(400, ErrorMessage = "Kitap resim yolu en fazla 400 karakter olmalıdır!")]
        public string Picture { get; set; }
        public  Book? Book { get; set; }

    }
}
