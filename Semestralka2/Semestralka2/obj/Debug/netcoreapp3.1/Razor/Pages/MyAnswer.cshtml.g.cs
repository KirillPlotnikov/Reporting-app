#pragma checksum "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\MyAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4545fb943cf666ad31184de317824f1867364b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Semestralka2.Pages.Pages_MyAnswer), @"mvc.1.0.razor-page", @"/Pages/MyAnswer.cshtml")]
namespace Semestralka2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\_ViewImports.cshtml"
using Semestralka2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4545fb943cf666ad31184de317824f1867364b5d", @"/Pages/MyAnswer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c614197577226ec4034cd587216d78128b11e015", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyAnswer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p><strong>Answer</strong></p>\r\n<p>");
#nullable restore
#line 5 "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\MyAnswer.cshtml"
Write(Model.Answer.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><strong>Attachment:</strong></p>\r\n\r\n");
#nullable restore
#line 8 "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\MyAnswer.cshtml"
 if(Model.Answer.FileName != null)
{
    
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Semestralka2.Pages.MyAnswerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Semestralka2.Pages.MyAnswerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Semestralka2.Pages.MyAnswerModel>)PageContext?.ViewData;
        public Semestralka2.Pages.MyAnswerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591