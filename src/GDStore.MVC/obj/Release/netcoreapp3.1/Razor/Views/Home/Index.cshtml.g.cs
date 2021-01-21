#pragma checksum "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e23744f4085a50732770d0e5b50bbac6baf0849a"
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
#nullable restore
#line 1 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
using GDStore.Application.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e23744f4085a50732770d0e5b50bbac6baf0849a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d20c89e717bfb565dfc7813bef1a3b1a23c0705", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GDStore.ViewModel.Products.ProductVm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner-1.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("1100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner-2.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner-3.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var Categories = (List<GDStore.ViewModel.Categories.CategoryVm>)ViewBag.Categories;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""slide-banner"">
    <div id=""slide"" class=""carousel slide"" data-ride=""carousel"">

        <!-- Indicators -->
        <ul class=""carousel-indicators"">
            <li data-target=""#slide"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#slide"" data-slide-to=""1""></li>
            <li data-target=""#slide"" data-slide-to=""2""></li>
        </ul>

        <!-- The slideshow -->
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <a");
            BeginWriteAttribute("href", " href=\"", 795, "\"", 802, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e23744f4085a50732770d0e5b50bbac6baf0849a6327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 953, "\"", 960, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e23744f4085a50732770d0e5b50bbac6baf0849a7835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1111, "\"", 1118, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e23744f4085a50732770d0e5b50bbac6baf0849a9345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
            </div>
        </div>

        <!-- Left and right controls -->
        <a class=""carousel-control-prev"" href=""#slide"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon""></span>
        </a>
        <a class=""carousel-control-next"" href=""#slide"" data-slide=""next"">
            <span class=""carousel-control-next-icon""></span>
        </a>
    </div>
</section>
");
#nullable restore
#line 40 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
 foreach (var i in Categories.Take(2))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"products products-male\">\r\n        <div class=\"container\">\r\n            <div class=\"title\">");
#nullable restore
#line 44 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
                          Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"row mt-2\">\r\n");
#nullable restore
#line 46 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
                 foreach (var item in Model.Where(p => p.CategoryId.Contains(i.Id)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-3 col-3"">
                        <div class=""product"">
                            <label class=""badge badge-warning"">-50%</label><br>
                            <label class=""badge badge-danger"">Khuyến mãi</label>
                            <a");
            BeginWriteAttribute("href", " href=\"", 2195, "\"", 2254, 4);
            WriteAttributeValue("", 2202, "/san-pham/", 2202, 10, true);
#nullable restore
#line 52 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2212, StringHelper.VNDecode(item.Name), 2212, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2245, "-", 2245, 1, true);
#nullable restore
#line 52 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2246, item.Id, 2246, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"thumbnail-img\"");
            BeginWriteAttribute("src", " src=\"", 2316, "\"", 2391, 3);
#nullable restore
#line 53 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2322, TempData["BackendUrl"], 2322, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2345, "/user-content/", 2345, 14, true);
#nullable restore
#line 53 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2359, item.ThumbnailImage.First().Url, 2359, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2392, "\"", 2398, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                            <hr>\r\n                            <h1 class=\"product-name\"><a");
            BeginWriteAttribute("href", " href=\"", 2525, "\"", 2584, 4);
            WriteAttributeValue("", 2532, "/san-pham/", 2532, 10, true);
#nullable restore
#line 56 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2542, StringHelper.VNDecode(item.Name), 2542, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2575, "-", 2575, 1, true);
#nullable restore
#line 56 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2576, item.Id, 2576, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
                                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n                            <div>\r\n                                <span class=\"price\"><strong>");
#nullable restore
#line 58 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₫</strong></span>\r\n                                <del class=\"original-price float-right\">");
#nullable restore
#line 59 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
                                                                   Write(item.OriginalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("₫</del>\r\n                            </div>\r\n                            <button class=\"btn btn-success btn-addToCart w-100 mt-3\" data-id=\"");
#nullable restore
#line 61 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Thêm vào giỏ hàng</button>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 64 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"text-center mt-3\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3165, "\"", 3172, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-see-more\">Xem thêm</a>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 73 "F:\Web\GDStore\src\GDStore.MVC\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"brands\">\r\n    <div class=\"container\">\r\n        <div class=\"title\">Thương hiệu</div>\r\n        <div class=\"row mt-2\">\r\n            <div class=\"col-md-3 col-3\">\r\n                <div class=\"brand\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3500, "\"", 3507, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/brand/adidas.png\" class=\"w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 3555, "\"", 3561, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3 col-3\">\r\n                <div class=\"brand\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3714, "\"", 3721, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/brand/nike.png\" class=\"w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 3767, "\"", 3773, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3 col-3\">\r\n                <div class=\"brand\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3926, "\"", 3933, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/brand/puma.png\" class=\"w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 3979, "\"", 3985, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3 col-3\">\r\n                <div class=\"brand\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4138, "\"", 4145, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/brand/bitis.png\" class=\"w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 4192, "\"", 4198, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"text-center mt-3\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4320, "\"", 4327, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-see-more\">Xem thêm</a>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GDStore.ViewModel.Products.ProductVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
