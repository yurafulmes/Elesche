#pragma checksum "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b36fe480acfc4fc1076590a6cb38aeb303893a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_List), @"mvc.1.0.view", @"/Views/School/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/School/List.cshtml", typeof(AspNetCore.Views_School_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b36fe480acfc4fc1076590a6cb38aeb303893a", @"/Views/School/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3b827fb3e2921bf1a568d0d76d3f82a5b718cc", @"/Views/_ViewImports.cshtml")]
    public class Views_School_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<School>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
 foreach (var school in Model)
{

#line default
#line hidden
            BeginContext(63, 21, true);
            WriteLiteral("<div>\r\n    <h1>Name: ");
            EndContext();
            BeginContext(85, 11, false);
#line 5 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
         Write(school.Name);

#line default
#line hidden
            EndContext();
            BeginContext(96, 25, true);
            WriteLiteral("</h1>\r\n    <h2>Director: ");
            EndContext();
            BeginContext(122, 15, false);
#line 6 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
             Write(school.Director);

#line default
#line hidden
            EndContext();
            BeginContext(137, 19, true);
            WriteLiteral("</h2>\r\n    <h2>ID: ");
            EndContext();
            BeginContext(157, 9, false);
#line 7 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
       Write(school.Id);

#line default
#line hidden
            EndContext();
            BeginContext(166, 38, true);
            WriteLiteral("</h2>\r\n    <div class=\"btn btn-info \">");
            EndContext();
            BeginContext(205, 55, false);
#line 8 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
                          Write(Html.ActionLink("Edit", "Edit", new { id = school.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(260, 42, true);
            WriteLiteral(" </div>\r\n    <div class=\"btn btn-warning\">");
            EndContext();
            BeginContext(303, 59, false);
#line 9 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
                            Write(Html.ActionLink("Delete", "Delete", new { id = school.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(362, 41, true);
            WriteLiteral("</div>\r\n    <div class=\"btn btn-default\">");
            EndContext();
            BeginContext(404, 61, false);
#line 10 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
                            Write(Html.ActionLink("Details", "Details", new { id = school.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(465, 16, true);
            WriteLiteral("</div>\r\n</div>\r\n");
            EndContext();
#line 12 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"

}

#line default
#line hidden
            BeginContext(486, 71, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <div class=\"btn btn-success \">\r\n        ");
            EndContext();
            BeginContext(558, 35, false);
#line 16 "E:\Asp.Net.MVC\Elesche\Elesche\Views\School\List.cshtml"
   Write(Html.ActionLink("Create", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(593, 20, true);
            WriteLiteral("\r\n</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<School>> Html { get; private set; }
    }
}
#pragma warning restore 1591