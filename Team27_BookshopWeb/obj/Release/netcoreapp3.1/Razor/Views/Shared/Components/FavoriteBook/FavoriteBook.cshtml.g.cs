#pragma checksum "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ca68fd9b1c7de99426099f95632aa1e83e5d77f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FavoriteBook_FavoriteBook), @"mvc.1.0.view", @"/Views/Shared/Components/FavoriteBook/FavoriteBook.cshtml")]
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
#line 1 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca68fd9b1c7de99426099f95632aa1e83e5d77f", @"/Views/Shared/Components/FavoriteBook/FavoriteBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FavoriteBook_FavoriteBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<button class=\"single-btn addToWishList\" data-proid=\'");
#nullable restore
#line 5 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
                                                Write(ViewBag.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>\r\n");
#nullable restore
#line 6 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
     if (Model == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i class=\"fas fa-heart loved\"></i>\r\n");
#nullable restore
#line 9 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i class=\"fas fa-heart\"></i>\r\n");
#nullable restore
#line 13 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</button>");
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
