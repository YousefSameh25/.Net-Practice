#pragma checksum "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3c1e5efb1e23e9b1d744cdcaea34987c2f6b671a88d96a1dacfcae3c33c5ae05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\_ViewImports.cshtml"
using DataAccessLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3c1e5efb1e23e9b1d744cdcaea34987c2f6b671a88d96a1dacfcae3c33c5ae05", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a20f5e93b5cadf4f840a6de4ddf2e308226641288ed5f1ca9cef75e3eb23305f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Employee Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "All Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-success\"> ");
#nullable restore
#line 6 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                             Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n<div class=\"alert alert-success\"> ");
#nullable restore
#line 7 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                             Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c1e5efb1e23e9b1d744cdcaea34987c2f6b671a88d96a1dacfcae3c33c5ae057621", async() => {
                WriteLiteral(" Create New Employee ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c1e5efb1e23e9b1d744cdcaea34987c2f6b671a88d96a1dacfcae3c33c5ae058930", async() => {
                WriteLiteral("\r\n    <div class=\"input-group mb-3\">\r\n        <input type=\"text\" name=\"Name\" class=\"form-control\" placeholder=\"Enter employee\'s name\">\r\n        <button class=\"btn btn-primary\" type=\"submit\">Search</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 26 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
  
    if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <center> <h1 class=\"alert-warning\"> There is no employees </h1> </center>\r\n");
#nullable restore
#line 30 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1> All Employees </h1>\r\n        <br />\r\n        <table class=\"table table-striped table-hover mt-3\">\r\n            <thead class=\"thead-dark\">\r\n                <tr>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 38 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 39 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 40 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 41 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 42 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 43 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 44 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 45 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 46 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th scope=\"col\"> ");
#nullable restore
#line 47 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                Write(Html.DisplayNameFor(E => E.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n\r\n\r\n                    <th scope=\"col\"> Details </th>\r\n                    <th scope=\"col\"> Update </th>\r\n                    <th scope=\"col\"> Delete </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                  
                    foreach (var E in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c1e5efb1e23e9b1d744cdcaea34987c2f6b671a88d96a1dacfcae3c33c5ae0515360", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2093, "~/Files/Images/", 2093, 15, true);
#nullable restore
#line 60 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 2108, E.ImageName, 2108, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  </img> </td>\r\n                            <td> ");
#nullable restore
#line 61 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(E.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 62 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(E.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 63 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(Html.DisplayFor(Emp => E.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 64 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(Html.DisplayFor(Emp => E.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 65 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(E.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 66 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(Html.DisplayFor(Emp => E.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 67 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(E.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 68 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                            Write(E.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                            <td>\r\n");
#nullable restore
#line 71 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                  
                                    if (E.IsActive)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle\" style=\"color:green\"> </i>\r\n");
#nullable restore
#line 75 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa-solid fa-circle\" style=\"color:red\"> </i>\r\n");
#nullable restore
#line 79 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c1e5efb1e23e9b1d744cdcaea34987c2f6b671a88d96a1dacfcae3c33c5ae0520964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 83 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = E.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 85 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 89 "C:\Users\youse\source\repos\MVCProject\MVC-Project\PresentationLayer\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
