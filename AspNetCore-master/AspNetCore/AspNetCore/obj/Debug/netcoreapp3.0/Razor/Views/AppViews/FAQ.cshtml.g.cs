#pragma checksum "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\AppViews\FAQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8364a5f5d221c88ed83210a82c54d529ca1c474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppViews_FAQ), @"mvc.1.0.view", @"/Views/AppViews/FAQ.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AppViews/FAQ.cshtml", typeof(AspNetCore.Views_AppViews_FAQ))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8364a5f5d221c88ed83210a82c54d529ca1c474", @"/Views/AppViews/FAQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddf19c24a85a5b15b5cbd6807ef85c4223d805f", @"/Views/_ViewImports.cshtml")]
    public class Views_AppViews_FAQ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\AppViews\FAQ.cshtml"
  
    ViewData["Title"] = "FAQ";

#line default
#line hidden
            BeginContext(37, 202, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-sm-4\">\n        <h2>FAQ</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 239, "\"", 286, 1);
#line 11 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\AppViews\FAQ.cshtml"
WriteAttributeValue("", 246, Url.Action("Dashboard_1", "Dashboards"), 246, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(287, 255, true);
            WriteLiteral(">Home</a>\n            </li>\n            <li class=\"active breadcrumb-item\">\n                <strong>Frequently asked questions</strong>\n            </li>\n        </ol>\n    </div>\n    <div class=\"col-sm-8\">\n        <div class=\"title-action\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 542, "\"", 549, 0);
            EndWriteAttribute();
            BeginContext(550, 13227, true);
            WriteLiteral(@" class=""btn btn-primary btn-sm"">Add question</a>
        </div>
    </div>
</div>

<div class=""wrapper wrapper-content animated fadeInUp"">

    <div class=""ibox-content m-b-sm border-bottom"">
        <div class=""text-center p-lg"">
            <h2>If you don't find the answer to your question</h2>
            <span>add your question by selecting </span>
            <button title=""Create new cluster"" class=""btn btn-primary btn-sm""><i class=""fa fa-plus""></i> <span class=""bold"">Add question</span></button> button
        </div>
    </div>

    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-toggle=""collapse"" href=""#faq1"" class=""faq-question"">What It a long established fact that a reader ?</a>
                <small>Added by <strong>Alex Smith</strong> <i class=""fa fa-clock-o""></i> Today 2:40 pm - 24.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Robert Nowak</span>
                <div ");
            WriteLiteral(@"class=""tag-list"">
                    <span class=""tag-item"">General</span>
                    <span class=""tag-item"">License</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                42
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq1"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
          ");
            WriteLiteral(@"      <a data-toggle=""collapse"" href=""#faq2"" class=""faq-question"">Many desktop publishing packages ?</a>
                <small>Added by <strong>Mark Nowak</strong> <i class=""fa fa-clock-o""></i> Today 3:30 pm - 11.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Robert Nowak</span>
                <div class=""tag-list"">
                    <span class=""tag-item"">General</span>
                    <span class=""tag-item"">License</span>
                    <span class=""tag-item"">CC</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                24
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq2"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        Many desktop publishing packages and web page editors now use Lorem Ipsum");
            WriteLiteral(@" as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-toggle=""collapse"" href=""#faq3"" class=""faq-question"">Ipsum generators on the Internet tend ?</a>
                <small>Added by <strong>Monica Rother</strong> <i class=""fa fa-clock-o""></i> Yestorday 7:60 pm - 12.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Alex Berg</span>
                <div class=""tag-list"">
                    <span class=""tag-item"">General</span>
                    <span class=""tag-item"">Web App</span>
                    <span class=""tag-item"">Instruction</span>
                </div>");
            WriteLiteral(@"
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                22
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq3"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-toggle=""collapse"" href=""#faq4"" class=""faq-questi");
            WriteLiteral(@"on"">What Finibus Bonorum et Malorum mean ?</a>
                <small>Added by <strong>Janet North</strong> <i class=""fa fa-clock-o""></i> Today 2:43 pm - 22.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Robert Nowak</span>
                <div class=""tag-list"">
                    <span class=""tag-item"">Buttons</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                65
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq4"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of ""de Finibus Bonorum et Malorum"" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The fir");
            WriteLiteral(@"st line of Lorem Ipsum, ""Lorem ipsum dolor sit amet.."", comes from a line in section 1.10.32.
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-toggle=""collapse"" href=""#faq5"" class=""faq-question"">The standard chunk of Lorem Ipsum used since ?</a>
                <small>Added by <strong>Robert Task</strong> <i class=""fa fa-clock-o""></i> Today 1:23 pm - 12.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Sandra Smith</span>
                <div class=""tag-list"">
                    <span class=""tag-item"">General</span>
                    <span class=""tag-item"">License</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                76
            </div>
        </div>
        <div ");
            WriteLiteral(@"class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq5"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from ""de Finibus Bonorum et Malorum"" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-toggle=""collapse"" href=""#faq6"" class=""faq-question"">Contrary to popular belief, Lorem Ipsum ?</a>
                <small>Added by <strong>Monica Smith</strong> <i class=""fa fa-clock-o""></i> Today 7:220 pm - 13.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Robert Nowak</span>
     ");
            WriteLiteral(@"           <div class=""tag-list"">
                    <span class=""tag-item"">Love</span>
                    <span class=""tag-item"">CC</span>
                    <span class=""tag-item"">Help</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                11
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq6"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-t");
            WriteLiteral(@"oggle=""collapse"" href=""#faq7"" class=""faq-question""> Many desktop publishing packages ? </a>
                <small>Added by <strong>Damien Sate</strong> <i class=""fa fa-clock-o""></i> Yestorday 4:50 pm - 8.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Alex Nowak</span>
                <div class=""tag-list"">
                    <span class=""tag-item"">International</span>
                    <span class=""tag-item"">What</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                64
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq7"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' ");
            WriteLiteral(@"will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-toggle=""collapse"" href=""#faq8"" class=""faq-question"">Lorem Ipsum, you need to be sure there isn't ?</a>
                <small>Added by <strong>Pablo Sarnoq</strong> <i class=""fa fa-clock-o""></i> Today 1:30 am - 1.06.2014</small>
            </div>
            <div class=""col-md-3"">
                <span class=""small font-bold"">Natalie Cole</span>
                <div class=""tag-list"">
                    <span class=""tag-item"">Translations</span>
                    <span class=""tag-item"">CC</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting ");
            WriteLiteral(@"</span><br />
                10
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq8"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""faq-item"">
        <div class=""row"">
            <div class=""col-md-7"">
                <a data-toggle=""collapse"" href=""#faq9"" class=""faq-question"">There are many variations of passages ?</a>
                <small>Added by <strong>Monica Smith</strong> <i class=""fa fa-clock-o""></i> Today 1:60 pm - 11.06.2014</small>
            </div>
            <div class=""col-md-3"">
            ");
            WriteLiteral(@"    <span class=""small font-bold"">Alex Nowak</span>
                <div class=""tag-list"">
                    <span class=""tag-item"">General</span>
                    <span class=""tag-item"">License</span>
                </div>
            </div>
            <div class=""col-md-2 text-right"">
                <span class=""small font-bold"">Voting </span><br />
                23
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div id=""faq9"" class=""panel-collapse collapse faq-answer"">
                    <p>
                        There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage
                    </p>
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
