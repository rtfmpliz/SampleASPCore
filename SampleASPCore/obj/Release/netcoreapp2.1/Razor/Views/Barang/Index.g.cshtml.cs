#pragma checksum "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe2afaa2d4a03c9429d2eea871a2e20bc8b1239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Barang_Index), @"mvc.1.0.view", @"/Views/Barang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Barang/Index.cshtml", typeof(AspNetCore.Views_Barang_Index))]
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
#line 1 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\_ViewImports.cshtml"
using SampleASPCore;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\_ViewImports.cshtml"
using SampleASPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe2afaa2d4a03c9429d2eea871a2e20bc8b1239", @"/Views/Barang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d10ced33a46cfde1ec9b73f7be53ea0e785dae", @"/Views/_ViewImports.cshtml")]
    public class Views_Barang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SampleASPCore.Models.Barang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
  
    ViewData["Title"] = "Daftar Barang";

#line default
#line hidden
            BeginContext(100, 232, true);
            WriteLiteral("<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\">\r\n        <a href=/Barang/Index>Home Page</a>\r\n    </li>\r\n    <li class=\"breadcrumb-item active\">Daftar Kategori</li>\r\n</ol>\r\n\r\n\r\n\r\n<div class=\" col-md-12\">\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(332, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc995feb6e549908486007d729506ab", async() => {
                BeginContext(355, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(369, 116, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(486, 46, false);
#line 23 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.KodeBarang));

#line default
#line hidden
            EndContext();
            BeginContext(532, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(600, 57, false);
#line 26 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Kategori.NamaKategori));

#line default
#line hidden
            EndContext();
            BeginContext(657, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(725, 46, false);
#line 29 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NamaBarang));

#line default
#line hidden
            EndContext();
            BeginContext(771, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(839, 41, false);
#line 32 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(880, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(948, 45, false);
#line 35 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HargaBeli));

#line default
#line hidden
            EndContext();
            BeginContext(993, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1061, 45, false);
#line 38 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HargaJual));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1269, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1342, 45, false);
#line 48 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KodeBarang));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1467, 56, false);
#line 51 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Kategori.NamaKategori));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1603, 45, false);
#line 54 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NamaBarang));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1728, 40, false);
#line 57 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1848, 44, false);
#line 60 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HargaBeli));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1972, 44, false);
#line 63 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HargaJual));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2096, 65, false);
#line 66 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2190, 71, false);
#line 67 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2290, 69, false);
#line 68 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2359, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 71 "C:\Users\user\source\repos\SampleASPCore\SampleASPCore\Views\Barang\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2426, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SampleASPCore.Models.Barang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
