#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "859ddbf33b437fd30618598fe0935eb0a53fd8b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_WidgetTop4_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/WidgetTop4/Default.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\_ViewImports.cshtml"
using CoreBlog.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\_ViewImports.cshtml"
using CoreBlog.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859ddbf33b437fd30618598fe0935eb0a53fd8b2", @"/Areas/Admin/Views/Shared/Components/WidgetTop4/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3002bba18602ea034213851867ed207d60ac82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_WidgetTop4_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.AppUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n        <div class=\"widget-head-color-box navy-bg p-lg text-center\">\r\n            <div class=\"m-b-md\">\r\n                <h2 class=\"font-bold no-margins\">\r\n                    ");
#nullable restore
#line 8 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
               Write(Model.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <small>Core Blog yetkili kullanıcı</small>\r\n            </div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 400, "\"", 436, 2);
            WriteAttributeValue("", 406, "/ProfileImages/", 406, 15, true);
#nullable restore
#line 12 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
WriteAttributeValue("", 421, Model.ImageUrl, 421, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle circle-border m-b-md\" alt=\"profile\">\r\n            <div>\r\n                <span>");
#nullable restore
#line 14 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
                 Write(ViewBag.gelen_mesaj_sayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> |\r\n                <span>Gelen mesaj</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"widget-text-box\">\r\n            <h4 class=\"media-heading\">");
#nullable restore
#line 19 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
                                 Write(Model.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            <p>Şuandaki aktif admin & moderatör rolüne sahip kullanıcı</p>
            <div class=""text-right"">
                <a href=""/Admin/AdminSettings/Setting/"" class=""btn btn-xs btn-outline btn-primary""><i class=""fa fa-gear""></i> Ayarlar</a>
            </div>
        </div>
    </div>



    <div class=""col-lg-2 mt-3"">
        <div class=""widget navy-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-user-circle fa-4x""></i>
                <h1 class=""m-xs"">");
#nullable restore
#line 33 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
                            Write(ViewBag.topla_kullanici);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <h3 class=""font-bold no-margins"">
                    Toplam kullanıcı
                </h3>
                <small>CoreBlog</small>
            </div>
        </div>
    </div>

    <div class=""col-lg-4 mt-3"">
        <div class=""widget lazur-bg p-xl"">

            <h2>
                ");
#nullable restore
#line 46 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
           Write(Model.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <ul class=\"list-unstyled m-t-md\">\r\n                <li>\r\n                    <span class=\"fa fa-envelope m-r-xs\"></span>\r\n                    <label>Mail: </label>\r\n                    ");
#nullable restore
#line 52 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    <span class=\"fa fa-user m-r-xs\"></span>\r\n                    <label>Kullancı Adı: </label>\r\n                    ");
#nullable restore
#line 57 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
               Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    <span class=\"fa fa-phone m-r-xs\"></span>\r\n                    <label>İletişim: </label>\r\n                    ");
#nullable restore
#line 62 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
               Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </li>
            </ul>

        </div>
    </div>

    <div class=""col-lg-2 mt-3"">
        <div class=""widget red-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-bell fa-4x""></i>
                <h1 class=""m-xs"">");
#nullable restore
#line 73 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\WidgetTop4\Default.cshtml"
                            Write(ViewBag.notf_say);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <h3 class=\"font-bold no-margins\">\r\n                    Bildirimler\r\n                </h3>\r\n                <small>Toplam bildirim sayısı</small>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n  \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591