#pragma checksum "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\Shared\ReservationSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5609ca9bc2dcda66731eb81f6bdcc9b800eba645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ReservationSummary), @"mvc.1.0.view", @"/Views/Shared/ReservationSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ReservationSummary.cshtml", typeof(AspNetCore.Views_Shared_ReservationSummary))]
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
#line 1 "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\_ViewImports.cshtml"
using TennisFormFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5609ca9bc2dcda66731eb81f6bdcc9b800eba645", @"/Views/Shared/ReservationSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ec458e9395451d1e531132245cc14b802da4da", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ReservationSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TennisFormFinal.Models.TennisReservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 24, true);
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(75, 46, false);
#line 4 "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Court.Name));

#line default
#line hidden
            EndContext();
            BeginContext(121, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(153, 51, false);
#line 7 "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Html.DisplayFor(modelItem => Model.ReservationTime));

#line default
#line hidden
            EndContext();
            BeginContext(204, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(236, 45, false);
#line 10 "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Html.DisplayFor(modelItem => Model.MatchType));

#line default
#line hidden
            EndContext();
            BeginContext(281, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(313, 46, false);
#line 13 "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Court.Type));

#line default
#line hidden
            EndContext();
            BeginContext(359, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(391, 16, false);
#line 16 "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
   Write(Model.GetPrice());

#line default
#line hidden
            EndContext();
            BeginContext(407, 33, true);
            WriteLiteral("\r\n    </td>\r\n\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(440, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd28d19b07df45748c839a7d71257b5b", async() => {
                BeginContext(499, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Allievo 6\Documents\GitHub\TennisBello\TennisFormFinal\Views\Shared\ReservationSummary.cshtml"
                                 WriteLiteral(Model.ReservationId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(509, 20, true);
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TennisFormFinal.Models.TennisReservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
