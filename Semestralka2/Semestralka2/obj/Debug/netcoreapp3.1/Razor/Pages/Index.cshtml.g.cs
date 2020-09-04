#pragma checksum "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a50ff65ef1b0b00b3b484f0afd6cae78c93429c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Semestralka2.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a50ff65ef1b0b00b3b484f0afd6cae78c93429c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c614197577226ec4034cd587216d78128b11e015", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Answer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Unanswered questions:</p><p id=\"unansweredCount\">");
#nullable restore
#line 7 "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\Index.cshtml"
                                               Write(Model.UnansweredCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h3>Oldest ten unanswered:</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a50ff65ef1b0b00b3b484f0afd6cae78c93429c4178", async() => {
                WriteLiteral("\r\n    <input class=\"btn btn-primary\" type=\"submit\" value=\"Answer oldest unanswered question\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table id=\"table\" class=\"table\">\r\n    <thead>\r\n        <tr><th>Date and time of creation</th><th>Question message</th><th>Attachment link</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "D:\.NET Projects\ASP .NET Core\Semestralka2\Semestralka2\Pages\Index.cshtml"
           await Html.RenderPartialAsync("_QuestionsPartial", Model.OldestTenQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    <script");
                BeginWriteAttribute("src", " src=\"", 655, "\"", 732, 2);
                WriteAttributeValue("", 661, "https://unpkg.com/", 661, 18, true);
                WriteLiteral("@");
                WriteAttributeValue("", 681, "microsoft/signalr@3.1.0/dist/browser/signalr.min.js", 681, 51, true);
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script>
        const hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(""/hub"")
            .build();

        function appendLeadingZeroes(n) {
            if (n <= 9) {
                return ""0"" + n;
            }
            return n
        }
        let tbody = document.getElementById(""table"").getElementsByTagName('tbody')[0];

        hubConnection.on(""Added"", function (data) {
            //let date = new Date(data.dateTimeOfCreation);
            //let formattedDate = appendLeadingZeroes(date.getDate()) + ""."" + appendLeadingZeroes(date.getMonth() + 1) + ""."" + date.getFullYear() + "" "" + date.getHours() + "":"" + appendLeadingZeroes(date.getMinutes()) + "":"" + appendLeadingZeroes(date.getSeconds());
            //console.log(formattedDate);
            //let dateTimeTd = document.createElement('td');
            //dateTimeTd.appendChild(document.createTextNode(formattedDate));
            //let questionMessageTd = document.createElement('td');
   ");
                WriteLiteral(@"         //questionMessageTd.appendChild(document.createTextNode(data.text));
            //let attachmentTd = document.createElement('td');

            //if (data.fileName != '') {
            //    let link = document.createElement('a');
            //    let linkToFile = 'http://localhost:60994/GetFile?filename=' + data.fileName;
            //    link.setAttribute('href', linkToFile);
            //    link.innerHTML = 'Download attachment';
            //    attachmentTd.appendChild(link);
            //} else {
            //    attachmentTd.innerHTML = 'No attachment';
            //}


            //let tr = document.createElement('tr');
            //tr.appendChild(dateTimeTd);
            //tr.appendChild(questionMessageTd);
            //tr.appendChild(attachmentTd);
            //let tbody = document.getElementById(""table"").getElementsByTagName('tbody')[0];
            //tbody.insertBefore(tr, tbody.firstChild);

            $(tbody).load(""/Index?handler=Partial"");
         ");
                WriteLiteral(@"   let result = parseInt($(""#unansweredCount"").html(), 10);
            result += 1;
            console.log(result);
            $(""#unansweredCount"").text(result);
        });

        hubConnection.on(""Answered"", function (data) {
            $(tbody).load(""/Index?handler=Partial"");
            let result = parseInt($(""#unansweredCount"").html(), 10);
            result -= 1;
            console.log(result);
            $(""#unansweredCount"").text(result);
        });
        hubConnection.start();
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
