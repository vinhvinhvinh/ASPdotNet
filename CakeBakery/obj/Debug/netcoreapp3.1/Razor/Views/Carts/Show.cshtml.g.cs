<<<<<<< HEAD
#pragma checksum "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1085839c17cf1002f9b5584d3201a3bf3f1a6c23"
=======
#pragma checksum "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9430bddefb4cf493e1e5e518244048df52c32636"
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Show), @"mvc.1.0.view", @"/Views/Carts/Show.cshtml")]
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1085839c17cf1002f9b5584d3201a3bf3f1a6c23", @"/Views/Carts/Show.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9430bddefb4cf493e1e5e518244048df52c32636", @"/Views/Carts/Show.cshtml")]
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3def8db8697e3562503afc1797c3cc8f1be8bf6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Carts_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CakeBakery.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
<<<<<<< HEAD
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
=======
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tion", new global::Microsoft.AspNetCore.Html.HtmlString("RemoveCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"

    ViewData["Title"] = "Giỏ hàng";
    var user = ViewBag.UserAccount;
    var productInCart = ViewBag.ProdInCart;
    

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1085839c17cf1002f9b5584d3201a3bf3f1a6c235062", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9430bddefb4cf493e1e5e518244048df52c326365242", async() => {
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
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
<!--================Cart Table Area =================-->
<section class=""cart_table_area p_100"">

    <div class=""container"">
        <div class=""table-responsive"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Sản phẩm</th>
                        <th scope=""col"">Tên sản phẩm</th>
                        <th scope=""col"">Số lượng</th>
                        <th scope=""col"">Gía</th>
                        <th scope=""col""></th>

");
            WriteLiteral("\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 33 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
=======
#line 33 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml"
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
                    foreach (Cart p in productInCart)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1085839c17cf1002f9b5584d3201a3bf3f1a6c237174", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9430bddefb4cf493e1e5e518244048df52c326367388", async() => {
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1210, "~/img/cake-feature/", 1210, 19, true);
#nullable restore
<<<<<<< HEAD
#line 38 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
=======
#line 38 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml"
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
AddHtmlAttributeValue("", 1229, p.Product.Image, 1229, 16, false);

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
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 40 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
                       Write(p.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><input type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 1385, "\"", 1404, 1);
#nullable restore
<<<<<<< HEAD
#line 41 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
=======
#line 41 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml"
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
WriteAttributeValue("", 1393, p.Quantity, 1393, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50px\" min=\"1\"></td>\r\n                        <td>");
#nullable restore
#line 42 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
                        Write((p.Product.Price * p.Quantity).ToString("0,00#"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND     </td>\r\n                        <td>");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1085839c17cf1002f9b5584d3201a3bf3f1a6c239769", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9430bddefb4cf493e1e5e518244048df52c3263610119", async() => {
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
                WriteLiteral("X");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
<<<<<<< HEAD
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
=======
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-ac", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 43 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
                                                         WriteLiteral(p.Id);
=======
#line 43 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml"
                                                            WriteLiteral(p.Id);
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 46 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
=======
#line 46 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml"
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"row cart_total_inner\">\r\n            <div class=\"col-lg-7\"></div>\r\n            <div class=\"col-lg-5\">\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1085839c17cf1002f9b5584d3201a3bf3f1a6c2312365", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9430bddefb4cf493e1e5e518244048df52c3263612977", async() => {
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
                WriteLiteral(@"
                    <div class=""cart_total_text"">
                        <div class=""cart_head"">
                            Tổng giỏ hàng
                        </div>

                        <div class=""sub_total"">
                            <h5>Phụ thu <span>0 VND</span></h5>
                        </div>
                        <div class=""total"">
                            <h4>Tổng tiền <span>");
#nullable restore
<<<<<<< HEAD
#line 64 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
=======
#line 64 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml"
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
                                           Write(ViewBag.TotalPriceInCart.ToString("0,00#"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VND</span></h4>\r\n                        </div>\r\n                        <div class=\"cart_footer\">\r\n                            <button class=\"pest_btn\" type=\"submit\">Đặt hàng</button>\r\n                            <span>");
#nullable restore
<<<<<<< HEAD
#line 68 "D:\HK5\ASP\ASPdotNet\CakeBakery\Views\Carts\Show.cshtml"
=======
#line 68 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Carts\Show.cshtml"
>>>>>>> f68e8ce11dc725783aab70d007375bfa84c3caad
                             Write(ViewBag.ErrorMessages);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--================End Cart Table Area =================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CakeBakery.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
