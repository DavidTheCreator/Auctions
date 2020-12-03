using System.ComponentModel.DataAnnotations;
using Auctions.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace Auctions.Models.View {
    public class RegisterModel {
        [Required]
        [Display(Name = "First Name")]
        public string first_name { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string last_name { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Remote(controller: "User", action: nameof(UserController.isEmailUnique))]
        public string email { get; set; }

        [Required]
        [Display(Name="Gender")]
        public string gender { get; set; }

        [Required, MinLength(6)]
        [Display(Name = "Username")]
        [Remote(controller: "User", action: nameof(UserController.isUsernameUnique))]
        public string username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(password), ErrorMessage = "Password and Confirm Password fields must match!")]
        [DataType(DataType.Password)]
        public string confirm_password { get; set; }
    }
}