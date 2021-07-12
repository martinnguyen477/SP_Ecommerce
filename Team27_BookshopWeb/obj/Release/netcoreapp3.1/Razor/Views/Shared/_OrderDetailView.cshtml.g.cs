#pragma checksum "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee8835c1911bffe585761259258c34150639fbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderDetailView), @"mvc.1.0.view", @"/Views/Shared/_OrderDetailView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee8835c1911bffe585761259258c34150639fbe", @"/Views/Shared/_OrderDetailView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderDetailView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Areas.admin.Models.OrderDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""modal fade"" id=""modalOrderDetail"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""scrollmodalLabel"">Chi tiết đơn hàng</h5>
                    <button type=""button"" class=""close"" id=""modal-close"">
                        <span aria-hidden=""true"">X</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""tab-content"" id=""bill-detail"">
                        <div class=""tab-pane active"" id=""tab_1"">
                            <div class=""row"">
                                <div class=""col-md-6 col-sm-12"">
                                    <div class=""portlet yellow-crusta box"">
                                        <div class=""portlet-title"">
                                            <div class=""caption"">
  ");
            WriteLiteral(@"                                              <i class=""fa fa-cogs""></i><b>Chi tiết hóa đơn</b>
                                            </div>
                                        </div>
                                        <div class=""portlet-body"" id=""bill"">
                                            <!-- PHẦN THÔNG TIN ĐƠN HÀNG -->
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Hóa đơn:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 32 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Ngày lập hóa đơn:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 40 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.CreatedAt.ToString("dd/MM/yyyy - HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Trạng thái:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 48 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.OrderStatus.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Phương thức thanh toán:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 56 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.PaymentMethod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Tình trạng thanh toán:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 64 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.DisplayPaymentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 67 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                             if (Model.Order.CouponId != null && Model.Order.CouponId != 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""row static-info"">
                                                    <div class=""col-md-5 name"">
                                                        Mã khuyến mãi:
                                                    </div>
                                                    <div class=""col-md-7 value"">
                                                        ");
#nullable restore
#line 74 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                                   Write(Model.Order.Coupon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 77 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Tổng tiền:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 84 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.DisplayTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6 col-sm-12"">
                                    <div class=""portlet blue-hoki box"">
                                        <div class=""portlet-title"">
                                            <div class=""caption"">
                                                <i class=""fa fa-cogs""></i><b>Thông tin khách hàng</b>
                                            </div>
                                        </div>
                                        <div class=""portlet-body"" id=""cus-info"">
                                            <!-- PHẦN THÔNG TIN KHÁCH HÀNG -->
                                            <div class=""row static-info"">
                                                <div class=""col-md-");
            WriteLiteral(@"5 name"">
                                                    Tên khách hàng:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 104 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Địa chỉ:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 112 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row static-info"">
                                                <div class=""col-md-5 name"">
                                                    Số điện thoại:
                                                </div>
                                                <div class=""col-md-7 value"">
                                                    ");
#nullable restore
#line 120 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                               Write(Model.Order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12 col-sm-12"">
                                    <div class=""portlet grey-cascade box"">
                                        <div class=""portlet-title"">
                                            <div class=""caption"">
                                                <i class=""fa fa-cogs""></i>Các sản phẩm đã mua
                                            </div>
                                        </div>
                                        <div class=""portlet-body"">
                                            <div class=""table-responsive"">
                                                <table class=""table table-hover t");
            WriteLiteral(@"able-bordered table-striped"" id=""table-details"">
                                                    <!-- PHẦN CHI TIẾT ĐƠN HÀNG -->
                                                    <thead>
                                                        <tr>
                                                            <th>Sản phẩm</th>
                                                            <th>Giá</th>
                                                            <th>Số lượng</th>
                                                            <th>Tổng tiền</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
#nullable restore
#line 148 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                                         foreach (var orderDetail in Model.OrderDetails)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                <td>\r\n                                                                    <a");
            BeginWriteAttribute("href", " href=\"", 10053, "\"", 10088, 2);
            WriteAttributeValue("", 10060, "/sach/", 10060, 6, true);
#nullable restore
#line 152 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
WriteAttributeValue("", 10066, orderDetail.Book.Slug, 10066, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 152 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                                                                                      Write(orderDetail.Book.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 155 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                                               Write(orderDetail.Book.DisplayPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 158 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                                               Write(orderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 161 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                                               Write(orderDetail.DisplayTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </td>\r\n                                                            </tr>\r\n");
#nullable restore
#line 164 "D:\HocKy2_2020-2021\ThuongMaiĐT\Source\Source_host\source\SP_Ecommerce\Team27_BookshopWeb\Views\Shared\_OrderDetailView.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                </div>
                                <div class=""col-md-6"">
                                    <button id=""btn-back-modal"" class=""btn btn--primary w-100 blue-stripe blue-steel"">Quay về</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

<script>
    // Đóng modal Chi tiết đơn hàng
    $('#btn-back-modal, .close#modal-close').on('click', function () {
        $(""#modalOrd");
            WriteLiteral("erDetail\").modal(\"hide\");\r\n\t});\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Areas.admin.Models.OrderDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
