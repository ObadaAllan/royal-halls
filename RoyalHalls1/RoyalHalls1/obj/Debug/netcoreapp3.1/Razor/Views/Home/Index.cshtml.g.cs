#pragma checksum "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee1685fba29546acea6540ebfa5b7aa7090c8d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee1685fba29546acea6540ebfa5b7aa7090c8d16", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807623d627cae2fe3f4f99c38da6379ec9428da2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<RoyalHalls1.Models.Home,RoyalHalls1.Models.About,IEnumerable<RoyalHalls1.Models.Hall>,IEnumerable<RoyalHalls1.Models.Testimonial>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:700px;height:350px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-mdb-ripple-color", new global::Microsoft.AspNetCore.Html.HtmlString("dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.userId = ViewBag.Uid ;
    ViewBag.home = Model.Item1;



#line default
#line hidden
#nullable disable
            WriteLiteral(@"

      <section class=""banner_main"">

         <div id=""myCarousel"" class=""carousel slide banner"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
               <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
               <li data-target=""#myCarousel"" data-slide-to=""1""></li>
               <li data-target=""#myCarousel"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
               <div class=""carousel-item active"">
                  <img style=""width:100%;height:700px"" class=""first-slide""");
            BeginWriteAttribute("src", " src=", 891, "", 942, 1);
#nullable restore
#line 23 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
WriteAttributeValue("", 896, Url.Content("~/Image/" + Model.Item1.SImage1), 896, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                  <div class=\"container\">\r\n                  </div>\r\n               </div>\r\n               <div class=\"carousel-item\">\r\n                  <img style=\"width:100%;height:700px\" class=\"second-slide\"");
            BeginWriteAttribute("src", " src=", 1174, "", 1225, 1);
#nullable restore
#line 28 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1179, Url.Content("~/Image/" + Model.Item1.SImage2), 1179, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Second slide\">\r\n               </div>\r\n               <div class=\"carousel-item\">\r\n                  <img style=\"width:100%;height:700px\" class=\"third-slide\"");
            BeginWriteAttribute("src", " src=", 1388, "", 1439, 1);
#nullable restore
#line 31 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1393, Url.Content("~/Image/" + Model.Item1.SImage3), 1393, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Third slide"">
               </div>
            </div>
            <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
            </a>
         </div>

         
      </section>
      <!-- end banner -->
      <!-- about -->
      <div class=""about"" id=""About"">
         <div class=""container-fluid"">
            <div class=""row"">
               <div class=""col-md-5"">
                  <div class=""titlepage"">
                     <h2>About Us</h2>

                     <h3>");
#nullable restore
#line 55 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                    Write(Model.Item2.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                     <p>");
#nullable restore
#line 57 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                   Write(Model.Item2.Descriotion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                  </div>\r\n               </div>\r\n               <div class=\"col-md-7\">\r\n                  <div class=\"about_img\">\r\n                     <figure>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee1685fba29546acea6540ebfa5b7aa7090c8d1610278", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                                                           WriteLiteral(Url.Content("~/Image/" + Model.Item2.Photo));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 63 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                     </figure>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- end about -->
      <!-- our_room -->

      <div  class=""our_room"">
         <div class=""container"">
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
#line 85 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                 foreach (var item in Model.Item3)
            {
             

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col-md-4 col-sm-6\">\r\n                  <div id=\"serv_hover\"  class=\"room\">\r\n                     <div class=\"room_img\">\r\n                        <figure><img style=\"width:350px;height:250px\"");
            BeginWriteAttribute("src", " src=", 3623, "", 3664, 1);
#nullable restore
#line 91 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
WriteAttributeValue("", 3628, Url.Content("~/Image/"+item.HPhoto), 3628, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\"  /></figure>\r\n                     </div>\r\n                     <div class=\"bed_room\">\r\n                        <h3>");
#nullable restore
#line 94 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                       Write(item.HName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 95 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                      Write(item.HDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <br>\r\n                        <i class=\"fa fa-map-marker\" style=\"font-size:25px;color:red\">");
#nullable restore
#line 97 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                                                                                Write(item.HAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i><br>\r\n                        <br>\r\n                        <h1 class=\"card-title pricing-card-title\">$");
#nullable restore
#line 99 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                                                              Write(item.HPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"text-muted\">/ Day</small></h1>\r\n                        <br>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee1685fba29546acea6540ebfa5b7aa7090c8d1615619", async() => {
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
#line 101 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n\r\n\r\n                     </div>\r\n                  </div>\r\n               </div>\r\n");
#nullable restore
#line 107 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
            }  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
               
                
            
           
              
           
         </div>
      </div>
      <!-- end our_room -->

      <!-- testimonial -->

    <section>
  <div class=""row d-flex justify-content-center"">
    <div class=""col-md-10 col-xl-8 text-center"">
      <h3 class=""mb-4"">Testimonials</h3>
      <p class=""mb-4 pb-2 mb-md-5 pb-md-0"">
        Here is some reviews form client on our services
      </p>

    </div>
  </div>


  <div class=""row text-center d-flex align-items-stretch"">

");
#nullable restore
#line 135 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
       foreach (var item in Model.Item4)
      {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     <div class=""col-md-4 mb-5 mb-md-5d-flex align-items-stretch"">

       <div class=""card testimonial-card"">
         <div class=""card-up"" style=""background-color: #9d589b;""></div>
         <div class=""avatar mx-auto bg-white"">
          <img style=""width:150px;height:150px""");
            BeginWriteAttribute("src", " src=", 5351, "", 5396, 1);
