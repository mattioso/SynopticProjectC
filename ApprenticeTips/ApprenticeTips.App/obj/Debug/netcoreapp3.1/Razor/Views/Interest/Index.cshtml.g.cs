#pragma checksum "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77bd31ae5927df44accfdbb25ef1d7f344feaeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Interest_Index), @"mvc.1.0.view", @"/Views/Interest/Index.cshtml")]
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
#nullable restore
#line 1 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\_ViewImports.cshtml"
using ApprenticeTips.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\_ViewImports.cshtml"
using ApprenticeTips.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77bd31ae5927df44accfdbb25ef1d7f344feaeb", @"/Views/Interest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e01c49a70d610f0b64b84c636ef7733c675191a", @"/Views/_ViewImports.cshtml")]
    public class Views_Interest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApprenticeTips.App.Models.Interest.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/express-interest.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
  
    ViewData["Title"] = "Register Interest";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""data-entry"">
    <div class=""row"">
        <div class=""col-lg-3""></div>
        <div class=""col text-center"">
            <h5>Please enter your details and we'll be in touch</h5>
        </div>
        <div class=""col-lg-3""></div>
    </div>

    <div class=""row"">
        <div class=""col-lg-3 col-md-2""></div>
        <div class=""col"">
            ");
#nullable restore
#line 18 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 21 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.TextBoxFor(model => model.FirstName, new { @class = "max-width" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 29 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 32 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.TextBoxFor(model => model.Surname, new { @class = "max-width" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 40 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 43 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.TextBoxFor(model => model.Email, new { @class = "max-width" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 51 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 54 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.TextBoxFor(model => model.PhoneNumber, new { @class = "max-width" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 62 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.PreviousQualificationLevels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 65 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.DropDownListFor(model => model.PreviousQualificationsLevel,
                              new SelectList(Model.PreviousQualificationLevels,
                              "Level",
                              "Name",
                              0),
                              new { @class = "max-width" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-lg-3 col-md-2""></div>
    </div>

    <div class=""row"">
        <div class=""col-lg-3""></div>
        <div class=""col text-center"">
            <h5>Please select the routes that interest you:</h5>
        </div>
        <div class=""col-lg-3""></div>
    </div>

    <div>

        <div class=""row"">
            <div class=""col-lg-3 col-md-2""></div>
            <div class=""col-3 col-md-3 col-sm-3"">
                ");
#nullable restore
#line 88 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Agriculture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 91 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Agriculture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 99 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Business));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 102 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Business));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 110 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Care));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 113 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Care));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 121 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Catering));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 124 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Catering));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 132 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Construction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 135 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Construction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 143 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Creative));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 146 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Creative));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 154 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Digital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 157 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Digital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 165 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 168 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 176 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Engineering));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 179 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Engineering));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 187 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Hair));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 190 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Hair));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 198 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Health));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 201 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Health));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 209 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Legal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 212 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Legal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 220 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Protective));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 223 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Protective));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 231 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Sales));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 234 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Sales));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n            <div class=\"col-3 col-md-3 col-sm-3\">\r\n                ");
#nullable restore
#line 242 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Transport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col text-right\">\r\n                ");
#nullable restore
#line 245 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.CheckBoxFor(x => x.Transport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-2\"></div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-md-2\"></div>\r\n        <div class=\"col top-padding\">\r\n            ");
#nullable restore
#line 254 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.TextAreaFor(x => x.Comments,
                                   new
                                   {
                                       @class = "max-width",
                                       @rows = 4,
                                       @placeholder = "Please provide any other information that you wish to let our recruiters know???"
                                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-lg-3 col-md-2""></div>
    </div>

    <div class=""row"">
        <div class=""col-lg-3 col-md-2""></div>
        <div class=""col top-padding"">
            <div class=""alert alert-danger hidden"" role=""alert"" id=""error-alert""></div>
        </div>
        <div class=""col-lg-3 col-md-2""></div>
    </div>

    <div class=""row"">
        <div class=""col-lg-3 col-md-2""></div>
        <div class=""col top-padding"">
            <button type=""button"" class=""btn btn-primary"" onclick=""OnSubmitPressed()"">Submit</button>
        </div>
        <div class=""col-lg-3 col-md-2""></div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77bd31ae5927df44accfdbb25ef1d7f344feaeb25222", async() => {
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
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApprenticeTips.App.Models.Interest.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
