#pragma checksum "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "831ce503e2212100409778b8a6cb59272e08e0ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_servicio_Details), @"mvc.1.0.view", @"/Views/Producto_servicio/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Producto_servicio/Details.cshtml", typeof(AspNetCore.Views_Producto_servicio_Details))]
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
#line 1 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\_ViewImports.cshtml"
using Simulador_de_negocios;

#line default
#line hidden
#line 2 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\_ViewImports.cshtml"
using Simulador_de_negocios.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"831ce503e2212100409778b8a6cb59272e08e0ab", @"/Views/Producto_servicio/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e121584f976f79b4896dc566fe0df751d7a87e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_servicio_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Simulador_de_negocios.Models.Producto_servicio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(100, 132, true);
            WriteLiteral("\r\n<h2>Detalles</h2>\r\n\r\n<div>\r\n    <h4>Producto_servicio</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(233, 51, false);
#line 14 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nombre_producto));

#line default
#line hidden
            EndContext();
            BeginContext(284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(328, 47, false);
#line 17 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.nombre_producto));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(419, 53, false);
#line 20 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.unidad_produccion));

#line default
#line hidden
            EndContext();
            BeginContext(472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(516, 49, false);
#line 23 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.unidad_produccion));

#line default
#line hidden
            EndContext();
            BeginContext(565, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(609, 54, false);
#line 26 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.produccion_mensual));

#line default
#line hidden
            EndContext();
            BeginContext(663, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(707, 50, false);
#line 29 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.produccion_mensual));

#line default
#line hidden
            EndContext();
            BeginContext(757, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(801, 50, false);
#line 32 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.costo_unitario));

#line default
#line hidden
            EndContext();
            BeginContext(851, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(895, 46, false);
#line 35 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.costo_unitario));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(985, 51, false);
#line 38 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.margen_utilidad));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1080, 47, false);
#line 41 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.margen_utilidad));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1171, 50, false);
#line 44 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.precio_publico));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1265, 46, false);
#line 47 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.precio_publico));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1355, 60, false);
#line 50 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.datos_empresa_id_empresa));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1459, 56, false);
#line 53 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
       Write(Html.DisplayFor(model => model.datos_empresa_id_empresa));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1562, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d041e684c6d84df0aa1de7efc58823ef", async() => {
                BeginContext(1617, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "c:\users\xd_pa\source\repos\sdn\Simulador_de_negocios\Views\Producto_servicio\Details.cshtml"
                           WriteLiteral(Model.id_producto);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1625, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1633, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898d52ab76534a60919b9b1a2528d528", async() => {
                BeginContext(1655, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1667, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Simulador_de_negocios.Models.Producto_servicio> Html { get; private set; }
    }
}
#pragma warning restore 1591