#pragma checksum "C:\Users\Intern 4\Desktop\CmpgProject2-main\WebApplication2\Views\Employees\Analytics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031f15b530188257fada60a8a2f8d6e2cbf5a4f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Analytics), @"mvc.1.0.view", @"/Views/Employees/Analytics.cshtml")]
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
#line 1 "C:\Users\Intern 4\Desktop\CmpgProject2-main\WebApplication2\Views\_ViewImports.cshtml"
using DimensionData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Intern 4\Desktop\CmpgProject2-main\WebApplication2\Views\_ViewImports.cshtml"
using DimensionData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"031f15b530188257fada60a8a2f8d6e2cbf5a4f7", @"/Views/Employees/Analytics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc0e6b6f68cabba37314c7a466a7820e138305e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Analytics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DimensionData.Data.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Intern 4\Desktop\CmpgProject2-main\WebApplication2\Views\Employees\Analytics.cshtml"
  
    ViewData["Title"] = "Analytics";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container mb-4\">\n    <div class=\"row\">\n        <div class=\"col-sm\">\n            <h1>");
#nullable restore
#line 11 "C:\Users\Intern 4\Desktop\CmpgProject2-main\WebApplication2\Views\Employees\Analytics.cshtml"
           Write(Model.ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            <p>The total number of records</p>\n        </div>\n        <div class=\"col-sm\">\n            <h1>");
#nullable restore
#line 15 "C:\Users\Intern 4\Desktop\CmpgProject2-main\WebApplication2\Views\Employees\Analytics.cshtml"
           Write(Model.Select(x => x.OwnerId == null).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            <p>The total number of records not relatig to User profiles</p>\n        </div>\n        <div class=\"col-sm\">\n            <h1>");
#nullable restore
#line 19 "C:\Users\Intern 4\Desktop\CmpgProject2-main\WebApplication2\Views\Employees\Analytics.cshtml"
           Write(Model.Select(x => x.OwnerId != null).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            <p>The total number of records that relates to user profiles</p>\n        </div>\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DimensionData.Data.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591