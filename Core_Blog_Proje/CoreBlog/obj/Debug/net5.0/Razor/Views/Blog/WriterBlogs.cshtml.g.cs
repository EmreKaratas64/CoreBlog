#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6ce44c4353bc358dab4b1b74934b4074232b882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_WriterBlogs), @"mvc.1.0.view", @"/Views/Blog/WriterBlogs.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6ce44c4353bc358dab4b1b74934b4074232b882", @"/Views/Blog/WriterBlogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_WriterBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
  
    ViewData["Title"] = "Bloglarım";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar Blog Listesi</h4>
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Kategori</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 29 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
                               Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 30 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
                               Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><label class=\"badge badge-gradient-info\" style=\"font-size:14px\">");
#nullable restore
#line 31 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
                                                                                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                                <td>");
#nullable restore
#line 32 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
                               Write(DateTime.Parse(item.BlogCreateDate.ToString()).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1346, "\"", 1382, 2);
            WriteAttributeValue("", 1353, "/Blog/DeleteBlog/", 1353, 17, true);
#nullable restore
#line 33 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
WriteAttributeValue("", 1370, item.BlogID, 1370, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" onclick=\"return confirm(\'Bu bloğu silmek istediğinizden emin misiniz?\')\"><i class=\"mdi mdi-alert btn-icon-prepend\"></i>&nbsp; Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1629, 2);
            WriteAttributeValue("", 1600, "/Blog/UpdateBlog/", 1600, 17, true);
#nullable restore
#line 34 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
WriteAttributeValue("", 1617, item.BlogID, 1617, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\"><i class=\"mdi mdi-upload btn-icon-prepend\"></i>&nbsp; Düzenle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 36 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Blog\WriterBlogs.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>

            <br />
            <a href=""/Blog/AddBlog/"" class=""btn btn-gradient-info""><i class=""mdi mdi-file-check btn-icon-prepend""></i>&nbsp; Blog Ekle</a>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
