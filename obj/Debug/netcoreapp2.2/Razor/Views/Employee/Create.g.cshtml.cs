#pragma checksum "/Users/alexanderpeloquin/Documents/SDGKU/Classes/WorkSpace/110 asp.net core/Session 4/Restaurant/Views/Employee/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58457b9ee008a293783d3052e7dd5bd656f062b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Create.cshtml", typeof(AspNetCore.Views_Employee_Create))]
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
#line 1 "/Users/alexanderpeloquin/Documents/SDGKU/Classes/WorkSpace/110 asp.net core/Session 4/Restaurant/Views/_ViewImports.cshtml"
using Restaurant;

#line default
#line hidden
#line 2 "/Users/alexanderpeloquin/Documents/SDGKU/Classes/WorkSpace/110 asp.net core/Session 4/Restaurant/Views/_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58457b9ee008a293783d3052e7dd5bd656f062b4", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a59b7783d8b0512a9ae3ec4003f04bd353cebbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 75, true);
            WriteLiteral("<div>\n    <h2>Register new Employees</h2>\n    <h5>Complete form below</h5>\n");
            EndContext();
            BeginContext(75, 1206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58457b9ee008a293783d3052e7dd5bd656f062b43500", async() => {
                BeginContext(81, 1193, true);
                WriteLiteral(@"
  <div class=""form-row"">
    <div class=""form-group col-md-6"">
      <label>First Name</label>
      <input class=""form-control"" id=""txtFirst"" placeholder=""First"">
    </div>
    <div class=""form-group col-md-6"">
      <label>Last Name</label>
      <input class=""form-control"" id=""txtLast"" placeholder=""Last"">
      <div id=""nameLastError"" class=""alert alert-danger hidden"" role=""alert"">Last Name are required Fields</div>
    </div>
    
  </div>

  <div class=""form-row"">
    <div class=""form-group col-md-7"">
      <label>Phone Number</label>
      <input type=""text"" class=""form-control"" id=""txtPhone""placeholder=""Phone Number"">
    </div>
    <div class=""form-group col-md-5"">
      <label>Position</label>
      <input type=""text"" class=""form-control"" id=""txtPosition""placeholder=""Position"">
    </div>
    <div class=""form-group col-md-4"">
      <label>Salary</label>
      <input type=""text"" class=""form-control"" id=""txtSalary""placeholder=""Salary"">
      <div id=""salaryError"" class=""alert alert-danger hidden"" rol");
                WriteLiteral("e=\"alert\">The value for Salary should be a number</div>\n    </div>\n  </div>\n\n  <button type=\"button\" onclick=\"SendTest()\" class = \"btn btn-md btn-primary\">Save</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1281, 8, true);
            WriteLiteral(" \n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
