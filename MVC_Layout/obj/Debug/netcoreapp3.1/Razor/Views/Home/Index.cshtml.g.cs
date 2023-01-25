#pragma checksum "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e559258370c5d8dff3ba68c50b53eafbf79b18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\_ViewImports.cshtml"
using MVC_Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\_ViewImports.cshtml"
using MVC_Layout.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e559258370c5d8dff3ba68c50b53eafbf79b18", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fda8892e4c93dcfbb08b441f6a075f1a61d4a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MVC_Layout.Models.Entity.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var categories = ViewBag.Categories as List<MVC_Layout.Models.Entity.Category>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
Write(Html.Partial("_BaseHeader"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
<center>
<a href=""/home/CreateProduct"" class=""btn btn-outline-success w-25 mt-4"">Create Product</a>
</center>
<section class=""py-5"">
    <div class=""container px-4 px-lg-5 mt-5"">
        <div class=""row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center"">
            
");
#nullable restore
#line 17 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col mb-5\">\r\n                    <div class=\"card h-100\">\r\n                        <!-- Product image-->\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 750, "\"", 768, 1);
#nullable restore
#line 22 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
WriteAttributeValue("", 756, p.ImagePath, 756, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""product"">
                        <!-- Product details-->
                        <div class=""card-body p-4"">
                            <div class=""text-center"">
                                <!-- Product name-->
                                <h5 class=""fw-bolder"">");
#nullable restore
#line 27 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
                                                 Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <!-- Product price-->\r\n                            ");
#nullable restore
#line 29 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
                       Write(p.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"text-center\">\r\n");
#nullable restore
#line 32 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
                                  
                                    string category = categories.Where(x => x.ID == p.CategoryId).FirstOrDefault().CategoryName;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h6 class=\"fw-bolder\">");
#nullable restore
#line 35 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
                                                 Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                            </div>
                        </div>
                        <!-- Product actions-->
                        <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                            <div class=""text-center""><a class=""btn btn-outline-dark mt-auto""");
            BeginWriteAttribute("href", " href=\"", 1828, "\"", 1873, 4);
            WriteAttributeValue("", 1835, "/selected-product/", 1835, 18, true);
#nullable restore
#line 40 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
WriteAttributeValue("", 1853, p.ProductName, 1853, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1867, "/", 1867, 1, true);
#nullable restore
#line 40 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
WriteAttributeValue("", 1868, p.ID, 1868, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View Details</a></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MVC_Layout.Models.Entity.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
