#pragma checksum "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Ecommerce\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "928fc78e2170760ff4fa8dec839ec08a005ad101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ecommerce_Cart), @"mvc.1.0.view", @"/Views/Ecommerce/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ecommerce/Cart.cshtml", typeof(AspNetCore.Views_Ecommerce_Cart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928fc78e2170760ff4fa8dec839ec08a005ad101", @"/Views/Ecommerce/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73358804c8727746b2b177dc6772a98e99c25b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Ecommerce_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Ecommerce\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
            BeginContext(38, 222, true);
            WriteLiteral("<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>E-commerce shoping cart</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 260, "\"", 307, 1);
#line 10 "E:\CODIGOS\GIT\2021\FiFellingsCore-master\FiFellings\FiFellings\Views\Ecommerce\Cart.cshtml"
WriteAttributeValue("", 267, Url.Action("Dashboard_1", "Dashboards"), 267, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(308, 16356, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>E-commerce</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Shoping cart</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>

<div class=""wrapper wrapper-content animated fadeInRight"">



    <div class=""row"">
        <div class=""col-md-9"">

            <div class=""ibox"">
                <div class=""ibox-title"">
                    <span class=""float-right"">(<strong>5</strong>) items</span>
                    <h5>Items in your cart</h5>
                </div>
                <div class=""ibox-content"">


                    <div class=""table-responsive"">
                        <table class=""table shoping-cart-table"">

                            <tbody>
                                <tr>
                                    <td width=""90"">
                                        <div class=""cart-product-imitation"">
                ");
            WriteLiteral(@"                        </div>
                                    </td>
                                    <td class=""desc"">
                                        <h3>
                                            <a href=""#"" class=""text-navy"">
                                                Desktop publishing software
                                            </a>
                                        </h3>
                                        <p class=""small"">
                                            It is a long established fact that a reader will be distracted by the readable
                                            content of a page when looking at its layout. The point of using Lorem Ipsum is
                                        </p>
                                        <dl class=""small m-b-none"">
                                            <dt>Description lists</dt>
                                            <dd>A description list is perfect for defining terms.</dd>
              ");
            WriteLiteral(@"                          </dl>

                                        <div class=""m-t-sm"">
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-gift""></i> Add gift package</a>
                                            |
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-trash""></i> Remove item</a>
                                        </div>
                                    </td>

                                    <td>
                                        $180,00
                                        <s class=""small text-muted"">$230,00</s>
                                    </td>
                                    <td width=""65"">
                                        <input type=""text"" class=""form-control"" placeholder=""1"">
                                    </td>
                                    <td>
                                        <h4>
                                            $180,00
            ");
            WriteLiteral(@"                            </h4>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>

                </div>
                <div class=""ibox-content"">
                    <div class=""table-responsive"">
                        <table class=""table shoping-cart-table"">

                            <tbody>
                                <tr>
                                    <td width=""90"">
                                        <div class=""cart-product-imitation"">
                                        </div>
                                    </td>
                                    <td class=""desc"">
                                        <h3>
                                            <a href=""#"" class=""text-navy"">
                                                Text editor
                                            </a>
                                        </h3>
         ");
            WriteLiteral(@"                               <p class=""small"">
                                            There are many variations of passages of Lorem Ipsum available
                                        </p>
                                        <dl class=""small m-b-none"">
                                            <dt>Description lists</dt>
                                            <dd>List is perfect for defining terms.</dd>
                                        </dl>

                                        <div class=""m-t-sm"">
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-gift""></i> Add gift package</a>
                                            |
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-trash""></i> Remove item</a>
                                        </div>
                                    </td>

                                    <td>
                                        $50,00
                     ");
            WriteLiteral(@"                   <s class=""small text-muted"">$63,00</s>
                                    </td>
                                    <td width=""65"">
                                        <input type=""text"" class=""form-control"" placeholder=""2"">
                                    </td>
                                    <td>
                                        <h4>
                                            $100,00
                                        </h4>
                                    </td>

                                </tr>
                            </tbody>
                        </table>
                    </div>

                </div>
                <div class=""ibox-content"">
                    <div class=""table-responsive"">
                        <table class=""table shoping-cart-table"">

                            <tbody>
                                <tr>
                                    <td width=""90"">
                                        <div class=""cart-produ");
            WriteLiteral(@"ct-imitation"">
                                        </div>
                                    </td>
                                    <td class=""desc"">
                                        <h3>
                                            <a href=""#"" class=""text-navy"">
                                                CRM software
                                            </a>
                                        </h3>
                                        <p class=""small"">
                                            Distracted by the readable
                                            content of a page when looking at its layout. The point of using Lorem Ipsum is
                                        </p>
                                        <dl class=""small m-b-none"">
                                            <dt>Description lists</dt>
                                            <dd>A description list is perfect for defining terms.</dd>
                                        </dl>

   ");
            WriteLiteral(@"                                     <div class=""m-t-sm"">
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-gift""></i> Add gift package</a>
                                            |
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-trash""></i> Remove item</a>
                                        </div>
                                    </td>

                                    <td>
                                        $110,00
                                    </td>
                                    <td width=""65"">
                                        <input type=""text"" class=""form-control"" placeholder=""1"">
                                    </td>
                                    <td>
                                        <h4>
                                            $110,00
                                        </h4>
                                    </td>

                                </tr>
 ");
            WriteLiteral(@"                           </tbody>
                        </table>
                    </div>

                </div>
                <div class=""ibox-content"">
                    <div class=""table-responsive"">
                        <table class=""table shoping-cart-table"">

                            <tbody>
                                <tr>
                                    <td width=""90"">
                                        <div class=""cart-product-imitation"">
                                        </div>
                                    </td>
                                    <td class=""desc"">
                                        <h3>
                                            <a href=""#"" class=""text-navy"">
                                                PM software
                                            </a>
                                        </h3>
                                        <p class=""small"">
                                            Readable content of a ");
            WriteLiteral(@"page when looking at its layout. The point of using Lorem Ipsum is
                                        </p>
                                        <dl class=""small m-b-none"">
                                            <dt>Description lists</dt>
                                            <dd>A description list is perfect for defining terms.</dd>
                                        </dl>

                                        <div class=""m-t-sm"">
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-gift""></i> Add gift package</a>
                                            |
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-trash""></i> Remove item</a>
                                        </div>
                                    </td>

                                    <td>
                                        $130,00
                                    </td>
                                    <td width=""65"">
 ");
            WriteLiteral(@"                                       <input type=""text"" class=""form-control"" placeholder=""1"">
                                    </td>
                                    <td>
                                        <h4>
                                            $130,00
                                        </h4>
                                    </td>

                                </tr>
                            </tbody>
                        </table>
                    </div>

                </div>
                <div class=""ibox-content"">
                    <div class=""table-responsive"">
                        <table class=""table shoping-cart-table"">

                            <tbody>
                                <tr>
                                    <td width=""90"">
                                        <div class=""cart-product-imitation"">
                                        </div>
                                    </td>
                                    <td class=""de");
            WriteLiteral(@"sc"">
                                        <h3>
                                            <a href=""#"" class=""text-navy"">
                                                Photo editor
                                            </a>
                                        </h3>
                                        <p class=""small"">
                                            Page when looking at its layout. The point of using Lorem Ipsum is
                                        </p>
                                        <dl class=""small m-b-none"">
                                            <dt>Description lists</dt>
                                            <dd>A description list is perfect for defining terms.</dd>
                                        </dl>

                                        <div class=""m-t-sm"">
                                            <a href=""#"" class=""text-muted""><i class=""fa fa-gift""></i> Add gift package</a>
                                            |
          ");
            WriteLiteral(@"                                  <a href=""#"" class=""text-muted""><i class=""fa fa-trash""></i> Remove item</a>
                                        </div>
                                    </td>

                                    <td>
                                        $700,00
                                    </td>
                                    <td width=""65"">
                                        <input type=""text"" class=""form-control"" placeholder=""1"">
                                    </td>
                                    <td>
                                        <h4>
                                            $70,00
                                        </h4>
                                    </td>

                                </tr>
                            </tbody>
                        </table>
                    </div>

                </div>
                <div class=""ibox-content"">

                    <button class=""btn btn-primary float-right""><i class=""");
            WriteLiteral(@"fa fa fa-shopping-cart""></i> Checkout</button>
                    <button class=""btn btn-white""><i class=""fa fa-arrow-left""></i> Continue shopping</button>

                </div>
            </div>

        </div>
        <div class=""col-md-3"">

            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Cart Summary</h5>
                </div>
                <div class=""ibox-content"">
                    <span>
                        Total
                    </span>
                    <h2 class=""font-bold"">
                        $390,00
                    </h2>

                    <hr />
                    <span class=""text-muted small"">
                        *For United States, France and Germany applicable sales tax will be applied
                    </span>
                    <div class=""m-t-sm"">
                        <div class=""btn-group"">
                            <a href=""#"" class=""btn btn-primary btn-sm""><i class=""fa fa-shopping-cart""></i> Checko");
            WriteLiteral(@"ut</a>
                            <a href=""#"" class=""btn btn-white btn-sm""> Cancel</a>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Support</h5>
                </div>
                <div class=""ibox-content text-center"">



                    <h3><i class=""fa fa-phone""></i> +43 100 783 001</h3>
                    <span class=""small"">
                        Please contact with us if you have any questions. We are avalible 24h.
                    </span>


                </div>
            </div>

            <div class=""ibox"">
                <div class=""ibox-content"">

                    <p class=""font-bold"">
                        Other products you may be interested
                    </p>

                    <hr />
                    <div>
                        <a href=""#"" class=""product-name""> Product 1</a>
                        <div class");
            WriteLiteral(@"=""small m-t-xs"">
                            Many desktop publishing packages and web page editors now.
                        </div>
                        <div class=""m-t text-righ"">

                            <a href=""#"" class=""btn btn-xs btn-outline btn-primary"">Info <i class=""fa fa-long-arrow-right""></i> </a>
                        </div>
                    </div>
                    <hr />
                    <div>
                        <a href=""#"" class=""product-name""> Product 2</a>
                        <div class=""small m-t-xs"">
                            Many desktop publishing packages and web page editors now.
                        </div>
                        <div class=""m-t text-righ"">

                            <a href=""#"" class=""btn btn-xs btn-outline btn-primary"">Info <i class=""fa fa-long-arrow-right""></i> </a>
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
