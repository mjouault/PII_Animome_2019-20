#pragma checksum "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a403759f9612c9a7bf8f8d0574fd002752bc4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUsers_AfficherProfil), @"mvc.1.0.view", @"/Views/ApplicationUsers/AfficherProfil.cshtml")]
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
#line 1 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\_ViewImports.cshtml"
using Animome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\_ViewImports.cshtml"
using Animome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a403759f9612c9a7bf8f8d0574fd002752bc4ad", @"/Views/ApplicationUsers/AfficherProfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21ed7cf7323d5833c2f71efd428528c776b44d1", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationUsers_AfficherProfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Animome.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
  
    ViewData["Title"] = "AfficherProfil";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Profil</h1>\r\n<dl>\r\n    <dt>\r\n        ");
#nullable restore
#line 11 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 15 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
   Write(Html.DisplayFor(Model => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
   Write(Html.DisplayFor(Model => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 19 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 22 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 25 "C:\Users\Maurine\Documents\ENSC\2A_ENSC\S8\PII\Animome\Animome\Views\ApplicationUsers\AfficherProfil.cshtml"
   Write(Html.DisplayNameFor(Model => Model.LesDomaineUsers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dt>\r\n    </dt>\r\n\r\n\r\n\r\n\r\n</dl>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Animome.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
