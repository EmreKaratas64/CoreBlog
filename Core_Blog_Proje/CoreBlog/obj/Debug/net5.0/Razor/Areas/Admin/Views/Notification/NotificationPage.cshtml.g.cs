#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be3a0fd3f3152492ccc59f16a2b219dff27561c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Notification_NotificationPage), @"mvc.1.0.view", @"/Areas/Admin/Views/Notification/NotificationPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3a0fd3f3152492ccc59f16a2b219dff27561c5", @"/Areas/Admin/Views/Notification/NotificationPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3002bba18602ea034213851867ed207d60ac82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Notification_NotificationPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml"
  
    ViewData["Title"] = "NotificationPage";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "be3a0fd3f3152492ccc59f16a2b219dff27561c54299", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml"
 if (TempData["PasifBasari"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger alert-dismissable\">\r\n            <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n            ");
#nullable restore
#line 13 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml"
       Write(TempData["PasifBasari"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 15 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml"
     if (TempData["AktifBasari"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success alert-dismissable\">\r\n            <button aria-hidden=\"true\" data-dismiss=\"alert\" class=\"close\" type=\"button\" onclick=\"refreash()\">×</button>\r\n            ");
#nullable restore
#line 21 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml"
       Write(TempData["AktifBasari"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 23 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Areas\Admin\Views\Notification\NotificationPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""col-lg-12"">
    <div class=""ibox "">
        <div class=""ibox-title"">
            <h5>Bildirimler</h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">
            <div id=""listnotificationshere"" class=""table-responsive"">

            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        window.onload = function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""GET"",
                url: ""/Admin/Notification/ListNotifications"",
                success: function (func) {
                    var n = jQuery.parseJSON(func);

                    let tablehtml = "" <table class=table table-hover> <thead> <tr> <th>#</th><th>Başlık</th> <th>Tarih</th> <th>Durum</th> <th>Düzenle</th> </tr> </thead > <tbody>"";

                    var status = """";
                    var btncol = ""btn-warning"";

                    $.each(n, (index, value) => {
                        if (value.NotificationStatus == true) {
                            status = ""Aktif"";
                            btncol = ""btn-primary"";
                        }

                        else {
                            status = ""Pasif"";
                            btncol = ""btn-danger"";
                  ");
                WriteLiteral(@"      }

                        tablehtml += `<tr><td>${value.NotificationID}</td><td> <label class=""${value.NotificationColor} text-white py-1 px-2"">${value.NotificationType}</label></td><td>${value.NotificationDate}</td><td> <a href=""/Admin/Notification/ChangeNotificationStatus/${value.NotificationID}"" class=""btn btn-outline ${btncol} btn-rounded""><i class=""fa fa-warning""></i>&nbsp;&nbsp; ${status} </button> </td><td><a href=""/Admin/Notification/BringNotification/${value.NotificationID}"" class=""btn btn-outline btn-warning btn-rounded""><i class=""fa fa-upload""></i>&nbsp;&nbsp;Düzenle</a></td></tr>`
                    });

                    tablehtml += ""</tbody></table>"";
                    $(""#listnotificationshere"").html(tablehtml);
                }
            });
        }
    </script>

");
            }
            );
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
