#pragma checksum "C:\Users\46500882\Pia_AgendaT2\Views\Home\VerContacto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4be4c13b024faccbebb3cf5b6d145cbf97aa7b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerContacto), @"mvc.1.0.view", @"/Views/Home/VerContacto.cshtml")]
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
#line 1 "C:\Users\46500882\Pia_AgendaT2\Views\_ViewImports.cshtml"
using PIA_AgendaT2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\46500882\Pia_AgendaT2\Views\_ViewImports.cshtml"
using PIA_AgendaT2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4be4c13b024faccbebb3cf5b6d145cbf97aa7b4", @"/Views/Home/VerContacto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729911bc6d5c8b65df1875352acb6fba5732dd99", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerContacto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\46500882\Pia_AgendaT2\Views\Home\VerContacto.cshtml"
  
    ViewData["Title"] = "Detalle contacto";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    Nombre: <input class=\"form-control\" type=\"text\" style=\"margin: 2%;\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 152, "\"", 199, 2);
#nullable restore
#line 7 "C:\Users\46500882\Pia_AgendaT2\Views\Home\VerContacto.cshtml"
WriteAttributeValue("", 166, ViewBag.Nombre, 166, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\46500882\Pia_AgendaT2\Views\Home\VerContacto.cshtml"
WriteAttributeValue(" ", 181, ViewBag.Apellido, 182, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n    Telefono: <input class=\"form-control\" type=\"text\" style=\"margin: 2%;\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 285, "\"", 316, 1);
#nullable restore
#line 8 "C:\Users\46500882\Pia_AgendaT2\Views\Home\VerContacto.cshtml"
WriteAttributeValue("", 299, ViewBag.Telefono, 299, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n    Email: <input class=\"form-control\" type=\"text\" style=\"margin: 2%;\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 399, "\"", 427, 1);
#nullable restore
#line 9 "C:\Users\46500882\Pia_AgendaT2\Views\Home\VerContacto.cshtml"
WriteAttributeValue("", 413, ViewBag.Email, 413, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 448, "\"", 470, 1);
#nullable restore
#line 10 "C:\Users\46500882\Pia_AgendaT2\Views\Home\VerContacto.cshtml"
WriteAttributeValue("", 454, ViewBag.URLFoto, 454, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
