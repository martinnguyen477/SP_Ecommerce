#pragma checksum "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc743d1502d0934d598ebc05a1240ade7daa6ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CouponGallery_Detail), @"mvc.1.0.view", @"/Views/CouponGallery/Detail.cshtml")]
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
#line 1 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc743d1502d0934d598ebc05a1240ade7daa6ea", @"/Views/CouponGallery/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_CouponGallery_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Entities.Coupon>
    {
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
#line 3 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
  
    ViewData["Title"] = Model.Name;
    Layout = "~/Views/Shared/_CouponLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"blog-post post-details mb--50\">\r\n    <div class=\"blog-gallery-slider\">\r\n        <div class=\"single-image\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0dc743d1502d0934d598ebc05a1240ade7daa6ea3617", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 286, "~/Team27StaticFiles/images/coupon/", 286, 34, true);
#nullable restore
#line 11 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
AddHtmlAttributeValue("", 320, Model.Image, 320, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
AddHtmlAttributeValue("", 339, Model.Name, 339, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"blog-content mt--30\">\r\n        <header>\r\n            <h3 class=\"blog-title\"> ");
#nullable restore
#line 16 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
                               Write(Model.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"post-meta\">\r\n                <span class=\"post-date\">\r\n                    <i class=\"far fa-calendar-alt\"></i>\r\n                    <span class=\"text-gray\">Ngày : </span>\r\n                    ");
#nullable restore
#line 21 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
               Write(Model.CreatedAt.ToString("dd-MM-yyyy lúc HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </header>\r\n        <article>\r\n            <h3 class=\"d-none sr-only\">blob-article</h3>\r\n            <p class=\"p-0\">\r\n                ");
#nullable restore
#line 28 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
           Write(Model.Description.Replace("<br>", Environment.NewLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <blockquote>\r\n                <div>\r\n                    <strong>CODE:</strong>\r\n                <p id=\"code\">");
#nullable restore
#line 33 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
                        Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </blockquote>\r\n            <div class=\"info\">\r\n                <p>Ngày bắt đầu: ");
#nullable restore
#line 37 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
                            Write(Model.StartsAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p style=\"color:red\">Ngày kết thúc: ");
#nullable restore
#line 38 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
                                               Write(Model.ExpiresAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </article>\r\n        <footer class=\"blog-meta\">\r\n            <div>\r\n                TAGS: <a");
            BeginWriteAttribute("href", " href=\"", 1549, "\"", 1597, 2);
            WriteAttributeValue("", 1556, "/ma-khuyen-mai/tags/", 1556, 20, true);
#nullable restore
#line 43 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
WriteAttributeValue("", 1576, Model.Type.ToLower(), 1576, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\CouponGallery\Detail.cshtml"
                                                                     Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>, <a href=\"/ma-khuyen-mai\">Khuyến mãi</a>\r\n            </div>\r\n        </footer>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Entities.Coupon> Html { get; private set; }
    }
}
#pragma warning restore 1591
