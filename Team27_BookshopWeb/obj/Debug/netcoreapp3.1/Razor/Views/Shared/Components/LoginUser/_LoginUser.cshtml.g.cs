#pragma checksum "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\LoginUser\_LoginUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03289a86c34a61e32504b00f428ba8d9e56ffdb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LoginUser__LoginUser), @"mvc.1.0.view", @"/Views/Shared/Components/LoginUser/_LoginUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03289a86c34a61e32504b00f428ba8d9e56ffdb1", @"/Views/Shared/Components/LoginUser/_LoginUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LoginUser__LoginUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\LoginUser\_LoginUser.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\">\r\n        <i class=\"icons-left fas fa-user\"></i> ");
#nullable restore
#line 8 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\LoginUser\_LoginUser.cshtml"
                                          Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </a><i class=""fas fa-chevron-down dropdown-arrow""></i>
    <ul class=""dropdown-box sub-menu"">
        <li> <a href=""/my-account/profile"">Tài khoản của tôi</a></li>
        <li> <a href=""/my-account/history"">Lịch sử đơn hàng</a></li>
        <li> <a href=""/my-account/wishlist"">Danh sách yêu thích</a></li>
        <li> <a href=""/logout"">Đăng xuất</a></li>
    </ul>
");
#nullable restore
#line 16 "F:\Ecommerce\Project\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\LoginUser\_LoginUser.cshtml"
}

#line default
#line hidden
#nullable disable
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
