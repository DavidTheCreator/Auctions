#pragma checksum "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8798e9e2c4884adcb3481b77bc0ddc7929db7c9d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8798e9e2c4884adcb3481b77bc0ddc7929db7c9d", @"/Views/User/AuctionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AuctionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auctions.Models.Database.Auction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAuction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-from", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Bid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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

    await Html.RenderPartialAsync("signalRScriptsPartial");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-xl-6 text-center\">\r\n        <div class=\"container\">\r\n            <div class=\"card\" style=\"width:500px; height:900px\">\r\n                <div class=\"card-header\">\r\n");
#nullable restore
#line 38 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                     if(sign_in_manager.IsSignedIn(User) && role == "User" && @Model.user_id == user_id) {
                        TempData["tab"] = "HomeTab";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8798e9e2c4884adcb3481b77bc0ddc7929db7c9d6902", async() => {
                WriteLiteral("<h5 class=\"text-primary\">");
#nullable restore
#line 40 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                                                                                              Write(Model.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                            WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-from", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["from"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"text-primary\">");
#nullable restore
#line 42 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                            Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 43 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1519, "\"", 1553, 2);
            WriteAttributeValue("", 1525, "data:image/png;base64,", 1525, 22, true);
#nullable restore
#line 45 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
WriteAttributeValue("", 1547, image, 1547, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%; height:70%\">\r\n                <div class=\"card-body\">\r\n                    <p>");
#nullable restore
#line 47 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                  Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                     if(@time_left.Hours == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"card-text text-danger timer\">");
#nullable restore
#line 50 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                           Write(time_left.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 50 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                            Write(time_left.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 50 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                                               Write(time_left.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 51 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"card-text timer\">");
#nullable restore
#line 52 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                               Write(time_left.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 52 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                Write(time_left.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 52 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                                   Write(time_left.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 53 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                      
                        float starting_price_ = Model.starting_price;
                        float price_ = starting_price_ + Model.price_increase;
                        string specifier = "C";
                        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

                        string starting_price = starting_price_.ToString(specifier, culture);
                        string price = price_.ToString(specifier, culture);


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5>Starting Price: </h5>\r\n");
#nullable restore
#line 65 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"

                        if(starting_price_ == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 class=\"card-text text-secondary\">$0</h5>\r\n");
#nullable restore
#line 68 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 class=\"card-text text-primary\">");
#nullable restore
#line 69 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                          Write(starting_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 70 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5>Current Price: </h5>\r\n");
#nullable restore
#line 73 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"

                        if(price_ == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 class=\"card-text text-secondary\">");
#nullable restore
#line 75 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                            Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 76 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 class=\"card-text text-success\">");
#nullable restore
#line 77 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                          Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 78 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                     if(@Model.bids != null && @Model.bids.LastOrDefault() != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 82 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                  Write(Model.bids.LastOrDefault().user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n");
#nullable restore
#line 83 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                     if(sign_in_manager.IsSignedIn(User) && role == "Admin") {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" class=\"btn btn-primary\" style=\"width:20%\" disabled>ADMIN</button>\r\n");
#nullable restore
#line 86 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                    } else if(sign_in_manager.IsSignedIn(User) && role == "User") {
                        if(@Model.user_id == id) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"btn btn-primary\" style=\"width:30%\" disabled>MY AUCTION</button>\r\n");
#nullable restore
#line 89 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                        } else if(@Model.state != @Auctions.Models.Database.state.SOLD) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"btn btn-warning\" style=\"width:20%\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8798e9e2c4884adcb3481b77bc0ddc7929db7c9d19893", async() => {
                WriteLiteral("BID");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                                                                               WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </button>\r\n");
#nullable restore
#line 93 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"btn btn-secondary\" style=\"width:20%\" disabled>SOLD</button>\r\n");
#nullable restore
#line 95 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                        }
                    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" class=\"btn btn-danger text-white\" style=\"width:30%\" disabled>Register/Log In</button>\r\n");
#nullable restore
#line 98 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-xl-6 text-center\">\r\n\r\n");
#nullable restore
#line 106 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
         if(Model.bids != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"text-dark\">Last 10 bidders:</h3>\r\n            <br>\r\n");
#nullable restore
#line 109 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"

            var bids = Model.bids.OrderByDescending(bid => bid.time);
            int cnt = 0;

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
             foreach(var bid in bids) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 class=\"text-dark\"> ");
#nullable restore
#line 114 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
                                  Write(bid.user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n");
#nullable restore
#line 115 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"

                if(cnt++ == 10) {
                    break;
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\r\n");
#nullable restore
#line 121 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
             
            
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"text-dark\">Still no bidders.</h3>\r\n");
#nullable restore
#line 125 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\AuctionDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
