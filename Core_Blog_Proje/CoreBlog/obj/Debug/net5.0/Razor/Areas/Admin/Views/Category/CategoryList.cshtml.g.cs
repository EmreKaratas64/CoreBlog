#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2aa76889d30931ca9d6b160e2d603311f783dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_CategoryList), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/CategoryList.cshtml")]
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
#nullable restore
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2aa76889d30931ca9d6b160e2d603311f783dc2", @"/Areas/Admin/Views/Category/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3002bba18602ea034213851867ed207d60ac82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/inspinia-gh-pages/css/AdminStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
  
    ViewData["Title"] = "Kategori Listesi";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2aa76889d30931ca9d6b160e2d603311f783dc24666", async() => {
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 13 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
 if (TempData["Activefailure"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissable\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n        ");
#nullable restore
#line 17 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
   Write(TempData["Activefailure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 22 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
 if (TempData["Passivefailure"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissable\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n        ");
#nullable restore
#line 26 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
   Write(TempData["Passivefailure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
 if (TempData["Activesuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissable\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n        ");
#nullable restore
#line 34 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
   Write(TempData["Activesuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 36 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
 if (TempData["Passivesuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissable\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n        ");
#nullable restore
#line 42 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
   Write(TempData["Passivesuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 44 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""col-lg-12"">
    <div class=""ibox "">
        <div class=""ibox-title"">
            <h5>Kategoriler </h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Kategori Adı</th>
                            <th>Aktif Yap</th>
                            <th>Pasif Yap</th>
                            <th>Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 71 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 74 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
                               Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 75 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2526, "\"", 2584, 2);
            WriteAttributeValue("", 2533, "/Admin/Category/MakeCategoryActive/", 2533, 35, true);
#nullable restore
#line 78 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 2568, item.CategoryID, 2568, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline btn-info btn-rounded\"><i class=\"fa fa-check\"></i>&nbsp;&nbsp;Aktif</a>\r\n                                </td>\r\n\r\n                                <td class=\"text-navy\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2816, "\"", 2875, 2);
            WriteAttributeValue("", 2823, "/Admin/Category/MakeCategoryPassive/", 2823, 36, true);
#nullable restore
#line 82 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 2859, item.CategoryID, 2859, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline btn-danger btn-rounded"" onclick=""return confirm('Kategoriyi pasif hale getirmek istediğinizden emin misiniz?')""><i class=""fa fa-warning""></i>&nbsp;&nbsp;Pasif</a>
                                </td>

                                <td>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 3181, "\"", 3234, 2);
            WriteAttributeValue("", 3188, "/Admin/Category/BringCategory/", 3188, 30, true);
#nullable restore
#line 86 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 3218, item.CategoryID, 3218, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline btn-warning btn-rounded\"><i class=\"fa fa-upload\"></i>&nbsp;&nbsp;Düzenle</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 89 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 95 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Category\CategoryList.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("CategoryList", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-outline btn-success btn-rounded\"><i class=\"fa fa-paste\"></i>&nbsp;&nbsp;Kategori Ekle</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
