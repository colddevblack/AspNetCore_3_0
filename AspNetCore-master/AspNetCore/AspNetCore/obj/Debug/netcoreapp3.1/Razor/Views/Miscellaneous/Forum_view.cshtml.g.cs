#pragma checksum "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc6b846337d0e0ae7a9d3ec5f1b528aed3fa93ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_Forum_view), @"mvc.1.0.view", @"/Views/Miscellaneous/Forum_view.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/Forum_view.cshtml", typeof(AspNetCore.Views_Miscellaneous_Forum_view))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6b846337d0e0ae7a9d3ec5f1b528aed3fa93ca", @"/Views/Miscellaneous/Forum_view.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73358804c8727746b2b177dc6772a98e99c25b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_Forum_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
  
    ViewData["Title"] = "Forum_view";

#line default
#line hidden
            BeginContext(44, 204, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-sm-4\">\n        <h2>Forum</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 248, "\"", 295, 1);
#line 11 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 255, Url.Action("Dashboard_1", "Dashboards"), 255, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 1281, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Forum</strong>
            </li>
        </ol>
    </div>
</div>
        <div class=""wrapper wrapper-content animated fadeInRight"">

            <div class=""ibox-content m-b-sm border-bottom"">
                <div class=""p-xs"">
                    <div class=""float-left m-r-md"">
                        <i class=""fa fa-globe text-navy mid-icon""></i>
                    </div>
                    <h2>Welcome in Inspinia Forum</h2>
                    <span>Feel free to choose topic you're interested in.</span>
                </div>
            </div>

            <div class=""ibox-content forum-container"">

                <div class=""forum-title"">
                    <div class=""float-right forum-desc"">
                        <samll>Total posts: 320,800</samll>
                    </div>
                    <h3>General subjects</h3>
                </div>

                <div class=""forum-item active"">
       ");
            WriteLiteral(@"             <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-shield""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1577, "\"", 1631, 1);
#line 46 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 1584, Url.Action("Forum_post_view", "Miscellaneous"), 1584, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1632, 1606, true);
            WriteLiteral(@" class=""forum-item-title"">General Discussion</a>
                            <div class=""forum-sub-title"">Talk about sports, entertainment, music, movies, your favorite color, talk about enything.</div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                1216
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                368
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-numbe");
            WriteLiteral(@"r"">
                                140
                            </span>
                            <div>
                                <small>Posts</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""forum-item"">
                    <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-bolt""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3238, "\"", 3292, 1);
#line 81 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 3245, Url.Action("Forum_post_view", "Miscellaneous"), 3245, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3293, 1600, true);
            WriteLiteral(@" class=""forum-item-title"">Introductions</a>
                            <div class=""forum-sub-title"">New to the community? Please stop by, say hi and tell us a bit about yourself. </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                890
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                120
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
             ");
            WriteLiteral(@"                   154
                            </span>
                            <div>
                                <small>Posts</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""forum-item active"">
                    <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-calendar""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4893, "\"", 4947, 1);
#line 116 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 4900, Url.Action("Forum_post_view", "Miscellaneous"), 4900, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4948, 1628, true);
            WriteLiteral(@" class=""forum-item-title"">Announcements</a>
                            <div class=""forum-sub-title"">This forum features announcements from the community staff. If there is a new post in this forum, please check it out. </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                680
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                124
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <");
            WriteLiteral(@"span class=""views-number"">
                                61
                            </span>
                            <div>
                                <small>Posts</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""forum-item"">
                    <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-star""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6576, "\"", 6630, 1);
#line 151 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 6583, Url.Action("Forum_post_view", "Miscellaneous"), 6583, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6631, 1877, true);
            WriteLiteral(@" class=""forum-item-title"">Staff Discussion</a>
                            <div class=""forum-sub-title"">This forum is for private, staff member only discussions, usually pertaining to the community itself. </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                1450
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                652
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""v");
            WriteLiteral(@"iews-number"">
                                572
                            </span>
                            <div>
                                <small>Posts</small>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""forum-title"">
                    <div class=""float-right forum-desc"">
                        <samll>Total posts: 17,800,600</samll>
                    </div>
                    <h3>Other subjects</h3>
                </div>

                <div class=""forum-item"">
                    <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-clock-o""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8508, "\"", 8562, 1);
#line 194 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 8515, Url.Action("Forum_post_view", "Miscellaneous"), 8515, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8563, 1676, true);
            WriteLiteral(@" class=""forum-item-title"">Lorem Ipsum is simply dummy text. </a>
                            <div class=""forum-sub-title"">Various versions have evolved over the years, sometimes by accident, sometimes on purpose passage of Lorem Ipsum (injected humour and the like).</div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                1516
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                238
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
                        <div class=""col-");
            WriteLiteral(@"md-1 forum-info"">
                            <span class=""views-number"">
                                180
                            </span>
                            <div>
                                <small>Posts</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""forum-item"">
                    <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-bomb""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 10239, "\"", 10293, 1);
#line 229 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 10246, Url.Action("Forum_post_view", "Miscellaneous"), 10246, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10294, 1713, true);
            WriteLiteral(@" class=""forum-item-title"">There are many variations of passages</a>
                            <div class=""forum-sub-title""> If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the . </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                1766
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                321
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
      ");
            WriteLiteral(@"                  <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                42
                            </span>
                            <div>
                                <small>Posts</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""forum-item"">
                    <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-bookmark""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 12007, "\"", 12061, 1);
#line 264 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 12014, Url.Action("Forum_post_view", "Miscellaneous"), 12014, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12062, 1666, true);
            WriteLiteral(@" class=""forum-item-title"">The standard chunk of Lorem Ipsum</a>
                            <div class=""forum-sub-title"">Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet.</div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                765
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                90
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-inf");
            WriteLiteral(@"o"">
                            <span class=""views-number"">
                                11
                            </span>
                            <div>
                                <small>Posts</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""forum-item"">
                    <div class=""row"">
                        <div class=""col-md-9"">
                            <div class=""forum-icon"">
                                <i class=""fa fa-ambulance""></i>
                            </div>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 13728, "\"", 13782, 1);
#line 299 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Miscellaneous\Forum_view.cshtml"
WriteAttributeValue("", 13735, Url.Action("Forum_post_view", "Miscellaneous"), 13735, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(13783, 1339, true);
            WriteLiteral(@" class=""forum-item-title"">Lorem Ipsum, you need to be sure there</a>
                            <div class=""forum-sub-title"">Internet tend to repeat predefined chunks as necessary, making this the</div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                2550
                            </span>
                            <div>
                                <small>Views</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-number"">
                                122
                            </span>
                            <div>
                                <small>Topics</small>
                            </div>
                        </div>
                        <div class=""col-md-1 forum-info"">
                            <span class=""views-numb");
            WriteLiteral(@"er"">
                                92
                            </span>
                            <div>
                                <small>Posts</small>
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
