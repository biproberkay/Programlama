#pragma checksum "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\KullaniciIslemleri\KullanicininRolleri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a27e6c516edf3f2a155e7bab466087e1d47f1ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KullaniciIslemleri_KullanicininRolleri), @"mvc.1.0.view", @"/Views/KullaniciIslemleri/KullanicininRolleri.cshtml")]
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
#line 1 "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\_ViewImports.cshtml"
using ETicaret;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\_ViewImports.cshtml"
using ETicaret.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a27e6c516edf3f2a155e7bab466087e1d47f1ad", @"/Views/KullaniciIslemleri/KullanicininRolleri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"122906d037701dbdec640b6ace2ab30b1ed226d0", @"/Views/_ViewImports.cshtml")]
    public class Views_KullaniciIslemleri_KullanicininRolleri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\KullaniciIslemleri\KullanicininRolleri.cshtml"
  
    ViewData["Title"] = "KullanicininRolleri";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron mt-5\" >\r\n    <h1 class=\"text-primary\"> <span class=\"text-danger\">");
#nullable restore
#line 6 "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\KullaniciIslemleri\KullanicininRolleri.cshtml"
                                                   Write(ViewBag.KullaniciAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>Kullanıcısının Rolleri</h1>\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <th>Rol</th>\r\n        </thead>\r\n");
#nullable restore
#line 11 "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\KullaniciIslemleri\KullanicininRolleri.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 14 "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\KullaniciIslemleri\KullanicininRolleri.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 16 "C:\Users\stude\source\repos\GitHub\studentberkay\Organizations\Bilgisayar Programciligi\Programlama\Programlama-3\10 - ETicaretSQLite_Identity_role\Views\KullaniciIslemleri\KullanicininRolleri.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a27e6c516edf3f2a155e7bab466087e1d47f1ad6228", async() => {
                WriteLiteral("Geri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
