#pragma checksum "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1f6925223d4c71943bf818d43972b44e7d827d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CapturarPrevisaoSemanal), @"mvc.1.0.view", @"/Views/Home/CapturarPrevisaoSemanal.cshtml")]
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
#line 1 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\_ViewImports.cshtml"
using ClimaTempo_AuvoSistemas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\_ViewImports.cshtml"
using ClimaTempo_AuvoSistemas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1f6925223d4c71943bf818d43972b44e7d827d", @"/Views/Home/CapturarPrevisaoSemanal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ee640c33d77e2a5757f51cf7318c101b7a1e5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CapturarPrevisaoSemanal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PrevisaoClima>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2 class=\"titulo-previsao-semanal\">Clima para os próximos 7 dias na cidade de ");
#nullable restore
#line 5 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                                                                          Write(ViewBag.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row previsao-semanal justify-content-around\">\r\n");
#nullable restore
#line 10 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
         foreach (var previsao in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-1 box-cidades-previsoes\">\r\n                <div class=\"row header-cidades-previsoes\">\r\n");
#nullable restore
#line 14 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                       string dia = previsao.DataPrevisao.ToString("dddd", new CultureInfo("pt-BR"));
                       string diaFormatado = Char.ToUpper(dia[0]) + dia.Substring(1);
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                  Write(diaFormatado);

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"container espacamento-cidades-previsoes\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                          
                            switch (previsao.Clima)
                            {
                                case "Nublado":

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-cloud\"></span>\r\n                                    <span class=\"nome-previsao\">Nublado</span>\r\n");
#nullable restore
#line 27 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                                    break;
                                case "Chuvoso":

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-tint\"></span>\r\n                                    <span class=\"nome-previsao\">Chuvoso</span>\r\n");
#nullable restore
#line 31 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                                    break;
                                case "Ensolarado":

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"glyphicon glyphicon-certificate\"></span>\r\n                                    <span class=\"nome-previsao\">Ensolarado</span>\r\n");
#nullable restore
#line 35 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                                    break;
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"row\">\r\n                        Mínima: ");
#nullable restore
#line 40 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                           Write(previsao.TemperaturaMinima);

#line default
#line hidden
#nullable disable
            WriteLiteral("°C\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        Máxima: ");
#nullable restore
#line 43 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
                           Write(previsao.TemperaturaMaxima);

#line default
#line hidden
#nullable disable
            WriteLiteral("°C\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\Onecino\source\repos\ClimaTempo_AuvoSistemas\ClimaTempo_AuvoSistemas\Views\Home\CapturarPrevisaoSemanal.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PrevisaoClima>> Html { get; private set; }
    }
}
#pragma warning restore 1591