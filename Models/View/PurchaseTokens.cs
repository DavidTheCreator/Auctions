using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace Auctions.Models.View {
    public class PurchaseTokensModel {
        [HiddenInput]
        [Required]
        public int id { get; set; }
        [Required]
        [Display(Name="Package")]
        public string package { get; set; } = "PLATINUM";
    }    
}