#pragma checksum "C:\Users\User1-PC\Desktop\almost ready\BoutiquePresentsWorkshop\BoutiquePresentsWorkshop\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3c6d2ecdb88e20eecc9a4717bfe26b047ecdbafc0d64b7114bc58b436aaf1e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\User1-PC\Desktop\almost ready\BoutiquePresentsWorkshop\BoutiquePresentsWorkshop\Views\_ViewImports.cshtml"
using BoutiquePresentsWorkshop;

#line default
#line hidden
#line 2 "C:\Users\User1-PC\Desktop\almost ready\BoutiquePresentsWorkshop\BoutiquePresentsWorkshop\Views\_ViewImports.cshtml"
using BoutiquePresentsWorkshop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3c6d2ecdb88e20eecc9a4717bfe26b047ecdbafc0d64b7114bc58b436aaf1e42", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c755ce7b45c5afe180304957644db2dd81797c48084252010e6e574e3f790c35", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User1-PC\Desktop\almost ready\BoutiquePresentsWorkshop\BoutiquePresentsWorkshop\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(60, 116, true);
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
            EndContext();
#line 9 "C:\Users\User1-PC\Desktop\almost ready\BoutiquePresentsWorkshop\BoutiquePresentsWorkshop\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(204, 51, true);
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(256, 15, false);
#line 12 "C:\Users\User1-PC\Desktop\almost ready\BoutiquePresentsWorkshop\BoutiquePresentsWorkshop\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(271, 17, true);
            WriteLiteral("</code>\n    </p>\n");
            EndContext();
#line 14 "C:\Users\User1-PC\Desktop\almost ready\BoutiquePresentsWorkshop\BoutiquePresentsWorkshop\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(290, 566, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
