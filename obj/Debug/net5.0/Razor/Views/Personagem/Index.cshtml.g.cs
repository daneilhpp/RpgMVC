#pragma checksum "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462f6435f6524a8e979fb7b535fc356e4f5c1a90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagem_Index), @"mvc.1.0.view", @"/Views/Personagem/Index.cshtml")]
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
#line 1 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\_ViewImports.cshtml"
using RpgMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\_ViewImports.cshtml"
using RpgMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462f6435f6524a8e979fb7b535fc356e4f5c1a90", @"/Views/Personagem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebea36c732a52daa63a4f2bed00ae66e1cb86a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMVC.Models.PersonagemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
  ViewBag.Title = "Personagens"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Relação de Personagens</h2>\r\n<p>\r\n    ");
#nullable restore
#line 6 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
Write(Html.ActionLink("Criar Novo Personagem", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 10 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 11 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 12 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Classes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 13 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 14 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 15 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 19 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 22 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Classes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Disputas ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.ActionLink("Editar", "Edit", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |  \r\n            ");
#nullable restore
#line 29 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | \r\n            ");
#nullable restore
#line 30 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
       Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }
            , new {onclick = "return confirm('Deseja realmente deletar este personagem?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </td>    \r\n    </tr>\r\n");
#nullable restore
#line 34 "D:\2DS-Daniel\DS\Daniel\RpgMVC\Views\Personagem\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMVC.Models.PersonagemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591