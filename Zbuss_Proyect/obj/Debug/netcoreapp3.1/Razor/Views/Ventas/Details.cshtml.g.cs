#pragma checksum "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4933dcdc5b35a97fccfc5ba1da477528075916af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ventas_Details), @"mvc.1.0.view", @"/Views/Ventas/Details.cshtml")]
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
#line 1 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\_ViewImports.cshtml"
using Zbuss_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\_ViewImports.cshtml"
using Zbuss_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4933dcdc5b35a97fccfc5ba1da477528075916af", @"/Views/Ventas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5720722c64ff9b7cdee343c5ac97ea6bb54da30", @"/Views/_ViewImports.cshtml")]
    public class Views_Ventas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zbuss_Proyect.Models.TbDetalleVenta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Details</h1>\r\n\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-center\">\r\n        <h4>TbDetalleVenta</h4>\r\n        <hr />\r\n        <dl class=\"col-5\" id=\"Ventas\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.FechaVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MetodoPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.MetodoPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Igv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.Igv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 55 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 58 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IdasientoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 61 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.IdasientoNavigation.CodAsiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 64 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.IduserNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 67 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
           Write(Html.DisplayFor(model => model.IduserNavigation.NroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4933dcdc5b35a97fccfc5ba1da477528075916af10034", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 73 "C:\Users\Josei\Desktop\PROYECTO _ FINAL\Proyecto_Zbuss\Zbuss_Proyect\Views\Ventas\Details.cshtml"
                           WriteLiteral(Model.Idventa);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4933dcdc5b35a97fccfc5ba1da477528075916af12199", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n<div>\r\n    <a id=\"printPDF\" class=\"btn btn-primary\">Print</a>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#printPDF"").click(function () {
            var element = document.getElementById('Ventas');



            html2pdf().from(element).set({
                margin: [30, 30, 15, 30],
                pagebreak: { avoid: 'tr' },



                jsPDF: { orientation: 'portrait', unit: 'pt', format: 'letter', compressPDF: true }
            }).save()
        });</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zbuss_Proyect.Models.TbDetalleVenta> Html { get; private set; }
    }
}
#pragma warning restore 1591
