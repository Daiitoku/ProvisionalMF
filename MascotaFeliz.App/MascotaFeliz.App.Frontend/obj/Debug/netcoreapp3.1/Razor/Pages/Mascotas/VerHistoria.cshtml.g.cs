#pragma checksum "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9727b9cc96bc08246af553b9ebf31074eaf3558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascotas.Pages_Mascotas_VerHistoria), @"mvc.1.0.razor-page", @"/Pages/Mascotas/VerHistoria.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascotas
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
#line 1 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9727b9cc96bc08246af553b9ebf31074eaf3558", @"/Pages/Mascotas/VerHistoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_VerHistoria : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
  
    ViewData["Title"] = "Home page";
    Layout=null;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n\r\n\r\n    <header>\r\n        <div class=\"Encabezado_superior\">\r\n            \r\n            <div class=\"titulo\">\r\n        <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 281, "\"", 319, 1);
#nullable restore
#line 15 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
WriteAttributeValue("", 287, Url.Content("~/img/huella.svg"), 287, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n        <h2>Historia de Mascota</h2>\r\n        <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 409, "\"", 447, 1);
#nullable restore
#line 17 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
WriteAttributeValue("", 415, Url.Content("~/img/huella.svg"), 415, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n        </div>\r\n\r\n\r\n        </div>\r\n      \r\n    </header>\r\n\r\n    <h1 id=\"listadodemascotas\">-");
#nullable restore
#line 25 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                           Write(Model.Mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 25 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                                              Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("          Fecha Inicio ");
#nullable restore
#line 25 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                                                                                          Write(Model.Mascota.Historia.FechaInicial);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

 
    <div class=""cajat"">
        <table class=""tabla"">

            <tr>
          
              <th>Fecha</th>
          
              <th>Veterinario</th>
          
              <th>Temperatura</th>

              <th>Peso (kg)</th>

              <th>Frecuencia Respiratoria</th>

            
              <th>Frecuencia Cardiaca</th>
              <th>Estado de Animo</th>
              <th>Recomendaciones </th>
              
            </tr>

");
#nullable restore
#line 50 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
             foreach (var x in Model.ListaVisitaspyp)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.FechaVisita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.IdVeterinario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.EstadoAnimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"
                   Write(x.Recomendaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\VerHistoria.cshtml"

                

                
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.VerHistoriaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.VerHistoriaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.VerHistoriaModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.VerHistoriaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591