#pragma checksum "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd5192941eba5307040f2767e2f842cacbcd1034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipment_List), @"mvc.1.0.view", @"/Views/Equipment/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Equipment/List.cshtml", typeof(AspNetCore.Views_Equipment_List))]
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
#line 1 "E:\Asp.Net.MVC\Elesche\Elesche\Views\_ViewImports.cshtml"
using Elesche.Models.SchoolModel;

#line default
#line hidden
#line 2 "E:\Asp.Net.MVC\Elesche\Elesche\Views\_ViewImports.cshtml"
using Elesche.Models.EquipmentModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5192941eba5307040f2767e2f842cacbcd1034", @"/Views/Equipment/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3b827fb3e2921bf1a568d0d76d3f82a5b718cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipment_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Equipment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "School", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
 foreach (var equipment in Model)
{

#line default
#line hidden
            BeginContext(69, 29, true);
            WriteLiteral("    <div>\r\n        <h1>Name: ");
            EndContext();
            BeginContext(99, 14, false);
#line 5 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
             Write(equipment.Name);

#line default
#line hidden
            EndContext();
            BeginContext(113, 27, true);
            WriteLiteral("</h1>\r\n        <h2>School: ");
            EndContext();
            BeginContext(141, 21, false);
#line 6 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
               Write(equipment.School.Name);

#line default
#line hidden
            EndContext();
            BeginContext(162, 23, true);
            WriteLiteral("</h2>\r\n        <h2>ID: ");
            EndContext();
            BeginContext(186, 12, false);
#line 7 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
           Write(equipment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(198, 42, true);
            WriteLiteral("</h2>\r\n        <div class=\"btn btn-info \">");
            EndContext();
            BeginContext(241, 58, false);
#line 8 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
                              Write(Html.ActionLink("Edit", "Edit", new { id = equipment.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(299, 46, true);
            WriteLiteral(" </div>\r\n        <div class=\"btn btn-warning\">");
            EndContext();
            BeginContext(346, 62, false);
#line 9 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
                                Write(Html.ActionLink("Delete", "Delete", new { id = equipment.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(408, 45, true);
            WriteLiteral("</div>\r\n        <div class=\"btn btn-default\">");
            EndContext();
            BeginContext(454, 64, false);
#line 10 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
                                Write(Html.ActionLink("Details", "Details", new { id = equipment.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(518, 20, true);
            WriteLiteral("</div>\r\n    </div>\r\n");
            EndContext();
#line 12 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
   
}

#line default
#line hidden
            BeginContext(546, 67, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <div class=\"btn btn-info\">\r\n        ");
            EndContext();
            BeginContext(613, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f6c25134c3848bfbd85c37868a220ac", async() => {
                BeginContext(710, 15, true);
                WriteLiteral("Back to Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
                                                          WriteLiteral(Model.FirstOrDefault()?.SchoolId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(729, 58, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"btn btn-success \">\r\n        ");
            EndContext();
            BeginContext(788, 35, false);
#line 19 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Equipment\List.cshtml"
   Write(Html.ActionLink("Create", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(823, 34, true);
            WriteLiteral("\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Equipment>> Html { get; private set; }
    }
}
#pragma warning restore 1591