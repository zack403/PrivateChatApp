using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PCHAT.API.Dtos
{
    public class UserForRegisterDto
    {
        public UserForRegisterDto()
        {
            Created = DateTime.Now;
        }

        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Please provide a password not less than 4 and not greater than 8")]
        public string Password { get; set; }
        public string gender { get; set; }
        public DateTime Created { get; set; }
    }
}
