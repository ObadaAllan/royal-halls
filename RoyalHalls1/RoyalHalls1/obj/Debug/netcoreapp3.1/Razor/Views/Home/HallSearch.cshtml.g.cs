#pragma checksum "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb1274ef60fa463e04a01f39e0d605a50eaea767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HallSearch), @"mvc.1.0.view", @"/Views/Home/HallSearch.cshtml")]
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
#line 1 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\_ViewImports.cshtml"
using RoyalHalls1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\_ViewImports.cshtml"
using RoyalHalls1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1274ef60fa463e04a01f39e0d605a50eaea767", @"/Views/Home/HallSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807623d627cae2fe3f4f99c38da6379ec9428da2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_HallSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< RoyalHalls1.Models.Hall>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HallSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-mdb-ripple-color", new global::Microsoft.AspNetCore.Html.HtmlString("dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
  
    ViewData["Title"] = "HallSearch";
    Layout = "~/Views/Shared/_Layout.cshtml";

    ViewBag.userId = ViewBag.Uid ;
    ViewBag.home = ViewBag.h;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        \r\n\r\n\r\n\r\n\r\n      <div  class=\"our_room\">\r\n         <div class=\"container\">\r\n             \r\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb1274ef60fa463e04a01f39e0d605a50eaea7675604", async() => {
                WriteLiteral("\r\n            \r\n                <input type=\"text\" class=\"form-control\" name=\"search\" placeholder=\"search for hall\" />\r\n            <br />\r\n\r\n           <button type=\"submit\" class=\"btn btn-dark\">search</button>\r\n           \r\n          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <div class=""row"">

               <div class=""col-md-12"">
                  <div class=""titlepage"">
                     <h2>Our Halls</h2>
                     <p>Lorem Ipsum available, but the majority have suffered </p>
                  </div>
               </div>
            </div>
                 
            <div class=""row"">
");
#nullable restore
#line 41 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
                 foreach (var item in Model)
            {
             
               

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col-md-4 col-sm-6\">\r\n                  <div id=\"serv_hover\"  class=\"room\">\r\n\r\n                     <div class=\"room_img\">\r\n                        <figure><img style=\"width:350px;height:250px\"");
            BeginWriteAttribute("src", " src=", 1306, "", 1347, 1);
#nullable restore
#line 49 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
WriteAttributeValue("", 1311, Url.Content("~/Image/"+item.HPhoto), 1311, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\"  /></figure>\r\n                     </div>\r\n                     <div class=\"bed_room\">\r\n                        <h3>");
#nullable restore
#line 52 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
                       Write(item.HName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 53 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
                      Write(item.HDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <br>\r\n                        <i class=\"fa fa-map-marker\" style=\"font-size:25px;color:red\">");
#nullable restore
#line 55 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
                                                                                Write(item.HAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i><br>\r\n                        <br>\r\n                        <h1 class=\"card-title pricing-card-title\">$");
#nullable restore
#line 57 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
                                                              Write(item.HPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"text-muted\">/ Day</small></h1>\r\n                        <br>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb1274ef60fa463e04a01f39e0d605a50eaea76710368", async() => {
                WriteLiteral("more details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"
                                                                                                                             WriteLiteral(item.HId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n                     </div>\r\n\r\n                  </div>\r\n               </div>\r\n");
#nullable restore
#line 65 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\HallSearch.cshtml"

            }  

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n               \r\n                \r\n            \r\n           \r\n              \r\n           \r\n         </div>\r\n      </div>\r\n      \r\n      <!-- end our_room -->\r\n     ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< RoyalHalls1.Models.Hall>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591