#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1141a32d398b7dd86be1aa568705ef3586f2c3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Widget_MainPage), @"mvc.1.0.view", @"/Areas/Admin/Views/Widget/MainPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1141a32d398b7dd86be1aa568705ef3586f2c3b", @"/Areas/Admin/Views/Widget/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3002bba18602ea034213851867ed207d60ac82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Widget_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper wrapper-content animated fadeInRight\">\r\n\r\n    ");
#nullable restore
#line 9 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
Write(await Component.InvokeAsync("WidgetsTop"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 11 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
Write(await Component.InvokeAsync("WidgetTop2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 13 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
Write(await Component.InvokeAsync("WidgetTop4"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"row m-t-lg\">\r\n        <div class=\"col-lg-6\">\r\n            <div class=\"ibox \">\r\n\r\n                ");
#nullable restore
#line 19 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
           Write(await Component.InvokeAsync("CommentsToBeApproved"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>


        <div class=""col-lg-6"">
            <div>
                <table class=""table"">
                    <tbody>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-danger m-r-sm"">");
#nullable restore
#line 31 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                               Write(ViewBag.mesajlar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                Mesajlar\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-primary m-r-sm\">");
#nullable restore
#line 35 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                                Write(ViewBag.bloglar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                Bloglar\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-info m-r-sm\">");
#nullable restore
#line 39 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                             Write(ViewBag.yorumlar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                                Yorumlar
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-info m-r-sm"">");
#nullable restore
#line 45 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                             Write(ViewBag.kategoriler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                Kategoriler\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-success m-r-sm\">");
#nullable restore
#line 49 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                                Write(ViewBag.aktif_yazar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                Aktif Yazarlar\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-danger m-r-sm\">");
#nullable restore
#line 53 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                               Write(ViewBag.bildirimler);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                                Bildirimler
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-warning m-r-sm"">");
#nullable restore
#line 59 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                                Write(ViewBag.aktif_blog);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                Aktif Bloglar\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-default m-r-sm\">");
#nullable restore
#line 63 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                                Write(ViewBag.moderatorler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                Moderatörler\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-warning m-r-sm\">");
#nullable restore
#line 67 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                                                                                Write(ViewBag.adminler);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                                Adminler
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div>
                <div class=""row"">
                    <div class=""col-md-8 mx-auto"">
                        <div class=""ibox-content text-center"">
                            <h1>");
#nullable restore
#line 78 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
                           Write(ViewBag.constructor_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <div class=\"m-b-sm\">\r\n                                <img alt=\"image\" class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 3308, "\"", 3353, 2);
            WriteAttributeValue("", 3314, "/ProfileImages/", 3314, 15, true);
#nullable restore
#line 80 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
WriteAttributeValue("", 3329, ViewBag.constructor_img, 3329, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <p class=\"font-bold\">Site Kurucusu</p>\r\n\r\n                            <div class=\"text-center\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3552, "\"", 3613, 2);
            WriteAttributeValue("", 3559, "/Admin/AdminMessage/SendMessage/", 3559, 32, true);
#nullable restore
#line 85 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Widget\MainPage.cshtml"
WriteAttributeValue("", 3591, ViewBag.site_const_id, 3591, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-outline btn-primary""><i class=""fa fa-phone""></i> İletişim</a>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>

</div>


<script>
    $(document).ready(function () {
        setTimeout(function () {
            toastr.options = {
                closeButton: true,
                progressBar: true,
                showMethod: 'slideDown',
                timeOut: 4000
            };
            toastr.success('Responsive Admin Theme', 'Welcome to INSPINIA');

        }, 1300);

    });
</script>
");
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