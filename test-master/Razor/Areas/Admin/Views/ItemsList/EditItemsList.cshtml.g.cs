#pragma checksum "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b45bd9c4c60986c73101a7ce3d786bbb0e71d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ItemsList_EditItemsList), @"mvc.1.0.view", @"/Areas/Admin/Views/ItemsList/EditItemsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ItemsList/EditItemsList.cshtml", typeof(AspNetCore.Areas_Admin_Views_ItemsList_EditItemsList))]
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
#line 8 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
using project_banhang.Models;

#line default
#line hidden
#line 10 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b45bd9c4c60986c73101a7ce3d786bbb0e71d0", @"/Areas/Admin/Views/ItemsList/EditItemsList.cshtml")]
    public class Areas_Admin_Views_ItemsList_EditItemsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
  
    ViewData["Title"] = "EditItemsList";
    Layout = "~/Areas/Admin/Views/_share/_layout.cshtml";

#line default
#line hidden
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(252, 247, true);
            WriteLiteral("\r\n\r\n<article class=\"content item-editor-page\">\r\n    <div class=\"title-block\">\r\n        <h3 class=\"title\">\r\n            Add new item <span class=\"sparkline bar\" data-type=\"bar\"></span>\r\n        </h3>\r\n    </div>\r\n    <form name=\"item\" method=\"post\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 499, "\"", 527, 1);
