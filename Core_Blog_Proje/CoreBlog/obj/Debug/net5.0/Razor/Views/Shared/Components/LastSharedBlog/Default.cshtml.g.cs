#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b4a580bcb89c9d7e8799dd095f85ff88af62a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LastSharedBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LastSharedBlog/Default.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b4a580bcb89c9d7e8799dd095f85ff88af62a8", @"/Views/Shared/Components/LastSharedBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LastSharedBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"single-gd tech-btm\">\r\n    <h4>Son paylaşılan blog</h4>\r\n");
#nullable restore
#line 6 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids\">\r\n\r\n            <div class=\"blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 255, "\"", 292, 2);
            WriteAttributeValue("", 262, "/Blog/BlogReadAll/", 262, 18, true);
#nullable restore
#line 11 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml"
WriteAttributeValue("", 280, item.BlogID, 280, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 320, "\"", 353, 2);
            WriteAttributeValue("", 326, "/BlogImages/", 326, 12, true);
#nullable restore
#line 12 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml"
WriteAttributeValue("", 338, item.BlogImage, 338, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 372, "\"", 378, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 513, "\"", 550, 2);
            WriteAttributeValue("", 520, "/Blog/BlogReadAll/", 520, 18, true);
#nullable restore
#line 18 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml"
WriteAttributeValue("", 538, item.BlogID, 538, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml"
                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h5>\r\n            </div>\r\n            <div class=\"clearfix\"> </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 24 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\Shared\Components\LastSharedBlog\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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