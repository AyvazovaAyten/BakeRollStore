#pragma checksum "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Delivery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1fbecf820f4929a37f9ed2cfc249f014b7e3deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_Index), @"mvc.1.0.view", @"/Views/Delivery/Index.cshtml")]
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
#line 1 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\_ViewImports.cshtml"
using SushiStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\_ViewImports.cshtml"
using SushiStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fbecf820f4929a37f9ed2cfc249f014b7e3deb", @"/Views/Delivery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235768ac1f8e9526eed26f94b952f05758b33dd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Delivery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Bake&amp;Roll - Online Sushi Order &amp; Free Sushi Delivery in Baku"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScript", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Script", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Delivery\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Intro Begins -->\r\n<section class=\"page-intro\">\r\n    <div class=\"container-lg flex-col\">\r\n        <h1 class=\"page-title\">Free Delivery In Baku</h1>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1fbecf820f4929a37f9ed2cfc249f014b7e3deb5271", async() => {
                WriteLiteral("<span>Bake&amp;Roll</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <span title=""Blog""><span>Free Delivery In Baku</span></span>
        </div>
    </div>
</section>
<!-- Page Intro Ends -->
<!-- Information Section Begins -->
<section class=""information_section"">
    <div class=""container-lg"">
        <div class=""section-title"">
            <p class=""title_text"">Delivery service&nbsp;</p>
        </div>
        <h3>Orders Received:</h3>
        <p>7 days a week, 24 hours.</p>
        <h3>Delivery time:</h3>
        <p>
            The approximate delivery time will be displayed on the display for your selected destination. You can
            ask the operator for more precise information.
        </p>
        <h3>Minimum order amount:</h3>
        <p>
            Minimum order amount has been determined for the distance to be dispatched. When you place an order,
            you will see the minimum amount assigned to your selected address based on the sights.
        </p>
        <h3>Delivery to non-Baku areas (possible):</h3>
        <p");
            WriteLiteral(@">You can ask for our minimum order quantity and delivery time.</p>
        <p>
            The selections you choose are made exclusively from new and high quality products after
            ordering.
        </p>
        <p>
            Delivery of pizzas and sushi takes place in special thermo-packaging due to storage conditions.
        </p>
        <h3>Your order will be shipped with:</h3>
        <p>For Sushi: bamboo sticks, vasabi, soy sauce (based on order amount and quantity)</p>
        <p>
            For pizzas and other dishes (depending on the order): wet napkin, dry napkin, disposable towel /
            spoon.
        </p>
        <h3>Payment for order:</h3>
        <p>You can pay the order in cash to the courier.</p>
        <h3>Attention:</h3>
        <p>
            When you receive your order, we kindly ask you to check what's inside the packaging. If there are any
            discrepancies and complaints, please contact our Operator.
        </p>
        <p>Complaints ");
            WriteLiteral(@"are not accepted after payment is received.</p>
        <h2>Bakıda Sushi Çatdırılma Ünvanları</h2>
        <p>
            Bakıda sushi çatdırılması xidmətimizin keçərli olduğu qəsəbələrin və metroların adları, təxmini
            çatdırılma müddəti və çatdırılma üçün minimum sifariş məbləği cədvəldə qeyd olunub.
        </p>
    </div>
</section>
<!-- Information Section Ends -->

<section class=""adress_section"">
    <div class=""container-lg"">
        <h4>Qəsəbələrə Sushi Çatdırılma</h4>
        <div class=""table-responsive mb-40"">
            <table class=""table text-center"">
                <thead>
                    <tr>
                        <th>Çatdırılma Ünvanı<br></th>
                        <th>Çatdırılma Müddəti<br></th>
                        <th>Minimum Sifariş Məbləği<br></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>2-ci mikrorayon &nbsp;q.<br></td>
                        <td>45-");
            WriteLiteral(@"60 &nbsp;dəq<br></td>
                        <td>25.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>3-cü mikrorayon &nbsp;q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>25.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>4-cü mikrorayon &nbsp;q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>5-ci mikrorayon &nbsp;q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>25.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>6-cı mikrorayon &nbsp;q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>");
            WriteLiteral(@"7-ci mikrorayon &nbsp;q.<br></td>
                        <td>60-75 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>8-ci mikrorayon &nbsp;q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>25.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>9-cu mikrorayon &nbsp;q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>20-ci sahə q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Badamdar q.<br></td>
                        <td>30-45 dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                  ");
            WriteLiteral(@"  <tr>
                        <td>Bakixanov q.<br></td>
                        <td>75-90 dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Bilgəh q.<br></td>
                        <td>90-120 &nbsp;dəq<br></td>
                        <td>60.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Biləcəri q.<br></td>
                        <td>60-75 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Buzovna q.<br></td>
                        <td>90-120 &nbsp;dəq<br></td>
                        <td>60.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Günəşli q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>");
            WriteLiteral(@"
                        <td>Həzi Aslanov q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Hövsan q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>60.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Kubinka q.<br></td>
                        <td>30-45 &nbsp;dəq<br></td>
                        <td>20.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Köhnə Günəşli q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Lökbatan q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                 ");
            WriteLiteral(@"   <tr>
                        <td>M.Ə.Rəsulzadə q.<br></td>
                        <td>60-75 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Montin q.<br></td>
                        <td>60-75 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Mərdəkan q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>60.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>NZS q.<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Novxanı q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>60.00 AZN<br></td>
                    </tr>
                   ");
            WriteLiteral(@" <tr>
                        <td>Qara Şəhər q.<br></td>
                        <td>30-45 &nbsp;dəq<br></td>
                        <td>25.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Sabunçu q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Sahil q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>60.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Səngəçal q.<br></td>
                        <td>75-90 &nbsp;dəq<br></td>
                        <td>60.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>Yeni Yasamal<br></td>
                        <td>45-60 &nbsp;dəq<br></td>
                        <td>25.00 AZN<br></td>
                    </tr>
                   ");
            WriteLiteral(@" <tr>
                        <td>Qaraçuxur<br></td>
                        <td>60-75 &nbsp;dəq<br></td>
                        <td>40.00 AZN<br></td>
                    </tr>
                    <tr>
                        <td>8-ci km<br></td>
                        <td>60-75 &nbsp;dəq<br></td>
                        <td>30.00 AZN<br></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</section>>

");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1fbecf820f4929a37f9ed2cfc249f014b7e3deb16827", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1fbecf820f4929a37f9ed2cfc249f014b7e3deb18008", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
