<<<<<<< HEAD
#pragma checksum "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindWeb/Pages/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a1893aafb01dba01b21f0d8f97f3ff4df7f89b"
=======
#pragma checksum "C:\Users\Admin\source\repos\CSharp8_book\Code\Chapter15\ParticalApps\NorthwindWeb\Pages\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b9646e402f8749f637c9f63179b1304477840e"
>>>>>>> 08a39265fe13e617f7663770464a9e037ee8a131
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_index), @"mvc.1.0.razor-page", @"/Pages/index.cshtml")]
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a1893aafb01dba01b21f0d8f97f3ff4df7f89b", @"/Pages/index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b9646e402f8749f637c9f63179b1304477840e", @"/Pages/index.cshtml")]
>>>>>>> 08a39265fe13e617f7663770464a9e037ee8a131
    public class Pages_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"jumbotron\">\n  <h1 class=\"display-3\">Welcome to Northwind!</h1>\n  <p class=\"lead\">We supply products to our customers.</p>\n  <hr />\n  <p>It\'s ");
#nullable restore
#line 16 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindWeb/Pages/index.cshtml"
     Write(Model.DayName);

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("! Our customers include restaurants, hotels, and cruise lines.</p>\n  <p>\n    <a class=\"btn btn-primary\" href=\"packtfeatures/employeesorted\">Contact out employees</a>\n  </p>\n</div>\n");
=======
            WriteLiteral("! Our customers include restaurants, hotels, and cruise lines.</p>\r\n  <p>\r\n    <a class=\"btn btn-primary\" href=\"packtfeature/employeesorted\">Contact out employees</a>\r\n  </p>\r\n</div>\r\n");
>>>>>>> 08a39265fe13e617f7663770464a9e037ee8a131
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindWeb/Pages/index.cshtml"
 
  public string DayName {get;set;}

  public void OnGet()
  {
    ViewData["Title"] = "Northwind Website";
    Model.DayName = DateTime.Now.ToString("dddd");
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_index>)PageContext?.ViewData;
        public Pages_index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
