#pragma checksum "C:\Users\WAKA\RiderProjects\RwandaShop\RwandaShop\Views\Shop\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01099ce2840314994f18c3de26f05363539776ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Create), @"mvc.1.0.view", @"/Views/Shop/Create.cshtml")]
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
#line 1 "C:\Users\WAKA\RiderProjects\RwandaShop\RwandaShop\Views\Shop\Create.cshtml"
using RwandaShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01099ce2840314994f18c3de26f05363539776ab", @"/Views/Shop/Create.cshtml")]
    public class Views_Shop_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RwandaShop.Models.Shop>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\WAKA\RiderProjects\RwandaShop\RwandaShop\Views\Shop\Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
<form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label"">Name</label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                 <label asp-for=""Description"">Description</label>
                <textarea class=""form-control"" id=""exampleTextarea"" rows=""3""></textarea>
                <span asp-validation-for=""Description"" class=""text-danger""></span>
               </div>
            <div class=""form-group"">
                            <label asp-for=""Type"" class=""control-label""></label>
                            <select asp-for=""Type"" name=""Cuisine"" class=""form-control"">
            
");
#nullable restore
#line 24 "C:\Users\WAKA\RiderProjects\RwandaShop\RwandaShop\Views\Shop\Create.cshtml"
                                 foreach (ShopType c in (ShopType[]) Enum.GetValues(typeof(ShopType)))
                                {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 1211, "\"", 1238, 1);
#nullable restore
#line 27 "C:\Users\WAKA\RiderProjects\RwandaShop\RwandaShop\Views\Shop\Create.cshtml"
WriteAttributeValue("", 1219, Convert.ToInt32(c), 1219, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\WAKA\RiderProjects\RwandaShop\RwandaShop\Views\Shop\Create.cshtml"
                                                                   Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 28 "C:\Users\WAKA\RiderProjects\RwandaShop\RwandaShop\Views\Shop\Create.cshtml"
            
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </select>\r\n                            <span asp-validation-for=\"Type\" class=\"text-danger\"></span>\r\n                        </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1536, "\"", 1546, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"Create\" class=\"btn btn-outline-primary\" />\r\n            </div>\r\n        </form>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RwandaShop.Models.Shop> Html { get; private set; }
    }
}
#pragma warning restore 1591