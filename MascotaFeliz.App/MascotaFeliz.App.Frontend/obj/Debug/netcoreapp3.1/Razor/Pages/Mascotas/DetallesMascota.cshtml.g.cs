#pragma checksum "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fbf9dbaa2d01ad034e8b5ba64948a1f642c7b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascotas.Pages_Mascotas_DetallesMascota), @"mvc.1.0.razor-page", @"/Pages/Mascotas/DetallesMascota.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fbf9dbaa2d01ad034e8b5ba64948a1f642c7b9", @"/Pages/Mascotas/DetallesMascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_DetallesMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListarMascotas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginWriteAttribute("src", " src=\"", 172, "\"", 210, 1);
#nullable restore
#line 8 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
WriteAttributeValue("", 178, Url.Content("~/img/huella.svg"), 178, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n        <h2>Detalle de Mascota</h2>\r\n        <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 299, "\"", 337, 1);
#nullable restore
#line 10 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
WriteAttributeValue("", 305, Url.Content("~/img/huella.svg"), 305, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n    </div>\r\n    <div class=\"contenido\">\r\n        <div class=\"card\">\r\n            <div class=\"card__inner\">\r\n                <div class=\"card__front\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 529, "\"", 569, 1);
#nullable restore
#line 16 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
WriteAttributeValue(" ", 535, Url.Content("~/img/cat&dog.jpg"), 536, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Mascotas\">\r\n                    <h3>");
#nullable restore
#line 17 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                   Write(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"card__asigancion\">\r\n                        <div>\r\n                            <p>Veterinario</p>\r\n                            <p>");
#nullable restore
#line 21 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                          Write(Model.mascota.Veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                             Write(Model.mascota.Veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div>\r\n                            <p>Dueño</p>\r\n                            <p>");
#nullable restore
#line 25 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                          Write(Model.mascota.Dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                       Write(Model.mascota.Dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                       
                    </div>
                </div>
                <div class=""card__back"">
                    
                    <p class=""detalle""> <span> Id:</span> <span class=""card__span"">");
#nullable restore
#line 32 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                                              Write(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                    <p class=\"detalle\"> <span> Color:</span><span class=\"card__span\"> ");
#nullable restore
#line 33 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                                                 Write(Model.mascota.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p class=\"detalle\"><span> Especie:</span><span class=\"card__span\"> ");
#nullable restore
#line 34 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                                                  Write(Model.mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p class=\"detalle\"><span> Raza:</span><span class=\"card__span\"> ");
#nullable restore
#line 35 "C:\Users\PC\Documents\RepoProvicional\ProvisionalMF\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                                               Write(Model.mascota.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"imagenMascota\"></div>\r\n\r\n    </div>\r\n    <div class=\"contenedor\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35fbf9dbaa2d01ad034e8b5ba64948a1f642c7b99658", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
