using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class BookActionViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }
        public Book? Book { get; set; }
    }
}

