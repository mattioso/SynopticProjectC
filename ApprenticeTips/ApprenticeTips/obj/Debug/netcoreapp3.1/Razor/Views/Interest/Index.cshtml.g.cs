#pragma checksum "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6baa3065e21bdf63d14e149ccb10c131f95cbe44"
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
#line 1 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\_ViewImports.cshtml"
using ApprenticeTips;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\_ViewImports.cshtml"
using ApprenticeTips.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6baa3065e21bdf63d14e149ccb10c131f95cbe44", @"/Views/Interest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ee700c39b4d11b61471829e5c106b5b52268e24", @"/Views/_ViewImports.cshtml")]
    public class Views_Interest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApprenticeTips.App.Models.Interest.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"data-entry\">\r\n    <h5>Please enter your details and we\'ll be in touch</h5>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 11 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 14 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 20 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 23 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 29 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 32 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 38 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 41 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
       Write(Html.EditorFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 46 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
   Write(Html.LabelFor(model => model.PreviousQualificationLevels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 47 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
   Write(Html.DropDownListFor(model => model.PreviousQualificationsLevel,
                              new SelectList(Model.PreviousQualificationLevels, 
                              "Level", 
                              "Name", 
                              0)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 55 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
   Write(Html.LabelFor(model => model.ApprentishipCatagories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"apprentship-catagories\">\r\n");
#nullable restore
#line 57 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
             foreach(var catagory in Model.ApprentishipCatagories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-4\">\r\n                        <p>");
#nullable restore
#line 61 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
                      Write(catagory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div>\r\n                        <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=", 1918, "", 1968, 1);
#nullable restore
#line 64 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
WriteAttributeValue("", 1922, string.Format("catagory-id-{0}", catagory.Id), 1922, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 67 "D:\_College\_Project\Code\SynopticProjectC\ApprenticeTips\ApprenticeTips\Views\Interest\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
