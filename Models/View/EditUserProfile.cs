using System.ComponentModel.DataAnnotations;
using Auctions.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace Auctions.Models.View {
    public class EditUserModel {
        [HiddenInput]
        public string id { get; set; }

        [Display(Name="First Name")]
        public string first_name { get; set; }

        [Display(Name="Last Name")]
        public string last_name { get; set; }

        [Display(Name="Gender")]
        public string gender { get; set; }

        [Display(Name="Email")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Remote(controller: "User", action: nameof(UserController.isEmailUnique))]
        public string email { get; set; }

        [MinLength(6)]
        [Display(Name="Username")]
        [Remote(controller: "User", action: nameof(UserController.isUsernameUnique))]
        public string username { get; set; }
        
        [Display(Name="Current Password")]
        [DataType(DataType.Password)]
        public string current_password { get; set; }

        [MinLength(8)]
        [Display(Name="New Password")]
        [DataType(DataType.Password)]
        public string new_password { get; set; }

        [MinLength(8)]
        [Display(Name="Confirm New Password")]
        [Compare(nameof(new_password), ErrorMessage="New Password and Confirm New Password fields must match!")]
        [DataType(DataType.Password)]
        public string confirm_new_password { get; set; }
    }
}