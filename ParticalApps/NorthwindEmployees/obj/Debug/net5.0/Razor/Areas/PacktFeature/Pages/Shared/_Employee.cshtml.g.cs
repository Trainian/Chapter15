#pragma checksum "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/Shared/_Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cfc0967c8d30c2851cdc401251b2f44bdfaf2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PacktFeature_Pages_Shared__Employee), @"mvc.1.0.view", @"/Areas/PacktFeature/Pages/Shared/_Employee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56cfc0967c8d30c2851cdc401251b2f44bdfaf2f", @"/Areas/PacktFeature/Pages/Shared/_Employee.cshtml")]
    public class Areas_PacktFeature_Pages_Shared__Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EmployeeInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card border-dark mb-3\" style=\"max-width: : 18rem;\">\n    <div class=\"card-header\">\n        ");
#nullable restore
#line 5 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/Shared/_Employee.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 6 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/Shared/_Employee.cshtml"
   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cfc0967c8d30c2851cdc401251b2f44bdfaf2f3585", async() => {
                WriteLiteral(" \n        <div class=\"card-body text-dark\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 10 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/Shared/_Employee.cshtml"
                          Write(Model.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n        <p class=\"card-text\">");
#nullable restore
#line 11 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/Shared/_Employee.cshtml"
                        Write(Model.Notes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>");
#nullable restore
#line 12 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/Shared/_Employee.cshtml"
      Write(Model.Orders.FirstOrDefault());

#line default
#line hidden
#nullable disable
                WriteLiteral(";</p>\n    </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindEmployees/Areas/PacktFeature/Pages/Shared/_Employee.cshtml"
                                 WriteLiteral(Model.EmployeeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
