#pragma checksum "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6337859edad7f96088313cd3a9f12248a37e65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lijekovi_Lijekovi), @"mvc.1.0.view", @"/Views/Lijekovi/Lijekovi.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6337859edad7f96088313cd3a9f12248a37e65", @"/Views/Lijekovi/Lijekovi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af08b38d399eb593fcc5d51851510ccab3f6c7ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Lijekovi_Lijekovi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Lijekovi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LijekoviPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"float:left; height:1000px; width:200px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c6337859edad7f96088313cd3a9f12248a37e654514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<h1>Lijekovi</h1>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c6337859edad7f96088313cd3a9f12248a37e655682", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"PretraziDiv\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6337859edad7f96088313cd3a9f12248a37e656844", async() => {
                WriteLiteral("\r\n        <label>Pretraži lijekove:</label>\r\n        <input type=\"text\" name=\"filter\" />\r\n        <input type=\"submit\" value=\"Pretraži\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<table class=""table table-dark"" style=""width:80.7%;"">
    <thead>
        <tr>
            <th scope=""col"">Redni broj</th>
            <th scope=""col"">Šifra</th>
            <th scope=""col"">Naziv</th>
            <th scope=""col"">Opis</th>
            <th scope=""col"">Obriši</th>
            <th scope=""col"">Uredi</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
         foreach (var s in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
           Write(s.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
           Write(s.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
           Write(s.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><button class=\"badge-danger\"><a style=\"color:white; text-decoration:none\" ;");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1100, 2);
            WriteAttributeValue("", 1065, "/Lijekovi/ObrisiLijek?LijekId=", 1065, 30, true);
#nullable restore
#line 40 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
WriteAttributeValue("", 1095, s.Id, 1095, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Obriši</a></button></td>\r\n            <td><button class=\"badge-danger\"><a style=\"color:white; text-decoration:none\" ;");
            BeginWriteAttribute("href", " href=\"", 1219, "\"", 1260, 2);
            WriteAttributeValue("", 1226, "/Lijekovi/UrediLijek?LijekId=", 1226, 29, true);
#nullable restore
#line 41 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
WriteAttributeValue("", 1255, s.Id, 1255, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a></button></td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n<div id=\"BrojDostupnihLijekova\">\r\n    <label style=\"margin-left:1%\">Broj dostupnih lijekova:</label>");
#nullable restore
#line 49 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Lijekovi\Lijekovi.cshtml"
                                                             Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<style>
    body {
        counter-reset: Serial; /* Set the Serial counter to 0 */
    }

    tr td:first-child:before {
        counter-increment: Serial; /* Increment the Serial counter */
        content: counter(Serial); /* Display the counter */
    }
    #PretraziDiv {
        color: white;
        background-color: #343a40;
        width: 80.6%;
        margin-left: 18.1%;
    }
    #BrojDostupnihLijekova {
        color: white;
        background-color: #343a40;
        width: 80.6%;
        margin-left: 18.1%;
        margin-top: -2%;
    }

</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Lijekovi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
