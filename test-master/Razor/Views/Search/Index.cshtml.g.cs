#pragma checksum "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d6e2e0509cbdcfdb0392403db9ebff2548836e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Index.cshtml", typeof(AspNetCore.Views_Search_Index))]
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
#line 8 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
using project_banhang.Models;

#line default
#line hidden
#line 10 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 13 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d6e2e0509cbdcfdb0392403db9ebff2548836e", @"/Views/Search/Index.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<ItemsList>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_shared/_chiTiet.cshtml";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(377, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
 if (ViewBag._query == null || ViewBag._query == "")
{

#line default
#line hidden
            BeginContext(436, 704, true);
            WriteLiteral(@"    <section class=""bread-crumb"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ul class=""breadcrumb"" itemscope="""" itemtype=""http://data-vocabulary.org/Breadcrumb"">
                        <li class=""home"">
                            <a itemprop=""url"" href=""/""><span itemprop=""title"">Trang chủ</span></a>
                            <span><i class=""fa fa-angle-right"" aria-hidden=""true""></i></span>
                        </li>
                        <li><strong>Kết quả tìm kiếm với từ khóa """"</strong></li>

                    </ul>
                </div>
            </div>
        </div>
    </section>
");
            EndContext();
            BeginContext(1142, 270, true);
            WriteLiteral(@"    <div class=""bread-crumb"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h3>Không có kết quả tìm kiếm phù hợp</h3>
                </div>
            </div>
        </div>
    </div>");
            EndContext();
#line 42 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
          }
else
{

#line default
#line hidden
            BeginContext(1424, 582, true);
            WriteLiteral(@"    <section class=""bread-crumb"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ul class=""breadcrumb"" itemscope="""" itemtype=""http://data-vocabulary.org/Breadcrumb"">
                        <li class=""home"">
                            <a itemprop=""url"" href=""/""><span itemprop=""title"">Trang chủ</span></a>
                            <span><i class=""fa fa-angle-right"" aria-hidden=""true""></i></span>
                        </li>
                        <li><strong>Kết quả tìm kiếm với từ khóa """);
            EndContext();
            BeginContext(2007, 14, false);
#line 54 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                             Write(ViewBag._query);

#line default
#line hidden
            EndContext();
            BeginContext(2021, 122, true);
            WriteLiteral("\"</strong></li>\r\n\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            EndContext();
            BeginContext(2145, 229, true);
            WriteLiteral("    <section class=\"signup search-main\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n\r\n\r\n\r\n                <div class=\"col-xs-12 margin-bottom-15\">\r\n                    <h1 class=\"title-head title_search\">Có ");
            EndContext();
            BeginContext(2375, 13, false);
#line 69 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                      Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2388, 280, true);
            WriteLiteral(@" kết quả tìm kiếm phù hợp</h1>

                </div>
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12 margin-bottom-30"">
                    <div class=""products-view-gridsss products cls_search"">
                        <div class=""row content_col"">

");
            EndContext();
#line 76 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2757, 455, true);
            WriteLiteral(@"                                <div class=""col-xs-6 col-sm-4 col-md-3 col-lg-3 col-lg-fix-5"">
                                    <div class=""product-col"">


































                                        <div class=""product-box-h"">
                                            <div class=""product-thumbnail"">
                                                <a class=""image_link display_flex""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3212, "\"", 3243, 2);
            WriteAttributeValue("", 3219, "/Product/Detail/", 3219, 16, true);
#line 116 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
WriteAttributeValue("", 3235, item.id, 3235, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3244, "\"", 3262, 1);
#line 116 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
WriteAttributeValue("", 3252, item.name, 3252, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3263, 55, true);
            WriteLiteral(">\r\n                                                    ");
            EndContext();
            BeginContext(3318, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f15beafa7ca14185923cac17073e8863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3328, "~/Upload/Products/", 3328, 18, true);
#line 117 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 3346, item.media, 3346, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Upload/Products/");
#line 117 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                                                                         Write(item.media);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-lazyload", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 117 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 3410, item.name, 3410, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3422, 578, true);
            WriteLiteral(@"
                                                </a>

                                                <!-- Tag giá sốc -->
                                                <!-- End tag giá sốc -->
                                                <!-- Tag Mã KM -->
                                                <!-- End Tag Mã KM -->
                                            </div>
                                            <div class=""product-info a-left"">
                                                <h3 class=""product-name""><a class=""height_name text2line""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4000, "\"", 4031, 2);
            WriteAttributeValue("", 4007, "/Product/Detail/", 4007, 16, true);
#line 126 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
WriteAttributeValue("", 4023, item.id, 4023, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4032, "\"", 4050, 1);
#line 126 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
WriteAttributeValue("", 4040, item.name, 4040, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4051, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4053, 9, false);
#line 126 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                                                                                                        Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(4062, 170, true);
            WriteLiteral("</a></h3>\r\n\r\n                                                <div class=\"product-hides\">\r\n                                                    <div class=\"product-hide\">\r\n");
            EndContext();
#line 130 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                          
                                                            var infor = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                                                        

#line default
#line hidden
            BeginContext(4482, 92, true);
            WriteLiteral("\r\n                                                        <div class=\"price-box clearfix\">\r\n");
            EndContext();
#line 135 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                             if (item.sale == true)
                                                            {
                                                                double newprice = item.price - item.price * item.discount / 100;
                                                                

#line default
#line hidden
            BeginContext(4922, 135, true);
            WriteLiteral("<div class=\"special-price\">\r\n                                                                        <span class=\"price product-price\">");
            EndContext();
            BeginContext(5058, 45, false);
#line 139 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                                                     Write(string.Format(infor, "{0:c0" + "}", newprice));

#line default
#line hidden
            EndContext();
            BeginContext(5103, 366, true);
            WriteLiteral(@"</span>
                                                                    </div>
                                                                    <div class=""old-price"">
                                                                        <span class=""price product-price-old"">
                                                                            ");
            EndContext();
            BeginContext(5470, 47, false);
#line 143 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                       Write(string.Format(infor, "{0:c0" + "}", item.price));

#line default
#line hidden
            EndContext();
            BeginContext(5517, 157, true);
            WriteLiteral("\r\n                                                                        </span>\r\n                                                                    </div>");
            EndContext();
#line 145 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                                 
                                                            }
                                                            else
                                                            {
                                                                

#line default
#line hidden
            BeginContext(5945, 209, true);
            WriteLiteral("<div class=\"old-price\">\r\n                                                                        <span class=\"price product-price\">\r\n                                                                            ");
            EndContext();
            BeginContext(6155, 47, false);
#line 151 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                       Write(string.Format(infor, "{0:c0" + "}", item.price));

#line default
#line hidden
            EndContext();
            BeginContext(6202, 157, true);
            WriteLiteral("\r\n                                                                        </span>\r\n                                                                    </div>");
            EndContext();
#line 153 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                                 
                                                            }

#line default
#line hidden
            BeginContext(6431, 342, true);
            WriteLiteral(@"

                                                        </div>


                                                    </div>
                                                </div>
                                                <div class=""product-action clearfix hidden-xs"">
                                                    <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 6773, "\"", 6800, 2);
            WriteAttributeValue("", 6782, "/Cart/Buy/", 6782, 10, true);
#line 163 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
WriteAttributeValue("", 6792, item.id, 6792, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6801, 55, true);
            WriteLiteral(" method=\"post\" class=\"variants form-nut-grid\" data-id=\"");
            EndContext();
            BeginContext(6857, 7, false);
#line 163 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                                                                                                       Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(6864, 90, true);
            WriteLiteral("\" enctype=\"multipart/form-data\">\r\n                                                        ");
            EndContext();
            BeginContext(6955, 23, false);
#line 164 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(6978, 2144, true);
            WriteLiteral(@"
                                                        <div>

                                                            <input type=""hidden"" name=""variantId"" value=""20443148"">
                                                            <button class=""btn-buy btn-cart btn btn-circle left-to "" title=""Thêm vào giỏ hàng"">
                                                                <i class=""fa fa-shopping-basket""></i>Mua ngay
                                                            </button>


                                                            <a data-toggle=""tooltip"" title="""" href=""/o-cung-mang-hdd-6tb-western-digital-cloud-home-wdbvxc0060hwt"" data-handle=""o-cung-mang-hdd-6tb-western-digital-cloud-home-wdbvxc0060hwt"" class=""xem_nhanh btn-circle btn_view btn right-to quick-view hidden-xs hidden-sm hidden-md"" data-original-title=""Xem nhanh"">
                                                                <i class=""fa fa-eye""></i>
                                                      ");
            WriteLiteral(@"      </a>

                                                        </div>
                                                    </form>
                                                </div>

                                                <div class=""bizweb-product-reviews-badge"" data-id=""12489038""><div class=""bizweb-product-reviews-star"" data-score=""5"" data-number=""5"" title=""Tuyệt vời"" style=""color: rgb(255, 190, 0);""><i data-alt=""1"" class=""star-on-png"" title=""Tuyệt vời""></i>&nbsp;<i data-alt=""2"" class=""star-on-png"" title=""Tuyệt vời""></i>&nbsp;<i data-alt=""3"" class=""star-on-png"" title=""Tuyệt vời""></i>&nbsp;<i data-alt=""4"" class=""star-on-png"" title=""Tuyệt vời""></i>&nbsp;<i data-alt=""5"" class=""star-on-png"" title=""Tuyệt vời""></i><input name=""score"" type=""hidden"" value=""5"" readonly=""""></div><div><p>1</p></div><div><img src=""https://productreviews.sapoapps.vn//assets/images/user.png"" width=""18"" height=""17""></div></div>
                                            </div>
                                    ");
            WriteLiteral("    </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 186 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(9153, 152, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            EndContext();
#line 201 "G:\ASP.NET\project_banhang\project_banhang\Views\Search\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<ItemsList>> Html { get; private set; }
    }
}
#pragma warning restore 1591