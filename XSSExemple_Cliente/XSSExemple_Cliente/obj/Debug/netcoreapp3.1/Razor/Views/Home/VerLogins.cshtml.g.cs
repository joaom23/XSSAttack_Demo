#pragma checksum "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\Home\VerLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b27592646c51b57c7c2aeca7c3e904551572fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerLogins), @"mvc.1.0.view", @"/Views/Home/VerLogins.cshtml")]
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
#line 1 "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\_ViewImports.cshtml"
using XSSExemple_Cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\Home\VerLogins.cshtml"
using XSSExemple_Cliente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b27592646c51b57c7c2aeca7c3e904551572fb", @"/Views/Home/VerLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac71777b38781728d2a1ed65b5910c032155166e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerLogins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\Home\VerLogins.cshtml"
  
    ViewData["Title"] = "Página protegida";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>Logins</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n     <tr>\r\n        <th>\r\n            Username\r\n        </th>\r\n        <th>\r\n            Password\r\n        </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\Home\VerLogins.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\Home\VerLogins.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\Home\VerLogins.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\jmfer\OneDrive\Ambiente de Trabalho\Criptografia\2 Trabalho\XSSExemple_Cliente\XSSExemple_Cliente\Views\Home\VerLogins.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
