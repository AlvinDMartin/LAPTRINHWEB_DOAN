#pragma checksum "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "231593efbc8dce934cd9b3432d37f36e9885e8d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\_ViewImports.cshtml"
using WebBanHangMyPham;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\_ViewImports.cshtml"
using WebBanHangMyPham.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231593efbc8dce934cd9b3432d37f36e9885e8d3", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f8d6e30aa8c9c313aea644133e4dc273a99aa4", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanHangMyPham.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 5 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupon.ToList().Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border\">\r\n        <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2500\">\r\n");
#nullable restore
#line 9 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Coupon.Count(); i++)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n");
#nullable restore
#line 14 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 669, "\"", 682, 1);
#nullable restore
#line 18 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 675, imgsrc, 675, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n                    </div>\r\n");
#nullable restore
#line 20 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n");
#nullable restore
#line 24 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1138, "\"", 1151, 1);
#nullable restore
#line 28 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1144, imgsrc, 1144, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n                    </div>\r\n");
#nullable restore
#line 30 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 35 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"backgroundWhite container\">\r\n\r\n    <ul id=\" menu-filters\" class=\"menu-filter-list list-inline text-center\">\r\n        <li class=\"active btn btn-secondary ml-1 mr-1\" data-filter=\"menu-restaurant\">Xem tất cả</li>\r\n\r\n");
#nullable restore
#line 44 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var item in Model.ThongTinLoaiSanPham)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"filter ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 46 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
                                                  Write(item.TenLoaiSanPham.Replace(" ", string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 46 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                   Write(item.TenLoaiSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 47 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n");
#nullable restore
#line 50 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var catogory in Model.ThongTinLoaiSanPham)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" id=\"menu-wrapper\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "231593efbc8dce934cd9b3432d37f36e9885e8d39967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 53 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(u=>u.ThongTinLoaiSanPham.TenLoaiSanPham.Equals(catogory.TenLoaiSanPham));

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
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 55 "D:\Quoc_Dat_CNTT\5.HK1_Nam3\DOAN_WEB\LAPTRINHWEB_DOAN\Dat\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""http://code.jquery.com/jquery-3.4.1.js""
            integrity=""sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=""
            crossorigin=""anonymous""></script>

    <script>
        //var post = $('.post');

        function InitLayout() {
            $(""#menu-filters li"").click(function () {
                $(""#menu-filters li"").removeClass('active btn btn-secondary');
                $(this).addClass('active btn btn-secondary');

                var selectedFilter = $(this).data(""filter"");

                setTimeout(function () {
                    $(selectedFilter).slideDown();
                }, 300);
            });
        };
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanHangMyPham.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
