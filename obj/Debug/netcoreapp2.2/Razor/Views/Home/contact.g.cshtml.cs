#pragma checksum "H:\TP\TP\Views\Home\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30be012adc3d2cf3905884529b417199347f47d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contact), @"mvc.1.0.view", @"/Views/Home/contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/contact.cshtml", typeof(AspNetCore.Views_Home_contact))]
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
#line 1 "H:\TP\TP\Views\_ViewImports.cshtml"
using TP;

#line default
#line hidden
#line 2 "H:\TP\TP\Views\_ViewImports.cshtml"
using TP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30be012adc3d2cf3905884529b417199347f47d2", @"/Views/Home/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e02f271512f7ee2bc5afc1efbb038cd21b8d727b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "H:\TP\TP\Views\Home\contact.cshtml"
  
    ViewData["Title"] = "contact";

#line default
#line hidden
            BeginContext(43, 1928, true);
            WriteLiteral(@"
<section class=""hero-wrap"" style=""background-image: url(images/bg_1.jpg);"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters text align-items-end justify-content-center"" data-scrollax-parent=""true"">
            <div class=""col-md-8 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index-2.html"">Home</a></span> <span>Contact</span></p>
                <h1 class=""mb-5 bread"">Contact Us</h1>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section contact-section"">
    <div class=""container mt-5"">
        <div class=""row block-9"">
            <div class=""col-md-4 order-last contact-info ftco-animate"">
                <div class=""row"">
                    <div class=""col-md-12 mb-4"">
                        <h2>Contact Information</h2>
                    </div>
                    <div class=""col-md-12 mb-3"">
                        <p><span>Address:</span> 198 West 21th Str");
            WriteLiteral(@"eet, Suite 721 New York NY 10016</p>
                    </div>
                    <div class=""col-md-12 mb-3"">
                        <p><span>Phone:</span> <a href=""tel://1234567920"">+ 1235 2355 98</a></p>
                    </div>
                    <div class=""col-md-12 mb-3"">
                        <p><span>Email:</span> <a href=""https://colorlib.com/cdn-cgi/l/email-protection#2841464e476851475d5a5b415c4d064b4745""><span class=""__cf_email__"" data-cfemail=""f79e999198b78e988285849e8392d994989a"">[email&#160;protected]</span></a></p>
                    </div>
                    <div class=""col-md-12 mb-3"">
                        <p><span>Website:</span> <a href=""#"">yoursite.com</a></p>
                    </div>
                </div>
            </div>
            <div class=""col-md-1""></div>
            <div class=""col-md-6 order-first ftco-animate"">
                ");
            EndContext();
            BeginContext(1971, 882, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30be012adc3d2cf3905884529b417199347f47d25657", async() => {
                BeginContext(1988, 858, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Your Name"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Your Email"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Subject"">
                    </div>
                    <div class=""form-group"">
<textarea name="""" id="""" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Message""></textarea>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-3 px-5"">
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2853, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
