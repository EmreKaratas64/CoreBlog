#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterDashboardNavbarProfile\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9d26c7f843dce41d1f0bf9f5c03fbe6e6abe11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterDashboardNavbarProfile_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterDashboardNavbarProfile/Default.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9d26c7f843dce41d1f0bf9f5c03fbe6e6abe11", @"/Views/Shared/Components/WriterDashboardNavbarProfile/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterDashboardNavbarProfile_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"nav-item nav-profile dropdown\">\r\n    <a class=\"nav-link dropdown-toggle\" id=\"profileDropdown\" href=\"#\" data-toggle=\"dropdown\" aria-expanded=\"false\">\r\n        <div class=\"nav-profile-img\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 259, 2);
            WriteAttributeValue("", 224, "/ProfileImages/", 224, 15, true);
#nullable restore
#line 5 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterDashboardNavbarProfile\Default.cshtml"
WriteAttributeValue("", 239, ViewBag.writerphoto, 239, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\">\r\n            <span class=\"availability-status online\"></span>\r\n        </div>\r\n        <div class=\"nav-profile-text\">\r\n            <p class=\"mb-1 text-black\">");
#nullable restore
#line 9 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterDashboardNavbarProfile\Default.cshtml"
                                  Write(ViewBag.namesurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </a>
    <div class=""dropdown-menu navbar-dropdown"" aria-labelledby=""profileDropdown"">
        <a class=""dropdown-item"" href=""/Writer/WriterSettings/"">
            <i class=""mdi mdi-cached mr-2 text-success""></i> Hesap Ayarları
        </a>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item"" href=""/WriterLogin/LogOutWriter/"">
            <i class=""mdi mdi-logout mr-2 text-primary""></i> Çıkış Yap
        </a>
    </div>
</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
