#pragma checksum "E:\Asp.Net.MVC\Elesche\Elesche\Views\Teacher\EditorTemplates\SubjectSelectViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c13b31bcd9654e149ec6f82bdc35d5c422011c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_EditorTemplates_SubjectSelectViewModel), @"mvc.1.0.view", @"/Views/Teacher/EditorTemplates/SubjectSelectViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/EditorTemplates/SubjectSelectViewModel.cshtml", typeof(AspNetCore.Views_Teacher_EditorTemplates_SubjectSelectViewModel))]
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
#line 3 "E:\Asp.Net.MVC\Elesche\Elesche\Views\_ViewImports.cshtml"
using Elesche.Models.SubjectModel;

#line default
#line hidden
#line 4 "E:\Asp.Net.MVC\Elesche\Elesche\Views\_ViewImports.cshtml"
using Elesche.Models.TeacherModel;

#line default
#line hidden
#line 5 "E:\Asp.Net.MVC\Elesche\Elesche\Views\_ViewImports.cshtml"
using Elesche.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c13b31bcd9654e149ec6f82bdc35d5c422011c", @"/Views/Teacher/EditorTemplates/SubjectSelectViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a91de7833b0b5dda87909e5137bf8b936879e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_EditorTemplates_SubjectSelectViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubjectSelectViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(34, 41, false);
#line 3 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Teacher\EditorTemplates\SubjectSelectViewModel.cshtml"
Write(Html.HiddenFor(model => model.Subject.Id));

#line default
#line hidden
            EndContext();
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(78, 43, false);
#line 4 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Teacher\EditorTemplates\SubjectSelectViewModel.cshtml"
Write(Html.HiddenFor(model => model.Subject.Name));

#line default
#line hidden
            EndContext();
            BeginContext(121, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(126, 60, false);
#line 6 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Teacher\EditorTemplates\SubjectSelectViewModel.cshtml"
Write(Html.LabelFor(model => model.IsSelected, Model.Subject.Name));

#line default
#line hidden
            EndContext();
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 41, false);
#line 7 "E:\Asp.Net.MVC\Elesche\Elesche\Views\Teacher\EditorTemplates\SubjectSelectViewModel.cshtml"
Write(Html.EditorFor(model => model.IsSelected));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubjectSelectViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
