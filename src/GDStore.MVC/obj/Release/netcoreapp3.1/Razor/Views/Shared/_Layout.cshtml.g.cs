#pragma checksum "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a75d1e88a842238e08710e175b0e5f2750fdc80"
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
#line 2 "F:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a75d1e88a842238e08710e175b0e5f2750fdc80", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c963f7eff9981e5d68544477c0ed8fcb0fd6c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/SweetAlert/css/sweetalert.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-png.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"vi\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a75d1e88a842238e08710e175b0e5f2750fdc807088", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Trang chủ</title>
    <link rel=""stylesheet""
          href=""//fonts.googleapis.com/css?family=Open+Sans:300,400,600|Roboto:100,300,400,500,700|Volkhov:400i"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.14.0/css/all.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a75d1e88a842238e08710e175b0e5f2750fdc807861", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a75d1e88a842238e08710e175b0e5f2750fdc809040", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a75d1e88a842238e08710e175b0e5f2750fdc8010927", async() => {
                WriteLiteral(@"
    <header class=""header"">
        <div class=""container"">
            <div class=""inner-header row"">
                <a href=""/"" class=""col-md-2 p-0"">
                    <div class=""brand d-flex"">
                        <div class=""brand-logo"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a75d1e88a842238e08710e175b0e5f2750fdc8011482", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <h1 class=""brand-name mt-2"" style=""font-family: serif;"">Store</h1>
                    </div>
                </a>
                <nav class=""navbar navbar-expand-sm col-md-4 p-0"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Category/Index"">Nam</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Category/Index"">Nữ</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Category/Index"">Giảm giá</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Category/Index"">Khuyến mãi</a>
                        </li>
                    </ul>
                </nav>
                <div class=""search-box co");
                WriteLiteral("l-md-3 mt-3\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a75d1e88a842238e08710e175b0e5f2750fdc8013871", async() => {
                    WriteLiteral("\r\n                        <input type=\"text\"");
                    BeginWriteAttribute("class", " class=\"", 2232, "\"", 2240, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Nhập tên sản phẩm...\">\r\n                        <button class=\"btn-search\" title=\"Tìm kiếm\"><i class=\"fas fa-search\"></i></button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""cart col-md-1"">
                    <a href=""/Cart/Index"">
                        <i class=""fas fa-shopping-cart fa-lg""></i>
                        <label class=""badge badge-warning lbl-cartQty"">0</label>
                    </a>
                </div>
                <div class=""account col-md-2"">
                    <div class=""d-flex align-items-center"">
                        <i class=""fas fa-user fa-lg""></i>
");
#nullable restore
#line 61 "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/Account/ManagerAccount\" class=\"ml-1\">");
#nullable restore
#line 63 "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml"
                                                                      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 64 "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/Account/Login\" class=\"ml-1\">Tài khoản</a>\r\n");
#nullable restore
#line 68 "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    ");
#nullable restore
#line 74 "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <section class=""stores"">
        <div class=""container"">
            <div class=""title"">Hệ thống cửa hàng</div>
            <div class=""row mt-2"">
                <div class=""col-md-6"">
                    <div class=""map"">
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3780.0799875628227!2d105.69237121482288!3d18.66040628732768!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3139cdde5e40a551%3A0x543b433120d5699b!2zVHLGsOG7nW5nIMSQ4bqhaSBo4buNYyBWaW5o!5e0!3m2!1svi!2s!4v1603002060645!5m2!1svi!2s""
                                width=""540"" height=""450"" frameborder=""0"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4050, "\"", 4068, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                aria-hidden=""false"" tabindex=""0""></iframe>
                    </div>
                </div>
                <div class=""col-md-6 pl-3"">
                    <div class=""store-item"">
                        <p class=""icon-map""><i class=""fas fa-map-marker-alt fa-lg""></i></p>
                        <p class=""map-content"">
                            <span class=""mb-1 ml-1"">
                                <span>ĐỊA CHỈ: </span><span>
                                    Số 68 Hai Bà Trưng,
                                    Phường Cửa Nam, Hoàn Kiếm, Hà Nội
                                </span><br><span>SĐT: 0243.936.5268</span>
                            </span>
                        </p>
                    </div>
                    <div class=""store-item"">
                        <p class=""icon-map""><i class=""fas fa-map-marker-alt fa-lg""></i></p>
                        <p class=""map-content"">
                            <span class=""mb-1 ml-1"">
    ");
                WriteLiteral(@"                            <span>ĐỊA CHỈ: </span><span>
                                    ĐỊA CHỈ:
                                </span><span> 316 Nguyễn Văn Cừ - Tp Vinh- Nghệ An</span><br><span>
                                    SĐT:
                                    02383.858.567
                                </span>
                            </span>
                        </p>
                    </div>
                    <div class=""store-item"">
                        <p class=""icon-map""><i class=""fas fa-map-marker-alt fa-lg""></i></p>
                        <p class=""map-content"">
                            <span class=""mb-1 ml-1"">
                                <span>ĐỊA CHỈ: </span><span>
                                    69 Trần Hưng Đạo,TT
                                    Liên Nghĩa, H.Đức Trọng, T.Lâm Đồng
                                </span><br><span>SĐT: 02633.645.939</span>
                            </span>
                        </p>
             ");
                WriteLiteral(@"       </div>
                    <div class=""store-item"">
                        <p class=""icon-map""><i class=""fas fa-map-marker-alt fa-lg""></i></p>
                        <p class=""map-content"">
                            <span class=""mb-1 ml-1"">
                                <span>ĐỊA CHỈ: </span><span>
                                    Số 47, Đường Nguyễn
                                    Huệ, P.Bến Nghé, Quận 1, TP.
                                    HCM
                                </span><br><span>SĐT: 0282.200.7476</span>
                            </span>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <footer class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-2"">
                    <div class=""logo-footer text-center"">
                        <a href=""/""><img src=""/img/logo-png.png""");
                BeginWriteAttribute("alt", " alt=\"", 7103, "\"", 7109, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""100px""></a>
                    </div>
                </div>
                <div class=""col-md-2"">
                    <div class=""about"">
                        <h4>Về GDStore</h4>
                        <ul>
                            <li><a href=""/Home/About"">Về GDStore</a></li>
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7448, "\"", 7455, 0);
                EndWriteAttribute();
                WriteLiteral(">Câu chuyện GDStore</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7520, "\"", 7527, 0);
                EndWriteAttribute();
                WriteLiteral(">Bước tiến phát triển</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7594, "\"", 7601, 0);
                EndWriteAttribute();
                WriteLiteral(@">Hoạt động</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""policy"">
                        <h4><a href=""/Home/Policy"">Chính sách</a></h4>
                        <ul>
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7924, "\"", 7931, 0);
                EndWriteAttribute();
                WriteLiteral(">Chính sách đổi trả</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7996, "\"", 8003, 0);
                EndWriteAttribute();
                WriteLiteral(">Chính sách bảo hành</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8069, "\"", 8076, 0);
                EndWriteAttribute();
                WriteLiteral(@">Chính sách khách hàng thân thiết</a></li>
                        </ul>
                    </div>
                </div>

                <div class=""col-md-5"">
                    <div class=""contact"">
                        <h4><a href=""/Home/Contact"">Liên hệ</a></h4>
                        <p><b>SĐT:</b> (012) 34 567 89 </p>
                        <p>
                            <b>Email : </b>Liên hệ các vấn đề về đặt hàng online : tuvan_online@gdstore.com.vn <br>
                            <b>
                                Email :
                            </b>Liên hệ các vấn đề về kênh cửa hàng, đại lý (offline) :
                            chamsockhachhang@gdstore.com.vn<br>
                            <b>Hotline : 19002126 </b>( cước phí: 3000đ/phút )<br>
                            Thời gian tư vấn: Từ 07h30 đến 12h15, 13h15 đến 21h30 các ngày trong tuần ( Trừ ngày Lễ,
                            Tết)
                        </p>
                    </div>
           ");
                WriteLiteral(@"     </div>
            </div>
        </div>
    </footer>
    <button onclick=""scrollToTop()"" id=""btnScroll"" title=""Go to top""><i class=""fas fa-arrow-up""></i></button>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
    <script src=""/vendor/SweetAlert/js/sweetalert.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a75d1e88a842238e08710e175b0e5f2750fdc8025472", async() => {
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
#nullable restore
#line 193 "F:\Web\GDStore\src\GDStore.MVC\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
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
