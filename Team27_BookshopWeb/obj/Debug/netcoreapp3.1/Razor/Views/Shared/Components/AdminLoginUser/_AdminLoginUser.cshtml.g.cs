#pragma checksum "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ee70b80595fc1112691c2a7374b07b02a85f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminLoginUser__AdminLoginUser), @"mvc.1.0.view", @"/Views/Shared/Components/AdminLoginUser/_AdminLoginUser.cshtml")]
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
#line 1 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ee70b80595fc1112691c2a7374b07b02a85f0a", @"/Views/Shared/Components/AdminLoginUser/_AdminLoginUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminLoginUser__AdminLoginUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 6 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"header-wrap\">\r\n\r\n        <div class=\"header-button\">\r\n\r\n            <div class=\"account-wrap\">\r\n                <div class=\"account-item clearfix js-item-menu\">\r\n                    <div class=\"image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0ee70b80595fc1112691c2a7374b07b02a85f0a3904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "~/Team27StaticFiles/Admins/images/icon/", 423, 39, true);
#nullable restore
#line 15 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
AddHtmlAttributeValue("", 462, ViewBag.Gender==1 ? "female.png" : "male.png", 462, 48, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
AddHtmlAttributeValue("", 517, ViewBag.Name, 517, 13, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"content\">\r\n                        <a class=\"js-acc-btn\" href=\"#\">");
#nullable restore
#line 18 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
                                                  Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                    </div>
                    <div class=""account-dropdown js-dropdown"">
                        <div class=""info clearfix"">
                            <div class=""image"">
                                <a href=""#"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0ee70b80595fc1112691c2a7374b07b02a85f0a6786", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 967, "~/Team27StaticFiles/Admins/images/icon/", 967, 39, true);
#nullable restore
#line 24 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
AddHtmlAttributeValue("", 1006, ViewBag.Gender==1 ? "female.png" : "male.png", 1006, 48, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
AddHtmlAttributeValue("", 1061, ViewBag.Name, 1061, 13, false);

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
            WriteLiteral("\r\n                                </a>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <h5 class=\"name\">\r\n                                    <a href=\"profile\">");
#nullable restore
#line 29 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
                                                 Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <span class=\"email\">");
#nullable restore
#line 31 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
                                               Write(ViewBag.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""account-dropdown__body"">
                            <div class=""account-dropdown__item"">
                                <a href=""/admin/profile"">
                                    <i class=""zmdi zmdi-account""></i>Tài khoản
                                </a>
                            </div>
                        </div>
                        <div class=""account-dropdown__footer"">
                            <a href=""/admin/logout"">
                                <i class=""zmdi zmdi-power""></i>Đăng xuất
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 51 "C:\Users\Nguyen Quoc Cuong\Desktop\New folder (3)\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\AdminLoginUser\_AdminLoginUser.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
