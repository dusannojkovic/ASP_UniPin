#pragma checksum "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de8606e144a2d0cd0add7fa5684b83e1faf5886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Details), @"mvc.1.0.view", @"/Views/Post/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Details.cshtml", typeof(AspNetCore.Views_Post_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de8606e144a2d0cd0add7fa5684b83e1faf5886", @"/Views/Post/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9d4233fb877e51304998fae0992f8f6277913f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application.DTO.PostDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 51, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>PostDTO</h4>\r\n");
            EndContext();
#line 11 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(172, 31, true);
            WriteLiteral("        <p class=\"text-danger\">");
            EndContext();
            BeginContext(204, 17, false);
#line 13 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
                          Write(TempData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(221, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(234, 12, true);
            WriteLiteral("    <hr />\r\n");
            EndContext();
#line 16 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(278, 46, true);
            WriteLiteral("<dl class=\"dl-horizontal\">\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(325, 38, false);
#line 20 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(363, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(395, 34, false);
#line 23 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(429, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(461, 42, false);
#line 26 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Naslov));

#line default
#line hidden
            EndContext();
            BeginContext(503, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(535, 38, false);
#line 29 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayFor(model => model.Naslov));

#line default
#line hidden
            EndContext();
            BeginContext(573, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(605, 40, false);
#line 32 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(645, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(677, 36, false);
#line 35 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(713, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(745, 43, false);
#line 38 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(788, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(820, 39, false);
#line 41 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(859, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(891, 42, false);
#line 44 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.PostBy));

#line default
#line hidden
            EndContext();
            BeginContext(933, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(965, 38, false);
#line 47 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayFor(model => model.PostBy));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1035, 48, false);
#line 50 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1115, 44, false);
#line 53 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1191, 44, false);
#line 56 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 13, true);
            WriteLiteral("\r\n    </dt>\r\n");
            EndContext();
#line 58 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
     foreach (var coment in Model.Comments)
    {

#line default
#line hidden
            BeginContext(1300, 29, true);
            WriteLiteral("        <dd>\r\n            <p>");
            EndContext();
            BeginContext(1330, 12, false);
#line 61 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
          Write(coment.Tekst);

#line default
#line hidden
            EndContext();
            BeginContext(1342, 21, true);
            WriteLiteral("</p>\r\n        </dd>\r\n");
            EndContext();
#line 63 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1370, 11, true);
            WriteLiteral("\r\n\r\n</dl>\r\n");
            EndContext();
#line 67 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1405, 37, true);
            WriteLiteral("        <h1>Model ne postoji!!</h1>\r\n");
            EndContext();
#line 71 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1449, 19, true);
            WriteLiteral("</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1469, 68, false);
#line 74 "D:\ProjektiAsp\UniPin\UniPin.MVC\Views\Post\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1545, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e0c778975548ccb8e4bff90aeb8dbd", async() => {
                BeginContext(1567, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1583, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application.DTO.PostDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
