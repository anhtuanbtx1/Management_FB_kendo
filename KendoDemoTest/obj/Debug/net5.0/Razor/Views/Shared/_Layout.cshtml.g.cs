#pragma checksum "D:\repos\MFootBall\Kendo_Football\Management_FB_kendo\KendoDemoTest\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efba9febf64a207a236739c79940cc99609c09c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\repos\MFootBall\Kendo_Football\Management_FB_kendo\KendoDemoTest\Views\_ViewImports.cshtml"
using KendoDemoTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\MFootBall\Kendo_Football\Management_FB_kendo\KendoDemoTest\Views\_ViewImports.cshtml"
using KendoDemoTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efba9febf64a207a236739c79940cc99609c09c2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23af27877f8ec79940a1203b73d2646b7c99e78d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/styles/kendo.common.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/styles/kendo.rtl.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/styles/kendo.default-main-dark.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/styles/c3n.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/styles/kendo.default.mobile.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/js/jszip.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kendo/js/kendo.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efba9febf64a207a236739c79940cc99609c09c27554", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\repos\MFootBall\Kendo_Football\Management_FB_kendo\KendoDemoTest\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - KendoDemoTest</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efba9febf64a207a236739c79940cc99609c09c28217", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efba9febf64a207a236739c79940cc99609c09c29396", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efba9febf64a207a236739c79940cc99609c09c210575", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efba9febf64a207a236739c79940cc99609c09c211755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efba9febf64a207a236739c79940cc99609c09c212935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efba9febf64a207a236739c79940cc99609c09c214115", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efba9febf64a207a236739c79940cc99609c09c215215", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efba9febf64a207a236739c79940cc99609c09c216315", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "efba9febf64a207a236739c79940cc99609c09c217415", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style style=""display:none"">

        /*thanh kéo scroll*/
        html {
            --scrollbarBG: #232f3d; /*#CFD8DC*/
            --thumbBG: #5f6164; /*#0271a9*/
        }

        ::-webkit-scrollbar {
            width: 12px;
            height: 12px;
        }

        body {
            scrollbar-width: thin;
            scrollbar-color: var(--thumbBG) var(--scrollbarBG);
        }

        ::-webkit-scrollbar-track {
            background: var(--scrollbarBG) !important;
        }

        ::-webkit-scrollbar-thumb {
            background-color: var(--thumbBG) !important;
            border-radius: 10px !important;
            border: 2px solid var(--scrollbarBG) !important;
            background: none;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efba9febf64a207a236739c79940cc99609c09c220079", async() => {
                WriteLiteral(@"
    <div id=""header"">
        <div id=""megaStore"">
            <div style=""display: flex; justify-content: space-between; align-items: center;"">
                <a class=""navbar-brand"" href=""/"">
                    <img src=""/content/images/logo-new.png"" style=""width: 92px; padding: 10px; margin-left: 20px;"">
                    <p style=""color: #f7b550;""> TRUNG TÂM THỂ THAO</p>
                </a>
                <ul id=""menu2"" style="" padding-right: 10px;  margin-right: 20px;"">
                    <li class=""align-right"" style=""border-color: white;"">
                        <i class=""k-icon k-i-notification"" style=""scale: 1.4;""></i>
                    </li>
                    <li class=""align-right"" style=""border-color: white;"">
");
                WriteLiteral(@"                        <span id=""pnAccount"" style=""font-size:14px;"">&nbsp;</span>
                        <ul style=""background-color:var(--lightgrayCustom) !important;"" class=""ul-login"">
                            <li>
                                <div style=""background-color:var(--lightgrayCustom) !important;width:205px"">
                                    <ol"">
                                        <li>
                                            <a style=""background-color:var(--lightgrayCustom) !important;margin-right:57px;"" class=""k-button k-button-solid-base k-button-solid k-button-md k-rounded-md"" href=""#"">
                                                <span class=""k-icon k-i-user""></span>
                                                <div>Tài khoản</div>
                                            </a>
                                        </li>
                                        <li>
                                            <a style=""background-color:var(--lightgra");
                WriteLiteral(@"yCustom) !important;margin-right:73px;"" class=""k-button k-button-solid-base k-button-solid k-button-md k-rounded-md"" href=""#"">
                                                <span class=""k-icon k-i-gear""></span>
                                                <div>Cài đặt</div>
                                            </a>
                                        </li>
                                        <li>
                                            <a style=""background-color:var(--lightgrayCustom) !important;margin-right:30px;"" class=""k-button k-button-solid-base k-button-solid k-button-md k-rounded-md change-password"" href=""#"">
                                                <span class=""k-icon k-i-lock""></span>
                                                <div>Đổi mật khẩu</div>
                                            </a>
                                        </li>
                                        <li>
                                            <a style=""backgro");
                WriteLiteral(@"und-color:var(--lightgrayCustom) !important;margin-right:45px;"" class=""k-button k-button-solid-base k-button-solid k-button-md k-rounded-md"" href=""/Account/Logout"">
                                                <span class=""k-icon k-i-logout""></span>
                                                <div>Đăng xuất</div>
                                            </a>
                                        </li>
                                        </ol>
");
                WriteLiteral(@"                                </div>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
            <ul id=""menu"" style=""font-size:14px; background-color: #232f3d;"">
                <li id=""mniDashboard"">
                    <a href=""/Dashboard"" id=""dashboard""><span class=""k-icon k-i-graph""></span>Thống kê</a>
                </li>
                <li id=""mniTrac"">
                    <a href=""/""><span class=""k-icon k-i-marker-pin-target""></span>Giám sát</a>
                </li>
                <li id=""mniView"">
                    <a><span class=""k-icon k-i-ungroup""></span>Hiển thị</a>
                    <ul></ul>
                </li>
                <li id=""mniPatrol"">
                    <a id=""tuantra"" onclick=""onTuanTra()""><span class=""k-icon k-i-calendar""></span>Tuần tra</a>
                </li>
                <li>
                    <a id=""news"" onclick=""onTaoTin()""><span class=""k-icon k-i-warn");
                WriteLiteral(@"ing""></span>Tạo tin mới</a>
                </li>
                <li id=""mniViolate"">
                    <a href=""/Violate/Violate"" id=""violate""><span class=""k-icon k-i-launch""></span>Vi phạm</a>
                </li>
                <li id=""mniReport"">
                    <a href=""/Report"" id=""report""><span class=""k-icon k-i-aggregate-fields""></span>Báo cáo</a>
                    <ul class=""ul-history"" style=""background-color:var(--lightgrayCustom);margin-top:11px"">
                        <li id=""mniHistory"">
                            <a id='patrolsHistory' href='/Histories/PatrolsHistory'><span class=""k-icon k-i-clock""></span>Lịch sử tuần tra</a>
                        </li>
                        <li");
                BeginWriteAttribute("id", " id=\"", 6788, "\"", 6793, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <a id=\'eventsHistory\' href=\'/Histories/EventsHistory\'><span class=\"k-icon k-i-clock\"></span>Lịch sử sự kiện</a>\r\n                        </li>\r\n                        <li");
                BeginWriteAttribute("id", " id=\"", 6996, "\"", 7001, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <a id=\'violationsHistory\' href=\'/Histories/ViolatesHistory\'><span class=\"k-icon k-i-clock\"></span>Lịch sử xử lý vi phạm</a>\r\n                        </li>\r\n");
                WriteLiteral(@"                    </ul>
                </li>
                <li style=""display:none;"">
                    <a id=""setting""><span class=""k-icon k-i-cog""></span> Cài đặt</a>
                    <ul>
                        <li>
                            <a id=""settingView"" onclick=""onTaoView()""><span class=""k-icon k-i-ungroup""></span>Thiết lập view</a>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
        <style>
            #header {
                /*background-image: linear-gradient(#ffffff, #ffbc00);*/
                /*border-bottom-color: #9f9f9f;
                                                                            border-bottom-style: solid;
                                                                            border-bottom-width: 1px;*/
            }

            .navbar-brand {
                align-items: center;
                display: flex;
                text-decoration: none;
             ");
                WriteLiteral(@"   font-size: 32px;
                font-weight: 700;
                /*color: #ff8a22;*/
            }

            #menu2 .k-i-arrow-60-down {
                scale: 1.4;
            }

            #menu .btn .k-link {
                padding: 0.45em 1em;
            }

            #menu .align-right {
                float: right;
            }

            #megaStore {
                /*border-bottom-color: #ff8201;*/
                border-bottom-style: solid;
                border-bottom-width: 0px;
                background-color: #17212b;
            }

            #menu h2 {
                font-size: 1em;
                text-transform: uppercase;
                padding: 5px 10px;
            }

            #template img {
                margin: 5px 20px 0 0;
                float: left;
            }

            #template {
                width: 380px;
            }

                #template ol {
                    float: left;
                    ma");
                WriteLiteral(@"rgin: 0 0 0 30px;
                    padding: 10px 10px 0 10px;
                }

                #template:after {
                    content: ""."";
                    display: block;
                    height: 0;
                    clear: both;
                    visibility: hidden;
                }

                #template .k-button {
                    float: left;
                    clear: left;
                    margin: 5px 0 5px 12px;
                }
        </style>
        <script>

            $(document).ready(function () {
                $(""#menu"").kendoMenu();
                $(""#menu2"").kendoMenu();
                //$(""#menu"").css(""display"", ""block"");
                //$(""#menu2"").css(""display"", ""block"");
                $(""#kendomenu"").kendoMenu({
                    select: function (e) {
                        $(""#menu"").find("".k-state-selected"").removeClass(""k-state-selected"");
                        $(e.item).addClass(""k-state-selected"");
    ");
                WriteLiteral(@"                }
                });

                // lỗi màu xanh nhiều dòng
                //$.each(
                //    $(""#menu"").find("".k-link""),
                //    function (i, data) {
                //        if (data.href == location.href) {
                //            $(data).addClass(""k-state-selected"");
                //        }
                //    }
                //);
            });

        </script>
    </div>

    <div id=""example"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 251 "D:\repos\MFootBall\Kendo_Football\Management_FB_kendo\KendoDemoTest\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>


    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#menu"").kendoMenu();
            $(""#menu2"").kendoMenu();
            $(""#menu"").css(""display"", """");
            $(""#menu2"").css(""display"", """");
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
