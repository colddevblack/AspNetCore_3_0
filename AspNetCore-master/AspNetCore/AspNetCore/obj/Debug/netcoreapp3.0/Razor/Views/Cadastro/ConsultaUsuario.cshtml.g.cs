#pragma checksum "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19d19ff3490f66d2534af3ded9cb423bee33c7b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_ConsultaUsuario), @"mvc.1.0.view", @"/Views/Cadastro/ConsultaUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/ConsultaUsuario.cshtml", typeof(AspNetCore.Views_Cadastro_ConsultaUsuario))]
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
#line 1 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\_ViewImports.cshtml"
using AspNetCore_3_0;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d19ff3490f66d2534af3ded9cb423bee33c7b7", @"/Views/Cadastro/ConsultaUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddf19c24a85a5b15b5cbd6807ef85c4223d805f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_ConsultaUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetCore_3_0.Models.UsuarioModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(88, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2425, 924, true);
            WriteLiteral(@"<!--}-->




<h2>Consulta Usarios</h2>

<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>Lista de usuários</h5>
                </div>
                <div class=""ibox-content"">
                    <table class=""table"">
                        <tr>
                            <td>ID Usuário</td>
                            <td>Nome Usuário </td>
                            <td>E-mail</td>
                            <td>data de nascimento</td>
                            <td>Endereço</td>
                            <td>CPF</td>
                            <td>data criação usuário</td>
                            <td>menu editar</td>
                            <td>menu apagar</td>
                        </tr>
");
            EndContext();
#line 94 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                         foreach (var item in Model)

                        {

#line default
#line hidden
            BeginContext(3432, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(3487, 7, false);
#line 98 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(3494, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3530, 9, false);
#line 99 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(item.nome);

#line default
#line hidden
            EndContext();
            BeginContext(3539, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3575, 10, false);
#line 100 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(3585, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3621, 19, false);
#line 101 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(item.dataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(3640, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3676, 13, false);
#line 102 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(item.endereco);

#line default
#line hidden
            EndContext();
            BeginContext(3689, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3725, 8, false);
#line 103 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(item.cpf);

#line default
#line hidden
            EndContext();
            BeginContext(3733, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3769, 16, false);
#line 104 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(item.dataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(3785, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3821, 127, false);
#line 105 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(Html.ActionLink("Editar Usuario", "EditarUsuario", "Cadastro", new { id = item.id }, new { @class = "btn btn-warning btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(3948, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3984, 127, false);
#line 106 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                       Write(Html.ActionLink("Apagar Usuario", "DeletarUsuario", "Cadastro", new { id = item.id }, new { @class = "btn btn-danger btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(4111, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 108 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Cadastro\ConsultaUsuario.cshtml"
                        }

#line default
#line hidden
            BeginContext(4172, 108, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNetCore_3_0.Models.UsuarioModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
