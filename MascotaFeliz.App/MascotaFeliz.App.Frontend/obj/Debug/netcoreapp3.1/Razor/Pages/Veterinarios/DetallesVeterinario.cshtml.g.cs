#pragma checksum "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff038585e0e1c7af4fad81f2c214ed5c31dd2082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_DetallesVeterinario), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/DetallesVeterinario.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
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
#line 1 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff038585e0e1c7af4fad81f2c214ed5c31dd2082", @"/Pages/Veterinarios/DetallesVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_DetallesVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListarVeterinarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main class=\"contenedor sombra\">\r\n\r\n    <div class=\"titulo\">\r\n        <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 176, "\"", 214, 1);
#nullable restore
#line 8 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
WriteAttributeValue("", 182, Url.Content("~/img/huella.svg"), 182, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n        <h2>Detalle de Veterinario</h2>\r\n        <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 307, "\"", 345, 1);
#nullable restore
#line 10 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
WriteAttributeValue("", 313, Url.Content("~/img/huella.svg"), 313, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n    </div>\r\n    <div class=\"contenido\">\r\n        <div class=\"card_vet\">\r\n            <div class=\"card__inner_vet\">\r\n                <div class=\"card__front_vet\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 549, "\"", 589, 1);
#nullable restore
#line 16 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
WriteAttributeValue(" ", 555, Url.Content("~/img/cat&dog.jpg"), 556, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Mascotas\">\r\n                    <h3>");
#nullable restore
#line 17 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
                   Write(Model.veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"card__back_vet\">\r\n                    <p class=\"detalle_vet\"> <span> Id:</span> <span class=\"card__span_vet\">");
#nullable restore
#line 20 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
                                                                                      Write(Model.veterinario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                    <p class=\"detalle_vet\"> <span> Nombres:</span><span class=\"card__span_vet\"> ");
#nullable restore
#line 21 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
                                                                                           Write(Model.veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p class=\"detalle_vet\"><span> Apellidos:</span><span class=\"card__span_vet\"> ");
#nullable restore
#line 22 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
                                                                                            Write(Model.veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p class=\"detalle_vet\"><span> Direccion:</span><span class=\"card__span_vet\"> ");
#nullable restore
#line 23 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
                                                                                            Write(Model.veterinario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p class=\"detalle_vet\"><span> Teléfono:</span><span class=\"card__span_vet\"> ");
#nullable restore
#line 24 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
                                                                                           Write(Model.veterinario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p class=\"detalle_vet\"><span> Tarjeta Profesional:</span><span class=\"card__span_vet\"> ");
#nullable restore
#line 25 "C:\Users\Acer\Documents\Nueva carpeta\ProvisionalMF\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetallesVeterinario.cshtml"
                                                                                                      Write(Model.veterinario.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"imagenMascota\"></div>\r\n\r\n    </div>\r\n    <div class=\"contenedor\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff038585e0e1c7af4fad81f2c214ed5c31dd20829184", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetallesVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVeterinarioModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetallesVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
