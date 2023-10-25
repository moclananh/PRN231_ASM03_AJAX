#pragma checksum "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01c88e834c65d63b011d1c4a5d7b6e126c20a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#nullable restore
#line 1 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Order\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Order\Index.cshtml"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01c88e834c65d63b011d1c4a5d7b6e126c20a99", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <h2> Product List</h2>
    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead>
            <tr>
                <th>Order Id</th>
                <th>Member Id</th>
                <th>Order Date</th>
                <th>Require Date</th>
                <th>Shipped Date</th>
                <th>Freight</th>

            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>

<script type=""text/javascript"">
    $(document).ready(function () {
        ShowAllOrders();

        function ShowAllOrders() {
            $(""table tbody"").html("""");
            $.ajax({
                url: ""https://localhost:5001/api/Orders"",
                typ");
            WriteLiteral(@"e: ""get"",
                contentType: ""json"",
                dataType: ""json"",
                success: function (result, status, xhr) {
                    $.each(result, function (index, value) {

                        $(""tbody"").append($(""<tr>""));
                        appendElement = $(""tbody tr"").last();
                        appendElement.append($(""<td>"").html(value[""orderId""]));
                        appendElement.append($(""<td>"").html(value[""memberId""]));
                        appendElement.append($(""<td>"").html(value[""orderDate""]));
                        appendElement.append($(""<td>"").html(value[""requireDate""]));
                        appendElement.append($(""<td>"").html(value[""shippedDate""]));
                        appendElement.append($(""<td>"").html(value[""freight""]));
                        $(""tbody"").append(appendElement);
                    });
                },
                error: function (xhr, status, error) {
                    console.log(xhr);
   ");
            WriteLiteral("             }\r\n            });\r\n        }\r\n    });\r\n</script>");
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
