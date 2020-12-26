#pragma checksum "F:\Web\GDStore\src\GDStore.MVC\Views\Account\ManagerAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a306622482aef2375bd8f463157602b9ae5dd06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ManagerAccount), @"mvc.1.0.view", @"/Views/Account/ManagerAccount.cshtml")]
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
#line 1 "F:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a306622482aef2375bd8f463157602b9ae5dd06", @"/Views/Account/ManagerAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d20c89e717bfb565dfc7813bef1a3b1a23c0705", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ManagerAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Web\GDStore\src\GDStore.MVC\Views\Account\ManagerAccount.cshtml"
  
    ViewData["Title"] = "Manager";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-rg"">
    <div class=""container p-0"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i> Trang chủ</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Tài khoản</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Quản lý tài khoản</li>
            </ol>
        </nav>
    </div>
</div>
<section class=""your-account mt-4 mb-4"">
    <div class=""container"">
        <div class=""d-flex"">
            <nav class=""navbar"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Account/ManagerAccount""><i class=""fa fa-user""></i> Thông tin tài khoản</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Account/ManagerOrder""><i class=""fas fa-clipboard""></i> Quản lý đơn hàng</a>
          ");
            WriteLiteral(@"          </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Account/AddressBook""><i class=""fa fa-map-marker""></i> Sổ địa chỉ</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-bell""></i> Thông báo</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-eye""></i> Sản phẩm đã xem</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-heart""></i> Sản phẩm yêu thích</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-question""></i> Hỏi đáp</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-sign-out-alt""></i> Đăn");
            WriteLiteral(@"g xuất</a>
                    </li>
                </ul>
            </nav>
            <div class=""content pl-4 flex-fill"">
                <h3>Quản lý tài khoản</h3>
                <hr>
                <div class=""col-md-6"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a306622482aef2375bd8f463157602b9ae5dd066281", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 2512, "\"", 2519, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2520, "\"", 2525, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Họ và tên"" class=""form-control"">
                        </div>
                        <div class=""form-group"">
                            <div class=""input-group mb-3"">
                                <input type=""text"" class=""form-control"" placeholder=""Nhập số điện thoại"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-success"" type=""submit"">Gửi mã xác thực</button>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <input type=""text""");
                BeginWriteAttribute("name", " name=\"", 3201, "\"", 3208, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nhập mã xác thực gửi tới số điện thoại trên\"\r\n                                   class=\"form-control\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3455, "\"", 3462, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nhập Email\"\r\n                                   class=\"form-control\">\r\n                        </div>\r\n                        <button class=\"btn btn-success\">Cập nhật</button>\r\n                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
