#pragma checksum "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5109fee324d34e3bb132a044080a3c45d55bd3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SelectedActor), @"mvc.1.0.view", @"/Views/Home/SelectedActor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5109fee324d34e3bb132a044080a3c45d55bd3b", @"/Views/Home/SelectedActor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991a69292ea27371af9a9dc4685e2126a27328ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SelectedActor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Actor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
  
    ViewData["Title"] = "Selected Actor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
                Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br>\r\n<h3>Takes part in the following movies:</h3>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
      
            foreach (var movie in Model.Movies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 259, "\"", 295, 2);
            WriteAttributeValue("", 266, "/Home/SelectedMovie/", 266, 20, true);
#nullable restore
#line 14 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
WriteAttributeValue("", 286, movie.Id, 286, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
                                                       Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>, ");
#nullable restore
#line 14 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
                                                                          Write(movie.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\Users\demo\OneDrive\Skrivbord\lab2-lisaohrstrom-main\Views\Home\SelectedActor.cshtml"
            }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Actor> Html { get; private set; }
    }
}
#pragma warning restore 1591
