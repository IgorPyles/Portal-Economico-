#pragma checksum "C:\Users\igor\Desktop\Valor\Valor\Views\Teste\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e01574e90ef04fd7fe65e3408653137b54d3812e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teste_Index), @"mvc.1.0.view", @"/Views/Teste/Index.cshtml")]
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
#line 1 "C:\Users\igor\Desktop\Valor\Valor\Views\_ViewImports.cshtml"
using Valor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\igor\Desktop\Valor\Valor\Views\_ViewImports.cshtml"
using Valor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e01574e90ef04fd7fe65e3408653137b54d3812e", @"/Views/Teste/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d2d24d975b935c9eab303778f014c7f4e45354", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Teste_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\igor\Desktop\Valor\Valor\Views\Teste\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Ações</h1>\r\n");
#nullable restore
#line 7 "C:\Users\igor\Desktop\Valor\Valor\Views\Teste\Index.cshtml"
     using (Html.BeginForm("Index", "Stock", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"text\" id=\"teste\" name=\"teste\" placeholder=\"STOCK\">\r\n        <input type=\"submit\" value=\"PESQUISAR\" class=\"btn btn-success\">\r\n");
#nullable restore
#line 11 "C:\Users\igor\Desktop\Valor\Valor\Views\Teste\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
