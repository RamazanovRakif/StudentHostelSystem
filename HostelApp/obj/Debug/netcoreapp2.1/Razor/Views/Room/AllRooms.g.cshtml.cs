#pragma checksum "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c18b25cb40723536362beea1b91f1ecc3de2e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_AllRooms), @"mvc.1.0.view", @"/Views/Room/AllRooms.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/AllRooms.cshtml", typeof(AspNetCore.Views_Room_AllRooms))]
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
#line 1 "D:\HostelSystem-Simple--master\HostelApp\Views\_ViewImports.cshtml"
using HostelApp.Models;

#line default
#line hidden
#line 2 "D:\HostelSystem-Simple--master\HostelApp\Views\_ViewImports.cshtml"
using HostelApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c18b25cb40723536362beea1b91f1ecc3de2e6", @"/Views/Room/AllRooms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f6ad44358bdc6050d50d7cdf1c1c5d2e640509", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_AllRooms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Room", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
  
    ViewData["Title"] = "AllRooms";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(117, 355, true);
            WriteLiteral(@"
<section class=""mg-best-rooms pt-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""mg-sec-title undefined"">
                    <h2>All Rooms</h2>
                    <p>These best rooms chosen by our customers</p>
                </div>
                <div class=""row"">
");
            EndContext();
#line 16 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                     foreach (var room in Model)
                    {

#line default
#line hidden
            BeginContext(545, 102, true);
            WriteLiteral("                        <div class=\"col-md-4\">\r\n                            <figure class=\"mg-room\">\r\n");
            EndContext();
#line 20 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                                 for (int i = 0; i < room.RoomImages.Count(); i++)
                                {

#line default
#line hidden
            BeginContext(766, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(802, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31f27a137eaa4a59a80aae62c59fc0d5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 814, "height:", 814, 7, true);
            AddHtmlAttributeValue(" ", 821, "208px;", 822, 7, true);
#line 22 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
AddHtmlAttributeValue("", 828, i==0? "display:block;" : "display:none;", 828, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 896, "~/images/room/", 896, 14, true);
#line 22 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
AddHtmlAttributeValue("", 910, room.RoomImages.ElementAt(i).Image, 910, 35, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(961, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                                }

#line default
#line hidden
            BeginContext(998, 86, true);
            WriteLiteral("                                <figcaption>\r\n                                    <h2>");
            EndContext();
            BeginContext(1085, 26, false);
#line 25 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                                   Write(room.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 253, true);
            WriteLiteral("</h2>\r\n                                    <div class=\"mg-room-rating\">\r\n                                        <i class=\"fa fa-star\"> </i> 5.0\r\n                                    </div>\r\n                                    <div class=\"mg-room-price\">");
            EndContext();
            BeginContext(1365, 10, false);
#line 29 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                                                          Write(room.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 64, true);
            WriteLiteral("<sup>/Month</sup></div>\r\n                                    <p>");
            EndContext();
            BeginContext(1440, 16, false);
#line 30 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                                  Write(room.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 4, true);
            WriteLiteral("</p>");
            EndContext();
            BeginContext(1460, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dbf9aed0c6c40089d9760903ee05d82", async() => {
                BeginContext(1551, 52, true);
                WriteLiteral("View Details<i class=\"fa fa-angle-double-right\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                                                                                                                                 WriteLiteral(room.ID);

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
            BeginContext(1607, 120, true);
            WriteLiteral("\r\n                                </figcaption>\r\n                            </figure>\r\n                        </div>\r\n");
            EndContext();
#line 34 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\AllRooms.cshtml"
                    }

#line default
#line hidden
            BeginContext(1750, 82, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591