#pragma checksum "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b88262d56ecc2b2fe561e914ad7ba67d86a76a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mailbox_EmailView), @"mvc.1.0.view", @"/Views/Mailbox/EmailView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mailbox/EmailView.cshtml", typeof(AspNetCore.Views_Mailbox_EmailView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88262d56ecc2b2fe561e914ad7ba67d86a76a8", @"/Views/Mailbox/EmailView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73358804c8727746b2b177dc6772a98e99c25b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Mailbox_EmailView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/p1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/p2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
  
    ViewData["Title"] = "EmailView";

#line default
#line hidden
            BeginContext(43, 303, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox "">
                <div class=""ibox-content mailbox-content"">
                    <div class=""file-manager"">
                        <a class=""btn btn-block btn-primary compose-mail""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 346, "\"", 391, 1);
#line 12 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 353, Url.Action("ComposeEmail", "Mailbox"), 353, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(392, 221, true);
            WriteLiteral(">Compose Mail</a>\n                        <div class=\"space-25\"></div>\n                        <h5>Folders</h5>\n                        <ul class=\"folder-list m-b-md\" style=\"padding: 0\">\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 613, "\"", 651, 1);
#line 16 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 620, Url.Action("Inbox", "Mailbox"), 620, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(652, 137, true);
            WriteLiteral("> <i class=\"fa fa-inbox \"></i> Inbox <span class=\"label label-warning float-right\">16</span> </a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 789, "\"", 827, 1);
#line 17 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 796, Url.Action("Inbox", "Mailbox"), 796, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(828, 88, true);
            WriteLiteral("> <i class=\"fa fa-envelope-o\"></i> Send Mail</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 916, "\"", 954, 1);
#line 18 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 923, Url.Action("Inbox", "Mailbox"), 923, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(955, 89, true);
            WriteLiteral("> <i class=\"fa fa-certificate\"></i> Important</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1044, "\"", 1082, 1);
#line 19 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 1051, Url.Action("Inbox", "Mailbox"), 1051, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1083, 140, true);
            WriteLiteral("> <i class=\"fa fa-file-text-o\"></i> Drafts <span class=\"label label-danger float-right\">2</span></a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1223, "\"", 1261, 1);
