using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Auctions.Models.View {
    public class CreateEditAuctionModel {
        [HiddenInput]
        [Required]
        public int id { get; set;}
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name="Description")]
        public string description { get; set; }
        [Required]
        [Display(Name="Image")]
        public IFormFile image { get; set; }    
        [Required]
        [Display(Name="Starting Price")]
        public float starting_price { get; set; }    
        [Required]
        [DataType(DataType.Date)]
        [Display(Name="Opens at (date)")]
        public DateTime opens_at { get; set; }
        [Required] 
        [DataType(DataType.Date)]
        [Display(Name="Closes at (date)")]
        public DateTime closes_at { get; set; }
        [Required]
        [DataType(DataType.Time)]
        [Display(Name="Opens at (time)")]
        public DateTime opens_at_time { get; set; }
        [Required]
        [DataType(DataType.Time)]
        [Display(Name="Closes at (time)")]
        public DateTime closes_at_time { get; set; }
    }    
}