#pragma checksum "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\UIElements\Buttons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f59a563f2a68b72373f34fb9e86f5c2c623a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UIElements_Buttons), @"mvc.1.0.view", @"/Views/UIElements/Buttons.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UIElements/Buttons.cshtml", typeof(AspNetCore.Views_UIElements_Buttons))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f59a563f2a68b72373f34fb9e86f5c2c623a75", @"/Views/UIElements/Buttons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddf19c24a85a5b15b5cbd6807ef85c4223d805f", @"/Views/_ViewImports.cshtml")]
    public class Views_UIElements_Buttons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\UIElements\Buttons.cshtml"
  
    ViewData["Title"] = "Buttons";

#line default
#line hidden
            BeginContext(41, 207, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Buttons</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 248, "\"", 295, 1);
#line 11 "E:\CODIGOS\GIT\2021\AspNetCore-master\AspNetCore\AspNetCore\Views\UIElements\Buttons.cshtml"
WriteAttributeValue("", 255, Url.Action("Dashboard_1", "Dashboards"), 255, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 32149, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>UI Elements</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Buttons</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""row wrapper wrapper-content animated fadeInRight"">
    <div class=""col-lg-4"">
        <div class=""ibox float-e-margins "">
            <div class=""ibox-title"">
                <h5>Colors buttons</h5>
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
              ");
            WriteLiteral(@"          </li>
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
                    Use any of the available button classes to quickly create a styled button.
                </p>

                <h3 class=""font-bold"">
                    Normal buttons
                </h3>
                <p>
                    <button type=""button"" class=""btn btn-w-m btn-default"">Default</button>
                    <button type=""button"" class=""btn btn-w-m btn-primary"">Primary</button>
                    <button type=""button"" class=""btn btn-w-m btn-success"">Success</button>
                    <button type=""button"" class=""btn btn-w-m btn-info"">Info</button>
                    <button t");
            WriteLiteral(@"ype=""button"" class=""btn btn-w-m btn-warning"">Warning</button>
                    <button type=""button"" class=""btn btn-w-m btn-danger"">Danger</button>
                    <button type=""button"" class=""btn btn-w-m btn-white"">Danger</button>
                    <button type=""button"" class=""btn btn-w-m btn-link"">Link</button>
                </p>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""ibox float-e-margins"">
            <div class=""ibox-title"">
                <h5>Diferent size</h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-wrench""></i>
                    </a>
                    <ul class=""dropdown-menu dropdown-user"">
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config op");
            WriteLiteral(@"tion 1</a>
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
                    If You want larger or smaller buttons You can add <code>.btn-lg</code>, <code>.btn-sm</code>, or <code>.btn-xs</code> class.
                </p>
                <h3 class=""font-bold"">Button Sizes</h3>
                <p>
                    <button type=""button"" class=""btn btn-primary btn-lg"">Large button</button>
                    <button type=""button"" class=""btn btn-default btn-lg"">Large button</button>
                    <br />
                    <button type=""button"" class=""btn btn-primary"">Default button</button>
                    <button type=""button"" clas");
            WriteLiteral(@"s=""btn btn-default"">Default button</button>
                    <br />
                    <button type=""button"" class=""btn btn-primary btn-sm"">Small button</button>
                    <button type=""button"" class=""btn btn-default btn-sm"">Small button</button>
                    <br />
                    <button type=""button"" class=""btn btn-primary btn-xs"">Mini button</button>
                    <button type=""button"" class=""btn btn-default btn-xs"">Mini button</button>
                </p>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""ibox float-e-margins "">
            <div class=""ibox-title"">
                <h5>Outline and Block Buttons</h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-wrench""></i>
                    <");
            WriteLiteral(@"/a>
                    <ul class=""dropdown-menu dropdown-user"">
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config option 1</a>
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
                    Create block level buttons or outline buttons, by adding <code>.btn-block</code>   or <code>.btn-outline</code>.
                </p>

                <h3 class=""font-bold"">Outline buttons</h3>
                <p>
                    <button type=""button"" class=""btn btn-outline btn-default"">Default</button>
                    <button type=""button"" class=""btn btn-outline btn-primary"">Primary</button>
      ");
            WriteLiteral(@"              <button type=""button"" class=""btn btn-outline btn-success"">Success</button>
                    <button type=""button"" class=""btn btn-outline btn-info"">Info</button>
                    <button type=""button"" class=""btn btn-outline btn-warning"">Warning</button>
                    <button type=""button"" class=""btn btn-outline btn-danger"">Danger</button>
                    <button type=""button"" class=""btn btn-outline btn-link"">Link</button>
                </p>
                <h3 class=""font-bold"">Block buttons</h3>
                <p>
                    <button type=""button"" class=""btn btn-block btn-outline btn-primary"">Primary</button>
                </p>
            </div>
        </div>
    </div>
    <div class=""col-lg-12"">
        <div class=""ibox "">
            <div class=""ibox-title"">
                <h5>3D Buttons</h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
  ");
            WriteLiteral(@"                  <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
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
                        <i class=""fa fa-times""></i>
                    </a>
                </div>
            </div>
            <div class=""ibox-content"">
                <p>
                    To add three diminsion to buttons You can add <code>.dim</code> class to button.
                </p>
                <h3 class=""font-bold"">Three diminsion button</h3>

                <button class=""btn btn-primary dim btn-large-dim"" type=""button""><i class=");
            WriteLiteral(@"""fa fa-money""></i></button>
                <button class=""btn btn-warning dim btn-large-dim"" type=""button""><i class=""fa fa-warning""></i></button>
                <button class=""btn btn-danger  dim btn-large-dim"" type=""button""><i class=""fa fa-heart""></i></button>
                <button class=""btn btn-primary  dim btn-large-dim"" type=""button""><i class=""fa fa-dollar""></i>6</button>
                <button class=""btn btn-info  dim btn-large-dim btn-outline"" type=""button""><i class=""fa fa-ruble""></i></button>
                <button class=""btn btn-primary dim"" type=""button""><i class=""fa fa-money""></i></button>
                <button class=""btn btn-warning dim"" type=""button""><i class=""fa fa-warning""></i></button>
                <button class=""btn btn-primary dim"" type=""button""><i class=""fa fa-check""></i></button>
                <button class=""btn btn-success  dim"" type=""button""><i class=""fa fa-upload""></i></button>
                <button class=""btn btn-info  dim"" type=""button""><i class=""fa fa-paste""></i> </but");
            WriteLiteral(@"ton>
                <button class=""btn btn-warning  dim"" type=""button""><i class=""fa fa-warning""></i></button>
                <button class=""btn btn-default  dim "" type=""button""><i class=""fa fa-star""></i></button>
                <button class=""btn btn-danger  dim "" type=""button""><i class=""fa fa-heart""></i></button>

                <button class=""btn btn-outline btn-primary dim"" type=""button""><i class=""fa fa-money""></i></button>
                <button class=""btn btn-outline btn-warning dim"" type=""button""><i class=""fa fa-warning""></i></button>
                <button class=""btn btn-outline btn-primary dim"" type=""button""><i class=""fa fa-check""></i></button>
                <button class=""btn btn-outline btn-success  dim"" type=""button""><i class=""fa fa-upload""></i></button>
                <button class=""btn btn-outline btn-info  dim"" type=""button""><i class=""fa fa-paste""></i> </button>
                <button class=""btn btn-outline btn-warning  dim"" type=""button""><i class=""fa fa-warning""></i></button>
        ");
            WriteLiteral(@"        <button class=""btn btn-outline btn-danger  dim "" type=""button""><i class=""fa fa-heart""></i></button>

            </div>
        </div>
    </div>
    <div class=""col-lg-12"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""ibox float-e-margins"">
                    <div class=""ibox-title"">
                        <h5>Button dropdowns</h5>
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
                  ");
            WriteLiteral(@"              <li>
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
                            Droppdowns buttons are avalible with any color and any size.
                        </p>

                        <h3 class=""font-bold"">Dropdowns</h3>
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-primary dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"" class=""font");
            WriteLiteral(@"-bold"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-warning dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
         ");
            WriteLiteral(@"                   </ul>
                        </div>
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-default dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>

                        <br />
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-primary btn-sm dropdown-toggle"">Action </button>
                            <ul class=""dr");
            WriteLiteral(@"opdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-warning btn-sm dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
");
            WriteLiteral(@"                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-default btn-sm dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>
                        <br />
                        <div class=""");
            WriteLiteral(@"btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-primary btn-xs dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-warning btn-xs dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                 ");
            WriteLiteral(@"               <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""dropdown-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>
                        <div class=""btn-group"">
                            <button data-toggle=""dropdown"" class=""btn btn-default btn-xs dropdown-toggle"">Action </button>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                <li class=""dropdown-divider""></li>
                                <li><a class=""drop");
            WriteLiteral(@"down-item"" href=""#"">Separated link</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Grouped Buttons</h5>
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
                           ");
            WriteLiteral(@"         <a href=""#"" class=""dropdown-item"">Config option 2</a>
                                </li>
                            </ul>
                            <a class=""close-link"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">
                        <p>
                            This is a group of buttons, ideal for sytuation where many actions are related to same element.
                        </p>

                        <h3 class=""font-bold"">Button Group</h3>
                        <div class=""btn-group"">
                            <button class=""btn btn-white"" type=""button"">Left</button>
                            <button class=""btn btn-primary"" type=""button"">Middle</button>
                            <button class=""btn btn-white"" type=""button"">Right</button>
                        </div>
                        <br />
                     ");
            WriteLiteral(@"   <br />
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-white""><i class=""fa fa-chevron-left""></i></button>
                            <button class=""btn btn-white"">1</button>
                            <button class=""btn btn-white  active"">2</button>
                            <button class=""btn btn-white"">3</button>
                            <button class=""btn btn-white"">4</button>
                            <button type=""button"" class=""btn btn-white""><i class=""fa fa-chevron-right""></i> </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""ibox "">
            <div class=""ibox-title"">
                <h5>Icon Buttons</h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""dropdown-toggle"" data-toggle=""d");
            WriteLiteral(@"ropdown"" href=""#"">
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
                        <i class=""fa fa-times""></i>
                    </a>
                </div>
            </div>
            <div class=""ibox-content"">
                <p>
                    To buttons with any color or any size you can add extra icon on the left or the right side.
                </p>

                <h3 class=""font-bold"">Commom Icon Buttons</h3>
                <p>
                    <button class=""btn btn-primary "" type=""button""><i class=""fa fa-check""></i>&nbsp;Submit</button>
    ");
            WriteLiteral(@"                <button class=""btn btn-success "" type=""button""><i class=""fa fa-upload""></i>&nbsp;&nbsp;<span class=""bold"">Upload</span></button>
                    <button class=""btn btn-info "" type=""button""><i class=""fa fa-paste""></i> Edit</button>
                    <button class=""btn btn-warning "" type=""button""><i class=""fa fa-warning""></i> <span class=""bold"">Warning</span></button>
                    <button class=""btn btn-default "" type=""button""><i class=""fa fa-map-marker""></i>&nbsp;&nbsp;Map</button>

                    <a href=""#"" class=""btn btn-success btn-facebook"">
                        <i class=""fa fa-facebook""> </i> Sign in with Facebook
                    </a>
                    <a href=""#"" class=""btn btn-success btn-facebook btn-outline"">
                        <i class=""fa fa-facebook""> </i> Sign in with Facebook
                    </a>
                    <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-user-md""></i>
                    </a>
  ");
            WriteLiteral(@"                  <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-group""></i>
                    </a>
                    <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-wrench""></i>
                    </a>
                    <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-exchange""></i>
                    </a>
                    <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-check-circle-o""></i>
                    </a>
                    <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-road""></i>
                    </a>
                    <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-ambulance""></i>
                    </a>
                    <a href=""#"" class=""btn btn-white btn-bitbucket"">
                        <i class=""fa fa-star""></i> Stared
       ");
            WriteLiteral(@"             </a>
                </p>

                <h3 class=""font-bold"">Toggle buttons Variations</h3>
                <p>Button groups can act as a radio or a switch or even a single toggle. Below are some examples click to see what happens</p>
                <button data-toggle=""button"" class=""btn btn-primary btn-outline"" type=""button"">Single Toggle</button>
                <button data-toggle=""button"" class=""btn btn-primary"" type=""button"">Single Toggle</button>
                <div data-toggle=""buttons-checkbox"" class=""btn-group"">
                    <button class=""btn btn-primary active"" type=""button""><i class=""fa fa-bold""></i> Bold</button>
                    <button class=""btn btn-primary"" type=""button""><i class=""fa fa-underline""></i> Underline</button>
                    <button class=""btn btn-primary active"" type=""button""><i class=""fa fa-italic""></i> Italic</button>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-12"">
        <div class=""row"">
      ");
            WriteLiteral(@"      <div class=""col-lg-6"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Circle Icon Buttons</h5>
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
                            <a class=""close-l");
            WriteLiteral(@"ink"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">
                        <p>
                            For buttons you can add <code>.btn-circle</code> to rounded buttons and make it circle.
                        </p>

                        <h3 class=""font-bold"">Circle buttons</h3>
                        <br />
                        <button class=""btn btn-default btn-circle"" type=""button"">
                            <i class=""fa fa-check""></i>
                        </button>
                        <button class=""btn btn-primary btn-circle"" type=""button"">
                            <i class=""fa fa-list""></i>
                        </button>
                        <button class=""btn btn-success btn-circle"" type=""button"">
                            <i class=""fa fa-link""></i>
                        </button>
                        <button cla");
            WriteLiteral(@"ss=""btn btn-info btn-circle"" type=""button"">
                            <i class=""fa fa-check""></i>
                        </button>
                        <button class=""btn btn-warning btn-circle"" type=""button"">
                            <i class=""fa fa-times""></i>
                        </button>
                        <button class=""btn btn-danger btn-circle"" type=""button"">
                            <i class=""fa fa-heart""></i>
                        </button>
                        <button class=""btn btn-danger btn-circle btn-outline"" type=""button"">
                            <i class=""fa fa-heart""></i>
                        </button>
                        <br />
                        <br />
                        <button class=""btn btn-default btn-circle btn-lg"" type=""button"">
                            <i class=""fa fa-check""></i>
                        </button>
                        <button class=""btn btn-primary btn-circle btn-lg"" type=""button"">
                            <i cla");
            WriteLiteral(@"ss=""fa fa-list""></i>
                        </button>
                        <button class=""btn btn-success btn-circle btn-lg"" type=""button"">
                            <i class=""fa fa-link""></i>
                        </button>
                        <button class=""btn btn-info btn-circle btn-lg"" type=""button"">
                            <i class=""fa fa-check""></i>
                        </button>
                        <button class=""btn btn-warning btn-circle btn-lg"" type=""button"">
                            <i class=""fa fa-times""></i>
                        </button>
                        <button class=""btn btn-danger btn-circle btn-lg"" type=""button"">
                            <i class=""fa fa-heart""></i>
                        </button>
                        <button class=""btn btn-danger btn-circle btn-lg btn-outline"" type=""button"">
                            <i class=""fa fa-heart""></i>
                        </button>

                    </div>
                </div>
            </div");
            WriteLiteral(@">
            <div class=""col-lg-6"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Rounded Buttons</h5>
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
                            <a class=""clo");
            WriteLiteral(@"se-link"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">
                        <p>
                            You can also add <code>.btn-rounded</code> class to round buttons.
                        </p>

                        <h3 class=""font-bold"">Button Group</h3>
                        <p>
                            <a class=""btn btn-default btn-rounded"" href=""#"">Default</a>
                            <a class=""btn btn-primary btn-rounded"" href=""#"">Primary</a>
                            <a class=""btn btn-success btn-rounded"" href=""#"">Success</a>
                            <a class=""btn btn-info btn-rounded"" href=""#"">Info</a>
                            <a class=""btn btn-warning btn-rounded"" href=""#"">Warning</a>
                            <a class=""btn btn-danger btn-rounded"" href=""#"">Danger</a>
                            <a class=""btn btn-dange");
            WriteLiteral(@"r btn-rounded btn-outline"" href=""#"">Danger</a>
                            <br />
                            <br />
                            <a class=""btn btn-primary btn-rounded btn-block"" href=""#""><i class=""fa fa-info-circle""></i> Block rounded with icon button</a>
                        </p>
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
