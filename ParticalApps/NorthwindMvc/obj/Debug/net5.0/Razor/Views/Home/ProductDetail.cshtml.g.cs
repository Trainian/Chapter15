#pragma checksum "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/Home/ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "866af4b4e48ac2cc83432ec4b264a54919854baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
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
#line 1 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"866af4b4e48ac2cc83432ec4b264a54919854baf", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9458929087a0e512718d65e5855385084e728d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/Home/ProductDetail.cshtml"
  
    ViewData["Title"] = "Product Detail - " + Model.ProductName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Product Detail</h2>\n<hr>\n<div>\n    <dl class=\"dl-horizontal\">\n        <dt>Product ID</dt>\n        <dd>");
#nullable restore
#line 10 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Product.Name</dt>\n        <dd>");
#nullable restore
#line 12 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Category ID</dt>\n        <dd>");
#nullable restore
#line 14 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Unit Price</dt>\n        <dd>");
#nullable restore
#line 16 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.UnitPrice.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Units in Stock</dt>\n        <dd>");
#nullable restore
#line 18 "/home/user/CSharp8_book/Code/Chapter15/ParticalApps/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    </dl>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
