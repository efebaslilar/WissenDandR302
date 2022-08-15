using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.IdentityModels;
using WissenDandR302EntityLayer.Models;

namespace WissenDandR302DataAccessLayer.ContextInfo
{
    public class MyContext: IdentityDbContext<AppUser,AppRole,string>
    {
        // Program.cs içinde bu options'ı ayarlayacağız.
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<BookAction> BookActions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<BookPicture> BookPictures { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookDiscount> BookDiscounts { get; set; }
    }
}
