#pragma checksum "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Menus\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9001c9cac1c309d4f9549508274ad8fe6db99733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menus_Show), @"mvc.1.0.view", @"/Views/Menus/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9001c9cac1c309d4f9549508274ad8fe6db99733", @"/Views/Menus/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3def8db8697e3562503afc1797c3cc8f1be8bf6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Menus_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\CDTH19E_0306191487\HocKy5\ASPDotNet\DoAn\CakeBakery\CakeBakery\Views\Menus\Show.cshtml"
  
    
    ViewData["Title"] = "Thực đơn";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9001c9cac1c309d4f9549508274ad8fe6db997333577", async() => {
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
<!--================Recipe Menu list Area =================-->
<section class=""price_list_area p_100"">
    <div class=""container"">
        <div class=""price_list_inner"">
            <div class=""single_pest_title"">
                <h2>Thực đơn ngày hôm nay</h2>
                <p>“Thành công của những thợ làm bánh xuất phát từ đôi bàn tay vàng cùng khối óc sáng tạo và trái tim đầy nhiệt huyết.”</p>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""discover_item_inner"">
                        <div class=""discover_item"">
                            <h4>Double Chocolate Pie</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam milk <span>$8.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Zabaglione Cake</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$12.99</span");
            WriteLiteral(@"></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Blueberry Muffin</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam milk <span>$8.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Box of Delight</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$7.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Classic French Croissant</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$6.79</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Macarons & Tea</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$5.99</span></p>");
            WriteLiteral(@"
                        </div>
                        <div class=""discover_item"">
                            <h4>Strawberry Sweet Cake</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$12.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Cupcake of Vanela</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$20.00</span></p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""discover_item_inner"">
                        <div class=""discover_item"">
                            <h4>Fried Egg Sandwich</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam milk <span>$8.99</span></p>
                        </div>
                        <div class=""discover_item"">
                     ");
            WriteLiteral(@"       <h4>Multigrain Hot Cake</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$12.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Branch Special Cake</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam milk <span>$8.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Bialy Egg Sandwich with Cake</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam milk <span>$7.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Strawberry Sweet Cake</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$6.79</span></p>
                        </div>
                        <div class=""discover_item"">
               ");
            WriteLiteral(@"             <h4>Double Chocolate Pie</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$5.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Blueberry Muffin</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$12.99</span></p>
                        </div>
                        <div class=""discover_item"">
                            <h4>Classic Chocolate Cake</h4>
                            <p>Chocolate puding, vanilla, fruite rasberry jam evporate milk <span>$20.00</span></p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row our_bakery_image"">
                <div class=""col-md-4 col-6"">
                    <img class=""img-fluid"" src=""img/our-bakery/bakery-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5249, "\"", 5255, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-4 col-6\">\r\n                    <img class=\"img-fluid\" src=\"img/our-bakery/bakery-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5405, "\"", 5411, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-4 col-6\">\r\n                    <img class=\"img-fluid\" src=\"img/our-bakery/bakery-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5561, "\"", 5567, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--================End Main Header Area =================-->");
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