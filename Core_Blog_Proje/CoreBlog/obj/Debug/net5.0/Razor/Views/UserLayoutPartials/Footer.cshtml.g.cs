#pragma checksum "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\UserLayoutPartials\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65dc245206845922d0d589b7ffa57670fd7e0135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserLayoutPartials_Footer), @"mvc.1.0.view", @"/Views/UserLayoutPartials/Footer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65dc245206845922d0d589b7ffa57670fd7e0135", @"/Views/UserLayoutPartials/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserLayoutPartials_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                <h3>Hakkımızda</h3>
                <p>Blog (Türkçe: ağ günlüğü, günce) veya Weblog (Türkçe: Ağ kütüğü) teknik bilgi gerektirmeden, kendi istedikleri şeyleri, kendi istedikleri şekilde yazan insanların oluşturabildikleri, günlüğe benzeyen web siteleridir...</p>
                <div class=""read"">
                    <a href=""/About/AboutPage/"" class=""btn btn-primary read-m"">Devamını Oku</a>
                </div>
            </div>
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">

                ");
#nullable restore
#line 14 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\UserLayoutPartials\Footer.cshtml"
           Write(await Component.InvokeAsync("Last3Blogs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <!-- subscribe -->\r\n            <div class=\"col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left\">\r\n                <h2>Mail bültenine abone olun</h2>\r\n                ");
#nullable restore
#line 20 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\UserLayoutPartials\Footer.cshtml"
           Write(await Html.PartialAsync("~/Views/Blog/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- //subscribe -->
            </div>
        </div>
        <!-- footer -->
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                                <span>Facebook</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-twitter""></i>
                                <span>Twitter</span>
                            </a>
                        </li>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-google-plus-g""></i>
                                <");
            WriteLiteral(@"span>Google+</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-pinterest-p""></i>
                                <span>Pinterest</span>
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
            <div class=""w3layouts-agile-copyrightbottom"">
                <p>
                    © ");
#nullable restore
#line 59 "D:\WebTasarım\Core_Blog_Proje\CoreBlog\Views\UserLayoutPartials\Footer.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Core Blog. Tüm hakları saklıdır |\r\n                    <a href=\"http://w3layouts.com/\">W3layouts</a> tarafından tasarlandı\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>\r\n");
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