#pragma checksum "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f587bec4bad3adc4fc1be486d285d15017dda3f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 1 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\_ViewImports.cshtml"
using UniPin.MVC;

#line default
#line hidden
#line 2 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\_ViewImports.cshtml"
using UniPin.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f587bec4bad3adc4fc1be486d285d15017dda3f2", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9d4233fb877e51304998fae0992f8f6277913f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Application.DTO.PostDTO>>
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(117, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "791a37e8dcf54e498a25b741e25735b3", async() => {
                BeginContext(140, 10, true);
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
            BeginContext(154, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(247, 38, false);
#line 16 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(285, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(341, 42, false);
#line 19 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Naslov));

#line default
#line hidden
            EndContext();
            BeginContext(383, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(439, 40, false);
#line 22 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(479, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(535, 42, false);
#line 25 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PostBy));

#line default
#line hidden
            EndContext();
            BeginContext(577, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(633, 48, false);
#line 28 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(681, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(737, 43, false);
#line 31 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(780, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(898, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(947, 37, false);
#line 40 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(984, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1040, 41, false);
#line 43 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naslov));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1137, 39, false);
#line 46 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1232, 41, false);
#line 49 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostBy));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1329, 47, false);
#line 52 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1435, "\"", 1454, 1);
#line 55 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
WriteAttributeValue("", 1441, item.Picture, 1441, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1455, 65, true);
            WriteLiteral(" alt=\"\" />\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1521, 72, false);
#line 58 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1614, 78, false);
#line 59 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1713, 76, false);
#line 60 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1828, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Application.DTO.PostDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
