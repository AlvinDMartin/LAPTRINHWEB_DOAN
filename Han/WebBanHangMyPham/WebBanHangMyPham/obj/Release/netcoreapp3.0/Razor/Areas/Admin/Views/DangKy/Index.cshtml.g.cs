#pragma checksum "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54a33459134959acd9f53aae79fdddb2bb96a66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DangKy_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DangKy/Index.cshtml")]
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
#line 1 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangMyPham;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangMyPham.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54a33459134959acd9f53aae79fdddb2bb96a66", @"/Areas/Admin/Views/DangKy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f8d6e30aa8c9c313aea644133e4dc273a99aa4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DangKy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBanHangMyPham.Models.DangKy>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br /><br />\r\n\r\n          <div class=\"row\">\r\n              <div class=\"col-6\">\r\n                  <h2 class=\"text-info\"> Danh sách đăng kí </h2>\r\n              </div>\r\n              <div class=\"col-6 text-right\">\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d54a33459134959acd9f53aae79fdddb2bb96a664350", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              </div>\r\n          </div>\r\n\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.TenDangNhap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.HoTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n\r\n\r\n");
#nullable restore
#line 42 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
               Write(Html.DisplayFor(m => item.TenDangNhap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
               Write(Html.DisplayFor(m => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
               Write(Html.DisplayFor(m => item.HoTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
               Write(Html.DisplayFor(m => item.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
               Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
               Write(Html.DisplayFor(m => item.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d54a33459134959acd9f53aae79fdddb2bb96a6610054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 64 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "D:\Studying\Năm 3\Lập trình WEB\WebBanHangMyPham\WebBanHangMyPham\Areas\Admin\Views\DangKy\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBanHangMyPham.Models.DangKy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
