#pragma checksum "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/EmployeeInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59177ab4c6c40597142287ab1ced8c6ca63b48f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PacktFeature_Pages_EmployeeInfo), @"mvc.1.0.razor-page", @"/Areas/PacktFeature/Pages/EmployeeInfo.cshtml")]
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
#line 2 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/EmployeeInfo.cshtml"
using Packt.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59177ab4c6c40597142287ab1ced8c6ca63b48f6", @"/Areas/PacktFeature/Pages/EmployeeInfo.cshtml")]
    public class Areas_PacktFeature_Pages_EmployeeInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card border-dark mb-3\" style=\"max-width: : 18rem;\">\n    <div class=\"card-header\">\n        ");
#nullable restore
#line 7 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/EmployeeInfo.cshtml"
   Write(Model.Employee);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 8 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/EmployeeInfo.cshtml"
   Write(Model.Employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    EMPLOYEEEEEE\n    <a");
            BeginWriteAttribute("href", " href=\"", 313, "\"", 320, 0);
            EndWriteAttribute();
            BeginWriteAttribute("asp-for", " asp-for=\"", 321, "\"", 337, 1);
#nullable restore
#line 11 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/EmployeeInfo.cshtml"
WriteAttributeValue("", 331, Model, 331, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"card-body text-dark\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 13 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/EmployeeInfo.cshtml"
                          Write(Model.Employee.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">");
#nullable restore
#line 14 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/EmployeeInfo.cshtml"
                        Write(Model.Employee.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    </a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PacktFeatures.Pages.EmployeeInfoPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PacktFeatures.Pages.EmployeeInfoPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PacktFeatures.Pages.EmployeeInfoPageModel>)PageContext?.ViewData;
        public PacktFeatures.Pages.EmployeeInfoPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591