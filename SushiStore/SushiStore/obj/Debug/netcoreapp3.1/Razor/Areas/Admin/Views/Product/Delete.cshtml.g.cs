#pragma checksum "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52d12947fb3b766bd48e5c1e6a09098dbca27c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Delete.cshtml")]
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
#line 1 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\_ViewImports.cshtml"
using SushiStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\_ViewImports.cshtml"
using SushiStore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\_ViewImports.cshtml"
using SushiStore.DTO.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\_ViewImports.cshtml"
using SushiStore.DTO.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a52d12947fb3b766bd48e5c1e6a09098dbca27c2", @"/Areas/Admin/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0d9f6466c393b21c13d2b8ae96631c9efa9985e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%; border:1px solid #CED4DA; border-radius:8px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
   ViewData["Title"] = "Delete"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Details</h4>
                <div class=""table-responsive pt-3"">
                    <table class=""table table-bordered"" style=""table-layout: fixed;"">
                        <thead>
                            <tr>
                                <th>
                                    Name
                                </th>
                                <th>
                                    OldPrice
                                </th>
                                <th>
                                    CurrentPrice
                                </th>
                                <th>
                                    Category
                                </th>
                                <th>
                                    Description
                                </th>
                               ");
            WriteLiteral(@" <th>
                                    Ingredients
                                </th>
                                <th>
                                    Nutrition
                                </th>

                            </tr>
                        </thead>
                        <tbody>

                            <tr>
                                <td>
                                    ");
#nullable restore
#line 43 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n");
#nullable restore
#line 46 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                                     if (Model.Prices.OldPrice != null)
                                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                   Write(Model.Prices.OldPrice);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 52 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                               Write(Model.Prices.CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n\n                                <td>\n                                    <ul>\n                                        <li><h5>");
#nullable restore
#line 57 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                                           Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\n                                    </ul>\n\n                                </td>\n                                <td style=\"word-wrap: break-word; width: 150px; white-space:unset;\">\n\n                                    ");
#nullable restore
#line 63 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </td>\n                                <td style=\"word-wrap: break-word; width: 150px; white-space:unset;\">\n\n                                    ");
#nullable restore
#line 68 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                               Write(Model.Ingredients);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </td>\n\n                                <td style=\"word-wrap: break-word; width: 150px; white-space:unset;\">\n                                    <h5>Calories: <span>");
#nullable restore
#line 73 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                                                   Write(Model.Nutrition.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\n                                    <h5>Carbohydrates: <span>");
#nullable restore
#line 74 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                                                        Write(Model.Nutrition.Carbohydrates);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\n                                    <h5>Oils: <span>");
#nullable restore
#line 75 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                                               Write(Model.Nutrition.Oils);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\n                                    <h5>Proteins: <span>");
#nullable restore
#line 76 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
                                                   Write(Model.Nutrition.Proteins);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>
                                </td>
                            </tr>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row mt-5 mb-5"">
    <div class=""col-12 d-flex flex-wrap justify-content-around"">

        <div class=""col-2 product-image  mr-2 ml-2 d-flex flex-column justify-content-center"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a52d12947fb3b766bd48e5c1e6a09098dbca27c213104", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3471, "~/assets/images/products/", 3471, 25, true);
#nullable restore
#line 92 "C:\Users\Шахвалад\source\repos\SushiStore\SushiStore\Areas\Admin\Views\Product\Delete.cshtml"
AddHtmlAttributeValue("", 3496, Model.Image, 3496, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n\n    </div>\n</div>\n\n\n<div class=\"row\">\n    <div class=\"col-12 grid-margin stretch-card\">\n        <div class=\"card\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a52d12947fb3b766bd48e5c1e6a09098dbca27c215021", async() => {
                WriteLiteral("\n                <button type=\"submit\" class=\"btn btn-danger mr-2\">Delete</button>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a52d12947fb3b766bd48e5c1e6a09098dbca27c215381", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
