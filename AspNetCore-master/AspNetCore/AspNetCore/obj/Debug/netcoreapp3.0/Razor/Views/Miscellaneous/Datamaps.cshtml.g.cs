#pragma checksum "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Miscellaneous\Datamaps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87075afd32206ddea75f1d46b9c5474b58a8ec4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_Datamaps), @"mvc.1.0.view", @"/Views/Miscellaneous/Datamaps.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/Datamaps.cshtml", typeof(AspNetCore.Views_Miscellaneous_Datamaps))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87075afd32206ddea75f1d46b9c5474b58a8ec4a", @"/Views/Miscellaneous/Datamaps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddf19c24a85a5b15b5cbd6807ef85c4223d805f", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_Datamaps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/d3/d3.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/topojson/topojson.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datamaps/datamaps.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Miscellaneous\Datamaps.cshtml"
  
    ViewData["Title"] = "Datamaps";

#line default
#line hidden
            BeginContext(42, 204, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Maps</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 246, "\"", 293, 1);
#line 11 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Miscellaneous\Datamaps.cshtml"
WriteAttributeValue("", 253, Url.Action("Dashboard_1", "Dashboards"), 253, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(294, 5128, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Forms</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Maps</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">
    </div>
</div>

<div class=""wrapper wrapper-content animated fadeIn"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Datamaps</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-i");
            WriteLiteral(@"tem"">Config option 1</a>
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
                    <strong>Datamaps</strong>
                    <p>
                        Interactive maps for data visualizations. Bundled into a single Javascript file.
                    </p>
                    <p>
                        Datamaps is intended to provide some data visualizations based on geographical data. It's SVG-based, can scale to any screen size, and includes everything inside of 1 script file. It heavily relies on the amazing D3.js library.
                        Full documentation can be found: <a href=""https://github.");
            WriteLiteral(@"com/markmarkoh/datamaps"" target=""_blank"">https://github.com/markmarkoh/datamaps</a>
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Basic example</h5>
                </div>
                <div class=""ibox-content"">
                    <div id=""basic_map""></div>
                    <pre>
var basic = new Datamap({
    element: document.getElementById(""basic_map""),
    responsive: true,
    fills: {
        defaultFill: ""#DBDAD6""
    },
    geographyConfig: {
        highlightFillColor: '#1C977A',
        highlightBorderWidth: 0,
    },
}); </pre>
                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>With selected regions</h5>
                </div>
                <div class=""ibox-content""");
            WriteLiteral(@">
                    <div id=""selected_map""></div>
                    <pre>
var basic = new Datamap({
    element: document.getElementById(""basic_map""),
    ...
    data: {
        USA: { fillKey: ""active"" },
        RUS: { fillKey: ""active"" },
        DEU: { fillKey: ""active"" },
        BRA: { fillKey: ""active"" }
    }
}); </pre>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>USA scope</h5>
                </div>
                <div class=""ibox-content"">
                    <div id=""usa_map""></div>
                    <pre>
var usa_map = new Datamap({
    element: document.getElementById(""usa_map""),
    responsive: true,
    scope: 'usa',
    fills: {
        defaultFill: ""#DBDAD6""
    },
    geographyConfig: {
        highlightFillColor: '#1C977A',
        highlightBorderWidth: 0,
    },
    ...
}); </pre>
                </div>
       ");
            WriteLiteral(@"     </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Map with arc</h5>
                </div>
                <div class=""ibox-content"">
                    <div id=""arc_map""></div>
                    <pre>
var arc_map = new Datamap({
    element: document.getElementById(""arc_map""),
    ...
});
arc_map.arc(
[
    { origin: 'USA', destination: 'RUS'},
    { origin: 'USA', destination: 'DEU'},
    { origin: 'USA', destination: 'POL'},
    { origin: 'USA', destination: 'JAP'},
    { origin: 'USA', destination: 'AUS'},
    { origin: 'USA', destination: 'BRA'}
],
{ strokeColor: '#2BA587', strokeWidth: 1}
);</pre>
                </div>
            </div>
        </div>
    </div>
    <div class=""footer"">
        <div class=""float-right"">
            10GB of <strong>250GB</strong> Free.
        </div>
        <div>
            <strong>Copyright</strong> Example Company &copy; 2014-2015
        </div>
    </div>
</");
            WriteLiteral("div>\n\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5440, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(5445, 244, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87075afd32206ddea75f1d46b9c5474b58a8ec4a11288", async() => {
                    BeginContext(5497, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(5506, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87075afd32206ddea75f1d46b9c5474b58a8ec4a11705", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5544, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(5553, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87075afd32206ddea75f1d46b9c5474b58a8ec4a13035", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5603, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(5612, 58, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87075afd32206ddea75f1d46b9c5474b58a8ec4a14365", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5670, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5689, 3386, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {


            var basic = new Datamap({
                element: document.getElementById(""basic_map""),
                responsive: true,
                fills: {
                    defaultFill: ""#DBDAD6""
                },
                geographyConfig: {
                    highlightFillColor: '#1C977A',
                    highlightBorderWidth: 0,
                },
            });

            var selected_map = new Datamap({
                element: document.getElementById(""selected_map""),
                responsive: true,
                fills: {
                    defaultFill: ""#DBDAD6"",
                    active: ""#2BA587""
                },
                geographyConfig: {
                    highlightFillColor: '#1C977A',
                    highlightBorderWidth: 0,
                },
                data: {
                    USA: { fillKey: ""active"" },
                    RUS: { fillKey: ""active"" },
              ");
                WriteLiteral(@"      DEU: { fillKey: ""active"" },
                    BRA: { fillKey: ""active"" }
                }
            });

            var usa_map = new Datamap({
                element: document.getElementById(""usa_map""),
                responsive: true,
                scope: 'usa',
                fills: {
                    defaultFill: ""#DBDAD6"",
                    active: ""#2BA587""
                },
                geographyConfig: {
                    highlightFillColor: '#1C977A',
                    highlightBorderWidth: 0
                },
                data: {
                    NE: { fillKey: ""active"" },
                    CA: { fillKey: ""active"" },
                    NY: { fillKey: ""active"" },
                }
            });

            var arc_map = new Datamap({
                element: document.getElementById(""arc_map""),
                responsive: true,
                fills: {
                    defaultFill: ""#F2F2F0"",
                    active: ""#DBDAD6"",
                    usa: ");
                WriteLiteral(@"""#269479""
                },
                geographyConfig: {
                    highlightFillColor: '#1C977A',
                    highlightBorderWidth: 0
                },
                data: {
                    USA: { fillKey: ""usa"" },
                    RUS: { fillKey: ""active"" },
                    DEU: { fillKey: ""active"" },
                    POL: { fillKey: ""active"" },
                    JAP: { fillKey: ""active"" },
                    AUS: { fillKey: ""active"" },
                    BRA: { fillKey: ""active"" }
                }
            });

            arc_map.arc(
                [
                    { origin: 'USA', destination: 'RUS' },
                    { origin: 'USA', destination: 'DEU' },
                    { origin: 'USA', destination: 'POL' },
                    { origin: 'USA', destination: 'JAP' },
                    { origin: 'USA', destination: 'AUS' },
                    { origin: 'USA', destination: 'BRA' }
                ],
                { strokeColor: '#2BA587'");
                WriteLiteral(@", strokeWidth: 1 }
            );

            // Resize map on window resize
            $(window).on('resize', function () {
                setTimeout(function () {
                    basic.resize();
                    selected_map.resize();
                }, 100)
            });

        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
