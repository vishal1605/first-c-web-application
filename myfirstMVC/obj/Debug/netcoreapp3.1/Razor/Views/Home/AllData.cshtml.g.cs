#pragma checksum "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c0da768e21f60ccc398f8ae15a648aca7da75b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllData), @"mvc.1.0.view", @"/Views/Home/AllData.cshtml")]
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
#line 1 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\_ViewImports.cshtml"
using myfirstMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\_ViewImports.cshtml"
using myfirstMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c0da768e21f60ccc398f8ae15a648aca7da75b", @"/Views/Home/AllData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6633002b4ef0308088b34e2716ce9f4fa5b8fc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "AllData";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row my-5"">
    <div class=""col-8 m-auto py-3"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Password</th>
                    <th scope=""col"">Edit</th>
                    <th scope=""col"">Delete</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                               Write(item.U_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                   Write(item.Psw);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 905, 2);
            WriteAttributeValue("", 883, "EditProcess/", 883, 12, true);
#nullable restore
#line 28 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
WriteAttributeValue("", 895, item.U_id, 895, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fa-solid fa-pen-to-square\"></i></a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1009, "\"", 1033, 2);
            WriteAttributeValue("", 1016, "Delete/", 1016, 7, true);
#nullable restore
#line 29 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
WriteAttributeValue("", 1023, item.U_id, 1023, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fa-solid fa-trash\"></i></a></td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
