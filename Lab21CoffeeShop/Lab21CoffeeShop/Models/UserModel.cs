using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab21CoffeeShop.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(15, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(15, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please a valid email address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please a valid phone number")]
        [Phone]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please a password")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}