#pragma checksum "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430ffe6848f48b712d007c0deb06925a62bad386"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"430ffe6848f48b712d007c0deb06925a62bad386", @"/Views/Interest/Index.cshtml")]
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
            WriteLiteral("\r\n<div id=\"data-entry\">\r\n    <h5>Please enter your details and we\'ll be in touch</h5>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 11 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 14 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 20 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 23 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 29 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 32 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 38 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 41 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.PhoneNumber, new { @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 47 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.PreviousQualificationLevels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 50 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
       Write(Html.DropDownListFor(model => model.PreviousQualificationsLevel,
                              new SelectList(Model.PreviousQualificationLevels,
                              "Level",
                              "Name",
                              0)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 62 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Agriculture));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 65 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Agriculture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 71 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Business));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 74 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Business));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 80 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Care));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 83 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Care));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 89 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Catering));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 92 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Catering));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 98 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Construction));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 101 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Construction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 107 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Creative));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 110 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Creative));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 116 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Digital));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 119 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Digital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 125 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 128 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 134 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Engineering));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 137 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Engineering));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 143 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Hair));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 146 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Hair));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 152 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Health));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 155 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Health));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 161 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Legal));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 164 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Legal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 170 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Protective));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 173 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Protective));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 179 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Sales));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 182 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Sales));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
#nullable restore
#line 188 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.LabelFor(x => x.Transport));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 191 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
           Write(Html.EditorFor(x => x.Transport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 197 "D:\_College\_Project\Code\SynopticProjectC\SynopticProjectC\ApprenticeTips\ApprenticeTips.App\Views\Interest\Index.cshtml"
   Write(Html.TextAreaFor(x => x.Comments,
                          new { cols = 75, rows = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"alert alert-danger\" role=\"alert\" id=\"error-alert\" style=\"display:none\"></div>\r\n\r\n    <button type=\"button\" class=\"btn btn-primary\" onclick=\"OnSubmitPressed()\">Submit</button>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "430ffe6848f48b712d007c0deb06925a62bad38621245", async() => {
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
