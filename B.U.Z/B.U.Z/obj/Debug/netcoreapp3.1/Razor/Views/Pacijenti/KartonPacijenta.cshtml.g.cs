#pragma checksum "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7428ede10edf96d38755ef54f8e82a137b87c9ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacijenti_KartonPacijenta), @"mvc.1.0.view", @"/Views/Pacijenti/KartonPacijenta.cshtml")]
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
#line 1 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using B.U.Z.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\_ViewImports.cshtml"
using ShieldUI.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
using B.U.Z.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7428ede10edf96d38755ef54f8e82a137b87c9ca", @"/Views/Pacijenti/KartonPacijenta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c214f9cc327750748f057da8e48ccd81cdbd30", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacijenti_KartonPacijenta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PacijentiKartonVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Home/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TerminiDropDown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("UcitajInformacije()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"float:left; height:1000px; width:20%; float:left; margin:0;\" class=\"primary\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7428ede10edf96d38755ef54f8e82a137b87c9ca5022", async() => {
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
            WriteLiteral(@"
</div>
<h1 style=""padding-top:3%; padding-left:22%;"">Stomatološki karton</h1>
<div id=""PacijentiKartonContainer"">

    <div id=""LicniPodaci"">

        <div style=""padding-bottom:3%;"">
            <h4>Lični podaci</h4>
        </div>
        <div>

            <label>Broj kartona:</label>
            <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 513, "\"", 539, 1);
#nullable restore
#line 18 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 521, Model.BrojKartona, 521, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        </div>\r\n        <div>\r\n\r\n            <label>Ime:</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 643, "\"", 661, 1);
#nullable restore
#line 24 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 651, Model.Ime, 651, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        </div>\r\n\r\n        <div>\r\n            <label>Prezime:</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 769, "\"", 791, 1);
#nullable restore
#line 30 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 777, Model.Prezime, 777, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div>\r\n            <label>Spol:</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 894, "\"", 913, 1);
#nullable restore
#line 35 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 902, Model.Spol, 902, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div>\r\n            <label>Datum rodjenja:</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1026, "\"", 1054, 1);
#nullable restore
#line 40 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 1034, Model.DatumRodjenja, 1034, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div id=\"KontaktPodaci\">\r\n        <div style=\"padding-bottom:3%;\">\r\n            <h4>Kontakt podaci</h4>\r\n        </div>\r\n        <div>\r\n            <label>Email:</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1295, "\"", 1315, 1);
#nullable restore
#line 50 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 1303, Model.Email, 1303, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div>\r\n            <label>Broj telefona:</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1427, "\"", 1454, 1);
#nullable restore
#line 55 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 1435, Model.BrojTelefona, 1435, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div>\r\n            <label>Grad:</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1557, "\"", 1576, 1);
#nullable restore
#line 60 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 1565, Model.Grad, 1565, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        \r\n    </div>\r\n\r\n    <div id=\"HistorijaTermina\">\r\n\r\n        <div style=\"padding-bottom:3%;\">\r\n            <h4>Historija termina</h4>\r\n        </div>\r\n\r\n        <div>\r\n            <label>Izvršene sesije:</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7428ede10edf96d38755ef54f8e82a137b87c9ca11158", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 73 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Sesije;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            <label>Izvršena usluga:</label>\r\n            <input id=\"Usluga\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2046, "\"", 2075, 1);
#nullable restore
#line 78 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 2054, Model.IzvrsenaUsluga, 2054, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div>\r\n            <label>Dijagnoza:</label>\r\n            <input id=\"Dijagnoza\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2198, "\"", 2222, 1);
#nullable restore
#line 83 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 2206, Model.Dijagnoza, 2206, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div>\r\n            <label>Terapija:</label>\r\n            <input id=\"Terapija\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2343, "\"", 2366, 1);
#nullable restore
#line 88 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 2351, Model.Terapija, 2351, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div>\r\n            <label>Lijek:</label>\r\n            <input id=\"Lijek\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2481, "\"", 2501, 1);
#nullable restore
#line 93 "C:\Users\Bios Servis\Desktop\College\Godina 3\Razvoj Softvera 1\Seminarski\DevAzure\webapp\B.U.Z\B.U.Z\Views\Pacijenti\KartonPacijenta.cshtml"
WriteAttributeValue("", 2489, Model.Lijek, 2489, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>

    </div>

</div>

<style>
    #PacijentiKartonContainer
    {
        border:1px solid red;
        float:left;
        width:80%;
        height:100%;
    }
    #LicniPodaci
    {
        width:40%;
        height:50%;
        margin-left:3%;
        margin-top:5%;
        float:left;
        border:1px solid green;
    }
    #KontaktPodaci {
        width: 40%;
        height: 50%;
        margin-left: 3%;
        margin-top: 5%;
        float: left;
        border: 1px solid purple;
    }
    #HistorijaTermina {
        border: 3px solid black;
        width: 55%;
        height: auto;
        float: left;
        margin-left: 3%;
        margin-top: 5%;
    }
</style>

<script>
    function UcitajInformacije()
    {
        var sesijaId = $(""#TerminiDropDown"").val();
        var url = ""/Pacijenti/InformacijeOTerminu?sesijaId="" + sesijaId;
        $.get(url, function (d) {
            $(""#Usluga"").val(d[0]);
            $(""#Dijagnoza"").");
            WriteLiteral("val(d[1]);\r\n            $(\"#Terapija\").val(d[2]);\r\n            $(\"#Lijek\").val(d[3]);\r\n        });\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PacijentiKartonVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
