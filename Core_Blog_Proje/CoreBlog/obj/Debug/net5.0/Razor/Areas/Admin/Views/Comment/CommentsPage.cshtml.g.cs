#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c765b5c307e2d93ebe336aa486a4e9d7f83a35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_CommentsPage), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/CommentsPage.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c765b5c307e2d93ebe336aa486a4e9d7f83a35", @"/Areas/Admin/Views/Comment/CommentsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3002bba18602ea034213851867ed207d60ac82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_CommentsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
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
#line 4 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
  
    ViewData["Title"] = "CommentsPage";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";
    string blog_score_color = "text-warning";
    string blog_score_icon = "fa-level-up";
    string comment_status = "Pasif";
    string comment_status_btn = "btn-primary";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71c765b5c307e2d93ebe336aa486a4e9d7f83a354619", async() => {
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
#line 16 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
 if (TempData["CommentAktif"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissable\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n        ");
#nullable restore
#line 20 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
   Write(TempData["CommentAktif"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 22 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
 if (TempData["PasifYapılamaz"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissable\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n        ");
#nullable restore
#line 28 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
   Write(TempData["PasifYapılamaz"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 30 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
 if (TempData["YorumSilmeBasari"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissable\">\r\n        <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n        ");
#nullable restore
#line 36 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
   Write(TempData["YorumSilmeBasari"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 38 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12"">
    <div class=""ibox "">
        <div class=""ibox-title"">
            <h5>Yorumlar </h5>
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
                            <th>Kullancı</th>
                            <th>Blog</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Puan</th>
                            <th>Durum</th>
                            <th>Sil</th>
                            <th>Detay</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 67 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 70 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                               Write(item.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 71 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                               Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                               Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 73 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                               Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 74 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                               Write(DateTime.Parse(item.CommentDate.ToString()).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 75 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                                 if (item.BlogScore >= 0 && item.BlogScore < 3)
                                {
                                    blog_score_color = "text-danger";
                                    blog_score_icon = "fa-level-down";
                                }

                                else if (item.BlogScore >= 3 && item.BlogScore < 4)
                                {
                                    blog_score_color = "text-warning";
                                    blog_score_icon = "fa-level-up";
                                }

                                else if (item.BlogScore >= 4 && item.BlogScore <= 5)
                                {
                                    blog_score_color = "text-navy";
                                    blog_score_icon = "fa-level-up";
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3617, "\"", 3642, 1);
#nullable restore
#line 93 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
WriteAttributeValue("", 3625, blog_score_color, 3625, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i");
            BeginWriteAttribute("class", " class=\"", 3647, "\"", 3674, 2);
            WriteAttributeValue("", 3655, "fa", 3655, 2, true);
#nullable restore
#line 93 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
WriteAttributeValue(" ", 3657, blog_score_icon, 3658, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 93 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                                                                                              Write(item.BlogScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 94 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                                 if (item.CommentStatus == false)
                                {
                                    comment_status = "Pasif";
                                    comment_status_btn = "btn-danger";
                                }
                                else
                                {
                                    comment_status = "Aktif";
                                    comment_status_btn = "btn-primary";
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"text-navy\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4314, "\"", 4369, 2);
            WriteAttributeValue("", 4321, "/Admin/Comment/MakeCommentActive/", 4321, 33, true);
#nullable restore
#line 105 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
WriteAttributeValue("", 4354, item.CommentID, 4354, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 4370, "\"", 4425, 4);
            WriteAttributeValue("", 4378, "btn", 4378, 3, true);
            WriteAttributeValue(" ", 4381, "btn-outline", 4382, 12, true);
#nullable restore
#line 105 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
WriteAttributeValue(" ", 4393, comment_status_btn, 4394, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4413, "btn-rounded", 4414, 12, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-warning\"></i>&nbsp;&nbsp; ");
#nullable restore
#line 105 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                                                                                                                                                                                            Write(comment_status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </td>\r\n\r\n                                <td class=\"text-navy\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4625, "\"", 4676, 2);
            WriteAttributeValue("", 4632, "/Admin/Comment/DeleteComment/", 4632, 29, true);
#nullable restore
#line 109 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
WriteAttributeValue("", 4661, item.CommentID, 4661, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline btn-danger btn-rounded"" onclick=""return confirm('Yorumları silme işleminin geri dönüşü yoktur. Yine de bu yorumu silmek istediğinizden emin misiniz?')""><i class=""fa fa-warning""></i>&nbsp;&nbsp; Sil</a>
                                </td>
                                <td class=""text-navy"">
                                    <button class=""btn btn-outline btn-info btn-rounded"" data-toggle=""modal"" data-target=""#");
#nullable restore
#line 112 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                                                                                                                      Write(item.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-link\"></i>&nbsp; İçerik</button>\r\n\r\n\r\n                                    <div class=\"modal\"");
            BeginWriteAttribute("id", " id=\"", 5247, "\"", 5267, 1);
#nullable restore
#line 115 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
WriteAttributeValue("", 5252, item.CommentID, 5252, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <div class=""modal-dialog"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h2 class=""modal-title"">Yorum İçeriği</h2>
                                                </div>
                                                <div class=""modal-body"">
                                                    <label>");
#nullable restore
#line 122 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
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
#line 132 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Comment\CommentsPage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
