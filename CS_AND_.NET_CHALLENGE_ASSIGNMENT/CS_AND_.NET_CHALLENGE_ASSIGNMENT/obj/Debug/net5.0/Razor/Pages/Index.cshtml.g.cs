#pragma checksum "C:\Users\vlarm\source\repos\CS_AND_.NET_CHALLENGE_ASSIGNMENT\CS_AND_.NET_CHALLENGE_ASSIGNMENT\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2453b44b7a369aed568f740e7aa37d07a88771bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CS_AND_.NET_CHALLENGE_ASSIGNMENT.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace CS_AND_.NET_CHALLENGE_ASSIGNMENT.Pages
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
#line 2 "C:\Users\vlarm\source\repos\CS_AND_.NET_CHALLENGE_ASSIGNMENT\CS_AND_.NET_CHALLENGE_ASSIGNMENT\Pages\_ViewImports.cshtml"
using CS_AND_.NET_CHALLENGE_ASSIGNMENT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2453b44b7a369aed568f740e7aa37d07a88771bf", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11470c159baa93d96952b6eb13d97ff6d916a1e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vlarm\source\repos\CS_AND_.NET_CHALLENGE_ASSIGNMENT\CS_AND_.NET_CHALLENGE_ASSIGNMENT\Pages\Index.cshtml"
  
    ViewData["Title"] = "Hauptseite";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <!-- Customize the CSHTML <h2> element with text of your choosing -->
    <h1 class=""display-4"">Hallo zussammen! <br /><br />Willkommen in dieser einfachen Web-App</h1>
    <br />
    <br />

    <!-- This razor syntax below will display the actual server time in the browser -->
    <p>Observe here that the current server time is: <strong>");
#nullable restore
#line 14 "C:\Users\vlarm\source\repos\CS_AND_.NET_CHALLENGE_ASSIGNMENT\CS_AND_.NET_CHALLENGE_ASSIGNMENT\Pages\Index.cshtml"
                                                        Write(ViewData["ServerTime"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <br />\r\n    <br />\r\n    <p>Learn all the things and stuff! <a href=\"https://docs.microsoft.com/aspnet/core\">Be cool and build Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
