#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d4d21416cd50af7da0d309974f15a9022542030"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_ListAllNotifications), @"mvc.1.0.view", @"/Views/Notification/ListAllNotifications.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d4d21416cd50af7da0d309974f15a9022542030", @"/Views/Notification/ListAllNotifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_ListAllNotifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
  
    ViewData["Title"] = "Bildirimler";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Tüm Bildirimler</h4>
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>İçerik</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 27 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
                               Write(item.NotificationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                                <td><label");
            BeginWriteAttribute("class", " class=\"", 965, "\"", 1011, 3);
#nullable restore
#line 29 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
WriteAttributeValue("", 973, item.NotificationColor, 973, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 996, "text-white", 997, 11, true);
            WriteAttributeValue(" ", 1007, "p-2", 1008, 4, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size:14px;border-radius:6px\">");
#nullable restore
#line 29 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
                                                                                                                              Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n\r\n                                <td>");
#nullable restore
#line 31 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
                               Write(DateTime.Parse(item.NotificationDate.ToString()).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>");
#nullable restore
#line 33 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
                               Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 36 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Notification\ListAllNotifications.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
