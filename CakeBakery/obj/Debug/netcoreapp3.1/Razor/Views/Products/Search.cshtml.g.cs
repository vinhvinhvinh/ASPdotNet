#pragma checksum "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Products\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f09cd5ee1e6b0600e9ce487f4b88e78666199aa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Search), @"mvc.1.0.view", @"/Views/Products/Search.cshtml")]
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
#line 1 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\_ViewImports.cshtml"
using CakeBakery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\_ViewImports.cshtml"
using CakeBakery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09cd5ee1e6b0600e9ce487f4b88e78666199aa7", @"/Views/Products/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3def8db8697e3562503afc1797c3cc8f1be8bf6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CakeBakery.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Products\Search.cshtml"
  
    var UOC_Format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
    ViewData["Title"] = "Kết quả tìm kiếm";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f09cd5ee1e6b0600e9ce487f4b88e78666199aa74080", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!--================Product Area =================-->
<section class=""product_area p_100"">
    <div class=""container"">
        <div class=""row product_inner_row"">
            <div class=""col-lg-9"">
                <div class=""row product_item_inner"">
");
#nullable restore
#line 16 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Products\Search.cshtml"
                     foreach (var prod in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-4 col-6\">\r\n                            <div class=\"cake_feature_item\">\r\n                                <div class=\"cake_img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f09cd5ee1e6b0600e9ce487f4b88e78666199aa75936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 886, "~/img/cake-feature/", 886, 19, true);
#nullable restore
#line 21 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Products\Search.cshtml"
AddHtmlAttributeValue("", 905, prod.Image, 905, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"cake_text\">\r\n                                    <h4>");
#nullable restore
#line 24 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Products\Search.cshtml"
                                   Write(String.Format(UOC_Format, "{0:c0}", @prod.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h3>");
#nullable restore
#line 25 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Products\Search.cshtml"
                                   Write(prod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <a class=\"pest_btn\" href=\"#\">Thêm vào giỏ hàng</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 30 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Products\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""product_pagination"">
                    <div class=""left_btn"">
                        <a href=""#""><i class=""lnr lnr-arrow-left""></i> Trang trước</a>
                    </div>
                    <div class=""middle_list"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination"">
                                <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">...</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">12</a></li>
                            </ul>
                        </nav>
                    </div>
                    <div class=""right");
            WriteLiteral(@"_btn""><a href=""#"">Trang sau <i class=""lnr lnr-arrow-right""></i></a></div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""product_left_sidebar"">
                    <aside class=""left_sidebar search_widget"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Nhập từ khóa"">
                            <div class=""input-group-append"">
                                <button class=""btn"" type=""button""><i class=""icon icon-Search""></i></button>
                            </div>
                        </div>
                    </aside>
                    <aside class=""left_sidebar p_catgories_widget"">
                        <div class=""p_w_title"">
                            <h3>Loại sản phẩm</h3>
                        </div>
                        <ul class=""list_style"">
                            <li><a href=""#"">Tên loại (số lượng)</a></li>
           ");
            WriteLiteral(@"                 <li><a href=""#"">Chocolate (15)</a></li>
                            <li><a href=""#"">Celebration (14)</a></li>
                            <li><a href=""#"">Wedding Cake (8)</a></li>
                            <li><a href=""#"">Desserts (11)</a></li>
                        </ul>
                    </aside>
                    <aside class=""left_sidebar p_price_widget"">
                        <div class=""p_w_title"">
                            <h3>Chọn khoản giá</h3>
                        </div>
                        <div class=""filter_price"">
                            <div id=""slider-range""></div>
                            <label for=""amount"">Khoảng:</label>
                            <input type=""text"" id=""amount"" readonly />
                            <a href=""#"">Lọc</a>
                        </div>
                    </aside>
                    <aside class=""left_sidebar p_sale_widget"">
                        <div class=""p_w_title"">
                        ");
            WriteLiteral("    <h3>Sản phẩm bán chạy</h3>\r\n                        </div>\r\n                        <div class=\"media\">\r\n                            <div class=\"d-flex\">\r\n                                <img src=\"img/product/sale-product/s-product-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4710, "\"", 4716, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Tên sản phẩm</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>Gía</h5>
                            </div>
                        </div>
                        <div class=""media"">
                            <div class=""d-flex"">
                                <img src=""img/product/sale-product/s-product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5724, "\"", 5730, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Brown Cake</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>$29</h5>
                            </div>
                        </div>
                        <div class=""media"">
                            <div class=""d-flex"">
                                <img src=""img/product/sale-product/s-product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6736, "\"", 6742, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Brown Cake</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>$29</h5>
                            </div>
                        </div>
                        <div class=""media"">
                            <div class=""d-flex"">
                                <img src=""img/product/sale-product/s-product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7748, "\"", 7754, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""media-body"">
                                <a href=""#""><h4>Brown Cake</h4></a>
                                <ul class=""list_style"">
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-star-o""></i></a></li>
                                </ul>
                                <h5>$29</h5>
                            </div>
                        </div>
                    </aside>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Product Area =================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CakeBakery.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
