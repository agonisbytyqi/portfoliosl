#pragma checksum "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d6a88cbf21dced66f9c53e29d15a6ca130b47e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\_ViewImports.cshtml"
using PortfolioStarlab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\_ViewImports.cshtml"
using PortfolioStarlab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d6a88cbf21dced66f9c53e29d15a6ca130b47e", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8cfbca27fe609d0afbc2b8833abcaa06714679", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioStarlab.Models.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""fancy""><span></span></div>
<h2 style=""color: black; text-align: center;"">CONTACT ME</h2>
<div id=""contact"" class=""section"" style=""display: flex;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-5 col-lg-offset-1 col-md-6 wow fadeInUp"" data-wow-delay=""0.6s"">
                <address>
                    <p><i class=""fa fa-phone""></i> +38349875338</p>
                    <p><i class=""fa fa-envelope-o""></i> bytyqiagonis@gmail.com</p>
                    <p><i class=""fa fa-map-marker""></i> Gjakove</p>
                </address>
            </div>
            <div class=""col-lg-6 col-md-6 col-xs-10 wow fadeInUp"" data-wow-delay=""0.6s"">
");
#nullable restore
#line 16 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml"
                 using (Html.BeginForm("Create", "Contacts", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml"
               Write(Html.TextBoxFor(m => m.FullName, new { @placeholder = "Full Name" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml"
               Write(Html.TextBoxFor(m => m.Message, new { @placeholder = "Message" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml"
               Write(Html.TextBoxFor(m => m.PhoneNumber, new { @placeholder = "Phone Number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input name=\"send\" type=\"submit\" class=\"form-control\" id=\"send\" value=\"SEND ME\">\r\n");
#nullable restore
#line 24 "C:\Users\BesiService\source\repos\portfoliosl\PortfolioStarlab\PortfolioStarlab\Views\Home\Contact.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-1 col-sm-1\"></div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioStarlab.Models.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591