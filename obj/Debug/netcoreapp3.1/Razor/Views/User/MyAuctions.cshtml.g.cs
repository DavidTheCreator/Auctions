#pragma checksum "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1934444e42ce401ea9b27f37976f7b96b32ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyAuctions), @"mvc.1.0.view", @"/Views/User/MyAuctions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1934444e42ce401ea9b27f37976f7b96b32ed6", @"/Views/User/MyAuctions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyAuctions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Auctions.Models.Database.Auction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAuction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAuction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
  
    ViewData["Title"] = "My Auctions";
    var button_class = TempData["button"];
    int cnt = Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 10 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
     if(TempData["action"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 257, "\"", 308, 4);
            WriteAttributeValue("", 265, "alert", 265, 5, true);
            WriteAttributeValue(" ", 270, "alert-", 271, 7, true);
#nullable restore
#line 11 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
WriteAttributeValue("", 277, button_class, 277, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 290, "alert-dissmisible", 291, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            ");
#nullable restore
#line 13 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
       Write(TempData["action"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
         if(cnt > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Starting Price</th>
                <th scope=""col"">Opens at</th>
                <th scope=""col"">Closes at</th>
                <th scope=""col"">Edit</th>
                <th scope=""col"">Delete</th>
            </tr>
");
#nullable restore
#line 31 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
         foreach(var auction in Model) {
            cnt--;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
               Write(auction.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
               Write(auction.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
               Write(auction.starting_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
               Write(auction.opens_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
               Write(auction.closes_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
                 if(auction.state == Auctions.Models.Database.state.DRAFT) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <button type=\"button\" class=\"btn btn-primary\">\r\n");
#nullable restore
#line 47 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
                              
                                TempData["tab"] = null;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b1934444e42ce401ea9b27f37976f7b96b32ed69348", async() => {
                WriteLiteral("Edit");
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
#line 50 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
                                                                                WriteLiteral(auction.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"btn btn-danger\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b1934444e42ce401ea9b27f37976f7b96b32ed612026", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
#line 55 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
                                                                                  WriteLiteral(auction.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n");
#nullable restore
#line 58 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <td>
                        <button type=""button"" class=""btn btn-primary text-white"" disabled>Edit</button>
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-danger text-white"" disabled>Delete</button>
                    </td>
");
#nullable restore
#line 65 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 72 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
 if(cnt == Model.Count()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h3>No Auctions Created</h3>\r\n    </div>\r\n");
#nullable restore
#line 76 "C:\Users\38160\Desktop\Faks\IEP\Auctions\Auctions\Views\User\MyAuctions.cshtml"
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
