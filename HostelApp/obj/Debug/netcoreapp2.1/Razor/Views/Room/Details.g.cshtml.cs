#pragma checksum "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4fa59137b7cb10dbdc7b292e9136783d153973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Details), @"mvc.1.0.view", @"/Views/Room/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/Details.cshtml", typeof(AspNetCore.Views_Room_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4fa59137b7cb10dbdc7b292e9136783d153973", @"/Views/Room/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f6ad44358bdc6050d50d7cdf1c1c5d2e640509", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/hosteladmin/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/hosteladmin/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slider image "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/hosteladmin/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(98, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(99, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7414430d3e0548cf98ea8240a75e14b6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(164, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2309685e0336421ca154b4984588072f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 319, true);
            WriteLiteral(@"


<div class="""" style=""height:700px; padding:150px 0 200px 0; "">
    <div class=""col-md-4"" style=""padding-bottom:50px;"">
        <div class=""form-group"">
            <div class=""col-md-6"">
                <label class=""control-label"">Room Number:</label>
            </div>
            <input type=""hidden"" id=""roomId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 542, "\"", 559, 1);
#line 17 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
WriteAttributeValue("", 550, Model.ID, 550, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(560, 134, true);
            WriteLiteral(" />\n            <div class=\"col-md-6\" style=\"text-align:center;\">\n                <label class=\"control-label\" style=\"color:#7E7E7E;\">");
            EndContext();
            BeginContext(695, 16, false);
#line 19 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                                                               Write(Model.RoomNumber);

#line default
#line hidden
            EndContext();
            BeginContext(711, 349, true);
            WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""form-group"" style=""padding-top:30px;"">
            <div class=""col-md-6"">
                <label class=""control-label"">Category:</label>
            </div>
            <div class=""col-md-6"" style=""text-align:center;"">
                <label class=""control-label"" style=""color:#7E7E7E;"">");
            EndContext();
            BeginContext(1061, 27, false);
#line 27 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                                                               Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 360, true);
            WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""form-group"" style=""padding-top:30px;"">
            <div class=""col-md-6"">
                <label class=""control-label"">Bed Count:</label>
            </div>
            <div class=""col-md-6"" style=""text-align:center;"">
                <label class=""control-label bed-count"" style=""color:#7E7E7E;"">");
            EndContext();
            BeginContext(1449, 14, false);
#line 35 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                                                                         Write(Model.BedCount);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 350, true);
            WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""form-group"" style=""padding-top:30px;"">
            <div class=""col-md-6"">
                <label class=""control-label"">Breakfast:</label>
            </div>
            <div class=""col-md-6"" style=""text-align:center;"">
                <label class=""control-label"" style=""color:#7E7E7E;"">");
            EndContext();
            BeginContext(1814, 15, false);
#line 43 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                                                               Write(Model.Breakfast);

#line default
#line hidden
            EndContext();
            BeginContext(1829, 346, true);
            WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""form-group"" style=""padding-top:30px;"">
            <div class=""col-md-6"">
                <label class=""control-label"">WI-FI:</label>
            </div>
            <div class=""col-md-6"" style=""text-align:center;"">
                <label class=""control-label"" style=""color:#7E7E7E;"">");
            EndContext();
            BeginContext(2176, 10, false);
#line 51 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                                                               Write(Model.WiFi);

#line default
#line hidden
            EndContext();
            BeginContext(2186, 363, true);
            WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""form-group room-order"" style=""padding-top:30px;"">
            <div class=""col-md-6"">
                <label class=""control-label"">Price:</label>
            </div>
            <div class=""col-md-6"" style=""text-align:center;"">
                <label class=""control-label price"" style=""color:#7E7E7E;"">");
            EndContext();
            BeginContext(2550, 11, false);
#line 59 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                                                                     Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2561, 207, true);
            WriteLiteral("</label>\n            </div>\n            <div class=\"col-md-6\">\n                <label class=\"control-label\">Resreved:</label>\n            </div>\n            <div class=\"col-md-6\" style=\"text-align:center;\">\n");
            EndContext();
#line 65 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                  
                    bool isReserved = Model.IsReserved;
                

#line default
#line hidden
            BeginContext(2861, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 68 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                 if (isReserved == true)
                {

#line default
#line hidden
            BeginContext(2920, 84, true);
            WriteLiteral("                    <label class=\"control-label\" style=\"color:#7E7E7E;\">Yes</label>\n");
            EndContext();
#line 71 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3022, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 72 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                 if (isReserved == false)
                {

#line default
#line hidden
            BeginContext(3082, 83, true);
            WriteLiteral("                    <label class=\"control-label\" style=\"color:#7E7E7E;\">No</label>\n");
            EndContext();
#line 75 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3183, 343, true);
            WriteLiteral(@"            </div>
        </div>
        <div class=""form-group"" style=""padding-top:30px;"">
            <div class=""col-md-6"">
                <label class=""control-label"">Description:</label>
            </div>
            <div class=""col-md-6"" style=""text-align:center;"">
                <label class=""control-label"" style=""color:#7E7E7E;"">");
            EndContext();
            BeginContext(3527, 17, false);
#line 83 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                                                               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3544, 171, true);
            WriteLiteral("  </label>\n            </div>\n        </div>\n    </div>\n    <div class=\"col-md-8\" style=\"padding-bottom:50px;\">\n        <div id=\"slider\">\n            <div class=\"images\">\n");
            EndContext();
#line 90 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                 for (int i = 0; i < Model.RoomImages.Count(); i++)
                {

#line default
#line hidden
            BeginContext(3801, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3825, "\"", 3863, 2);
            WriteAttributeValue("", 3833, "item", 3833, 4, true);
#line 92 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
WriteAttributeValue(" ", 3837, i == 0 ? "active" : "", 3838, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3864, 26, true);
            WriteLiteral(">\n                        ");
            EndContext();
            BeginContext(3890, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d52bc0af02f1488882b9c8b347313861", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3900, "~/images/room/", 3900, 14, true);
#line 93 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
AddHtmlAttributeValue("", 3914, Model.RoomImages.ElementAt(i).Image, 3914, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3972, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 95 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(4018, 287, true);
            WriteLiteral(@"            </div>
            <div class=""icon left"" id=""left"">
                <i class=""fas fa-chevron-left""></i>
            </div>

            <div class=""icon right"" id=""right"">
                <i class=""fas fa-chevron-right""></i>
            </div>
        </div>
    </div>
    ");
            EndContext();
            BeginContext(4305, 1777, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c8c1690dee45d9b0b17820cdfe2fbf", async() => {
                BeginContext(4392, 73, true);
                WriteLiteral("\n        <div class=\"row\">\n            <input type=\"hidden\" name=\"roomId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4465, "\"", 4482, 1);
#line 108 "D:\HostelSystem-Simple--master\HostelApp\Views\Room\Details.cshtml"
WriteAttributeValue("", 4473, Model.ID, 4473, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4483, 1051, true);
                WriteLiteral(@" />
            <div class=""col-md-6 col-lg-3"">
                <div class=""input-group date mg-check-in"">
                    <div class=""input-group-addon""><i class=""far fa-calendar-alt""></i></div>
                    <input name=""startDate"" class=""form-control checkIn"" type=""text"" id=""exampleInputEmail1"" placeholder=""Check In"" autocomplete=""off"">
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <div class=""input-group date mg-check-out"">
                    <div class=""input-group-addon""><i class=""far fa-calendar-alt""></i></div>
                    <input name=""endDate"" class=""form-control checkOut"" type=""text"" id=""exampleInputEmail1"" placeholder=""Check Out"" autocomplete=""off"">
                </div>
            </div>
            <div class=""col-md-12 col-lg-3"">
                <div class=""row"">
                    <div class=""col-6"">
                        <select name=""count"" style=""padding:0 0 0 10px; height:32px;"" class=""form-control"" id=""count"">
 ");
                WriteLiteral("                           ");
                EndContext();
                BeginContext(5534, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4bde16a002b46239157188ebda33330", async() => {
                    BeginContext(5551, 5, true);
                    WriteLiteral("Count");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5565, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(5594, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6e0561028874d1eb676be1ac8c98f6f", async() => {
                    BeginContext(5612, 1, true);
                    WriteLiteral("1");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5622, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(5651, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79afe5ebd21d4aa6963e0eb4d0d4e835", async() => {
                    BeginContext(5669, 1, true);
                    WriteLiteral("2");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5679, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(5708, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e97b3fed43714ffe9ca9cf9cacb34b67", async() => {
                    BeginContext(5726, 1, true);
                    WriteLiteral("3");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5736, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(5765, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e870fe0897ac412a8d5f5f820ca7a973", async() => {
                    BeginContext(5783, 1, true);
                    WriteLiteral("4");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5793, 282, true);
                WriteLiteral(@"
                        </select>
                    </div>

                </div>
            </div>
            <div class=""col-md-12 col-lg-3"">
                <input type=""submit"" class=""btn btn-main btn-block"" value=""Order"" id=""check"">
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6082, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
            BeginContext(6090, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182d0f5cbb5f4486b945488b72385275", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6132, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(6133, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce7bbe982f64e1d855494461a23e84f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6181, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(6182, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2805ba1b0fd64a81a2ccac9652927c3b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Room> Html { get; private set; }
    }
}
#pragma warning restore 1591