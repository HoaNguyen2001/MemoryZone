#pragma checksum "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a4f170efd8e9ee8a6f2bfb1421dac1908b6eb65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ItemsConfiguration_Configuration), @"mvc.1.0.view", @"/Areas/Admin/Views/ItemsConfiguration/Configuration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ItemsConfiguration/Configuration.cshtml", typeof(AspNetCore.Areas_Admin_Views_ItemsConfiguration_Configuration))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 14 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 8 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
using project_banhang.Models;

#line default
#line hidden
#line 10 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 16 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
using System.IO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a4f170efd8e9ee8a6f2bfb1421dac1908b6eb65", @"/Areas/Admin/Views/ItemsConfiguration/Configuration.cshtml")]
    public class Areas_Admin_Views_ItemsConfiguration_Configuration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<items_configuration>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
  
    ViewData["Title"] = "Configuration";
    Layout = "~/Areas/Admin/Views/_share/_layout.cshtml";

#line default
#line hidden
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(445, 781, true);
            WriteLiteral(@"
<article class=""content items-list-page"">
    <div class=""title-search-block"">
        <div class=""title-block"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <h3 class=""title"">
                        Items <a href=""/Admin/ItemsConfiguration/Add"" class=""btn btn-primary btn-sm rounded-s""> Add New </a>
                        <!--
                        -->
                        <div class=""action dropdown"">
                            <button class=""btn  btn-sm rounded-s btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""> More actions... </button>
                            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenu1"">
");
            EndContext();
            BeginContext(1416, 2520, true);
            WriteLiteral(@"                                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#confirm-modal""><i class=""fa fa-close icon""></i>Delete</a>
                            </div>
                        </div>
                    </h3>
                    <p class=""title-description""> Danh sách cấu hình sản phẩm </p>
                </div>
            </div>
        </div>
        <div class=""items-search"">
            <form class=""form-inline"">
                <div class=""input-group"">
                    <input type=""text"" class=""form-control boxed rounded-s"" placeholder=""Search for..."" style=""height:33px"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-secondary rounded-s"" type=""button"">
                            <i class=""fa fa-search""></i>
                        </button>
                    </span>
                </div>
            </form>
        </div>
    </div>
    <div class=""card items"">
        <ul class=""i");
            WriteLiteral(@"tem-list striped"">
            <li class=""item item-list-header"">
                <div class=""item-row"">
                    <div class=""item-col fixed item-col-check"">
                        <label class=""item-check"" id=""select-all-items"">
                            <input type=""checkbox"" class=""checkbox"">
                            <span></span>
                        </label>
                    </div>

                    <div class=""item-col item-col-header item-col-title"">
                        <div>
                            <span>Tên sản phẩm</span>
                        </div>
                    </div>

                    <div class=""item-col item-col-header item-col-header"">
                        <div class=""no-overflow"">
                            <span>Thương hiệu</span>
                        </div>
                    </div>

                    <div class=""item-col item-col-header item-col-category"">
                        <div class=""no-overflow"">
     ");
            WriteLiteral(@"                       <span>Dung lượng</span>
                        </div>
                    </div>

                    <div class=""item-col item-col-header fixed item-col-actions-dropdown"">
                    </div>
                    <div class=""item-col fixed item-col-actions-dropdown"">
                        <div class=""item-actions-dropdown"">

                        </div>
                    </div>
                </div>
            </li>
");
            EndContext();
#line 90 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(3993, 599, true);
            WriteLiteral(@"                <li class=""item item-list-header"">
                    <div class=""item-row"">
                        <div class=""item-col fixed item-col-check"">
                            <label class=""item-check"" id=""select-all-items"">
                                <input type=""checkbox"" class=""checkbox"">
                                <span></span>
                            </label>
                        </div>

                        <div class=""item-col item-col-header item-col-title"" style=""re"">
                            <div>
                                <span>");
            EndContext();
            BeginContext(4593, 24, false);
#line 103 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
                                 Write(ViewBag.nameProduct.name);

#line default
#line hidden
            EndContext();
            BeginContext(4617, 252, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"item-col item-col-header item-col-header\">\r\n                            <div class=\"no-overflow\">\r\n                                <span>");
            EndContext();
            BeginContext(4870, 10, false);
#line 109 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
                                 Write(item.brand);

#line default
#line hidden
            EndContext();
            BeginContext(4880, 254, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"item-col item-col-header item-col-category\">\r\n                            <div class=\"no-overflow\">\r\n                                <span>");
            EndContext();
            BeginContext(5135, 12, false);
#line 115 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
                                 Write(item.storage);

#line default
#line hidden
            EndContext();
            BeginContext(5147, 1035, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>

                        <div class=""item-col item-col-header fixed item-col-actions-dropdown""></div>
                        <div class=""item-col fixed item-col-actions-dropdown"">
                            <div class=""item-actions-dropdown"">
                                <a class=""item-actions-toggle-btn"">
                                    <span class=""inactive"">
                                        <i class=""fa fa-cog""></i>
                                    </span>
                                    <span class=""active"">
                                        <i class=""fa fa-chevron-circle-right""></i>
                                    </span>
                                </a>
                                <div class=""item-actions-block"">
                                    <ul class=""item-actions-list"">
                                        <li>
                                            <a cla");
            WriteLiteral("ss=\"remove\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6182, "\"", 6233, 2);
            WriteAttributeValue("", 6189, "/Admin/ItemsConfiguration/Delete?id=", 6189, 36, true);
#line 133 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
WriteAttributeValue("", 6225, item.id, 6225, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6234, 335, true);
            WriteLiteral(@" onclick=""return window.confirm('Are you sure?');"">
                                                <i class=""fa fa-trash-o ""></i>
                                            </a>
                                        </li>
                                        <li>
                                            <a class=""edit""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6569, "\"", 6618, 2);
            WriteAttributeValue("", 6576, "/Admin/ItemsConfiguration/Edit?id=", 6576, 34, true);
#line 138 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
WriteAttributeValue("", 6610, item.id, 6610, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6619, 380, true);
            WriteLiteral(@">
                                                <i class=""fa fa-pencil""></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
");
            EndContext();
#line 148 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
            }

#line default
#line hidden
            BeginContext(7014, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(7027, 90, false);
#line 149 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsConfiguration\Configuration.cshtml"
       Write(Html.PagedListPager(Model, page => Url.Action("Configuration", "ItemsList", new { page })));

#line default
#line hidden
            EndContext();
            BeginContext(7117, 43, true);
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n</article>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<items_configuration>> Html { get; private set; }
    }
}
#pragma warning restore 1591