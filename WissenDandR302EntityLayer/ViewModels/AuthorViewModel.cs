using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Adınız en az 2 en fazla 50 karakter olabilir!")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Soyadınız en az 2 en fazla 50 karakter olabilir!")]
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }

    }
}
