using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302EntityLayer.IdentityModels;

namespace WissenDandR302EntityLayer.Models
{
    [Table("Customers")]
    public class Customer:Base<string>
    {
        public string AppUserId { get; set; }

        //Todo ilişki
        [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }
    }
}
