#pragma checksum "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f43bce5490dd2a5546f4305d82c6c3e0b5b0810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UploadBox), @"mvc.1.0.view", @"/Views/Shared/_UploadBox.cshtml")]
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
#line 1 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\_ViewImports.cshtml"
using App_consulta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\_ViewImports.cshtml"
using App_consulta.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f43bce5490dd2a5546f4305d82c6c3e0b5b0810", @"/Views/Shared/_UploadBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"447b7686d26caf9e4eafaf498393ffbee01a0de8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UploadBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormAdjuntoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAdjunto_string"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adjunto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline formAdjunto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f43bce5490dd2a5546f4305d82c6c3e0b5b08105268", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
Write(Html.Hidden("id", Model, new { id = "idejecucion"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <label class=\"sr-only\" for=\"nameAdjuntoEjec\">Nombre del adjunto</label>\r\n    <div class=\"input-group mr-sm-2 mt-1\">\r\n        <div class=\"custom-file hideForce\">\r\n            <input");
                BeginWriteAttribute("id", " id=\"", 497, "\"", 529, 2);
                WriteAttributeValue("", 502, "fileAdjuntoEjec_", 502, 16, true);
#nullable restore
#line 9 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
WriteAttributeValue("", 518, Model.Ruta, 518, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"file\" required type=\"file\" class=\"custom-file-input fileUploadAdjuntoEjec \" lang=\"es\">\r\n            <label class=\"custom-file-label\" for=\"fileAdjuntoEjec\" data-browse=\"Elegir\">Seleccionar Archivo</label>\r\n        </div>\r\n    </div>\r\n    <button");
                BeginWriteAttribute("id", " id=\"", 781, "\"", 812, 2);
                WriteAttributeValue("", 786, "btnAdjuntoEjec_", 786, 15, true);
#nullable restore
#line 13 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
WriteAttributeValue("", 801, Model.Ruta, 801, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("data_id", " data_id=\"", 813, "\"", 834, 1);
#nullable restore
#line 13 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
WriteAttributeValue("", 823, Model.Ruta, 823, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-primary mt-1 btn-upload width100\">Cargar ");
#nullable restore
#line 13 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
                                                                                                                                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "data_id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 4 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
AddHtmlAttributeValue("", 68, Model.Ruta, 68, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "data_id2", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 4 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
AddHtmlAttributeValue("", 91, Model.Id, 91, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "data_nombre", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 4 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
AddHtmlAttributeValue("", 115, Model.Nombre, 115, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <span");
            BeginWriteAttribute("id", " id=\"", 997, "\"", 1034, 2);
            WriteAttributeValue("", 1002, "uploadingAdjuntoEjec_", 1002, 21, true);
#nullable restore
#line 17 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
WriteAttributeValue("", 1023, Model.Ruta, 1023, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-text small text-primary\"></span>\r\n        <a");
            BeginWriteAttribute("id", " id=\"", 1092, "\"", 1124, 2);
            WriteAttributeValue("", 1097, "infoAdjuntoEjec_", 1097, 16, true);
#nullable restore
#line 18 "C:\Users\rinco\github\compensacion\codigo fuente\App consulta\Views\Shared\_UploadBox.cshtml"
WriteAttributeValue("", 1113, Model.Ruta, 1113, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-text small text-success\" target=\"_blank\"></a>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormAdjuntoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591