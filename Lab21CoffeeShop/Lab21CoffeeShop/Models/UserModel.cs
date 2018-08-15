using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab21CoffeeShop.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(15, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(15, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number")]
        [RegularExpression(@"^[0-9]{3}-?[0-9]{3}-?[0-9]{4}$", ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Phone")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Passwords must match")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Coffee Style")]
        public string Gender { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}