#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7db9af03eb6ce233bbb7042fb2979081124a4b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_CommentsByWriter), @"mvc.1.0.view", @"/Views/Writer/CommentsByWriter.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7db9af03eb6ce233bbb7042fb2979081124a4b7", @"/Views/Writer/CommentsByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_CommentsByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
  
    ViewData["Title"] = "Yazar Blog Yorumları";
    Layout = "~/Views/Shared/WriterLayout.cshtml";
    string blog_score_color = "badge-gradient-warning";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Bloglara Yapılan Yorumlar</h4>
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Kullanıcı</th>
                            <th>Blog</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Puan</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 30 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                           Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            <td>");
#nullable restore
#line 32 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                           Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 34 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                           Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 36 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                           Write(DateTime.Parse(item.CommentDate.ToString()).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 38 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                             if (item.BlogScore >= 0 && item.BlogScore < 3)
                            {
                                blog_score_color = "badge-gradient-danger";
                            }
                            else if (item.BlogScore >= 3 && item.BlogScore < 4)
                            {
                                blog_score_color = "badge-gradient-warning";
                            }
                            else if (item.BlogScore >= 4 && item.BlogScore <= 5)
                            {
                                blog_score_color = "badge-gradient-success";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td><label");
            BeginWriteAttribute("class", " class=\"", 2009, "\"", 2040, 2);
            WriteAttributeValue("", 2017, "badge", 2017, 5, true);
#nullable restore
#line 51 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
WriteAttributeValue(" ", 2022, blog_score_color, 2023, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size:14px\">");
#nullable restore
#line 51 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                                                                                         Write(item.BlogScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label></td>

                            <td class=""text-navy"">
                                <button class=""btn btn-sm btn-outline-dark"" data-toggle=""modal"" data-target=""#Modal1""><i class=""mdi mdi-link-variant""></i>&nbsp; İçerik</button>


                                <div class=""modal"" id=""Modal1"">
                                    <div class=""modal-dialog"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h2 class=""modal-title"">Yorum İçeriği</h2>
                                            </div>
                                            <div class=""modal-body"">
                                                <label>");
#nullable restore
#line 64 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                                                  Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </td>
                        </tr>
");
#nullable restore
#line 72 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Writer\CommentsByWriter.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
