#pragma checksum "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7776c118dee166391fe5f0dbef4e251038f79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang.Pages.MH_LoaiHang.Pages_MH_LoaiHang_DanhSachLH), @"mvc.1.0.razor-page", @"/Pages/MH_LoaiHang/DanhSachLH.cshtml")]
namespace QuanLyCuaHang.Pages.MH_LoaiHang
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
#line 1 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\_ViewImports.cshtml"
using QuanLyCuaHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7776c118dee166391fe5f0dbef4e251038f79e", @"/Pages/MH_LoaiHang/DanhSachLH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb323fe5fcc16b6d2fe1de9864a53f95a6caf4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_LoaiHang_DanhSachLH : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Danh sách Loại Hàng</h1>\r\n<br />\r\n<a href=\"/MH_LoaiHang/TaoMoiLH\" style=\"text-decoration: none;\"><h6>Thêm mới Loại Hàng</h6></a>\r\n<br />\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7776c118dee166391fe5f0dbef4e251038f79e3768", async() => {
                WriteLiteral(@"
        <div class=""input-group"">
            <input type=""text"" name=""TuKhoa"" class=""form-control"" placeholder=""nhập từ khóa"">
            <div class=""input-group-append"">
                <button class=""btn btn-info"" type=""submit"">Tìm kiếm</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<br />\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>STT</th>\r\n            <th>Mã Loại Hàng</th>\r\n            <th>Tên Loại Hàng</th>\r\n            <th>&nbsp;</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
         foreach(LoaiHang eachItem in Model.dsLH)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>#");
#nullable restore
#line 38 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
             Write(Model.dsLH.IndexOf(eachItem) + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
           Write(eachItem.MaLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
           Write(eachItem.TenLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1081, "\"", 1132, 2);
            WriteAttributeValue("", 1088, "/MH_LoaiHang/SuaLH?MaLH=", 1088, 24, true);
#nullable restore
#line 42 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
WriteAttributeValue("", 1112, eachItem.MaLoaiHang, 1112, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n                |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1231, 2);
            WriteAttributeValue("", 1187, "/MH_LoaiHang/XoaLH?MaLH=", 1187, 24, true);
#nullable restore
#line 44 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
WriteAttributeValue("", 1211, eachItem.MaLoaiHang, 1211, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\DanhSachLH.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang.Pages.MH_LoaiHang.DanhSachLHModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_LoaiHang.DanhSachLHModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_LoaiHang.DanhSachLHModel>)PageContext?.ViewData;
        public QuanLyCuaHang.Pages.MH_LoaiHang.DanhSachLHModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591