#pragma checksum "G:\ASP.NET\project_banhang\project_banhang\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7040252cbf275d8ce3c2b6db29421d3ad30a3421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7040252cbf275d8ce3c2b6db29421d3ad30a3421", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\ASP.NET\project_banhang\project_banhang\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/_shared/_chiTiet.cshtml";

#line default
#line hidden
            BeginContext(95, 1117, true);
            WriteLiteral(@"
<section class=""bread-crumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul class=""breadcrumb"" itemscope="""" itemtype=""http://data-vocabulary.org/Breadcrumb"">
                    <li class=""home"">
                        <a itemprop=""url"" href=""/""><span itemprop=""title"">Trang chủ</span></a>
                        <span><i class=""fa fa-angle-right"" aria-hidden=""true""></i></span>
                    </li>

                    <li><strong itemprop=""title"">Đăng ký tài khoản</strong></li>

                </ul>
            </div>
        </div>
    </div>
</section>

<div class=""container margin-bottom-20"">
    <h1 class=""title-head""><a href=""#"">Đăng ký tài khoản</a></h1>
    <div class=""row"">
        <div class=""col-lg-12 "">
            <div class=""page-login"">
                <div id=""login"">
                    <span>Nếu chưa có tài khoản vui lòng đăng ký tại đây</span>

                    <form accept-charset=""UTF-8"" i");
            WriteLiteral("d=\"customer_register\" method=\"post\" action=\"/Account/RegisterPost\">\r\n                        ");
            EndContext();
            BeginContext(1213, 23, false);
#line 34 "G:\ASP.NET\project_banhang\project_banhang\Views\Account\Register.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1236, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2550, 1896, true);
            WriteLiteral(@"                        <div class=""form-signup"">

                        </div>
                        <div class=""form-signup clearfix"">
                            <div class=""row col-md-6"">
                                <div class=""col-md-12"">
                                    <fieldset class=""form-group"">
                                        <label> Họ<span class=""required"">*</span></label>
                                        <input type=""text"" class=""form-control form-control-lg"" value="""" name=""lastName"" id=""lastName"" placeholder="""" required="""">
                                    </fieldset>
                                </div>

                                <div class=""col-md-12"">
                                    <fieldset class=""form-group"">
                                        <label>Tên <span class=""required"">*</span></label>
                                        <input type=""text"" class=""form-control form-control-lg"" value="""" name=""firstName"" id=""firstName"" ");
            WriteLiteral(@"placeholder="""" required="""">
                                    </fieldset>
                                </div>

                                <div class=""col-md-12"">
                                    <fieldset class=""form-group"">
                                        <label>Địa chỉ <span class=""required"">*</span></label>
                                        <input type=""text"" class=""form-control form-control-lg"" value="""" name=""address"" id=""firstName"" placeholder="""" required="""">
                                    </fieldset>
                                </div>

                                <div class=""col-md-12"">
                                    <fieldset class=""form-group"">
                                        <label>Email <span class=""required"">*</span></label>
                                        <input type=""email""");
            EndContext();
            BeginWriteAttribute("pattern", " pattern=\"", 4446, "\"", 4497, 3);
            WriteAttributeValue("", 4456, "[a-z0-9._%+-]+", 4456, 14, true);
            WriteAttributeValue("", 4470, "@", 4470, 1, true);
            WriteAttributeValue("", 4472, "[a-z0-9.-]+\\.[a-z]{2,63}$", 4472, 25, true);
            EndWriteAttribute();
            BeginContext(4498, 1808, true);
            WriteLiteral(@" class=""form-control form-control-lg"" value="""" name=""email"" id=""email"" placeholder=""Tên đăng nhập"" required="""">
                                    </fieldset>
                                </div>

                                <div class=""col-md-12"">
                                    <fieldset class=""form-group"">
                                        <label>Mật khẩu <span class=""required"">*</span> </label>
                                        <input type=""password"" class=""form-control form-control-lg"" value="""" name=""password"" id=""password"" placeholder=""Mật khẩu"" required="""">
                                    </fieldset>
                                </div>

                                <div class=""col-md-12"">
                                    <fieldset class=""form-group"">
                                        <label>Số điện thoại <span class=""required"">*</span></label>
                                        <input type=""text"" class=""form-control form-control-lg"" value="""" ");
            WriteLiteral(@"name=""phone"" id=""firstName"" placeholder=""Số điện thoại"" required="""">
                                    </fieldset>
                                </div>
                            </div>


                            <div class=""col-xs-12 text-xs-left"" style=""margin-top:30px; padding: 0"">
                                <button type=""summit"" value=""Đăng ký"" class=""btn  btn-style btn-primary"" onclick=""check()"">Đăng ký</button>
                                <a href=""/Account/Login"" class=""btn-link-style btn-register"" style=""margin-left: 20px;text-decoration: underline; "">Đăng nhập</a>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
