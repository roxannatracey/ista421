#pragma checksum "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Quizzes\Quiz11\Views\Person2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d1a44a94778f69cefe62f1485593eb31c646cb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person2_Index), @"mvc.1.0.view", @"/Views/Person2/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person2/Index.cshtml", typeof(AspNetCore.Views_Person2_Index))]
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
#line 1 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Quizzes\Quiz11\Views\_ViewImports.cshtml"
using Quiz11;

#line default
#line hidden
#line 2 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Quizzes\Quiz11\Views\_ViewImports.cshtml"
using Quiz11.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d1a44a94778f69cefe62f1485593eb31c646cb3", @"/Views/Person2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead9d3029cdd3d52325071cecd0bc1d3bdc5742f", @"/Views/_ViewImports.cshtml")]
    public class Views_Person2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quiz11.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(38, 15, false);
#line 4 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Quizzes\Quiz11\Views\Person2\Index.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(53, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(65, 14, false);
#line 5 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Quizzes\Quiz11\Views\Person2\Index.cshtml"
Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(79, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(91, 21, false);
#line 6 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Quizzes\Quiz11\Views\Person2\Index.cshtml"
Write(Model.MyFavoriteSnack);

#line default
#line hidden
            EndContext();
            BeginContext(112, 34, true);
            WriteLiteral("</h2>\r\n<h2 style=\" color: green\"> ");
            EndContext();
            BeginContext(147, 21, false);
#line 7 "C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Quizzes\Quiz11\Views\Person2\Index.cshtml"
                      Write(Model.MyFavoriteColor);

#line default
#line hidden
            EndContext();
            BeginContext(168, 5, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quiz11.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
