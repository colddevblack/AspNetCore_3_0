#pragma checksum "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\UIElements\BadgesLabelsProgress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d747a2bdd2e9602139aae17fa50f4675854cad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UIElements_BadgesLabelsProgress), @"mvc.1.0.view", @"/Views/UIElements/BadgesLabelsProgress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UIElements/BadgesLabelsProgress.cshtml", typeof(AspNetCore.Views_UIElements_BadgesLabelsProgress))]
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
#line 1 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\_ViewImports.cshtml"
using AspNetCore_3_0;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d747a2bdd2e9602139aae17fa50f4675854cad2", @"/Views/UIElements/BadgesLabelsProgress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddf19c24a85a5b15b5cbd6807ef85c4223d805f", @"/Views/_ViewImports.cshtml")]
    public class Views_UIElements_BadgesLabelsProgress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\UIElements\BadgesLabelsProgress.cshtml"
  
    ViewData["Title"] = "BadgesLabelsProgress";

#line default
#line hidden
            BeginContext(54, 224, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Badges, Labels, Progress</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 278, "\"", 325, 1);
#line 11 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\UIElements\BadgesLabelsProgress.cshtml"
WriteAttributeValue("", 285, Url.Action("Dashboard_1", "Dashboards"), 285, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(326, 7789, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>UI Elements</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Badges, Labels, Progress</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Badges</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <");
            WriteLiteral(@"a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <p>
                        To add a badge style You have to add <code>.badge</code>class to element. To cahnge a color od bage you cna add extra class like <code>.badge-primary</code>.
                    </p>
                    <p><span class=""badge"">Plain</span></p>
                    <p><span class=""badge badge-primary"">Primary</span></p>
                    <p><span class=""badge badge-info"">Information</span></p>
                    <p><span class=""badge badge-success"">Success</span></p>
         ");
            WriteLiteral(@"           <p><span class=""badge badge-warning"">Warning</span></p>
                    <p><span class=""badge badge-danger"">Danger</span></p>
                </div>
            </div>
        </div>

        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Labels</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option");
            WriteLiteral(@" 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <p>
                        Analogic to badge. To add a label style You have to add <code>.label</code>class to element. To cahnge a color od label you cna add extra class like <code>.label-primary</code>.
                    </p>
                    <p><span class=""label"">Plain</span></p>
                    <p><span class=""label label-primary"">Primary</span></p>
                    <p><span class=""label label-info"">Information</span></p>
                    <p><span class=""label label-success"">Success</span></p>
                    <p><span class=""label label-warning"">Warning</span></p>
                    <p><span class=""label label-danger"">Danger</span></p>
                </div>
            </d");
            WriteLiteral(@"iv>
        </div>

    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Progress Bars</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                    ");
            WriteLiteral(@"        <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <h5>Basic ProgressBars</h5>
                    <div class=""progress"">
                        <div style=""width: 35%"" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""35"" role=""progressbar"" class=""progress-bar bg-success"">
                            <span class=""sr-only"">35% Complete (success)</span>
                        </div>
                    </div>
                    <br />
                    <div class=""progress progress-bar-default"">
                        <div style=""width: 43%"" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""43"" role=""progressbar"" class=""progress-bar"">
                            <span class=""sr-only"">43% Complete (success)</span>
                        </div>
                    </div>

                    <h5>Striped Progressbars</h5>

                    <div class=""progress"">
          ");
            WriteLiteral(@"              <div style=""width: 50%"" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""50"" role=""progressbar"" class=""progress-bar  progress-bar-striped bg-warning"">
                            <span class=""sr-only"">40% Complete (success)</span>
                        </div>
                    </div>

                    <h5>Active Progressbars</h5>

                    <div class=""progress"">
                        <div style=""width: 75%"" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""75"" role=""progressbar"" class=""progress-bar  progress-bar-striped  progress-bar-animated bg-danger"">
                            <span class=""sr-only"">40% Complete (success)</span>
                        </div>
                    </div>

                    <h5>Stacked Progressbars</h5>

                    <div class=""progress"">
                        <div style=""width: 30%"" class=""progress-bar  progress-bar-striped progress-bar-animated bg-success"">
                            <span class=""sr-only"">30% Complete (");
            WriteLiteral(@"success)</span>
                        </div>
                        <div style=""width: 20%"" class=""progress-bar  progress-bar-striped progress-bar-animated bg-warning"">
                            <span class=""sr-only"">15% Complete (warning)</span>
                        </div>
                        <div style=""width: 40%"" class=""progress-bar  progress-bar-striped progress-bar-animated bg-danger"">
                            <span class=""sr-only"">40% Complete (danger)</span>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
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
