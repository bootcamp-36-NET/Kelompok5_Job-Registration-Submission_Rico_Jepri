#pragma checksum "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\JobRegistrationSubmisson\WebClient\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0d50b2625a14bb451018f63bf8c1e2763f59f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Index.cshtml", typeof(AspNetCore.Views_Employees_Index))]
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
#line 1 "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\JobRegistrationSubmisson\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#line 2 "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\JobRegistrationSubmisson\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0d50b2625a14bb451018f63bf8c1e2763f59f2", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2@9.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Script/Employee.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\JobRegistrationSubmisson\WebClient\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/_layout.cshtml";

#line default
#line hidden
            BeginContext(90, 3567, true);
            WriteLiteral(@"

<div class=""content-wrapper"">
    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header no-bd"">
                    <h5 class=""modal-title""><span class=""fw-mediumbold"">Job list</span></h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <table class=""table table-bordered table-striped"">
                        <tbody>
                            <tr hidden>
                                <th width=""30%"">Id</th>
                                <th>:</th>
                                <td id=""Id""> </td>
                            </tr>
                            <tr>
                                <t");
            WriteLiteral(@"h width=""30%"">Name</th>
                                <th>:</th>
                                <td id=""Name""> </td>
                            </tr>
                            <tr>
                                <th>Gender</th>
                                <th width=""10%"">:</th>
                                <td id=""Gender""></td>
                            </tr>
                            <tr>
                                <th>Birth Date</th>
                                <th>:</th>
                                <td id=""BirthDate""></td>
                            </tr>
                            <tr>
                                <th>Address</th>
                                <th>:</th>
                                <td id=""Address""></td>
                            </tr>
                            <tr>
                                <th>Religion</th>
                                <th>:</th>
                                <td id=""Religion""></td>
        ");
            WriteLiteral(@"                    </tr>
                            <tr>
                                <th>Marital Status</th>
                                <th>:</th>
                                <td id=""MaritalStatus""></td>
                            </tr>
                            <tr>
                                <th>Nasionality</th>
                                <th>:</th>
                                <td id=""Nasionality""></td>
                            </tr>
                            <tr>
                                <th>Last Education</th>
                                <th>:</th>
                                <td id=""LastEducation""></td>
                            </tr>
                            <tr>
                                <th>GPA</th>
                                <th>:</th>
                                <td id=""GPA""></td>
                            </tr>
                            <tr>
                                <th>Experience</th>
        ");
            WriteLiteral(@"                        <th>:</th>
                                <td id=""Experience""></td>
                            </tr>
                            <tr>
                                <th>Achievement</th>
                                <th>:</th>
                                <td id=""Achievement""></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class=""modal-footer no-bd"">
");
            EndContext();
            BeginContext(3800, 1893, true);
            WriteLiteral(@"                    <button type=""button"" id=""approve"" class=""btn btn-outline-success"" data-dismiss=""modal"" onclick=""Approve()"">Approve</button>
                    <button type=""button"" id=""reject"" class=""btn btn-outline-danger"" data-dismiss=""modal"" onclick=""Reject()"">Reject</button>
                </div>
            </div>
        </div>
    </div>
    <!-- End Modal -->
    <!-- START PAGE CONTENT-->
    <div class=""page-heading"">
        <h1 class=""page-title"">DataTables</h1>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""index.html""><i class=""la la-home font-20""></i></a>
            </li>
            <li class=""breadcrumb-item"">DataTables</li>
        </ol>
    </div>
    <div class=""page-content fade-in-up"">
        <div class=""ibox"">
            <div class=""ibox-head"">
                <div class=""ibox-title"">Data Table</div>
            </div>
            <div class=""ibox-body"">
                <table class=""table table-striped ");
            WriteLiteral(@"table-bordered table-hover"" id=""Jobseeker"" cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr>
                            <th>No</th>
                            <th>JobSeeker Name</th>
                            <th>Job Title</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
    </div>
    <!-- END PAGE CONTENT-->
    <footer class=""page-footer"">
        <div class=""font-13"">2018 © <b>AdminCAST</b> - All rights reserved.</div>
        <a class=""px-4"" href=""http://themeforest.net/item/adminca-responsive-bootstrap-4-3-angular-4-admin-dashboard-template/20912589"" target=""_blank"">BUY PREMIUM</a>
        <div class=""to-top""><i class=""fa fa-angle-double-up""></i></div>
    </footer>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5710, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5716, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eb52b5cb8844573978b5e7b790dd3f3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5761, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5767, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80581d77ece4310898cb40f5b27bf3d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5814, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
