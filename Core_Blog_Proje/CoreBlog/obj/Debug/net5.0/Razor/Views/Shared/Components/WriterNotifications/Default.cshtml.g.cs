#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5493012c98aa5b30476e8f074be7220dde18c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotifications_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotifications/Default.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5493012c98aa5b30476e8f074be7220dde18c0c", @"/Views/Shared/Components/WriterNotifications/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterNotifications_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\r\n");
#nullable restore
#line 6 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <a class=\"dropdown-item preview-item\" href=\"#\">\r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 427, "\"", 471, 2);
            WriteAttributeValue("", 435, "preview-icon", 435, 12, true);
#nullable restore
#line 11 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml"
WriteAttributeValue(" ", 447, item.NotificationColor, 448, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 497, "\"", 531, 1);
#nullable restore
#line 12 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml"
WriteAttributeValue("", 505, item.NotificationTypeIcon, 505, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 16 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml"
                                                               Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 17 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml"
                                               Write(DateTime.Parse(item.NotificationDate.ToString()).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 20 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\WriterNotifications\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6 class=\"p-3 mb-0 text-center\"><a href=\"/Notification/ListAllNotifications/\">Tüm Bildirimleri Gör</a></h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
