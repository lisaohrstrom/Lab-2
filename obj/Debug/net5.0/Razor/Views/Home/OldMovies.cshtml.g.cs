#pragma checksum "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede4bff323fff34298de6d54512286b3f26ccb5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OldMovies), @"mvc.1.0.view", @"/Views/Home/OldMovies.cshtml")]
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
#line 1 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\_ViewImports.cshtml"
using MovieLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\_ViewImports.cshtml"
using MovieLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede4bff323fff34298de6d54512286b3f26ccb5d", @"/Views/Home/OldMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991a69292ea27371af9a9dc4685e2126a27328ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OldMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml"
  
    ViewData["Title"] = "Old Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Old Movies</h1><br>\r\n<h4>Here you can find ");
#nullable restore
#line 8 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml"
                 Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" movies released before the year 2000.</h4>\r\n<p>Ordered by the newest first:</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 12 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml"
      
            foreach (var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 306, "\"", 342, 2);
            WriteAttributeValue("", 313, "/Home/SelectedMovie/", 313, 20, true);
#nullable restore
#line 15 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml"
WriteAttributeValue("", 333, movie.Id, 333, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml"
                                                       Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</a> ");
#nullable restore
#line 15 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml"
                                                                         Write(movie.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\OldMovies.cshtml"
            }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591