#pragma checksum "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a97c765db024a409573eb996eabf6d8008f46dc960d539645baad544f13c15d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Edit), @"mvc.1.0.view", @"/Views/Student/Edit.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a97c765db024a409573eb996eabf6d8008f46dc960d539645baad544f13c15d3", @"/Views/Student/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"35f6ccac35bf5b6580930131dd8a00f4fbff89fbaff8a6ea9c72496c82fab2a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.NewFolder.Registrants>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
  
    ViewBag.Title = "Edit Student";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>");
            Write(
#nullable restore
#line 7 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
     ViewBag.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
 using (Html.BeginForm("Edit", "Student", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 11 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
     Html.AntiForgeryToken()

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 13 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
     if (TempData["SuccessMessage"] != null)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
            Write(
#nullable restore
#line 16 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             TempData["SuccessMessage"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div style=\"display:flex;flex-direction:column;align-items:center\">\r\n        <div>\r\n            ");
            Write(
#nullable restore
#line 21 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.LabelFor(m => m.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 22 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.TextBoxFor(m => m.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 23 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.ValidationMessageFor(m => m.Name, "", new { style = "color:red;" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
            Write(
#nullable restore
#line 27 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.LabelFor(m => m.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 28 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.TextBoxFor(m => m.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 29 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.ValidationMessageFor(m => m.Email, "", new { style = "color:red;" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
            Write(
#nullable restore
#line 33 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.LabelFor(m => m.Mobile)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 34 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.TextBoxFor(m => m.Mobile)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 35 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.ValidationMessageFor(m => m.Mobile, "", new { style = "color:red;" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
            Write(
#nullable restore
#line 39 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.LabelFor(m => m.State)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 40 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.DropDownListFor(m => m.State, new SelectList((IEnumerable<string>)ViewBag.States), "Select State", new { @class = "state-dropdown" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n");
            WriteLiteral("            ");
            Write(
#nullable restore
#line 42 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.ValidationMessageFor(m => m.State, "", new { style = "color:red;" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
            Write(
#nullable restore
#line 46 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.LabelFor(m => m.City)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 47 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.DropDownListFor(m => m.City, new SelectList((List<string>)ViewBag.Cities), "Select City")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 48 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.ValidationMessageFor(m => m.City, "", new { style = "color:red;" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
            Write(
#nullable restore
#line 52 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.LabelFor(m => m.AboutYourself)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 53 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.TextAreaFor(m => m.AboutYourself)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 54 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.ValidationMessageFor(m => m.AboutYourself, "", new { style = "color:red;" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
            Write(
#nullable restore
#line 58 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.LabelFor(m => m.Photo)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 59 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.TextBoxFor(m => m.Photo, new { type = "file" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 60 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
             Html.ValidationMessageFor(m => m.Photo, "", new { style = "color:red;" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div>\r\n            <button class=\" btn btn-primary\" type=\"submit\">Submit</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 68 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\"", 2348, "\"", 2385, 1);
            WriteAttributeValue("", 2355, 
#nullable restore
#line 70 "C:\Users\Purendra\Source\Repos\WebApplication3\WebApplication3\Views\Student\Edit.cshtml"
          Url.Action("List", "Student")

#line default
#line hidden
#nullable disable
            , 2355, 30, false);
            EndWriteAttribute();
            WriteLiteral(">Back to Student List</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.NewFolder.Registrants> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
