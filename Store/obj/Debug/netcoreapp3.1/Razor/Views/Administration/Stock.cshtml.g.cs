#pragma checksum "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2ffa759c0007328231ac058d77fe5180943e473e757e085a20da770d0f707e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Stock), @"mvc.1.0.view", @"/Views/Administration/Stock.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2ffa759c0007328231ac058d77fe5180943e473e757e085a20da770d0f707e26", @"/Views/Administration/Stock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"98f0cfd404208161cef64f65b9d85180142f5977b81c7d987e916908e06957f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Administration_Stock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Store.ViewModels.StockViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
  
    ViewData["Title"] = "Stock";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n");
#nullable restore
#line 7 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
  
    await Html.RenderPartialAsync("Partial/_nav_product");

#line default
#line hidden
#nullable disable

            WriteLiteral("\n\n");
#nullable restore
#line 12 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
 if (Model.Stock.Any())
{

#line default
#line hidden
#nullable disable

            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Rozmiar</th>
                <th scope=""col"">Ilość</th>
                <th scope=""col"">Edytuj</th>
                <th scope=""col"">Usuń</th>

            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 27 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
             foreach (var stock in Model.Stock)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
            Write(
#nullable restore
#line 30 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
                                     stock.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n                    <td>");
            Write(
#nullable restore
#line 31 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
                         stock.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                    <td>");
            Write(
#nullable restore
#line 32 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
                         stock.Qty

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                    <td>");
            Write(
#nullable restore
#line 33 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
                         Html.ActionLink("Edit", "EditStock", "Administration", new { id = stock.Id })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                    <td>");
            Write(
#nullable restore
#line 34 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
                         Html.ActionLink("Delete", "DeleteStock", "Administration", new { id = stock.Id })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n\n                </tr>\n");
#nullable restore
#line 37 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"

            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\n\n    </table>\n");
#nullable restore
#line 42 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"

}

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h4>Dodaj nowy</h4>\n<br />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ffa759c0007328231ac058d77fe5180943e473e757e085a20da770d0f707e267183", async() => {
                WriteLiteral("\n\n    <div class=\"form-row\">\n        <div class=\"form-group col-md-2\">\n            ");
                Write(
#nullable restore
#line 51 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
             Html.LabelFor(x => x.Name)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            ");
                Write(
#nullable restore
#line 52 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
             Html.TextBoxFor(x => x.Name, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-row\">\n        <div class=\"form-group col-md-2\">\n            ");
                Write(
#nullable restore
#line 58 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
             Html.LabelFor(x => x.Qty)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            ");
                Write(
#nullable restore
#line 59 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
             Html.TextBoxFor(x => x.Qty, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n        </div>\n    </div>\n    ");
                Write(
#nullable restore
#line 62 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
     Html.HiddenFor(x => x.ProductId)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n\n    <br />\n    <button id=\"save\" type=\"button\" value=\"Submit\" class=\"btn btn-primary\">Dodaj</button>\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n<br />\n<button type=\"button\" class=\"btn btn-dark\"");
            BeginWriteAttribute("onclick", "\n        onclick=\"", 1672, "\"", 1749, 5);
            WriteAttributeValue("", 1690, "location.href", 1690, 13, true);
            WriteAttributeValue(" ", 1703, "=", 1704, 2, true);
            WriteAttributeValue(" ", 1705, "\'", 1706, 2, true);
            WriteAttributeValue("", 1707, 
#nullable restore
#line 73 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\Stock.cshtml"
                                   Url.Action("Products", "Administration")

#line default
#line hidden
#nullable disable
            , 1707, 41, false);
            WriteAttributeValue("", 1748, "\'", 1748, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n    Wróć do listy produktów\n</button>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {

            $('input.form-control').val("""");


            $('#save').click(function () {
                $.validator.unobtrusive.parse(myForm);
                if ($(myForm).valid()) {
                    var data = $(myForm).serialize()


                    var ajaxConfig = {
                        type: ""POST"",
                        url: ""/Administration/Stock"",
                        data: data,
                        success: function (response) {
                            location.reload();

                        },
                        error: function (xhr, status) {
                            alert('Something went wrong :///');
                        }
                    }
                    $.ajax(ajaxConfig);
                }
            });
        });
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store.ViewModels.StockViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
