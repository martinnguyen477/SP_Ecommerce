#pragma checksum "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.ShopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Team27StaticFiles/mycss/shop.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "default", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "nameasc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "namedesc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "priceasc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "pricedesc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "viewdesc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "viewasc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control nice-select sort-select mr-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sort", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Cửa hàng";
    Layout = "~/Views/Shared/_Master.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf9387", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""breadcrumb-section"">
    <h2 class=""sr-only"">Site Breadcrumb</h2>
    <div class=""container"">
        <div class=""breadcrumb-contents"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
                    <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 642, "\"", 681, 5);
            WriteAttributeValue("", 649, "/", 649, 1, true);
#nullable restore
#line 20 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 650, Model.Type, 650, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 661, "/", 661, 1, true);
#nullable restore
#line 20 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 662, Model.DisplayPath, 662, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 680, "/", 680, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 21 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
               Write(Model.DisplayBreadcrumb);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </a></li>
                    <!-- breadcrumb -->
                </ol>
            </nav>
        </div>
    </div>
</section>
<main class=""inner-page-sec-padding-bottom"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-9 order-lg-2"">
                <!-- Hiển thị kết quả tìm kiếm cho -->
                <h3 id=""shop-page-description"">");
#nullable restore
#line 35 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <span id=\"book-count\">");
#nullable restore
#line 35 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                                                                    Write(Model.Books.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 35 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                                                                                           Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" kết quả</span></h3>
                <div class=""shop-toolbar with-sidebar mb--30"">

                    <div class=""row align-items-center"">

                        <div class=""col-lg-2 col-md-2 col-sm-6"">
                            <!-- Product View Mode -->
                            <div class=""product-view-mode"">
                                <a href=""#"" class=""sorting-btn active"" data-target=""grid"">
                                    <i class=""fas fa-th""></i>
                                </a>
                                <a href=""#"" class=""sorting-btn"" data-target=""grid-four"">
                                    <span class=""grid-four-icon"">
                                        <i class=""fas fa-grip-vertical""></i><i class=""fas fa-grip-vertical""></i>
                                    </span>
                                </a>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4 col-sm-6 mt--10 mt-md--0");
            WriteLiteral(" \">\r\n                            <div class=\"sorting-selection\">\r\n                                <span>Sắp xếp:</span>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf15043", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                     if (Model.search != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2590, "\"", 2611, 1);
#nullable restore
#line 59 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2598, Model.search, 2598, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 60 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2809, "\"", 2830, 1);
#nullable restore
#line 63 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2817, Model.search, 2817, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled/>\r\n");
#nullable restore
#line 64 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf17292", async() => {
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf17601", async() => {
                        WriteLiteral("Mặc định");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf19022", async() => {
                        WriteLiteral("\r\n                                            Tên: (A - Z)\r\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf20448", async() => {
                        WriteLiteral("\r\n                                            Tên: (Z - A)\r\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf21874", async() => {
                        WriteLiteral("\r\n                                            Giá: (Thấp &gt; cao)\r\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf23308", async() => {
                        WriteLiteral("\r\n                                            Giá: (Cao &gt; Thấp)\r\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf24742", async() => {
                        WriteLiteral("\r\n                                            Lượt xem: (Cao nhất)\r\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7603b4bb69dd77c4d138b18cce6dbdcae0fc40bf26178", async() => {
                        WriteLiteral("\r\n                                            Lượt xem: (Thấp nhất)\r\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 66 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.sort);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""shop-toolbar d-none"">
                    <div class=""row align-items-center"">
                        <div class=""col-lg-2 col-md-2 col-sm-6"">
                            <!-- Product View Mode -->
                            <div class=""product-view-mode"">
                                <a href=""#"" class=""sorting-btn active"" data-target=""grid"">
                                    <i class=""fas fa-th""></i>
                                </a>
                                <a href=""#"" class=""sorting-btn"" data-target=""grid-four"">
                                    <span class=""grid-four-icon"">
                                        <i class=""fas fa-grip-vertical""></i><i class=""fas fa-grip-vertical""></i>
                                    </span>
                                </a>
                                <a href=""#"" class=""sorting-bt");
            WriteLiteral(@"n"" data-target=""list "">
                                    <i class=""fas fa-list""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""shop-product-wrap grid with-pagination row space-db--30 shop-border"">
                    <!-- Hiển thị sách -->
");
#nullable restore
#line 115 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                     foreach (var book in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-sm-6\">\r\n                        <!--Gọi partial view hiển thị thông tin sách-->\r\n");
#nullable restore
#line 119 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                          await Html.RenderPartialAsync("_ProductCard", book);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 121 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!-- Pagination Block -->
                <div class=""row pt--30"">
                    <div class=""col-md-12"">
                        <div class=""pagination-block"">
                            <!-- Phân trang link -->
                            <!--Gọi partial view hiển thị phân trang-->
");
#nullable restore
#line 129 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                              await Html.RenderPartialAsync("_Pagination", new PaginationViewModel(Model.AllPages, Model.CurrentPage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3  mt--40 mt-lg--0"">
                <div class=""inner-page-sidebar"">
                    <!-- Accordion -->
                    <div class=""single-block"">
                        <h3 class=""sidebar-title"">Loại sách</h3>
                        <ul class=""sidebar-menu--shop"">
                            <!-- Danh sách loại sách -->
                            ");
#nullable restore
#line 141 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                       Write(await Component.InvokeAsync("CategoriesPublisherList", "loai-sach"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>

                    <div class=""single-block"">
                        <h3 class=""sidebar-title"">Nhà xuất bản</h3>
                        <ul class=""sidebar-menu--shop menu-type-2"">
                            <!-- Danh sách nhà xuất bản -->
                            ");
#nullable restore
#line 149 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                       Write(await Component.InvokeAsync("CategoriesPublisherList", "nha-xuat-ban"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>

                    <!-- Box Facebook page like -->
                    <div class=""single-block"">
                        <div class=""fb-page"" 
                             data-href=""https://www.facebook.com/Linhttk27"" 
                             data-tabs=""timeline"" 
                             data-width="""" 
                             data-height="""" 
                             data-small-header=""true"" 
                             data-adapt-container-width=""true"" 
                             data-hide-cover=""false"" 
                             data-show-facepile=""true"">
                        <blockquote cite=""https://www.facebook.com/Linhttk27"" class=""fb-xfbml-parse-ignore"">
                            <a href=""https://www.facebook.com/Linhttk27"">TwentySven - Ở đây có bán Sách</a>
                            </blockquote>
                        </div>
                    </div>

                    <!-- RSS Feeds ");
            WriteLiteral("Area -->\r\n");
#nullable restore
#line 171 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                     try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                   Write(await Component.InvokeAsync("RssFeed"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                                               
                    }
                    catch (Exception)
                    {
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.ShopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
