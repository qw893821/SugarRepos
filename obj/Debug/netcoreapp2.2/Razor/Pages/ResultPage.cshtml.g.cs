#pragma checksum "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\ResultPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4cfcb8316fef9267b6c8960041a46281b60684e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(sugarrepo.Pages.Pages_ResultPage), @"mvc.1.0.razor-page", @"/Pages/ResultPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ResultPage.cshtml", typeof(sugarrepo.Pages.Pages_ResultPage), null)]
namespace sugarrepo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\_ViewImports.cshtml"
using sugarrepo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4cfcb8316fef9267b6c8960041a46281b60684e", @"/Pages/ResultPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6811ab3fc414e982e23afe3ebb2cf884ec3c915", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ResultPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\ResultPage.cshtml"
 if (Model.sugar == null)
{

#line default
#line hidden
            BeginContext(84, 30, true);
            WriteLiteral("    <p>Product Not Found</p>\r\n");
            EndContext();
#line 8 "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\ResultPage.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(126, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(130, 17, false);
#line 11 "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\ResultPage.cshtml"
Write(Model.sugar.UPCNo);

#line default
#line hidden
            EndContext();
            BeginContext(147, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(157, 17, false);
#line 12 "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\ResultPage.cshtml"
Write(Model.sugar.NDBNo);

#line default
#line hidden
            EndContext();
            BeginContext(174, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(184, 20, false);
#line 13 "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\ResultPage.cshtml"
Write(Model.sugar.LongName);

#line default
#line hidden
            EndContext();
            BeginContext(204, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "C:\Users\xiuma\Documents\GitHub\SugarRepo\SugarRepos\Pages\ResultPage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sugarrepo.Pages.ResultPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<sugarrepo.Pages.ResultPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<sugarrepo.Pages.ResultPageModel>)PageContext?.ViewData;
        public sugarrepo.Pages.ResultPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
