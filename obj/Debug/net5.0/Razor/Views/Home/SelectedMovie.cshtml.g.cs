#pragma checksum "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3dcb62d2781ae17dc956e38b53f1836162e9156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SelectedMovie), @"mvc.1.0.view", @"/Views/Home/SelectedMovie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3dcb62d2781ae17dc956e38b53f1836162e9156", @"/Views/Home/SelectedMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991a69292ea27371af9a9dc4685e2126a27328ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SelectedMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
  
    ViewData["Title"] = "Selected Movie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><br>\r\n\r\n<p><b>Genre:</b> ");
#nullable restore
#line 9 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
            Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<p><b>Release Year:</b> ");
#nullable restore
#line 10 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
                   Write(Model.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<p><b>Actors:</b> </p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
      
            foreach (var actor in Model.Actors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 302, "\"", 338, 2);
            WriteAttributeValue("", 309, "/Home/SelectedActor/", 309, 20, true);
#nullable restore
#line 16 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
WriteAttributeValue("", 329, actor.Id, 329, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
                                                       Write(actor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
                                                                        Write(actor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 17 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedMovie.cshtml"
            }
    

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
