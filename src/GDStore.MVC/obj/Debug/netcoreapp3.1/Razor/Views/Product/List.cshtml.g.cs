#pragma checksum "F:\Web\GDStore\src\GDStore.MVC\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d8fe2086d6564b5b9900d3b2528c86a114b6a29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d8fe2086d6564b5b9900d3b2528c86a114b6a29", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d20c89e717bfb565dfc7813bef1a3b1a23c0705", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\Web\GDStore\src\GDStore.MVC\Views\Product\List.cshtml"
  
    ViewData["Title"] = "Danh sách sản phẩm";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"title-content\">Danh sách sản phẩm</h1>\r\n<div class=\"row mt-3 mb-3\">\r\n    <div class=\"col-md-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8fe2086d6564b5b9900d3b2528c86a114b6a295193", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> Thêm sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4 mb-2 p-0\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8fe2086d6564b5b9900d3b2528c86a114b6a296737", async() => {
                WriteLiteral(@"
            <div class=""input-group"">
                <input type=""text"" class=""form-control bg-light border-1 small""
                       placeholder=""Nhập tên sản phẩm... "" aria-label=""Search""
                       aria-describedby=""basic-addon2"" required>
                <div class=""input-group-append"">
                    <button class=""btn btn-primary"" type=""button"">
                        <i class=""fas fa-search fa-sm""></i>
                    </button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"table-responsive\">\r\n    <table class=\"table table-striped table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th><input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 1220, "\"", 1227, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1228, "\"", 1233, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Chọn tất cả</th>
                <th>Mã sản phẩm</th>
                <th>Tên sản phẩm</th>
                <th>Giá</th>
                <th>Hành động</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 1511, "\"", 1518, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1519, "\"", 1524, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>1</td>\r\n                <td>Giày Thể Thao Nam Biti\'s Hunter X Matcha DSMH03400XMN (Xanh Mi Nơ)</td>\r\n                <td>590.000₫</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1733, "\"", 1740, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1821, "\"", 1828, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 1993, "\"", 2000, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2001, "\"", 2006, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>2</td>\r\n                <td>Giày Thể Thao Nam Biti\'s Hunter Street DSMH04300XNH (Xanh Nhớt)</td>\r\n                <td>690.000₫</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2212, "\"", 2219, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2300, "\"", 2307, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 2472, "\"", 2479, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2480, "\"", 2485, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>3</td>\r\n                <td>Sandal Nam Biti\'s Hunter DEMH00600XAM (Xám)</td>\r\n                <td>300.000₫</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2671, "\"", 2678, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2759, "\"", 2766, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 2931, "\"", 2938, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2939, "\"", 2944, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>4</td>\r\n                <td>Dentsu Redder - Hương Giang - Vietnamese Canvas of Pride (Women)</td>\r\n                <td>650.000₫</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3151, "\"", 3158, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3239, "\"", 3246, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 3411, "\"", 3418, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3419, "\"", 3424, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>5</td>\r\n                <td>Giày Thể Thao Nữ Biti\'s Hunter X BKL - Midnight Black Inverted DSWH02302DEN (Đen)</td>\r\n                <td>790.000₫</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3648, "\"", 3655, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3736, "\"", 3743, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger""><i class=""fas fa-trash-alt""></i></a>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<ul class=""pagination"">
    <li class=""page-item""><a class=""page-link"" href=""#"">Đầu</a></li>
    <li class=""page-item""><a class=""page-link"" href=""#"">Trước</a></li>
    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
    <li class=""page-item active""><a class=""page-link"" href=""#"">2</a></li>
    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
    <li class=""page-item""><a class=""page-link"" href=""#"">Tiếp</a></li>
    <li class=""page-item""><a class=""page-link"" href=""#"">Cuối</a></li>
</ul>
");
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