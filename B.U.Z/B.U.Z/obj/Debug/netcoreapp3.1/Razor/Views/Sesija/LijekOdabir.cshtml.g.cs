#pragma checksum "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Sesija\LijekOdabir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc23d8540dbb1b8d78e5188cc642be32defe0516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sesija_LijekOdabir), @"mvc.1.0.view", @"/Views/Sesija/LijekOdabir.cshtml")]
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
#nullable restore
#line 1 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Sesija\LijekOdabir.cshtml"
using B.U.Z.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc23d8540dbb1b8d78e5188cc642be32defe0516", @"/Views/Sesija/LijekOdabir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af08b38d399eb593fcc5d51851510ccab3f6c7ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Sesija_LijekOdabir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SesijaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("lijekovi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("forma"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Sesija\LijekOdabir.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"mainAjax\">\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc23d8540dbb1b8d78e5188cc642be32defe05165030", async() => {
                WriteLiteral("\r\n            <div id=\"leftColumn\">\r\n                <div>\r\n                    <input type=\"text\" hidden");
                BeginWriteAttribute("value", " value=\"", 356, "\"", 379, 1);
#nullable restore
#line 15 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Sesija\LijekOdabir.cshtml"
WriteAttributeValue("", 364, Model.SesijaId, 364, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"sesijaId\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Lijekovi:</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc23d8540dbb1b8d78e5188cc642be32defe05165982", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 19 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Sesija\LijekOdabir.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LijekId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Sesija\LijekOdabir.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Lijekovi;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onchange", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 608, "findOpis();", 608, 11, true);
                AddHtmlAttributeValue(" ", 619, "saveLijek(", 620, 11, true);
#nullable restore
#line 19 "C:\Users\PC\Desktop\Predavanja\Razvoj softvera I\Seminarski rad\DevAzure\webapp\B.U.Z\B.U.Z\Views\Sesija\LijekOdabir.cshtml"
AddHtmlAttributeValue("", 630, Model.SesijaId, 630, 15, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 645, ")", 645, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <label>Opis:</label>
                    <input type=""text"" id=""Opis"" readonly  class=""form-control"" />
                </div>
            </div>
            <div id=""rightColumn"">
                <div class=""form-group"">
                    <label>Napomena:</label>
                    <textarea id=""Napomena"" rows=""7"" class=""form-control""></textarea>
                </div>
            </div>
        ");
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
</div>
<style>
    #leftColumn {
        float: left;
        width: 50%;
        padding-left: 5px;
        padding-right: 10px;
    }

    #rightColumn {
        float: left;
        width: 50%;
        padding-left: 10px;
        padding-right: 5px;
    }

    #forma {
        color: white;
        padding-left: 20px;
        padding-right: 20px;
    }
</style>
<script>
    $(document).ready(function () {
        loadLijek();
    })

    function loadLijek() {
        var sesija = $(""#sesijaId"").val();
        var url = '/Sesija/GetLijek?SesijaId=' + sesija;

        $.get(url, function (d) {
            $(""#lijekovi"").val(d);
            findOpis();
        })
    }

    function findOpis() {

        var lijekId = $(""#lijekovi"").val();
        var url = '/Lijekovi/getOpis?lijekId=' + lijekId;

        $.get(url, function (d) {
            $(""#Opis"").val(d);
        })
    }

    function saveLijek(seijsaId) {

        var lijekId = $(""#lijeko");
            WriteLiteral("vi\").val();\r\n        var url = \"/Sesija/SaveLijek?SesijaId=\" + seijsaId + \"&LijekId=\" + lijekId;\r\n\r\n        $.get(url, function (d) {\r\n        })\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SesijaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
