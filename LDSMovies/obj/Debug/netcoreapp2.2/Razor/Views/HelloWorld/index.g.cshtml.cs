#pragma checksum "C:\Users\humbl\source\repos\LDSMovies\LDSMovies\Views\HelloWorld\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12c42795cdb5932237b079af70acb0d4f260233"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_index), @"mvc.1.0.view", @"/Views/HelloWorld/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/index.cshtml", typeof(AspNetCore.Views_HelloWorld_index))]
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
#line 1 "C:\Users\humbl\source\repos\LDSMovies\LDSMovies\Views\_ViewImports.cshtml"
using LDSMovies;

#line default
#line hidden
#line 2 "C:\Users\humbl\source\repos\LDSMovies\LDSMovies\Views\_ViewImports.cshtml"
using LDSMovies.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12c42795cdb5932237b079af70acb0d4f260233", @"/Views/HelloWorld/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d03525c2ff293d6bcf8014e4bf1146b6832a080", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\humbl\source\repos\LDSMovies\LDSMovies\Views\HelloWorld\index.cshtml"
  
    ViewData["Title"] = "Movie List";

#line default
#line hidden
            BeginContext(46, 66, true);
            WriteLiteral("\r\n<h2>My Movie List</h2>\r\n\r\n\r\n<p>Hello from our View Template!</p>");
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
