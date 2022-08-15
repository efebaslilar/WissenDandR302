using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302EntityLayer.ViewModels
{
    public class BookViewModel //BookDTO
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Kitap adı en fazla 200 karakter olmalıdır!")]
        public string BookName { get; set; }
        [Required]
        public int PageNumber { get; set; }
        public int? PressYear { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public byte BookGenreId { get; set; }
        public  BookGenre? BookGenre { get; set; }
        public  Author? Author { get; set; }
        public  List<BookPicture>? BookPictures { get; set; }
        public List<IFormFile>? Files { get; set; }
    }
}
