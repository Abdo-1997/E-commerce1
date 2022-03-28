
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace E_commerce1.Models
{
    public class User:IdentityUser
    {
        [Required ,MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }

        public byte[] Photo { set; get; }
    }
}
