#pragma checksum "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Labs\ClassroomDemo2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "167daf1d2878e7eee7cf7f509ffb2f3e1531ab04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"167daf1d2878e7eee7cf7f509ffb2f3e1531ab04", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassroomDemo2.Models.MyPerson>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(46, 15, false);
#line 3 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Labs\ClassroomDemo2\Views\Home\Index.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(61, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(73, 14, false);
#line 4 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Labs\ClassroomDemo2\Views\Home\Index.cshtml"
Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(87, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(99, 21, false);
#line 5 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Labs\ClassroomDemo2\Views\Home\Index.cshtml"
Write(Model.MyFavoriteSnack);

#line default
#line hidden
            EndContext();
            BeginContext(120, 5, true);
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassroomDemo2.Models.MyPerson> Html { get; private set; }
    }
}
#pragma warning restore 1591
