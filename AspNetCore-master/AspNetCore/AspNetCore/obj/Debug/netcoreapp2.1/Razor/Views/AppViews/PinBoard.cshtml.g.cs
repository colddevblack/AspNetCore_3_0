#pragma checksum "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\AppViews\PinBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a03b5dc0f23bde62dab7ceabcd2fd88f27b1fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppViews_PinBoard), @"mvc.1.0.view", @"/Views/AppViews/PinBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AppViews/PinBoard.cshtml", typeof(AspNetCore.Views_AppViews_PinBoard))]
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
#line 1 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\_ViewImports.cshtml"
using FiFellings;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a03b5dc0f23bde62dab7ceabcd2fd88f27b1fa", @"/Views/AppViews/PinBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73358804c8727746b2b177dc6772a98e99c25b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_AppViews_PinBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\AppViews\PinBoard.cshtml"
  
    ViewData["Title"] = "PinBoard";

#line default
#line hidden
            BeginContext(42, 208, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-9\">\n        <h2>Pin Board</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 250, "\"", 297, 1);
#line 11 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\AppViews\PinBoard.cshtml"
WriteAttributeValue("", 257, Url.Action("Dashboard_1", "Dashboards"), 257, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(298, 2648, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                App Views
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Pin Board</strong>
            </li>
        </ol>
    </div>
</div>

<div class=""wrapper wrapper-content animated fadeInUp"">
    <ul class=""notes"">
        <li>
            <div>
                <small>12:03:28 12-04-2014</small>
                <h4>Long established fact</h4>
                <p>The years, sometimes by accident, sometimes on purpose (injected humour and the like).</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>11:08:33 16-04-2014</small>
                <h4>Latin professor at Hampden-Sydney </h4>
                <p>The first line of Lorem Ipsum, ""Lorem ipsum dolor sit amet.."", comes from a line in section 1.10.32.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
       ");
            WriteLiteral(@" </li>
        <li>
            <div>
                <small>9:12:28 10-04-2014</small>
                <h4>The standard chunk of Lorem</h4>
                <p>Ipsum used since the 1500s is reproduced below for those interested.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>3:33:12 6-03-2014</small>
                <h4>The generated Lorem Ipsum </h4>
                <p>The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>5:20:11 4-04-2014</small>
                <h4>Contrary to popular belief</h4>
                <p>Hampden-Sydney College in Virginia, looked up one.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
           ");
            WriteLiteral(@" <div>
                <small>2:10:12 4-05-2014</small>
                <h4>There are many variations</h4>
                <p>All the Lorem Ipsum generators on the Internet .</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>10:15:26 6-04-2014</small>
                <h4>Ipsum used standard chunk of Lorem</h4>
                <p>Standard chunk  is reproduced below for those.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
    </ul>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
