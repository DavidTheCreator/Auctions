using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Auctions.Models.View;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;


namespace Auctions.Models.Database {
    public class User: IdentityUser {
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public string gender { get; set; }
        public int tokens { get; set; } = 0;
        public bool is_deleted { get; set; } = false;
        public ICollection<Auction> auctions { get; set; }
        public ICollection<Bid> bids { get; set; }
        public ICollection<Order> orders { get; set; }
    }

    public class UserProfile : Profile {
        public UserProfile() {
            base.CreateMap<RegisterModel, User>()
                .ForMember(
                    destination => destination.Email,
                    options => options.MapFrom(data => data.email)
                ).ForMember(
                    destination => destination.UserName,
                    options => options.MapFrom(data => data.username)
                ).ReverseMap();
        }
    }
}