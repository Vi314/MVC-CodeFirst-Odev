#pragma checksum "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2475ed9ebdb9a551a5808516bfa8956a41b36e00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2475ed9ebdb9a551a5808516bfa8956a41b36e00", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fda8892e4c93dcfbb08b441f6a075f1a61d4a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Layout.Models.Repository.IAccount>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1\">\r\n\r\n            <p class=\"text-center h1 fw-bold mb-5 mt-4\">Log In</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2475ed9ebdb9a551a5808516bfa8956a41b36e004073", async() => {
                WriteLiteral(@"
                <div class=""d-flex flex-row align-items-center mb-4"">
                    <i class=""fas fa-user fa-lg me-3 fa-fw""></i>
                    <div class=""form-outline flex-fill mb-0"">
                        <input type=""text"" id=""form3Example1c"" name=""Username"" >
                        <label class=""form-label"" for=""form3Example1c"" style=""margin-left: 0px;"">Username</label>
                        <div class=""form-notch"">
                            <div class=""form-notch-leading"" style=""width: 9px;""></div>
                            <div class=""form-notch-middle"" style=""width: 71.2px;""></div><div class=""form-notch-trailing""></div>
                        </div>
                    </div>
                </div>
                <div class=""d-flex flex-row align-items-center mb-4"">
                    <i class=""fas fa-lock fa-lg me-3 fa-fw""></i>
                    <div class=""form-outline flex-fill mb-0"">
                        <input type=""password"" id=""form3Example4c"" name=""p");
                WriteLiteral(@"assword"" >
                        <label class=""form-label"" for=""form3Example4c"" style=""margin-left: 0px;"">Password</label>
                        <div class=""form-notch""><div class=""form-notch-leading"" style=""width: 9px;""></div><div class=""form-notch-middle"" style=""width: 64px;""></div><div class=""form-notch-trailing""></div></div>
                    </div>
                </div>
                <div class=""d-flex justify-content-center mx-4 mb-3 mb-lg-4"">
                    <button type=""submit"" class=""btn btn-primary btn-lg"">Log in</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"container justify-content-center\">\r\n                <h3>");
#nullable restore
#line 38 "C:\Users\Viraldo\Desktop\MVC_Layout\MVC_Layout\Views\Home\Login.cshtml"
               Write(ViewBag.Authenticate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Layout.Models.Repository.IAccount> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591