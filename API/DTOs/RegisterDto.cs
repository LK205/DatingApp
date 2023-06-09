using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required] public string knownAs { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public string City { get; set; }
        [Required] public string Country { get; set; }

        [Required]
        [StringLength( 100 ,MinimumLength = 3)]
        public string Password { get; set; }
    }
}