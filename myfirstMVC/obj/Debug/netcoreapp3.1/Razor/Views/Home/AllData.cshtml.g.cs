#pragma checksum "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6369b1a4a99d3f97fed8bf623a287afcb8506164"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6369b1a4a99d3f97fed8bf623a287afcb8506164", @"/Views/Home/AllData.cshtml")]
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
<div class=""row table-div my-3"">
    <div class=""col-12 my-3 upper-btn"">
        <button class=""btn btn-primary"" id=""add-user"">New</button>


    </div>
    <div class=""col-8 m-auto py-2"">
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
            <tbody id=""add-row"">
");
#nullable restore
#line 26 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 819, "\"", 834, 1);
#nullable restore
#line 28 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
WriteAttributeValue("", 824, item.U_id, 824, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <th scope=\"row\">");
#nullable restore
#line 29 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                                   Write(item.U_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                       Write(item.Psw);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button class=\"btn btn-primary\" id=\"edit-btn\"");
            BeginWriteAttribute("value", " value=\"", 1103, "\"", 1121, 1);
#nullable restore
#line 33 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
WriteAttributeValue("", 1111, item.U_id, 1111, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-pen-to-square\"></i></button></td>\r\n                        <td><button class=\"btn btn-danger\" id=\"delete-btn\"");
            BeginWriteAttribute("value", " value=\"", 1254, "\"", 1272, 1);
#nullable restore
#line 34 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
WriteAttributeValue("", 1262, item.U_id, 1262, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-trash\"></i></button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Nitesh Gupta\source\repos\myfirstMVC\myfirstMVC\Views\Home\AllData.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </tbody>
        </table>

        
    </div>
    <div class=""col-12 my-1 d-flex justify-content-center lower-btn"">
        <button class=""btn btn-primary mx-2 hide"" id=""save"">Save</button>
        <button class=""btn btn-warning hide"" id=""update"">Update</button>

    </div>
</div>

");
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
