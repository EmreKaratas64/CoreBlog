#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7064b5ea0d327cdd996da184b0f4e90814c5cd7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterMessages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterMessages/Default.cshtml")]
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
#nullable restore
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7064b5ea0d327cdd996da184b0f4e90814c5cd7b", @"/Views/Shared/Components/WriterMessages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterMessages_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"
   
    int mesaj_sayi = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Mesajlar</h6>\r\n");
#nullable restore
#line 10 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <a class=\"dropdown-item preview-item\">\r\n            <div class=\"preview-thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 440, "\"", 486, 2);
            WriteAttributeValue("", 446, "/ProfileImages/", 446, 15, true);
#nullable restore
#line 15 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"
WriteAttributeValue("", 461, item.SenderUser.ImageUrl, 461, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" class=\"profile-pic\">\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 18 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"
                                                                        Write(item.SenderUser.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mesaj gönderdi</h6>\r\n                <p class=\"text-gray mb-0\"> ");
#nullable restore
#line 19 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"
                                      Write(item.MessageDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 22 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"

        if(item.MessageDate == DateTime.Today)
        {
            mesaj_sayi++;
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6 class=\"p-3 mb-0 text-center\">");
#nullable restore
#line 29 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterMessages\Default.cshtml"
                                Write(mesaj_sayi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" yeni mesaj</h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
