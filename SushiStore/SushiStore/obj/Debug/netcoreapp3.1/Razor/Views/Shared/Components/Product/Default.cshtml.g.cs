#pragma checksum "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2626917dad3400d3e066529c31f911bfdec55df2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Product_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Product/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2626917dad3400d3e066529c31f911bfdec55df2", @"/Views/Shared/Components/Product/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235768ac1f8e9526eed26f94b952f05758b33dd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Product_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
  
    Layout = null;

    ViewBag.ProductCount = 12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
   int l = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
   var res = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
   string test;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Menu Section Starts -->\r\n<section class=\"menu_section\">\r\n    <div class=\"sticky-menu\">\r\n        <div class=\"container-lg\">\r\n            <ul class=\"menu-items\">\r\n\r\n                <li class=\"menu-item active category sticky-menu-btn\"");
            BeginWriteAttribute("id", " id=\"", 367, "\"", 405, 1);
#nullable restore
#line 17 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
WriteAttributeValue("", 372, Model.Categories.ElementAt(0).Id, 372, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p class=\"menu-link\" data-id=\"");
#nullable restore
#line 18 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                             Write(Model.Categories.ElementAt(0).Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 18 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                                            Write(Model.Categories.ElementAt(0).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span class=\"nav-item-line\"></span>\r\n                </li>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                 for (int i = 1; i < Model.Categories.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"menu-item category sticky-menu-btn\"");
            BeginWriteAttribute("id", " id=\"", 781, "\"", 819, 1);
#nullable restore
#line 24 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
WriteAttributeValue("", 786, Model.Categories.ElementAt(i).Id, 786, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <p class=\"menu-link\" data-id=\"");
#nullable restore
#line 25 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                 Write(Model.Categories.ElementAt(i).Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 25 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                                                Write(Model.Categories.ElementAt(i).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <span class=\"nav-item-line\"></span>\r\n                    </li>\r\n");
#nullable restore
#line 28 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
        </div>
    </div>

    <div class=""container-lg"">
        <div class=""product-category active-category"">

            <div class=""section-title"">
                <p class=""title_text"" id=""categoryName"">Sushi Torts</p>
            </div>
            <div class=""products"" id=""ProductsList"">
");
#nullable restore
#line 40 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                 foreach (Product product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 card-column product-item\"");
            BeginWriteAttribute("id", " id=\"", 1544, "\"", 1560, 1);
#nullable restore
#line 42 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
WriteAttributeValue("", 1549, product.Id, 1549, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-card\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2626917dad3400d3e066529c31f911bfdec55df210653", async() => {
                WriteLiteral("\r\n                                <div class=\"img-wrapper\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2626917dad3400d3e066529c31f911bfdec55df211008", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1912, "~/assets/images/products/", 1912, 25, true);
#nullable restore
#line 47 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
AddHtmlAttributeValue("", 1937, product.Image, 1937, 14, false);

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
                WriteLiteral("\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                                            WriteLiteral(product.Id);

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
            WriteLiteral("\r\n                            <div class=\"product-info\">\r\n                                <div class=\"stars\">\r\n");
#nullable restore
#line 52 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                     if (product.Rating != null)
                                    {
                                       
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                         for (l = 0; l < Math.Floor((double)product.Rating); l++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""star"">
                                                <div class=""empty"">
                                                    <div class=""star-icon""></div>
                                                </div>
                                                <div class=""full"" style=""width: 100%;"">
                                                    <div class=""star-icon""></div>
                                                </div>
                                            </div>
");
#nullable restore
#line 65 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                         for (int j = l; j < 5; j++)
                                        {
                                            if (j == l)
                                            {
                                                { res = (int)((product.Rating - Math.Floor((double)product.Rating)) * 100); }
                                                { test = res.ToString() + "%"; }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""star"">
                                                    <div class=""empty"">
                                                        <div class=""star-icon""></div>
                                                    </div>
                                                    <div class=""full""");
            BeginWriteAttribute("style", " style=\"", 3824, "\"", 3845, 3);
            WriteAttributeValue("", 3832, "width:", 3832, 6, true);
#nullable restore
#line 76 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
WriteAttributeValue(" ", 3838, test, 3839, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3844, "", 3845, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                  <div class=\"star-icon\"></div>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 80 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""star"">
                                                    <div class=""empty"">
                                                        <div class=""star-icon""></div>
                                                    </div>
                                                    <div class=""full"" style=""width: 0%;"">
                                                        <div class=""star-icon""></div>
                                                    </div>
                                                </div>
");
#nullable restore
#line 91 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                            }

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                         

                                    }
                                    else
                                    {
                                        for (int k = 0; k < 5; k++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""star"">
                                                <div class=""empty"">
                                                    <div class=""star-icon""></div>
                                                </div>
                                                <div class=""full"" style=""width: 0%;"">
                                                    <div class=""star-icon""></div>
                                                </div>
                                            </div>
");
#nullable restore
#line 108 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2626917dad3400d3e066529c31f911bfdec55df221077", async() => {
#nullable restore
#line 111 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                                                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                                WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <p class=\"info\">\r\n                                    ");
#nullable restore
#line 113 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                               Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n\r\n                            </div>\r\n                            <div class=\"price-container\">\r\n");
#nullable restore
#line 118 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                 if (product.Prices.OldPrice != null && product.Prices.ShowOldPrice == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span aria-label=\"old-price\" class=\"price-crossed\">");
#nullable restore
#line 120 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                                  Write(product.Prices.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</span>\r\n");
#nullable restore
#line 121 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span aria-label=\"price-sale\" class=\"price\">");
#nullable restore
#line 122 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                       Write(product.Prices.CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</span>\r\n                            </div>\r\n                            <button type=\"button\" class=\"add-btn\" data-id=\"");
#nullable restore
#line 124 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"
                                                                      Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Add To Cart</button>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 127 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Views\Shared\Components\Product\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div id=\"load-btn-wrap text-right\"><div id=\"load\">Load More</div></div>\r\n\r\n    </div>\r\n</section>\r\n<!-- Menu Section Ends -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591