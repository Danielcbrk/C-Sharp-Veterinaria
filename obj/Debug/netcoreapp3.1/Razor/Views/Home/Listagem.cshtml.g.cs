#pragma checksum "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85369f6937fb2e89a4bd2764b8c82b8d455e29df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
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
#line 1 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\_ViewImports.cshtml"
using atividade_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\_ViewImports.cshtml"
using atividade_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85369f6937fb2e89a4bd2764b8c82b8d455e29df", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"683e2f15ca30afe8a58526c7c8ba686c00e5588d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemAgenda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de agendamentos já realizados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

<table border=""1"">

    <thead>
        <tr>
            <th>Nome do cliente</th>
            <th>Telefone</th>
            <th>Data</th>
            <th>Animal</th>
            <th>Necessidade</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 22 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
         foreach (ItemAgenda item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
               Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
               Write(item.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
               Write(item.data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
               Write(item.animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 29 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"
                Write(item.necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "A:\T.I-PROGRAMAÇÃO\TÉCNICO EM INFORMATICA PARA INTERNET - PSG\UC05-Codificar aplicacoes web\atividade_3\Views\Home\Listagem.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n\r\n</table>\r\n\r\n<a href=\"/home/Agendamento\">Faça seu agendamento</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemAgenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
