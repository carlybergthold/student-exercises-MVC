#pragma checksum "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54d48dcdc5d528ccec9edc8b8b5306c9f943d6ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Index.cshtml", typeof(AspNetCore.Views_Instructors_Index))]
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
#line 1 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\_ViewImports.cshtml"
using StudentExercisesMVC;

#line default
#line hidden
#line 2 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\_ViewImports.cshtml"
using StudentExercisesMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d48dcdc5d528ccec9edc8b8b5306c9f943d6ca", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae3dac0dc5d195cfb606d7b7ac9ff8ae977575d", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentExercisesMVC.Models.Instructor>>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a81d75f9f8e4d01a72498155082d81f", async() => {
                BeginContext(154, 10, true);
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
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 38, false);
#line 16 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 44, false);
#line 19 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(455, 47, false);
#line 22 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 45, false);
#line 25 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(603, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 44, false);
#line 28 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(703, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(821, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(870, 37, false);
#line 37 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(907, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(963, 43, false);
#line 40 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1062, 46, false);
#line 43 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1164, 44, false);
#line 46 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1264, 43, false);
#line 49 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1363, 51, false);
#line 52 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1435, 57, false);
#line 53 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1513, 55, false);
#line 54 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\imapl\Documents\Workspace\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1607, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentExercisesMVC.Models.Instructor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
