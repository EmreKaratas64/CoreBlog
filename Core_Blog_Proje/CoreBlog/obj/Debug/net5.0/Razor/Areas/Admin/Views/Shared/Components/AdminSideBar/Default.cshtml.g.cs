#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\AdminSideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b27add8569327a1f275f1ef629928a06ee2529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_AdminSideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/AdminSideBar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b27add8569327a1f275f1ef629928a06ee2529", @"/Areas/Admin/Views/Shared/Components/AdminSideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3002bba18602ea034213851867ed207d60ac82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_AdminSideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/logo3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    <img alt=""image"" class=""rounded-circle""");
            BeginWriteAttribute("src", " src=\"", 310, "\"", 351, 2);
            WriteAttributeValue("", 316, "/ProfileImages/", 316, 15, true);
#nullable restore
#line 8 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\AdminSideBar\Default.cshtml"
WriteAttributeValue("", 331, ViewBag.admin_photo, 331, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:90px\" />\r\n                    <a data-toggle=\"dropdown\" class=\"dropdown-toggle\" href=\"#\">\r\n                        <span class=\"block m-t-xs font-bold\">");
#nullable restore
#line 10 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\AdminSideBar\Default.cshtml"
                                                        Write(ViewBag.admin_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        <span class=""text-muted text-xs block"">Admin & Moderatör </span>
                    </a>
                </div>
                <div class=""logo-element"">
                    <a class=""navbar-brand brand-logo-mini"" href=""/Admin/Widget/MainPage/"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47b27add8569327a1f275f1ef629928a06ee25295571", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                </div>
            </li>
            <li>
                <a href=""/Admin/Widget/MainPage/""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboard</span> </a>
            </li>
            <li>
                <a href=""mailbox.html""><i class=""fa fa-envelope""></i> <span class=""nav-label"">Mesajlar </span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""/Admin/AdminMessage/InBox/"">Gelen Kutusu</a></li>
                    <li><a href=""/Admin/AdminMessage/SendBox/"">Giden Kutusu</a></li>
                    <li><a href=""/Admin/AdminMessage/SendMessage/"">Yeni Mesaj</a></li>
                </ul>
            </li>
            <li>
                <a href=""/Admin/Category/CategoryList/""><i class=""fa fa-list-alt""></i> <span class=""nav-label"">Kategoriler</span></a>
            </li>
            <li>
                <a href=""/Admin/Blog/BlogsPage/""><i class=""fa fa-paper-plane""></i> <span class=""nav-label"">Bloglar</span></a>");
            WriteLiteral(@"
            </li>

            <li>
                <a href=""/Admin/Comment/CommentsPage/""><i class=""fa fa-comments""></i> <span class=""nav-label"">Yorumlar</span></a>
            </li>
            <li>
                <a href=""/Admin/Contact/ContactMessages/""><i class=""fa fa-phone""></i> <span class=""nav-label"">Site Mesajları</span></a>
            </li>
            <li>
                <a href=""/Admin/MailSubscribes/NewsLetter/""><i class=""fa fa-envelope-o""></i> <span class=""nav-label"">Mail Abonelikleri</span></a>
            </li>
            <li>
                <a href=""/Admin/Writer/WriterPage/""><i class=""fa fa-users""></i> <span class=""nav-label"">Yazarlar</span></a>
            </li>
            <li>
                <a href=""/Admin/User/UsersPage/""><i class=""fa fa-users""></i> <span class=""nav-label"">Kullanıcılar</span></a>
            </li>

            <li class=""landing_link"">
                <a target=""_blank"" href=""/Admin/Notification/NotificationPage/""><i class=""fa fa-bell""></i> <sp");
            WriteLiteral("an class=\"nav-label\">Bildirimler</span> <span class=\"label label-warning float-right\">");
#nullable restore
#line 53 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\AdminSideBar\Default.cshtml"
                                                                                                                                                                                               Write(ViewBag.notification_sayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n            </li>\r\n\r\n            <li class=\"landing_link\">\r\n                <a target=\"_blank\" href=\"/Admin/AdminSettings/Setting\"><i class=\"fa fa-gears\"></i> <span class=\"nav-label\">Ayarlar</span></a>\r\n            </li>\r\n");
#nullable restore
#line 59 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\AdminSideBar\Default.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li>
                    <a target=""_blank"" href=""/Admin/AdminRole/RolesPage/""><i class=""fa fa-list-ul""></i> <span class=""nav-label"">Roller</span></a>
                </li>
                <li>
                    <a target=""_blank"" href=""/Admin/AdminRole/UsersRoleList/""><i class=""fa fa-vcard""></i> <span class=""nav-label"">Kullanıcı Rolleri</span></a>
                </li>
");
#nullable restore
#line 67 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Shared\Components\AdminSideBar\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a href=\"/Admin/AdminLogin/LogOut/\"><i class=\"fa fa-power-off\"></i> <span class=\"nav-label\">Çıkış Yap </span></a>\r\n            </li>\r\n        </ul>\r\n\r\n    </div>\r\n</nav>");
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
