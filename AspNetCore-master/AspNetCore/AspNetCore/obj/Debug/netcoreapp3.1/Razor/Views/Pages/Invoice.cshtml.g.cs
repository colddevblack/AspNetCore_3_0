#pragma checksum "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Pages\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb219d0f2e9123dc5c62fe9358c9758e77c4b902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Invoice), @"mvc.1.0.view", @"/Views/Pages/Invoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pages/Invoice.cshtml", typeof(AspNetCore.Views_Pages_Invoice))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb219d0f2e9123dc5c62fe9358c9758e77c4b902", @"/Views/Pages/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73358804c8727746b2b177dc6772a98e99c25b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Pages\Invoice.cshtml"
  
    ViewData["Title"] = "Invoice";

#line default
#line hidden
            BeginContext(41, 206, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-8\">\n        <h2>Invoice</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 247, "\"", 294, 1);
#line 11 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Pages\Invoice.cshtml"
WriteAttributeValue("", 254, Url.Action("Dashboard_1", "Dashboards"), 254, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(295, 493, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                Other Pages
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Invoice</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-4"">
        <div class=""title-action"">
            <a href=""#"" class=""btn btn-white""><i class=""fa fa-pencil""></i> Edit </a>
            <a href=""#"" class=""btn btn-white""><i class=""fa fa-check ""></i> Save </a>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 788, "\"", 831, 1);
#line 25 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Pages\Invoice.cshtml"
WriteAttributeValue("", 795, Url.Action("invoicePrint", "Pages"), 795, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(832, 4458, true);
            WriteLiteral(@" target=""_blank"" class=""btn btn-primary""><i class=""fa fa-print""></i> Print Invoice </a>
        </div>
    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""ibox-content p-xl"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h5>From:</h5>
                <address>
                    <strong>Inspinia, Inc.</strong><br>
                    106 Jorg Avenu, 600/10<br>
                    Chicago, VT 32456<br>
                    <abbr title=""Phone"">P:</abbr> (123) 601-4590
                </address>
            </div>

            <div class=""col-sm-6 text-right"">
                <h4>Invoice No.</h4>
                <h4 class=""text-navy"">INV-000567F7-00</h4>
                <span>To:</span>
                <address>
                    <strong>Corporate, Inc.</strong><br>
                    112 Street Avenu, 1080<br>
                    Miami, CT 445611<br>
                    <abbr title=""Phone"">P:</abbr> (120) 9000-4321
                </add");
            WriteLiteral(@"ress>
                <p>
                    <span><strong>Invoice Date:</strong> Marh 18, 2014</span><br />
                    <span><strong>Due Date:</strong> March 24, 2014</span>
                </p>
            </div>
        </div>

        <div class=""table-responsive m-t"">
            <table class=""table invoice-table"">
                <thead>
                    <tr>
                        <th>Item List</th>
                        <th>Quantity</th>
                        <th>Unit Price</th>
                        <th>Tax</th>
                        <th>Total Price</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <div><strong>Admin Theme with psd project layouts</strong></div>
                            <small>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</small>
                        </td>
            ");
            WriteLiteral(@"            <td>1</td>
                        <td>$26.00</td>
                        <td>$5.98</td>
                        <td>$31,98</td>
                    </tr>
                    <tr>
                        <td>
                            <div><strong>Wodpress Them customization</strong></div>
                            <small>
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                Eiusmod tempor incididunt ut labore et dolore magna aliqua.
                            </small>
                        </td>
                        <td>2</td>
                        <td>$80.00</td>
                        <td>$36.80</td>
                        <td>$196.80</td>
                    </tr>
                    <tr>
                        <td>
                            <div><strong>Angular JS & Node JS Application</strong></div>
                            <small>Lorem ");
            WriteLiteral(@"ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</small>
                        </td>
                        <td>3</td>
                        <td>$420.00</td>
                        <td>$193.20</td>
                        <td>$1033.20</td>
                    </tr>

                </tbody>
            </table>
        </div><!-- /table-responsive -->

        <table class=""table invoice-total"">
            <tbody>
                <tr>
                    <td><strong>Sub Total :</strong></td>
                    <td>$1026.00</td>
                </tr>
                <tr>
                    <td><strong>TAX :</strong></td>
                    <td>$235.98</td>
                </tr>
                <tr>
                    <td><strong>TOTAL :</strong></td>
                    <td>$1261.98</td>
                </tr>
            </tbody>
        </table>
        <div class=""text-right"">
            <button class=""btn btn-primary""><i class");
            WriteLiteral(@"=""fa fa-dollar""></i> Make A Payment</button>
        </div>

        <div class=""well m-t"">
            <strong>Comments</strong>
            It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less
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
