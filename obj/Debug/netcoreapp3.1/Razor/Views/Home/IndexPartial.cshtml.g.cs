#pragma checksum "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c362c5c8bdab75bbfde60d621d60c64524493f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexPartial), @"mvc.1.0.view", @"/Views/Home/IndexPartial.cshtml")]
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
#line 1 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
using Auctions.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c362c5c8bdab75bbfde60d621d60c64524493f4", @"/Views/Home/IndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Auctions.Models.Database.Auction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuctionDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 9 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
  
    ViewData["Title"] = "Home Page";

    int current_page = (int) TempData["current_page"];
    int num_pages = (int) TempData["num_pages"];
    int cnt = Model.Count();
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
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 31 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
     for(int i = 0; i < 3; i++) {

        if(cnt == 0) {
            break;
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 38 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
             foreach(var auction in Model) {
                string image = Convert.ToBase64String(auction.image);
                var time_left = auction.closes_at - DateTime.Now;
                cnt--;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-3\">\r\n                    <div class=\"card mt-4\" style=\"width:250px; height:460px\">\r\n                        <div class=\"card-header text-center\">\r\n                            <h5>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c362c5c8bdab75bbfde60d621d60c64524493f47075", async() => {
#nullable restore
#line 47 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                                                                Write(auction.name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                                            WriteLiteral(auction.id);

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
            WriteLiteral("\r\n                            </h5>\r\n                        </div>\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1533, "\"", 1567, 2);
            WriteAttributeValue("", 1539, "data:image/png;base64,", 1539, 22, true);
#nullable restore
#line 50 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
WriteAttributeValue("", 1561, image, 1561, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%; height:50%\">\r\n                        <div class=\"card-body text-center\">\r\n");
#nullable restore
#line 52 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                             if(@time_left.Hours == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"card-text text-danger timer\">");
#nullable restore
#line 53 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                   Write(time_left.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 53 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                    Write(time_left.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 53 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                                       Write(time_left.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 54 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"card-text timer\">");
#nullable restore
#line 55 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                       Write(time_left.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 55 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                        Write(time_left.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 55 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                           Write(time_left.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 56 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                              
                                float price = auction.price_increase;
                                string price_format = "";

                                if(price > 999) {
                                    price_format = price.ToString();
                                    price_format = price_format.Substring(price_format.Length - 3, price_format.Length - 1);
                                    price /= 1000;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h5 class=\"card-text text-success\">$");
#nullable restore
#line 66 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                   Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 66 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                          Write(price_format);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</h5>\r\n");
#nullable restore
#line 67 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                } else if(price == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h5 class=\"card-text text-secondary\">$0.00</h5>\r\n");
#nullable restore
#line 69 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h5 class=\"card-text text-success\">$");
#nullable restore
#line 70 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                   Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</h5>\r\n");
#nullable restore
#line 71 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                             if(@auction.bids != null && @auction.bids.LastOrDefault() != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 75 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                          Write(auction.bids.LastOrDefault().user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n");
#nullable restore
#line 76 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                             if(sign_in_manager.IsSignedIn(User) && role == "Admin") {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-primary\" style=\"width:30%\" disabled>ADMIN</button>\r\n");
#nullable restore
#line 80 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            } else if(sign_in_manager.IsSignedIn(User) && role == "User") {
                                if(@auction.user_id == id) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-primary\" style=\"width:60%\" disabled>MY AUCTION</button>\r\n");
#nullable restore
#line 83 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                }
                                else if(@auction.state != @Auctions.Models.Database.state.SOLD) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-warning\" style=\"width:40%\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c362c5c8bdab75bbfde60d621d60c64524493f417994", async() => {
                WriteLiteral("BID");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                                       WriteLiteral(auction.id);

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
            WriteLiteral("\r\n                                    </button>\r\n");
#nullable restore
#line 88 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-secondary\" style=\"width:40%\" disabled>SOLD</button>\r\n");
#nullable restore
#line 90 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                }
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-danger text-white\" style=\"width:70%\" disabled>Register/Log In</button>\r\n");
#nullable restore
#line 93 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 98 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 100 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 103 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
 if(cnt == Model.Count()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h3>No Auctions</h3>\r\n    </div>\r\n");
#nullable restore
#line 107 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5 justify-content-center\">\r\n    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 113 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
             for(int i = 0; i < num_pages; i++) {
                int index = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <button class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5119, "\"", 5144, 3);
            WriteAttributeValue("", 5129, "filter(", 5129, 7, true);
#nullable restore
#line 116 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
WriteAttributeValue("", 5136, index, 5136, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5142, ");", 5142, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 116 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </li>\r\n");
#nullable restore
#line 118 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </nav>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Auctions.Models.Database.Auction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