#line 19 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
WriteAttributeValue("", 508, ViewBag.FormAction, 508, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(528, 32, true);
            WriteLiteral(" enctype=\"multipart/form-data\"> ");
            EndContext();
            BeginContext(624, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(635, 23, false);
#line 20 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(658, 338, true);
            WriteLiteral(@"
        <div class=""card card-block"">
            <!--row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Tên sản phẩm: </label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control boxed"" placeholder="""" name=""name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 996, "\"", 1050, 1);
            WriteAttributeValue("", 1004, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 26 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                     if (Model != null) {

#line default
#line hidden
                BeginContext(1032, 10, false);
#line 26 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                          Write(Model.name);

#line default
#line hidden
                EndContext();
#line 26 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                                                 }

#line default
#line hidden
                PopWriter();
            }
            ), 1004, 46, false);
            EndWriteAttribute();
            BeginContext(1051, 27, true);
            WriteLiteral(">\r\n                </div>\r\n");
            EndContext();
#line 28 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                  
                    //lay bien mode truyen tu url
                    string mode = Context.Request.Query["mode"].ToString();
                    if (mode == "exists")
                    {

#line default
#line hidden
            BeginContext(1292, 234, true);
            WriteLiteral("                        <div class=\"col-sm-3\"></div>\r\n                        <div class=\"alert alert-danger col-sm-6\">\r\n                            <strong>Thông báo</strong> Tên sản phẩm đã tồn tại.\r\n                        </div>\r\n");
            EndContext();
#line 37 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1568, 307, true);
            WriteLiteral(@"            </div>
            <!--row-->
            <!--end row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Nội dung: </label>
                <div class=""col-md-10"">
                    <textarea name=""content"" id=""content"">");
            EndContext();
#line 45 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                           if(Model!=null){

#line default
#line hidden
            BeginContext(1899, 13, false);
#line 45 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                            Write(Model.content);

#line default
#line hidden
            EndContext();
#line 45 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                      }

#line default
#line hidden
            BeginContext(1920, 447, true);
            WriteLiteral(@"</textarea>
                    <script language=""javascript"">
                        CKEDITOR.replace(""content"");
                    </script>
                </div>
            </div>
            <!--end row-->
            <!--row-->
            <div class=""form-group row"">
                <div class=""col-md-2"">Mô tả:</div>
                <div class=""col-md-10"">
                    <textarea name=""description"" id=""description"">");
            EndContext();
#line 56 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                   if (Model != null) { 

#line default
#line hidden
            BeginContext(2396, 17, false);
#line 56 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                         Write(Model.description);

#line default
#line hidden
            EndContext();
#line 56 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                        }

#line default
#line hidden
            BeginContext(2422, 425, true);
            WriteLiteral(@"</textarea>
                    <script language=""javascript"">
                        CKEDITOR.replace(""description"");
                    </script>
                </div>
            </div>

            <!--row-->
            <div class=""form-group row"">
                <div class=""col-md-2"">Thông tin khuyến mãi</div>
                <div class=""col-md-10"">
                    <textarea name=""note"" id=""note"">");
            EndContext();
#line 67 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                     if (Model != null) { 

#line default
#line hidden
            BeginContext(2876, 10, false);
#line 67 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                           Write(Model.note);

#line default
#line hidden
            EndContext();
#line 67 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                   }

#line default
#line hidden
            BeginContext(2895, 556, true);
            WriteLiteral(@"</textarea>
                    <script language=""javascript"">
                        CKEDITOR.replace(""note"");
                    </script>
                </div>
            </div>

            <!--row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Danh mục: </label>
                <div class=""col-sm-3"">
                    <select name=""id_category"" class=""form-control"" style=""width: 300px;"">
                        <option value=""0"">Nhiều danh mục hơn</option>
");
            EndContext();
#line 80 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                          
                            //khoi tao doi tuong de truy van csdl
                            DataContext db = new DataContext();
                            var category = db.ItemsCategories.OrderByDescending(tbl => tbl.id).ToList();
                        

#line default
#line hidden
            BeginContext(3744, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 85 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                         foreach (var item in category)
                        {

#line default
#line hidden
            BeginContext(3828, 36, true);
            WriteLiteral("                            <option ");
            EndContext();
#line 87 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                     if (Model != null && item.id == Model.id_category) { 

#line default
#line hidden
            BeginContext(3924, 9, true);
            WriteLiteral(" selected");
            EndContext();
#line 87 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                 }

#line default
#line hidden
            BeginContext(3942, 8, true);
            WriteLiteral(" value=\"");
            EndContext();
            BeginContext(3951, 7, false);
#line 87 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                     Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(3958, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(3961, 9, false);
#line 87 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(3970, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 88 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                        }

#line default
#line hidden
            BeginContext(4008, 196, true);
            WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <label class=\"col-sm-2 form-control-label text-xs-right\"> Thương hiệu: </label>\r\n                <div class=\"col-sm-3\" \">\r\n");
            EndContext();
            BeginContext(4402, 160, true);
            WriteLiteral("                    <select name=\"brand\" class=\"form-control\" style=\"width: 300px;\">\r\n                        <option value=\"0\">Nhiều thương hiệu hơn</option>\r\n");
            EndContext();
#line 97 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                         foreach (var brand in ViewBag.brand1)
                        {

#line default
#line hidden
            BeginContext(4653, 36, true);
            WriteLiteral("                            <option ");
            EndContext();
#line 99 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                     if (Model != null && Model.id_brand == brand.id) { 

#line default
#line hidden
            BeginContext(4747, 9, true);
            WriteLiteral(" selected");
            EndContext();
#line 99 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                               }

#line default
#line hidden
            BeginContext(4765, 8, true);
            WriteLiteral(" value=\"");
            EndContext();
            BeginContext(4774, 8, false);
#line 99 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                   Write(brand.id);

#line default
#line hidden
            EndContext();
            BeginContext(4782, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(4785, 10, false);
#line 99 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                              Write(brand.name);

#line default
#line hidden
            EndContext();
            BeginContext(4795, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 100 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                        }

#line default
#line hidden
            BeginContext(4833, 363, true);
            WriteLiteral(@"                    </select>
                </div>
            </div>
            <!--row-->
            <!--row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Dung lượng </label>
                <div class=""col-sm-4"">
                    <input type=""number"" name=""storage"" value=""");
            EndContext();
#line 109 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                if (Model != null) {

#line default
#line hidden
            BeginContext(5224, 13, false);
#line 109 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                     Write(Model.storage);

#line default
#line hidden
            EndContext();
#line 109 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                               }

#line default
#line hidden
            BeginContext(5245, 303, true);
            WriteLiteral(@""" id=""storage"" />GB
                </div>
            </div>

            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Bus Ram </label>
                <div class=""col-sm-4"">
                    <input type=""number"" name=""busram"" value=""");
            EndContext();
#line 116 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                               if (Model != null) {

#line default
#line hidden
            BeginContext(5576, 12, false);
#line 116 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                    Write(Model.busram);

#line default
#line hidden
            EndContext();
#line 116 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                             }

#line default
#line hidden
            BeginContext(5596, 310, true);
            WriteLiteral(@""" id=""busram"" />MHz
                </div>
            </div>

            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Chuẩn ổ cứng </label>
                <div class=""col-sm-4"">
                    <input type=""text"" name=""chuanocung"" value=""");
            EndContext();
#line 123 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                 if (Model != null) {

#line default
#line hidden
            BeginContext(5934, 16, false);
#line 123 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                      Write(Model.chuanocung);

#line default
#line hidden
            EndContext();
#line 123 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                   }

#line default
#line hidden
            BeginContext(5958, 351, true);
            WriteLiteral(@""" id=""chuanocung"" />
                </div>
            </div>
            <!--end row-->
            <!--row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Giá: </label>
                <div class=""col-sm-10"">
                    <input type=""number"" name=""price"" value=""");
            EndContext();
#line 131 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                              if (Model != null) {

#line default
#line hidden
            BeginContext(6337, 11, false);
#line 131 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                   Write(Model.price);

#line default
#line hidden
            EndContext();
#line 131 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                           }

#line default
#line hidden
            BeginContext(6356, 366, true);
            WriteLiteral(@""" id=""discount"" />(VNĐ)
                </div>


            </div>
            <!--end row-->
            <!--row-->
            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Giảm giá: </label>
                <div class=""col-sm-10"">
                    <input type=""number"" name=""discount"" value=""");
            EndContext();
#line 141 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                 if (Model != null) {

#line default
#line hidden
            BeginContext(6750, 14, false);
#line 141 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                      Write(Model.discount);

#line default
#line hidden
            EndContext();
#line 141 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                                 }

#line default
#line hidden
            BeginContext(6772, 383, true);
            WriteLiteral(@""" id=""discount"" />%

                </div>

            </div>

            <!--end row-->
            <!--row-->
            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <label class=""col-sm-1 form-control-label text-xs-right""> Hot: </label>
                <div class=""col-sm-1"">
                    <input type=""checkbox"" ");
            EndContext();
#line 153 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                            if (Model != null && Model.hot == true) { 

#line default
#line hidden
            BeginContext(7204, 8, true);
            WriteLiteral(" checked");
            EndContext();
#line 153 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                            }

#line default
#line hidden
            BeginContext(7221, 223, true);
            WriteLiteral(" name=\"hot\" id=\"hot\">\r\n                </div>\r\n\r\n                <label class=\"col-sm-1 form-control-label text-xs-right\"> Sales: </label>\r\n                <div class=\"col-sm-1\">\r\n                    <input type=\"checkbox\" ");
            EndContext();
#line 158 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                            if (Model != null && Model.sale == true) { 

#line default
#line hidden
            BeginContext(7494, 8, true);
            WriteLiteral(" checked");
            EndContext();
#line 158 "G:\ASP.NET\project_banhang\project_banhang\Areas\Admin\Views\ItemsList\EditItemsList.cshtml"
                                                                                                             }

#line default
#line hidden
            BeginContext(7511, 1205, true);
            WriteLiteral(@" name=""sale"" id=""sale"">
                </div>

            </div>
            <!--end row-->
            <!--row-->

            <div class=""form-group row"">
                <label class=""col-sm-2 form-control-label text-xs-right""> Ảnh: </label>
                <div class=""col-sm-10"">
                    <input type=""file"" name=""media"">
                </div>
            </div>
            <!--end row-->
            <!--row-->
            <div class=""form-group row"">
                <div class=""form-group row"">
                    <div class=""col-sm-10 col-sm-offset-2"">
                        <button type=""submit"" class=""btn btn-primary""> Submit </button>
                    </div>
                </div>
            </div>
            <!--end row-->
        </div>
    </form>
</article>

<script language=""javascript"">
    document.getElementById(""sale"").onclick = function (e) {
        if (this.checked) {
                        document.getElementById(""discount"").readOnly = fa");
            WriteLiteral("lse;\r\n                    }\r\n        else {\r\n                        document.getElementById(\"discount\").readOnly = true;\r\n                    }\r\n                    };\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
