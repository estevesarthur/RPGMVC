#pragma checksum "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c14c07f832ac47a2a9087c58bf5e13398b821da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Index), @"mvc.1.0.view", @"/Views/Personagens/Index.cshtml")]
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
#line 1 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c14c07f832ac47a2a9087c58bf5e13398b821da", @"/Views/Personagens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.PersonagemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-sucess\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Relação de Personagens</h2>\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Criar Novo Personagem", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>");
#nullable restore
#line 27 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 28 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 29 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 48 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 49 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id}
                    ,new {onclick = "return confirm('Deseja realmente deletar este personagem?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                \r\n                ");
#nullable restore
#line 52 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.ActionLink("Listar Habilidades", "Index", "PersonagemHabilidades", new {id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | \r\n                ");
#nullable restore
#line 53 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
           Write(Html.ActionLink("Atribuir Habilidade", "Create", "PersonagemHabilidades", new {id = item.Id, nome = item.Nome}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Clique aqui para um embate com armas", "Index", "Disputas", 
    null, new { @class = "btn btn-warning"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
#nullable restore
#line 62 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Clique aqui para um embate com habilidades", "IndexHabilidades", "Disputas",
    null, new { @class = "btn btn-dark"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 65 "C:\Users\estev\OneDrive - Etec Centro Paula Souza\1Q\2 Modulo\Desenvolvimento de Sistemas\AULA_DS\DS2021-1\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Clique aqui para um embate em grupo", "DisputaGeral", null, null,
    new { @class= "btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.PersonagemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
