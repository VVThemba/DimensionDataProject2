#pragma checksum "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c94150c0feeede1b9bec9466abda28c0ddc0ce24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
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
#line 1 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\_ViewImports.cshtml"
using DimensionData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\_ViewImports.cshtml"
using DimensionData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94150c0feeede1b9bec9466abda28c0ddc0ce24", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc0e6b6f68cabba37314c7a466a7820e138305e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DimensionData.Data.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c94150c0feeede1b9bec9466abda28c0ddc0ce244736", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 44 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 47 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 50 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 53 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 56 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 59 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 62 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 65 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 68 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 71 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 74 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 77 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 80 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 83 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 86 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 89 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 92 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 95 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 98 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 101 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 104 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 107 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 110 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 113 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 116 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 119 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 125 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 128 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 131 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 134 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 137 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 140 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 143 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 146 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 149 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 152 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 155 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 158 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 161 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 164 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 167 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 170 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 173 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 176 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 179 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 182 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 185 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 188 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 191 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 194 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 197 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 200 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 203 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 206 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 209 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 212 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 215 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 218 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 221 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 224 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 227 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 230 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n               \n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c94150c0feeede1b9bec9466abda28c0ddc0ce2431390", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 235 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\n");
#nullable restore
#line 236 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
                 if (item.OwnerId == ViewBag.UserId || User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c94150c0feeede1b9bec9466abda28c0ddc0ce2433935", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 238 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
                                           WriteLiteral(item.Id);

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
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c94150c0feeede1b9bec9466abda28c0ddc0ce2436146", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 239 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
                                             WriteLiteral(item.Id);

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
            WriteLiteral("\n");
#nullable restore
#line 240 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 243 "C:\Users\Intern 4\Downloads\Compressed\CmpgProject2-main\CmpgProject2-main\WebApplication2\Views\Employees\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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