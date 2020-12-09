using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace Auctions.Models.View {
    public class PurchaseTokensModel {
        [HiddenInput]
        public int id { get; set; }
        [Display(Name="Package")]
        public string package { get; set; }
    }    
}