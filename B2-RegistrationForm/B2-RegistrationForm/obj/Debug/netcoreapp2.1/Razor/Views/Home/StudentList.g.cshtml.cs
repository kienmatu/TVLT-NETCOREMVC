#pragma checksum "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f66b903646e169db9d1cebcfc3aa89d5b905ce7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentList), @"mvc.1.0.view", @"/Views/Home/StudentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/StudentList.cshtml", typeof(AspNetCore.Views_Home_StudentList))]
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
#line 1 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\_ViewImports.cshtml"
using B2_RegistrationForm;

#line default
#line hidden
#line 2 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\_ViewImports.cshtml"
using B2_RegistrationForm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f66b903646e169db9d1cebcfc3aa89d5b905ce7", @"/Views/Home/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da8124cbfd726c3180c67a193009681adeb4851", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<B2RegistrationForm.Models.Student>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(84, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(113, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c24ed559957f4b5aa5d3b4d01612d570", async() => {
                BeginContext(119, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>StudentList</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(219, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(221, 1067, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2e0add0a14c4354b26ba38b29bbca9f", async() => {
                BeginContext(227, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(238, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0fac2c6ea34c12930b6a3765c350dd", async() => {
                    BeginContext(261, 10, true);
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
                BeginContext(275, 92, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(368, 40, false);
#line 22 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(408, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(464, 41, false);
#line 25 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(505, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(561, 41, false);
#line 28 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(602, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(658, 47, false);
#line 31 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.hasGraduate));

#line default
#line hidden
                EndContext();
                BeginContext(705, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 37 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(823, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(872, 39, false);
#line 40 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(911, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(967, 40, false);
#line 43 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1007, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1063, 40, false);
#line 46 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(1103, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1159, 46, false);
#line 49 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.hasGraduate));

#line default
#line hidden
                EndContext();
                BeginContext(1205, 49, true);
                WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
                EndContext();
#line 53 "C:\Users\KIENDINH\source\repos\B2-RegistrationForm\B2-RegistrationForm\Views\Home\StudentList.cshtml"
}

#line default
#line hidden
                BeginContext(1257, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1288, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<B2RegistrationForm.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
