#pragma checksum "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a50c41ad96781d74dab5d8d667806e68ba53c61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CarDetails), @"mvc.1.0.view", @"/Views/Shared/_CarDetails.cshtml")]
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
#line 1 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
using Bazar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a50c41ad96781d74dab5d8d667806e68ba53c61", @"/Views/Shared/_CarDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CarDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
  
    CarModel car = Main.GetCarById(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"container p-3 my-3 border bg-light text-center\">\r\n\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 167, "\"", 188, 1);
#nullable restore
#line 12 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
WriteAttributeValue("", 173, car.Fotografia, 173, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\" width=\"600\" height=\"300\" runat=server>\r\n\r\n    </div>\r\n    <div class=\"container p-3 my-3 border bg-light text-left\">\r\n\r\n        <h3>");
#nullable restore
#line 17 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
       Write(car.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
                  Write(car.Modelul);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n        <h2><b>");
#nullable restore
#line 18 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
          Write(String.Format("{0:n0}", car.Pretul));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Lei</b> </h2>\r\n        <br>\r\n\r\n        <div class=\"d-flex  align-items-left flex-wrap row\">\r\n\r\n\r\n\r\n            <button class=\"btn btn-outline-dark mr-3\">An Fabricatie: <b>");
#nullable restore
#line 25 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
                                                                   Write(car.Anul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></button>\r\n            <button class=\"btn btn-outline-dark mr-3\">Caroserie: <b>");
#nullable restore
#line 26 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
                                                               Write(car.Caroseria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></button>\r\n            <button class=\"btn btn-outline-dark mr-3\">Volum motor: <b>");
#nullable restore
#line 27 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
                                                                 Write(car.Volumul);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm³</b></button>\r\n            <button class=\"btn btn-outline-dark mr-3\">Putere: <b>");
#nullable restore
#line 28 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
                                                            Write(car.Puterea);

#line default
#line hidden
#nullable disable
            WriteLiteral(" CP</b></button>\r\n            <button class=\"btn btn-outline-dark mr-3\">Combustibil: <b>");
#nullable restore
#line 29 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
                                                                 Write(car.Combustibilul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></button>\r\n\r\n\r\n\r\n\r\n        </div>\r\n        <br>\r\n        <h4> Telefon: <b> ");
#nullable restore
#line 36 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
                     Write(car.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></h4> <br>\r\n\r\n    </div>\r\n\r\n  <div class=\"container border bg-light text-left\">\r\n\r\n    <h3>Descriere</h3> <br>\r\n    <h5>");
#nullable restore
#line 43 "C:\Users\radu9\OneDrive\Desktop\WebApplication2\WebApplication2\Views\Shared\_CarDetails.cshtml"
   Write(car.Descriere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n    </div>\r\n\r\n\r\n");
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
