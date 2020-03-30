using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Please enter a user name")]
        [StringLength(10, MinimumLength = 3, ErrorMessage ="UserName must be between 3 and 10 characters")]
        public string UserName { get; set; }

        [MinLength(3, ErrorMessage = "password must be between 3 and 10 characters long")]
        [MaxLength(10, ErrorMessage = "password must be between 3 and 10 characters long")]
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }

        [Range(18, 99, ErrorMessage = "Age must be between 18 and 99")]
        public int Age { get; set; }
        
    }

   
}
