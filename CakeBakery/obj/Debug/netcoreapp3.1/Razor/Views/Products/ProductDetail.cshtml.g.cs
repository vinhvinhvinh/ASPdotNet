#pragma checksum "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Products\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2239f1256e067cdfd85726fa818a46c1c68b2258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductDetail), @"mvc.1.0.view", @"/Views/Products/ProductDetail.cshtml")]
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
#line 1 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\_ViewImports.cshtml"
using CakeBakery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\_ViewImports.cshtml"
using CakeBakery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2239f1256e067cdfd85726fa818a46c1c68b2258", @"/Views/Products/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3def8db8697e3562503afc1797c3cc8f1be8bf6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CakeBakery.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("370"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Products\ProductDetail.cshtml"
  

    ViewData["Title"] = "Chi tiết bánh";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2239f1256e067cdfd85726fa818a46c1c68b22584518", async() => {
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
<!--================Product Details Area =================-->
<section class=""product_details_area p_100"">
    <div class=""container"">
        <div class=""row product_d_price"">
            <div class=""col-lg-6"">
                <div class=""product_img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2239f1256e067cdfd85726fa818a46c1c68b22585923", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 544, "~/img/cake-feature/", 544, 19, true);
#nullable restore
#line 16 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Products\ProductDetail.cshtml"
AddHtmlAttributeValue("", 563, Model.Image, 563, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Products\ProductDetail.cshtml"
AddHtmlAttributeValue("", 582, Model.Name, 582, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"product_details_text\">\r\n                    <h4>");
#nullable restore
#line 21 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Products\ProductDetail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 22 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Products\ProductDetail.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <h5>Giá :<span>");
#nullable restore
#line 23 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Products\ProductDetail.cshtml"
                              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>
                    <div class=""quantity_box"">
                        <label for=""quantity"">Số lượng :</label>
                        <input type=""text"" placeholder=""1"" id=""quantity"">
                    </div>
                    <a class=""pink_more"" href=""#"">Thêm vào giỏ hàng</a>
                </div>
            </div>
        </div>
        <div class=""product_tab_area"">
            <nav>
                <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                    <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#nav-home"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">Thông tin</a>
                    <a class=""nav-item nav-link"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#nav-contact"" role=""tab"" aria-controls=""nav-contact"" aria-selected=""false"">Bình luận</a>
                </div>
            </nav>
            <div class=""tab-content"" id=""nav-tabContent"">
                <div class=""tab-pane fade show active"" id=""na");
            WriteLiteral(@"v-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                    <p>Công thức, nguyên liệu</p>
                </div>
                <div class=""tab-pane fade"" id=""nav-contact"" role=""tabpanel"" aria-labelledby=""nav-contact-tab"">

                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Product Details Area =================-->
<!--================Similar Product Area =================-->
<section class=""similar_product_area p_100"">
    <div class=""container"">
        <div class=""main_title"">
            <h2>Sản phẩm liên quan</h2>
        </div>
        <div class=""row similar_product_inner"">
            <div class=""col-lg-3 col-md-4 col-6"">
                <div class=""cake_feature_item"">
                    <div class=""cake_img"">
                        <img src=""img/cake-feature/c-feature-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2789, "\"", 2795, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cake_text"">
                        <h4>$29</h4>
                        <h3>Strawberry Cupcakes</h3>
                        <a class=""pest_btn"" href=""#"">Thêm vào giỏ hàng</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-6"">
                <div class=""cake_feature_item"">
                    <div class=""cake_img"">
                        <img src=""img/cake-feature/c-feature-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3323, "\"", 3329, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cake_text"">
                        <h4>$29</h4>
                        <h3>Strawberry Cupcakes</h3>
                        <a class=""pest_btn"" href=""#"">Add to cart</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-6"">
                <div class=""cake_feature_item"">
                    <div class=""cake_img"">
                        <img src=""img/cake-feature/c-feature-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3851, "\"", 3857, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cake_text"">
                        <h4>$29</h4>
                        <h3>Strawberry Cupcakes</h3>
                        <a class=""pest_btn"" href=""#"">Add to cart</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-6"">
                <div class=""cake_feature_item"">
                    <div class=""cake_img"">
                        <img src=""img/cake-feature/c-feature-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4379, "\"", 4385, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cake_text"">
                        <h4>$29</h4>
                        <h3>Strawberry Cupcakes</h3>
                        <a class=""pest_btn"" href=""#"">Add to cart</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Similar Product Area =================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CakeBakery.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
