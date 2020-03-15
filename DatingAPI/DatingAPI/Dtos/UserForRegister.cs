using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Dtos
{
    public class UserForRegister
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(12,MinimumLength =6, ErrorMessage ="Hało powinno byćdłuższe niz 6 znaków")]
        public string Password { get; set; }

    }
}
