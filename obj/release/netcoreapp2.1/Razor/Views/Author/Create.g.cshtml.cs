#pragma checksum "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "211a8d7ec631ee35fafff838d41d564b59f1d475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Create), @"mvc.1.0.view", @"/Views/Author/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Create.cshtml", typeof(AspNetCore.Views_Author_Create))]
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
#line 1 "C:\Users\d.hedtke\Desktop\u\Views\_ViewImports.cshtml"
using u;

#line default
#line hidden
#line 2 "C:\Users\d.hedtke\Desktop\u\Views\_ViewImports.cshtml"
using u.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211a8d7ec631ee35fafff838d41d564b59f1d475", @"/Views/Author/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29fdfc10703ed83b319158412a633a7de600cb67", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFCoreWebDemo.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
  
    ViewBag.Title = "New Author";

#line default
#line hidden
            BeginContext(71, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(78, 13, false);
#line 6 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(91, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
            BeginContext(127, 32, true);
            WriteLiteral("  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(160, 39, false);
#line 10 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(199, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(206, 71, false);
#line 11 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
Write(Html.TextBoxFor(model => model.FirstName, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(277, 45, true);
            WriteLiteral(" \r\n  </div>\r\n  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(323, 38, false);
#line 14 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(361, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(368, 70, false);
#line 15 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
Write(Html.TextBoxFor(model => model.LastName, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(438, 78, true);
            WriteLiteral(" \r\n  </div>\r\n  <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n");
            EndContext();
#line 18 "C:\Users\d.hedtke\Desktop\u\Views\Author\Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFCoreWebDemo.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
