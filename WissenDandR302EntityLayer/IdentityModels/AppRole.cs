﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.IdentityModels
{
    public class AppRole : IdentityRole
    {
        public DateTime CreatedDate { get; set; }
        [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olmalıdır!")]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
