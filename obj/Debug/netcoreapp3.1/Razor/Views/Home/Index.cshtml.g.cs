#pragma checksum "C:\Users\henri\OneDrive\Área de Trabalho\SENAI\aula_Aspnetcore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92dd6e196e77f727eb950764d2cd4637fb3a305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\henri\OneDrive\Área de Trabalho\SENAI\aula_Aspnetcore\Views\_ViewImports.cshtml"
using aula_Aspnetcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\henri\OneDrive\Área de Trabalho\SENAI\aula_Aspnetcore\Views\_ViewImports.cshtml"
using aula_Aspnetcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a92dd6e196e77f727eb950764d2cd4637fb3a305", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5db970c6b582858823dc52d6954ff11d60b70a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\henri\OneDrive\Área de Trabalho\SENAI\aula_Aspnetcore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Início";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem-Vindo</h1>\r\n    <h2>");
#nullable restore
#line 7 "C:\Users\henri\OneDrive\Área de Trabalho\SENAI\aula_Aspnetcore\Views\Home\Index.cshtml"
   Write(ViewBag.Teste);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Número de erros: ");
#nullable restore
#line 7 "C:\Users\henri\OneDrive\Área de Trabalho\SENAI\aula_Aspnetcore\Views\Home\Index.cshtml"
                                     Write(ViewBag.TesteInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
