#pragma checksum "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d849a9486d6d310835cbafb1dddeffb03cc01d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_WonAuctions), @"mvc.1.0.view", @"/Views/User/WonAuctions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d849a9486d6d310835cbafb1dddeffb03cc01d", @"/Views/User/WonAuctions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_User_WonAuctions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Auctions.Models.Database.Auction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuctionDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
  
    ViewData["Title"] = "Won Auctions";
    var user_id = (string) TempData["user_id"];
    int cnt = Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 10 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
     for(int i = 0; i < 3; i++) {
        if(cnt == 0) {
            break;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
             foreach(var auction in Model) {
                if(auction.bids.LastOrDefault() == null || auction.bids.LastOrDefault().user_id != user_id) {
                    cnt--;
                    continue;
                }
                
                string image = Convert.ToBase64String(auction.image);
                cnt--;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-3\">\r\n                    <div class=\"card\" style=\"width:250px; height:450px\">\r\n                        <div class=\"card-header text-center\">\r\n                            <h5>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23d849a9486d6d310835cbafb1dddeffb03cc01d5539", async() => {
#nullable restore
#line 28 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
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
#line 28 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 1156, "\"", 1190, 2);
            WriteAttributeValue("", 1162, "data:image/png;base64,", 1162, 22, true);
#nullable restore
#line 31 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
WriteAttributeValue("", 1184, image, 1184, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%; height:50%\">\r\n                        <div class=\"card-body text-center\">\r\n                            \r\n");
#nullable restore
#line 34 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                             if(@auction.price_increase > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"card-text text-success\">$");
#nullable restore
#line 35 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                                                               Write(auction.starting_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 35 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                                                                                         Write(auction.price_increase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 36 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"card-text text-secondary\">$");
#nullable restore
#line 37 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                                                                 Write(auction.starting_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 37 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                                                                                           Write(auction.price_increase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 38 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 40 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
                                                                      Write(auction.bids.LastOrDefault().user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                            <button type=\"button\" class=\"btn btn-secondary\" style=\"width:40%\" disabled>SOLD</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 45 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 47 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 50 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
 if(cnt == Model.Count()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center mt-5\">\r\n        <h3>No Auctions Won</h3>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\WonAuctions.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
