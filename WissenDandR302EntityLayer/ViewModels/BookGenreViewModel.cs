using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class BookGenreViewModel
    {
        public byte Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        [StringLength(50, ErrorMessage = "Tür adı en fazla 50 karakter olmalıdır!")]
        public string GenreName { get; set; }
    }
}
