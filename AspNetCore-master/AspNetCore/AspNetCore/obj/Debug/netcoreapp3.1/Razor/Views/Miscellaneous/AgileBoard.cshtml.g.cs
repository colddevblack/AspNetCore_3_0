#pragma checksum "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\AgileBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2417ac6425ac8744b2ef34f0969f9f2b5bda5f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_AgileBoard), @"mvc.1.0.view", @"/Views/Miscellaneous/AgileBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/AgileBoard.cshtml", typeof(AspNetCore.Views_Miscellaneous_AgileBoard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2417ac6425ac8744b2ef34f0969f9f2b5bda5f71", @"/Views/Miscellaneous/AgileBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73358804c8727746b2b177dc6772a98e99c25b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_AgileBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/touchpunch/jquery.ui.touch-punch.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\AgileBoard.cshtml"
  
    ViewData["Title"] = "AgileBoard";

#line default
#line hidden
            BeginContext(44, 211, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Agile board</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 255, "\"", 302, 1);
#line 11 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\AgileBoard.cshtml"
WriteAttributeValue("", 262, Url.Action("Dashboard_1", "Dashboards"), 262, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(303, 12875, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Miscellaneous</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Agile board</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>

<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h3>To-do</h3>
                    <p class=""small""><i class=""fa fa-hand-o-up""></i> Drag task between list</p>

                    <div class=""input-group"">
                        <input type=""text"" placeholder=""Add new task. "" class=""input form-control-sm form-control"">
                        <span class=""input-group-btn"">
                            <button type=""button"" class=""btn btn-sm btn-white""> <i class=""fa fa-plus""></i> Add task</button>
                        </span>
                    </di");
            WriteLiteral(@"v>

                    <ul class=""sortable-list connectList agile-list"" id=""todo"">
                        <li class=""warning-element"" id=""task1"">
                            Simply dummy text of the printing and typesetting industry.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Tag</a>
                                <i class=""fa fa-clock-o""></i> 12.10.2015
                            </div>
                        </li>
                        <li class=""success-element"" id=""task2"">
                            Many desktop publishing packages and web page editors now use Lorem Ipsum as their default.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 05.04.2015
                            </div>
                        </li>
                        <li cla");
            WriteLiteral(@"ss=""info-element"" id=""task3"">
                            Sometimes by accident, sometimes on purpose (injected humour and the like).
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 16.11.2015
                            </div>
                        </li>
                        <li class=""danger-element"" id=""task4"">
                            All the Lorem Ipsum generators
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-primary"">Done</a>
                                <i class=""fa fa-clock-o""></i> 06.10.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=""task5"">
                            Which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected");
            WriteLiteral(@" humour, or non-characteristic words etc.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Tag</a>
                                <i class=""fa fa-clock-o""></i> 09.12.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=""task6"">
                            Packages and web page editors now use Lorem Ipsum as
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-primary"">Done</a>
                                <i class=""fa fa-clock-o""></i> 08.04.2015
                            </div>
                        </li>
                        <li class=""success-element"" id=""task7"">
                            Many desktop publishing packages and web page editors now use Lorem Ipsum as their default.
                            <div class=""agile-detail"">
                       ");
            WriteLiteral(@"         <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 05.04.2015
                            </div>
                        </li>
                        <li class=""info-element"" id=""task8"">
                            Sometimes by accident, sometimes on purpose (injected humour and the like).
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 16.11.2015
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h3>In Progress</h3>
                    <p class=""small""><i class=""fa fa-hand-o-up""></i> Drag task between list</p>
                    <ul class=""sortabl");
            WriteLiteral(@"e-list connectList agile-list"" id=""inprogress"">
                        <li class=""success-element"" id=""task9"">
                            Quisque venenatis ante in porta suscipit.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Tag</a>
                                <i class=""fa fa-clock-o""></i> 12.10.2015
                            </div>
                        </li>
                        <li class=""success-element"" id=""task10"">
                            Phasellus sit amet tortor sed enim mollis accumsan in consequat orci.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 05.04.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=""task11"">
                            Nunc sed arcu");
            WriteLiteral(@" at ligula faucibus tempus ac id felis. Vestibulum et nulla quis turpis sagittis fringilla.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 16.11.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=""task12"">
                            Ut porttitor augue non sapien mollis accumsan.
                            Nulla non elit eget lacus elementum viverra.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Tag</a>
                                <i class=""fa fa-clock-o""></i> 09.12.2015
                            </div>
                        </li>
                        <li class=""info-element"" id=""task13"">
                            Packages and web page editors now use Lorem Ipsum as
   ");
            WriteLiteral(@"                         <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-primary"">Done</a>
                                <i class=""fa fa-clock-o""></i> 08.04.2015
                            </div>
                        </li>
                        <li class=""success-element"" id=""task14"">
                            Quisque lacinia tellus et odio ornare maximus.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 05.04.2015
                            </div>
                        </li>
                        <li class=""danger-element"" id=""task15"">
                            Enim mollis accumsan in consequat orci.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                              ");
            WriteLiteral(@"  <i class=""fa fa-clock-o""></i> 11.04.2015
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h3>Completed</h3>
                    <p class=""small""><i class=""fa fa-hand-o-up""></i> Drag task between list</p>
                    <ul class=""sortable-list connectList agile-list"" id=""completed"">
                        <li class=""info-element"" id=""task16"">
                            Sometimes by accident, sometimes on purpose (injected humour and the like).
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 16.11.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=");
            WriteLiteral(@"""task17"">
                            Ut porttitor augue non sapien mollis accumsan.
                            Nulla non elit eget lacus elementum viverra.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Tag</a>
                                <i class=""fa fa-clock-o""></i> 09.12.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=""task18"">
                            Which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Tag</a>
                                <i class=""fa fa-clock-o""></i> 09.12.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=""tas");
            WriteLiteral(@"k19"">
                            Packages and web page editors now use Lorem Ipsum as
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-primary"">Done</a>
                                <i class=""fa fa-clock-o""></i> 08.04.2015
                            </div>
                        </li>
                        <li class=""success-element"" id=""task20"">
                            Many desktop publishing packages and web page editors now use Lorem Ipsum as their default.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 05.04.2015
                            </div>
                        </li>
                        <li class=""info-element"" id=""task21"">
                            Sometimes by accident, sometimes on purpose (injected humour and the like).
          ");
            WriteLiteral(@"                  <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 16.11.2015
                            </div>
                        </li>
                        <li class=""warning-element"" id=""task22"">
                            Simply dummy text of the printing and typesetting industry.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn btn-xs btn-white"">Tag</a>
                                <i class=""fa fa-clock-o""></i> 12.10.2015
                            </div>
                        </li>
                        <li class=""success-element"" id=""task23"">
                            Many desktop publishing packages and web page editors now use Lorem Ipsum as their default.
                            <div class=""agile-detail"">
                                <a href=""#"" class=""float-right btn b");
            WriteLiteral(@"tn-xs btn-white"">Mark</a>
                                <i class=""fa fa-clock-o""></i> 05.04.2015
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>

    </div>

    <div class=""row"">
        <div class=""col-lg-12"">

            <h4>
                Serialised Output
            </h4>
            <p>
                Serializes the sortable's item id's into an array of string.
            </p>

            <div class=""output p-m m white-bg""></div>


        </div>
    </div>


</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(13196, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(13201, 210, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2417ac6425ac8744b2ef34f0969f9f2b5bda5f7119191", async() => {
                    BeginContext(13253, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(13262, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2417ac6425ac8744b2ef34f0969f9f2b5bda5f7119610", async() => {
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
                    BeginContext(13314, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(13323, 69, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2417ac6425ac8744b2ef34f0969f9f2b5bda5f7120942", async() => {
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
                    BeginContext(13392, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13411, 726, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#todo, #inprogress, #completed"").sortable({
                connectWith: "".connectList"",
                update: function (event, ui) {

                    var todo = $(""#todo"").sortable(""toArray"");
                    var inprogress = $(""#inprogress"").sortable(""toArray"");
                    var completed = $(""#completed"").sortable(""toArray"");
                    $('.output').html(""ToDo: "" + window.JSON.stringify(todo) + ""<br/>"" + ""In Progress: "" + window.JSON.stringify(inprogress) + ""<br/>"" + ""Completed: "" + window.JSON.stringify(completed));
                }
            }).disableSelection();

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(14139, 1, true);
            WriteLiteral("\n");
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