#line 20 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 1230, Url.Action("Inbox", "Mailbox"), 1230, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1262, 895, true);
            WriteLiteral(@"> <i class=""fa fa-trash-o""></i> Trash</a></li>
                        </ul>
                        <h5>Categories</h5>
                        <ul class=""category-list"" style=""padding: 0"">
                            <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> Work </a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Documents</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Social</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Advertising</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Clients</a></li>
                        </ul>

                        <h5 class=""tag-title"">Labels</h5>
                        <ul class=""tag-list"" style=""padding: 0"">
                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2157, "\"", 2164, 0);
            EndWriteAttribute();
            BeginContext(2165, 77, true);
            WriteLiteral("><i class=\"fa fa-tag\"></i> Family</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2242, "\"", 2249, 0);
            EndWriteAttribute();
            BeginContext(2250, 75, true);
            WriteLiteral("><i class=\"fa fa-tag\"></i> Work</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2325, "\"", 2332, 0);
            EndWriteAttribute();
            BeginContext(2333, 75, true);
            WriteLiteral("><i class=\"fa fa-tag\"></i> Home</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2408, "\"", 2415, 0);
            EndWriteAttribute();
            BeginContext(2416, 79, true);
            WriteLiteral("><i class=\"fa fa-tag\"></i> Children</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2495, "\"", 2502, 0);
            EndWriteAttribute();
            BeginContext(2503, 79, true);
            WriteLiteral("><i class=\"fa fa-tag\"></i> Holidays</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2582, "\"", 2589, 0);
            EndWriteAttribute();
            BeginContext(2590, 76, true);
            WriteLiteral("><i class=\"fa fa-tag\"></i> Music</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2666, "\"", 2673, 0);
            EndWriteAttribute();
            BeginContext(2674, 82, true);
            WriteLiteral("><i class=\"fa fa-tag\"></i> Photography</a></li>\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2756, "\"", 2763, 0);
            EndWriteAttribute();
            BeginContext(2764, 379, true);
            WriteLiteral(@"><i class=""fa fa-tag""></i> Film</a></li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-9 animated fadeInRight"">
            <div class=""mail-box-header"">
                <div class=""float-right tooltip-demo"">
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3143, "\"", 3188, 1);
#line 50 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 3150, Url.Action("ComposeEmail", "Mailbox"), 3150, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3189, 304, true);
            WriteLiteral(@" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Reply""><i class=""fa fa-reply""></i> Reply</a>
                    <a href=""#"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Print email""><i class=""fa fa-print""></i> </a>
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3493, "\"", 3531, 1);
#line 52 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 3500, Url.Action("Inbox", "Mailbox"), 3500, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3532, 3745, true);
            WriteLiteral(@" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Move to trash""><i class=""fa fa-trash-o""></i> </a>
                </div>
                <h2>
                    View Message
                </h2>
                <div class=""mail-tools tooltip-demo m-t-md"">


                    <h3>
                        <span class=""font-normal"">Subject: </span>Aldus PageMaker including versions of Lorem Ipsum.
                    </h3>
                    <h5>
                        <span class=""float-right font-normal"">10:15AM 02 FEB 2014</span>
                        <span class=""font-normal"">From: </span>alex.smith@corporation.com
                    </h5>
                </div>
            </div>
            <div class=""mail-box"">


                <div class=""mail-body"">
                    <p>
                        Hello Jonathan!
                        <br />
                        <br />
                        Lorem Ipsum is simply dummy text of the printing and typesetting ");
            WriteLiteral(@"industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer
                        took a galley of type and scrambled it to make a type <strong>specimen book.</strong>It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. It has survived not only five centuries, but also the leap into electronic typesetting, remaining
                        essentially unchanged.
                    </p>
                    <p>
                        It was popularised in the 1960s with the release <a href=""#"" class=""text-navy"">Letraset sheets</a>  containing Lorem Ipsum passages, and more recently with desktop publishing software
                        like Aldus PageMaker including versions of Lorem Ipsum.
                    </p>
                    <p>
                        There are many variations of passages of");
            WriteLiteral(@" <strong>Lorem Ipsum</strong>Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of.
                    </p>
                </div>
                <div class=""mail-attachment"">
                    <p>
                        <span><i class=""fa fa-paperclip""></i> 2 attachments - </span>
                        <a href=""#"">Download all</a>
                        |
                        <a href=""#"">View all images</a>
                    </p>

                    <div class=""attachment"">
                        <div class=""file-box"">
                            <div class=""file"">
                                <a href=""#"">
                                    <span class=""corner""></span>

                                    <div class=""icon"">
                                        <i class=""fa fa-file""></i>
                                    </div>
               ");
            WriteLiteral(@"                     <div class=""file-name"">
                                        Document_2014.doc
                                        <br />
                                        <small>Added: Jan 11, 2014</small>
                                    </div>
                                </a>
                            </div>

                        </div>
                        <div class=""file-box"">
                            <div class=""file"">
                                <a href=""#"">
                                    <span class=""corner""></span>

                                    <div class=""image"">
                                        ");
            EndContext();
            BeginContext(7277, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b88262d56ecc2b2fe561e914ad7ba67d86a76a817107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7334, 730, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""file-name"">
                                        Italy street.jpg
                                        <br />
                                        <small>Added: Jan 6, 2014</small>
                                    </div>
                                </a>

                            </div>
                        </div>
                        <div class=""file-box"">
                            <div class=""file"">
                                <a href=""#"">
                                    <span class=""corner""></span>

                                    <div class=""image"">
                                        ");
            EndContext();
            BeginContext(8064, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b88262d56ecc2b2fe561e914ad7ba67d86a76a819186", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8121, 641, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""file-name"">
                                        My feel.png
                                        <br />
                                        <small>Added: Jan 7, 2014</small>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class=""clearfix""></div>
                    </div>
                </div>
                <div class=""mail-body text-right tooltip-demo"">
                    <a class=""btn btn-sm btn-white""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8762, "\"", 8807, 1);
#line 152 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 8769, Url.Action("ComposeEmail", "Mailbox"), 8769, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8808, 90, true);
            WriteLiteral("><i class=\"fa fa-reply\"></i> Reply</a>\n                    <a class=\"btn btn-sm btn-white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8898, "\"", 8943, 1);
#line 153 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 8905, Url.Action("ComposeEmail", "Mailbox"), 8905, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8944, 74, true);
            WriteLiteral("><i class=\"fa fa-arrow-right\"></i> Forward</a>\n                    <button");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 9018, "\"", 9026, 0);
            EndWriteAttribute();
            BeginContext(9027, 185, true);
            WriteLiteral(" data-placement=\"top\" data-toggle=\"tooltip\" type=\"button\" data-original-title=\"Print\" class=\"btn btn-sm btn-white\"><i class=\"fa fa-print\"></i> Print</button>\n                    <button");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 9212, "\"", 9220, 0);
            EndWriteAttribute();
            BeginContext(9221, 270, true);
            WriteLiteral(@" data-placement=""top"" data-toggle=""tooltip"" data-original-title=""Trash"" class=""btn btn-sm btn-white""><i class=""fa fa-trash-o""></i> Remove</button>
                </div>
                <div class=""clearfix""></div>


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
