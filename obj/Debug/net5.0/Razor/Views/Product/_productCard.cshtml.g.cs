#pragma checksum "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d3b35a34ec3adb7b58a9efb5759ae45ec901f3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__productCard), @"mvc.1.0.view", @"/Views/Product/_productCard.cshtml")]
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
#line 1 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\_ViewImports.cshtml"
using Activity3_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\_ViewImports.cshtml"
using Activity3_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3b35a34ec3adb7b58a9efb5759ae45ec901f3b", @"/Views/Product/_productCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41e475264c773e4fedbd62231ad3c80681cf3d73", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__productCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activity3_2.Models.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card text-white bg-primary mb-3\" style=\"width: 20rem;\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 119, "\"", 162, 2);
            WriteAttributeValue("", 125, "https://i.pravatar.cc/150?u=", 125, 28, true);
#nullable restore
#line 4 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 153, Model.Id, 153, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 184, "\"", 201, 1);
#nullable restore
#line 4 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 190, Model.Name, 190, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 6 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 7 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
                        Write(Html.DisplayFor(m => Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">");
#nullable restore
#line 8 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 452, 2);
            WriteAttributeValue("", 422, "/Product/ShowDetails/", 422, 21, true);
#nullable restore
#line 9 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 443, Model.Id, 443, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Details</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 498, "\"", 532, 2);
            WriteAttributeValue("", 505, "/Product/EditForm/", 505, 18, true);
#nullable restore
#line 10 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 523, Model.Id, 523, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 578, "\"", 610, 2);
            WriteAttributeValue("", 585, "/Product/Delete/", 585, 16, true);
#nullable restore
#line 11 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 601, Model.Id, 601, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n        <!-- Button trigger modal -->\r\n        <button");
            BeginWriteAttribute("value", " value=\"", 701, "\"", 718, 1);
#nullable restore
#line 13 "C:\Users\NAM_DESKTOP\source\repos\Activity3-2\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 709, Model.Id, 709, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-primary edit-product-button\" data-toggle=\"modal\" data-target=\"#editModal\">\r\n            Edit Modal\r\n        </button>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activity3_2.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591