#pragma checksum "C:\Users\Graciela Porras\source\repos\Proyecto3_Lenguajes\Views\Gimnasio\IniciarSesion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fbec59c4ce98d8d12ce77bcf7a7437ae3e5d8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gimnasio_IniciarSesion), @"mvc.1.0.view", @"/Views/Gimnasio/IniciarSesion.cshtml")]
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
#line 1 "C:\Users\Graciela Porras\source\repos\Proyecto3_Lenguajes\Views\_ViewImports.cshtml"
using Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Graciela Porras\source\repos\Proyecto3_Lenguajes\Views\_ViewImports.cshtml"
using Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fbec59c4ce98d8d12ce77bcf7a7437ae3e5d8d8", @"/Views/Gimnasio/IniciarSesion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6017297ea63e1ae17a5721bfdcff85b1a7a90e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Gimnasio_IniciarSesion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IniciarGYM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Graciela Porras\source\repos\Proyecto3_Lenguajes\Views\Gimnasio\IniciarSesion.cshtml"
  
    ViewData["Title"] = "IniciarSesion";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <CENTER>\r\n        <br /><br /><br />\r\n\r\n        <h2>Iniciar Sesion</h2>\r\n        <div content=\"width=device-widt\" id=\"form\" class=\"row\">\r\n            <div class=\"col-sm-4\"></div>\r\n            <div class=\"col-sm-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fbec59c4ce98d8d12ce77bcf7a7437ae3e5d8d84485", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Graciela Porras\source\repos\Proyecto3_Lenguajes\Views\Gimnasio\IniciarSesion.cshtml"
                     if (Model != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"alert alert-success\" id=\"al1\" role=\"alert\" style=\"display: block; text-align:center\">\r\n                            ");
#nullable restore
#line 18 "C:\Users\Graciela Porras\source\repos\Proyecto3_Lenguajes\Views\Gimnasio\IniciarSesion.cshtml"
                       Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <br>\r\n");
#nullable restore
#line 21 "C:\Users\Graciela Porras\source\repos\Proyecto3_Lenguajes\Views\Gimnasio\IniciarSesion.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <input type=""text"" style="" margin-bottom: 15px;"" class=""form-control"" id=""Nombre"" name=""Nombre""
                           placeholder=""Nombre de usuario"" required />
                    <input type=""password"" style=""margin-bottom: 15px;"" class=""form-control"" id=""Password""
                           name=""Password""
                           placeholder=""Contraseña""
                           required />

                    <button type=""submit"" class=""btn btn-primary"">Iniciar Sesión</button>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-4\"></div>\r\n            <br>\r\n        </div>\r\n    </CENTER> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591
