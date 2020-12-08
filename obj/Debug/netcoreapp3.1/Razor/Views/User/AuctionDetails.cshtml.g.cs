#pragma checksum "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f00b87376b42c87d40cb877de864cc631bc19c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AuctionDetails), @"mvc.1.0.view", @"/Views/User/AuctionDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\_ViewImports.cshtml"
using Auctions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\_ViewImports.cshtml"
using Auctions.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
using Auctions.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f00b87376b42c87d40cb877de864cc631bc19c3", @"/Views/User/AuctionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AuctionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auctions.Models.Database.Auction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
  
    ViewData["Title"] = "Auction Details";

    var user_id = (string) TempData["user_id"];

    string image = Convert.ToBase64String(Model.image);
    var time_left = Model.closes_at - DateTime.Now;
    string role = "";
    string id = "";

    foreach(System.Security.Claims.Claim claim in User.Claims) {
        if(claim.Type.Equals(ClaimTypes.Role)) {
            role = claim.Value;
        }

        if(claim.Type.Equals("id")) {
            id = claim.Value;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"auction\">\r\n");
#nullable restore
#line 32 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
       await Html.RenderPartialAsync("AuctionDetailsPartial",Model); 

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> sign_in_manager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auctions.Models.Database.Auction> Html { get; private set; }
    }
}
#pragma warning restore 1591
