#pragma checksum "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b27240def2cc3a870faf336b2274971c78b8c8e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
using WebStore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
using WebStore.Data.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27240def2cc3a870faf336b2274971c78b8c8e4", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f995601cf2e45bcdc71b39abd44ea1dc817cf585", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n<h2>All cars</h2>\r\n<h3>");
#nullable restore
#line 12 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 14 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
      
        foreach (Car car in Model.allCars) { 
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
       Write(Html.Partial("AllCars", car));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nick\source\repos\WebStore\WebStore\Views\Cars\List.cshtml"
                                         
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
