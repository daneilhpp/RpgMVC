#pragma checksum "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5024da3b43590fe9360fd1304356e997c4a146b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disputas_Index), @"mvc.1.0.view", @"/Views/Disputas/Index.cshtml")]
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
#line 1 "D:\2DS-Daniel\DS\RpgMVC\Views\_ViewImports.cshtml"
using RpgMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2DS-Daniel\DS\RpgMVC\Views\_ViewImports.cshtml"
using RpgMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5024da3b43590fe9360fd1304356e997c4a146b", @"/Views/Disputas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebea36c732a52daa63a4f2bed00ae66e1cb86a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Disputas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMVC.Models.DisputaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
  ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
 if (@TempData["Mensagem"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
 if (@TempData["MensagemErro"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 11 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Ataque com Arma</h2>\r\n");
#nullable restore
#line 15 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
 using(Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
       Write(Html.DisplayName("Atacante"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 23 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
           Write(Html.DropDownListFor(model => model.AtacanteId, new SelectList(@ViewBag.ListaAtacantes, "Id","Name"), "--Selecione--", new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
       Write(Html.DisplayName("Oponente"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 29 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
           Write(Html.DropDownListFor(model => model.OponenteId, new SelectList(@ViewBag.ListaOponentes, "Id","Name"), "--Selecione--", new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-6"">
                <input type=""submit"" value=""Atacar com Arma."" class=""btn btn-primary""/>
            </div>
        </div>
    </div>
");
#nullable restore
#line 38 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 39 "D:\2DS-Daniel\DS\RpgMVC\Views\Disputas\Index.cshtml"
Write(Html.ActionLink("Retornar","Index","Personagem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMVC.Models.DisputaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
