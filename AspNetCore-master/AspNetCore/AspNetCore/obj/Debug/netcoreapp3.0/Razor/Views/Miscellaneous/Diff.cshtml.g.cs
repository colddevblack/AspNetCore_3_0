#pragma checksum "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Miscellaneous\Diff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f9e0daff8c0b9d0abcf26e0b93807f95bedc98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_Diff), @"mvc.1.0.view", @"/Views/Miscellaneous/Diff.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/Diff.cshtml", typeof(AspNetCore.Views_Miscellaneous_Diff))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f9e0daff8c0b9d0abcf26e0b93807f95bedc98", @"/Views/Miscellaneous/Diff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddf19c24a85a5b15b5cbd6807ef85c4223d805f", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_Diff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/google-diff-match-patch-js/diff_match_patch.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/preetyTextDiff/jquery.pretty-text-diff.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Miscellaneous\Diff.cshtml"
  
    ViewData["Title"] = "Diff";

#line default
#line hidden
            BeginContext(38, 209, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Text Diff</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 247, "\"", 294, 1);
#line 11 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\Miscellaneous\Diff.cshtml"
WriteAttributeValue("", 254, Url.Action("Dashboard_1", "Dashboards"), 254, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(295, 4268, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Miscellaneous</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Diff</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Diff plugin</h5>
                </div>

                <div class=""ibox-content"">

                    <strong>jQuery.PrettyTextDiff</strong>
                    <p>
                        A wrapper around Google's diff_match_patch library.
                        <br />
                        You can run diff on existing text by adding class <code>original</code> and <code>changed</code> and add element that compares text. Or you can pass text as a param of function. See example below.
                  ");
            WriteLiteral(@"  </p>

                    <div class=""well"">
                        <h3 class=""m-t-lg"">Standard example</h3>

                        <div class=""row diff-wrapper"">
                            <div class=""col-md-4"">
                                <h4>Oryginal text</h4>

                                <div class=""original"">
                                    Lorem Ipsum is simply dummy text of the printing and
                                    typesetting industry. Lorem Ipsum has been the industry's standard dummy
                                    text ever since the 1500s, when an unknown printer took a galley of type and
                                    scrambled it to make a type specimen book. It has survived not only
                                    centuries, but also the leap into electronic typesetting.
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <h4>Changed text</h4>

     ");
            WriteLiteral(@"                           <div class=""changed"">
                                    Lorem Ipsum is simply typesetting dummy text of the
                                    printing and has been the industry's typesetting. Lorem Ipsum has been the
                                    industry's standard dummy text ever the 1500s, when an printer took a galley
                                    of type and simply it to make a type. It has survived not only five
                                    centuries, but survived not also the leap into electronic typesetting.
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <h4>Diff results</h4>

                                <div class=""diff1""></div>
                            </div>
                        </div>
                    </div>

                    <h3 class=""m-t-lg"">As a function param</h3>
                    <p>
                        Diff wil");
            WriteLiteral(@"l run after textarea will change. So feel free to play with it to see Diff results.
                    </p>
                    <div class=""row diff-wrapper2"">
                        <div class=""col-md-4"">
                            <h4>Oryginal text</h4>
                            <textarea class=""form-control diff-textarea"" id=""original"" rows=""6"">Lorem Ipsum is simply printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text eve
                            </textarea>
                        </div>
                        <div class=""col-md-4"">
                            <h4>Diff results</h4>
                            <div class=""diff2""></div>
                        </div>
                        <div class=""col-md-4"">
                            <h4>New text</h4>
                            <textarea class=""form-control diff-textarea"" id=""changed"" rows=""6"">Ting dummy text of the printing and has been the industry's typesetting. Lorem Ipsum has been the industry's
  ");
            WriteLiteral("                          </textarea>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4581, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(4586, 240, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f9e0daff8c0b9d0abcf26e0b93807f95bedc989999", async() => {
                    BeginContext(4638, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(4647, 76, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f9e0daff8c0b9d0abcf26e0b93807f95bedc9810415", async() => {
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
                    BeginContext(4723, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(4732, 75, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f9e0daff8c0b9d0abcf26e0b93807f95bedc9811745", async() => {
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
                    BeginContext(4807, 5, true);
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
                BeginContext(4826, 842, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            // Initial diff1
            $("".diff-wrapper"").prettyTextDiff({
                diffContainer: "".diff1""
            });


            // Initial diff2
            $("".diff-wrapper2"").prettyTextDiff({
                originalContent: $('#original').val(),
                changedContent: $('#changed').val(),
                diffContainer: "".diff2""
            });

            // Run diff on textarea change
            $("".diff-textarea"").on('change keyup', function () {
                $("".diff-wrapper2"").prettyTextDiff({
                    originalContent: $('#original').val(),
                    changedContent: $('#changed').val(),
                    diffContainer: "".diff2""
                });

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
