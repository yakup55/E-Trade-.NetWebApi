using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record UserDtoRegistraction
    {
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        [Required(ErrorMessage = "User Name is Required")]
        public string? UserUserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string? UserPassword { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhoneNumber { get; set; }

        public ICollection<string>? Roles { get; set; }
    }
}
