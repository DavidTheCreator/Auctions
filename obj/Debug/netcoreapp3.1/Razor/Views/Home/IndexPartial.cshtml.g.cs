#pragma checksum "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "647272fd1304bf6ad1bddd929cd290c8a2c3cf31"
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
#nullable restore
#line 4 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647272fd1304bf6ad1bddd929cd290c8a2c3cf31", @"/Views/Home/IndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Auctions.Models.Database.Auction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuctionDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Bid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 10 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
  
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
#line 32 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
     for(int i = 0; i < 3; i++) {

        if(cnt == 0) {
            break;
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 39 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
             foreach(var auction in Model) {
                string image = Convert.ToBase64String(auction.image);
                var time_left = auction.closes_at - DateTime.Now;
                if(time_left < TimeSpan.Zero) {
                    time_left = TimeSpan.Zero;
                }
                cnt--;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-3\">\r\n                    <div class=\"card mt-4\" style=\"width:250px; height:450px\">\r\n                        <div class=\"card-header text-center\">\r\n                            <h5>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "647272fd1304bf6ad1bddd929cd290c8a2c3cf317030", async() => {
#nullable restore
#line 51 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                                                                            Write(auction.name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1453, "text-primary", 1453, 12, true);
#nullable restore
#line 51 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
AddHtmlAttributeValue(" ", 1465, auction.id, 1466, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#line 51 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 1691, "\"", 1725, 2);
            WriteAttributeValue("", 1697, "data:image/png;base64,", 1697, 22, true);
#nullable restore
#line 54 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
WriteAttributeValue("", 1719, image, 1719, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%; height:50%\">\r\n                        <div class=\"card-body text-center\">\r\n");
#nullable restore
#line 56 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                             if(@time_left.Hours == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"card-text text-danger timer\">");
#nullable restore
#line 57 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                   Write(time_left.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 57 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                    Write(time_left.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 57 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                                       Write(time_left.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 58 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"card-text timer\">");
#nullable restore
#line 59 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                       Write(time_left.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 59 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                        Write(time_left.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 59 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                           Write(time_left.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 60 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                              
                                float price_ = auction.price_increase;
                                string specifier = "C";
                                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

                                string price = price_.ToString(specifier, culture);

                                if(price_ == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h5 class=\"card-text text-secondary\">");
#nullable restore
#line 70 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                    Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 71 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h5 class=\"card-text text-success\">");
#nullable restore
#line 72 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                  Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 73 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                             if(@auction.bids != null && @auction.bids.LastOrDefault() != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 77 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                          Write(auction.bids.LastOrDefault().user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n");
#nullable restore
#line 78 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                             if(sign_in_manager.IsSignedIn(User) && role == "Admin") {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-primary\" style=\"width:40%\" disabled>ADMIN</button>\r\n");
#nullable restore
#line 82 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            } else if(sign_in_manager.IsSignedIn(User) && role == "User") {
                                if(@auction.user_id == id) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-primary\" style=\"width:60%\" disabled>MY AUCTION</button>\r\n");
#nullable restore
#line 85 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                }
                                else if(@auction.state != @Auctions.Models.Database.state.SOLD) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-warning\" style=\"width:40%\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "647272fd1304bf6ad1bddd929cd290c8a2c3cf3117732", async() => {
                WriteLiteral("BID");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                                                       WriteLiteral(auction.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4023, "bid(", 4023, 4, true);
#nullable restore
#line 88 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
AddHtmlAttributeValue("", 4027, auction.id, 4027, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4038, ");", 4038, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </button>\r\n");
#nullable restore
#line 90 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-secondary\" style=\"width:40%\" disabled>SOLD</button>\r\n");
#nullable restore
#line 92 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                }
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-danger text-white\" style=\"width:70%\" disabled>Register/Log In</button>\r\n");
#nullable restore
#line 95 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 100 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 102 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 105 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
 if(cnt == Model.Count()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center mt-5\">\r\n        <h3>No Auctions</h3>\r\n    </div>\r\n");
#nullable restore
#line 109 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5 justify-content-center\">\r\n    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 115 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
             for(int i = 0; i < num_pages; i++) {
                int index = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <button class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5087, "\"", 5112, 3);
            WriteAttributeValue("", 5097, "filter(", 5097, 7, true);
#nullable restore
#line 118 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
WriteAttributeValue("", 5104, index, 5104, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5110, ");", 5110, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
                                                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </li>\r\n");
#nullable restore
#line 120 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\Home\IndexPartial.cshtml"
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
