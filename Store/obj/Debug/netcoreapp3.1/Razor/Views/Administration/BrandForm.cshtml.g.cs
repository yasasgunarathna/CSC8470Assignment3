#pragma checksum "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ade4e631dae1a142f9d76d16c416966994bf61980fbd1d9ce321261c103ea7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_BrandForm), @"mvc.1.0.view", @"/Views/Administration/BrandForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ade4e631dae1a142f9d76d16c416966994bf61980fbd1d9ce321261c103ea7af", @"/Views/Administration/BrandForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"98f0cfd404208161cef64f65b9d85180142f5977b81c7d987e916908e06957f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Administration_BrandForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Store.Models.Brand>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imagePreview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
  
    ViewData["Title"] = "Brand Form";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n");
#nullable restore
#line 7 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
  
    await Html.RenderPartialAsync("Partial/_nav_product");

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<hr />\n<br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade4e631dae1a142f9d76d16c416966994bf61980fbd1d9ce321261c103ea7af6094", async() => {
                WriteLiteral("\n\n    ");
                Write(
#nullable restore
#line 16 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
     Html.AntiForgeryToken()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n    ");
                Write(
#nullable restore
#line 17 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
     Html.ValidationSummary()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n    <div class=\"form-row\">\n\n        <div class=\"form-group col-md-3\">\n\n            ");
                Write(
#nullable restore
#line 22 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.LabelFor(b => b.Name)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            ");
                Write(
#nullable restore
#line 23 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.TextBoxFor(b => b.Name, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            ");
                Write(
#nullable restore
#line 24 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.ValidationMessageFor(b => b.Name)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n        </div>\n\n        <div class=\"col-md-2\"></div>\n        <div class=\"form-group col-md-6\">\n\n            ");
                Write(
#nullable restore
#line 30 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.LabelFor(b => b.Description)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            ");
                Write(
#nullable restore
#line 31 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.TextAreaFor(b => b.Description, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            ");
                Write(
#nullable restore
#line 32 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.ValidationMessageFor(b => b.Description)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n        </div>\n    </div>\n    <br />\n");
#nullable restore
#line 36 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
      
        if (Model.Name == null)
        {

#line default
#line hidden
#nullable disable

                WriteLiteral("            <div class=\"form-row\">\n                <button id=\"save\" type=\"button\" value=\"Submit\" class=\"btn btn-primary\">Add</button>\n            </div>\n");
#nullable restore
#line 42 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable

                Write(
#nullable restore
#line 45 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.HiddenFor(x => x.Id)

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 45 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
                                      
            ;

#line default
#line hidden
#nullable disable

                WriteLiteral("            <div class=\"form-row\">\n                <button id=\"save\" type=\"button\" value=\"Submit\" class=\"btn btn-primary\">Save</button>\n            </div>\n");
#nullable restore
#line 50 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
        }
    

#line default
#line hidden
#nullable disable

                WriteLiteral("\n    <div class=\"form-row\">\n        <div class=\"col-md-5\"></div>\n        <div class=\"form-group col-md-3\">\n");
#nullable restore
#line 56 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
              
                if (Model.PhotoPath == null)
                {
                    Model.PhotoPath = "ImageDefault.png";
                }
            

#line default
#line hidden
#nullable disable

                WriteLiteral("            ");
                Write(
#nullable restore
#line 62 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
             Html.LabelFor(p => p.Photo)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ade4e631dae1a142f9d76d16c416966994bf61980fbd1d9ce321261c103ea7af11545", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1663, "~/images/", 1663, 9, true);
                AddHtmlAttributeValue("", 1672, 
#nullable restore
#line 64 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
                                    Url.Content(Model.PhotoPath)

#line default
#line hidden
#nullable disable
                , 1672, 29, false);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <input id=\"imageBrowes\" type=\"file\" name=\"Photo\" accept=\"image/jpeg, image/png\" onchange=\"ShowImagePreview(this, document.getElementById(\'imagePreview\'))\" />\n            </div>\n        </div>\n    </div>\n\n    <br />\n    <br />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<button type=\"button\" class=\"btn btn-dark\"");
            BeginWriteAttribute("onclick", "\n        onclick=\"", 2049, "\"", 2123, 5);
            WriteAttributeValue("", 2067, "location.href", 2067, 13, true);
            WriteAttributeValue(" ", 2080, "=", 2081, 2, true);
            WriteAttributeValue(" ", 2082, "\'", 2083, 2, true);
            WriteAttributeValue("", 2084, 
#nullable restore
#line 75 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Administration\BrandForm.cshtml"
                                   Url.Action("Brand", "Administration")

#line default
#line hidden
#nullable disable
            , 2084, 38, false);
            WriteAttributeValue("", 2122, "\'", 2122, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n    Back to list\n</button>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade4e631dae1a142f9d76d16c416966994bf61980fbd1d9ce321261c103ea7af15800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#save').click(function () {
                $.validator.unobtrusive.parse(myForm);
                if ($(myForm).valid()) {
                    var file = $('#imageBrowes').get(0).files;
                    var data = new FormData(myForm);
                    data.append('Photo', file[0]);

                    var ajaxConfig = {
                        type: ""POST"",
                        url: ""/Administration/SaveBrand"",
                        data: data,
                        success: function (response) {
                            window.location.replace(""/Administration/Brand"");
                        },
                        error: function (xhr, status) {
                            alert('Something went wrong :///');
                        }
                    }

                    if ($(myForm).attr('enctype') == ""multipart/form-data"") {
                        ajaxConfig[""contentType""] = false;
                        aj");
                WriteLiteral(@"axConfig[""processData""] = false;
                    }

                    $.ajax(ajaxConfig);
                }
            });
        });

        function ShowImagePreview(input, previewImage) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    previewImage.src = e.target.result;
                }
                reader.readAsDataURL(input.files[0]);
            }
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store.Models.Brand> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
