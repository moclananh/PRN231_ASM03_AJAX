#pragma checksum "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Order\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4e83b78f94e8a388be7b99cf608eb1dea44f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Create), @"mvc.1.0.view", @"/Views/Order/Create.cshtml")]
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
#line 1 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4e83b78f94e8a388be7b99cf608eb1dea44f8d", @"/Views/Order/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("order-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4e83b78f94e8a388be7b99cf608eb1dea44f8d3902", async() => {
                WriteLiteral("\r\n    <title>Tạo Đơn Đặt Hàng</title>\r\n    <style>\r\n        /* CSS để tùy chỉnh giao diện biểu mẫu */\r\n        label, input, button {\r\n            display: block;\r\n            margin-bottom: 10px;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4e83b78f94e8a388be7b99cf608eb1dea44f8d5105", async() => {
                WriteLiteral("\r\n    <h2>Create Order</h2>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4e83b78f94e8a388be7b99cf608eb1dea44f8d5400", async() => {
                    WriteLiteral("\r\n        <!-- memberId sẽ được lấy từ phiên đăng nhập, không cần nhập tay -->\r\n        <input type=\"hidden\" id=\"memberId\" name=\"memberId\"");
                    BeginWriteAttribute("value", " value=\"", 464, "\"", 472, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\r\n        <!-- Thời gian thực tế cho orderDate -->\r\n        <input type=\"hidden\" id=\"orderDate\" name=\"orderDate\"");
                    BeginWriteAttribute("value", " value=\"", 588, "\"", 596, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">

        <label for=""requireDate"">Ngày yêu cầu giao hàng:</label>
        <input type=""date"" id=""requireDate"" name=""requireDate"">

        <label for=""shippedDate"">Ngày giao hàng:</label>
        <input type=""date"" id=""shippedDate"" name=""shippedDate"">

        <label for=""freight"">Phí vận chuyển:</label>
        <input type=""number"" id=""freight"" name=""freight"">

        <button type=""button"" id=""create-order-button"">Tạo Đơn Đặt Hàng</button>
    ");
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
                WriteLiteral(@"

    <script>
        document.getElementById(""create-order-button"").addEventListener(""click"", function () {
            // Lấy thông tin từ biểu mẫu
            var requireDate = document.getElementById(""requireDate"").value;
            var shippedDate = document.getElementById(""shippedDate"").value;
            var freight = parseFloat(document.getElementById(""freight"").value);

            // Lấy thời gian thực tế cho orderDate
            var orderDate = new Date().toISOString();

            // Lấy memberId từ server
            var xhr = new XMLHttpRequest();
            xhr.open(""GET"", ""/User/GetUserId"", true);
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    var memberId = xhr.responseText;

                    // Tạo đối tượng dữ liệu đơn đặt hàng
                    var orderData = {
                        ""memberId"": memberId,
                        ""orderDate"": orderDate,
              ");
                WriteLiteral(@"          ""requireDate"": requireDate,
                        ""shippedDate"": shippedDate,
                        ""freight"": freight
                    };

                    // Gửi yêu cầu tạo đơn đặt hàng qua AJAX
                    var apiUrl = ""https://localhost:5001/api/Orders"";
                    var xhrCreateOrder = new XMLHttpRequest();
                    xhrCreateOrder.open(""POST"", apiUrl, true);
                    xhrCreateOrder.setRequestHeader(""Content-Type"", ""application/json;charset=UTF-8"");

                    xhrCreateOrder.onreadystatechange = function () {
                        if (xhrCreateOrder.readyState === 4) {
                            if (xhrCreateOrder.status === 201) {
                                // Xử lý khi đơn đặt hàng đã được tạo thành công
                                console.log(""Đơn đặt hàng đã được tạo."");
                                window.location.href = ""https://localhost:5002/Order"";
                            } else {
           ");
                WriteLiteral(@"                     // Xử lý khi tạo đơn đặt hàng thất bại
                                console.log(""Tạo đơn đặt hàng thất bại."");
                            }
                        }
                    };

                    // Chuyển đổi dữ liệu đơn đặt hàng thành chuỗi JSON
                    var orderDataJSON = JSON.stringify(orderData);
                    xhrCreateOrder.send(orderDataJSON);
                }
            };

            xhr.send();
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
