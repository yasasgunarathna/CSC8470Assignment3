#pragma checksum "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a7be5cd75e4f0583664bf1584a235ef8c682b2b20edef87e14280204a30eccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8a7be5cd75e4f0583664bf1584a235ef8c682b2b20edef87e14280204a30eccd", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"98f0cfd404208161cef64f65b9d85180142f5977b81c7d987e916908e06957f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Store.ViewModels.LoginViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1 class=\"display-4\">Log In!</h1>\n<hr />\n<br />\n\n");
#nullable restore
#line 10 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
 using (Html.BeginForm("Login", "Account", new { ReturnUrl = Context.Request.Query["ReturnUrl"] }))
{
    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 12 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
     Html.AntiForgeryToken()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <div>\n        ");
            Write(
#nullable restore
#line 15 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
         Html.ValidationSummary()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-row form-group\">\n        <div class=\"col-md-4\">\n            ");
            Write(
#nullable restore
#line 20 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
             Html.LabelFor(u => u.UserName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            ");
            Write(
#nullable restore
#line 21 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
             Html.TextBoxFor(u => u.UserName, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            ");
            Write(
#nullable restore
#line 22 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
             Html.ValidationMessageFor(u => u.UserName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </div>\n\n        <div class=\"col-md-3\">\n        </div>\n\n        <div class=\"col-md-3\">\n            <p>Don\'t have an account yet?</p>\n            <button type=\"button\" class=\"btn btn-dark\"");
            BeginWriteAttribute("onclick", "\n                    onclick=\"", 759, "\"", 841, 5);
            WriteAttributeValue("", 789, "location.href", 789, 13, true);
            WriteAttributeValue(" ", 802, "=", 803, 2, true);
            WriteAttributeValue(" ", 804, "\'", 805, 2, true);
            WriteAttributeValue("", 806, 
#nullable restore
#line 31 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
                                               Url.Action("Register", "Account")

#line default
#line hidden
#nullable disable
            , 806, 34, false);
            WriteAttributeValue("", 840, "\'", 840, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                Register\n            </button>\n        </div>\n\n    </div>\n");
            WriteLiteral("    <div class=\"form-row form-group\">\n        <div class=\"col-md-4\">\n            ");
            Write(
#nullable restore
#line 40 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
             Html.LabelFor(u => u.Password)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            ");
            Write(
#nullable restore
#line 41 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
             Html.PasswordFor(u => u.Password, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            ");
            Write(
#nullable restore
#line 42 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
             Html.ValidationMessageFor(u => u.Password)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </div>\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
            Write(
#nullable restore
#line 47 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
         Html.CheckBoxFor(u => u.RememberMe)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        ");
            Write(
#nullable restore
#line 48 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
         Html.DisplayNameFor(u => u.RememberMe)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <br />\n    <button type=\"submit\" class=\"btn btn-primary\">Log in</button>\n");
#nullable restore
#line 53 "D:\2024\Month\July\Madhu\Yasas\WebStore-master\Store\Views\Account\Login.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<br />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store.ViewModels.LoginViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591