#nullable restore
#line 143 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
WriteAttributeValue("", 5356, Url.Content("~/Image/"+item.User.Photo), 5356, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n            class=\"rounded-circle img-fluid\" />\r\n         </div>\r\n         <div class=\"card-body\">\r\n          <h4 class=\"mb-4\">");
#nullable restore
#line 147 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                      Write(item.User.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 147 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                                       Write(item.User.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n          <hr />\r\n          <p class=\"dark-grey-text mt-4\">\r\n            <i class=\"fas fa-quote-left pe-2\"></i>");
#nullable restore
#line 150 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"
                                             Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </p>\r\n         </div>\r\n       </div>\r\n\r\n\r\n     </div>      \n");
#nullable restore
#line 157 "D:\tahaluf training\FirstProject\RoyalHalls1\RoyalHalls1\Views\Home\Index.cshtml"


      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    
  </div>

</section>

      <!-- end testimonial -->



      <!--  contact -->
      <div class=""contact"" id=""Contact"">
         <div class=""container"">
            <div class=""row"">
               <div class=""col-md-12"">
                  <div class=""titlepage"">
                     <h2>Contact Us</h2>
                  </div>
               </div>
            </div>
            <div class=""row"">
               <div class=""col-md-6"">
                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee1685fba29546acea6540ebfa5b7aa7090c8d1621665", async() => {
                WriteLiteral(@"
                     <div class=""row"">
                        <div class=""col-md-12 "">
                           <input class=""contactus"" type=""text""  placeholder=""Name""  name=""Name""> 
                        </div>
                        <div class=""col-md-12"">
                           <input class=""contactus"" type=""text""  placeholder=""Email""   name=""email""> 
                        </div>
                        <div class=""col-md-12"">
                           <input class=""contactus"" type=""text"" name=""phone"" placeholder=""Phone Number"" >                          
                        </div>
                        <div class=""col-md-12"">
                           <textarea class=""textarea"" name=""text""  placeholder=""Message"" Message=""Name"">Message</textarea>
                        </div>
                        <div class=""col-md-12"">
                           <button class=""send_btn"">Send</button>
                        </div>
                     </div>
                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
               </div>
               <div class=""col-md-6"">
                  <div class=""map_main"">
                     <div class=""map-responsive"">
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d433870.82683883054!2d36.227826049425936!3d31.83545332308035!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x151b5fb85d7981af%3A0x631c30c0f8dc65e8!2z2LnZhdmR2KfZhg!5e0!3m2!1sar!2sjo!4v1664404541744!5m2!1sar!2sjo"" width=""600"" height=""400"" frameborder=""0"" style=""border:0; width: 100%;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 7872, "\"", 7890, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n                     </div>\r\n                  </div>\r\n               </div>\r\n            </div>\r\n         </div>\r\n      </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<RoyalHalls1.Models.Home,RoyalHalls1.Models.About,IEnumerable<RoyalHalls1.Models.Hall>,IEnumerable<RoyalHalls1.Models.Testimonial>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
