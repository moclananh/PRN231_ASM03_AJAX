#pragma checksum "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7aacc7c332b93c294c1a511d91e5ece1096ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Products\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Products\Index.cshtml"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7aacc7c332b93c294c1a511d91e5ece1096ae2", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7aacc7c332b93c294c1a511d91e5ece1096ae25164", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </p>


<div class=""container-fluid"">
    <h2> Product List</h2>
    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead>
            <tr>
                <th>Product Id</th>
                <th>Category Name</th>
                <th>Product Name</th>
                <th>Weight</th>
                <th>UnitPrice</th>
                <th>UnitInStock</th>
                <th>Update</th>
                <th>Delete</th>

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
        ShowAllProducts();

        function ShowAllProducts() {
            var isAdmin = '");
#nullable restore
#line 37 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Products\Index.cshtml"
                       Write(User.IsInRole("Admin")?"true":"false");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            $(""table tbody"").html("""");
            $.ajax({
                url: ""https://localhost:5001/api/Products"",
                type: ""get"",
                contentType: ""json"",
                dataType: ""json"",
                success: function (result, status, xhr) {
                    $.each(result, function (index, value) {

                        var categoryId = value[""categoryId""];
                        var categoryName = getCategoryName(categoryId);

                        $(""tbody"").append($(""<tr>""));
                        appendElement = $(""tbody tr"").last();
                        appendElement.append($(""<td>"").html(value[""productId""]));
                        appendElement.append($(""<td>"").html(categoryName));
                        appendElement.append($(""<td>"").html(value[""productName""]));
                        appendElement.append($(""<td>"").html(value[""weight""]));
                        appendElement.append($(""<td>"").html(value[""unitPrice""]));
       ");
            WriteLiteral(@"                 appendElement.append($(""<td>"").html(value[""unitInStock""]));
                        if(isAdmin == ""true""){
                             appendElement.append($(""<td>"").html(""<button class='edit btn btn-primary' data-toggle='modal' data-target='#editModal'>Edit</button>""));
                              appendElement.append($(""<td>"").html(""<button class='delete btn btn-primary' data-toggle='modal' data-target='#deleteModal'>Delete</button>""));
                        }
                        $(""tbody"").append(appendElement);
                    });
                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                }
            });
        }

        //display all category
        // Function to get category name based on categoryId
        function getCategoryName(categoryId) {
            var categoryName = """";
            $.ajax({
                async: false,
                url: ""https://localhost:5001/api/Ca");
            WriteLiteral(@"tegories/"" + categoryId,
                type: ""get"",
                success: function (data) {
                    categoryName = data.categoryName;
                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                }
            });
            return categoryName;
        }

        function loadCategories() {
            $.ajax({
                url: ""https://localhost:5001/api/Categories"",
                type: ""get"",
                success: function (data) {
                    var categoryDropdown = $(""#categoryDropdown"");

                    // Clear existing options
                    categoryDropdown.empty();

                    // Populate the dropdown with category names and IDs
                    data.forEach(function (category) {
                        categoryDropdown.append(
                            $(""<option>"")
                                .val(category.categoryId)
                           ");
            WriteLiteral(@"     .text(category.categoryName)
                        );
                    });
                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                    alert(""Error loading categories."");
                }
            });
        }

        //delete
        //$(document).on(""click"", "".delete-link"", function () {
        //    var deleteLink = $(this); // Capture the reference to the clicked delete link
        //    var productId = deleteLink.data(""id"");
        //    if (confirm(""Are you sure you want to delete this product?"")) {
        //        // Perform the delete action here using an AJAX request
        //        $.ajax({
        //            url: ""https://localhost:5001/api/Products/"" + productId,
        //            type: ""delete"",
        //            success: function (result) {
        //                // Handle the success, e.g., remove the deleted row from the table
        //                deleteLink.c");
            WriteLiteral(@"losest(""tr"").remove(); // Use the captured reference here
        //            },
        //            error: function (xhr, status, error) {
        //                console.log(xhr);
        //                alert(""Error deleting the product."");
        //            }
        //        });
        //    }
        //});

        //delete
        $(""table"").on(""click"", ""button.delete"", function () {
            var row = $(this).closest(""tr"");
            var productId = row.find(""td:nth-child(1)"").text();
            console.log(""Product Id table: "" + productId);
            // Populate the modal form for editing
            $(""#deleteModal"").find(""input[name='productId']"").val(productId);
        });


        $(""#deleteModal"").on('submit', 'form#deleteForm', function (e) {
            e.preventDefault();
            var productId = $(this).find(""input[name='productId']"").val();

            console.log(""Product ID Logic: "" + productId);
            // Send an AJAX request to u");
            WriteLiteral(@"pdate the product
            $.ajax({
                url: ""https://localhost:5001/api/Products/"" + productId,
                type: ""delete"",
                contentType: ""application/json"",
                success: function (result, status, xhr) {
                    window.location.href = ""https://localhost:5002/Products"";
                    ShowAllProducts();

                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                }
            });
        });

        //edit
        $(""table"").on(""click"", ""button.edit"", function () {
            var row = $(this).closest(""tr"");
            var productId = row.find(""td:nth-child(1)"").text();
            var categoryId = row.find(""td:nth-child(2)"").text();
            var productName = row.find(""td:nth-child(3)"").text();
            var weight = row.find(""td:nth-child(4)"").text();
            var unitPrice = row.find(""td:nth-child(5)"").text();
            var unitInStock = ro");
            WriteLiteral(@"w.find(""td:nth-child(6)"").text();
            // Populate the modal form for editing
            $(""#editModal"").find(""input[name='productId']"").val(productId);
            $(""#categoryDropdown"").val(loadCategories); // Reset category selection
            $(""#editModal"").find(""input[name='productName']"").val(productName);
            $(""#editModal"").find(""input[name='weight']"").val(weight);
            $(""#editModal"").find(""input[name='unitPrice']"").val(unitPrice);
            $(""#editModal"").find(""input[name='unitInStock']"").val(unitInStock);

        });

        // Handle the edit form submission
        $(""#editModal"").on('submit', 'form#editForm', function (e) {
            e.preventDefault();
            var productId = $(this).find(""input[name='productId']"").val();
            var updatedProduct = {
                productId: productId,
                categoryId: $(""#categoryDropdown"").val(),
                productName: $(this).find(""input[name='productName']"").val(),
            ");
            WriteLiteral(@"    weight: $(this).find(""input[name='weight']"").val(),
                unitPrice: $(this).find(""input[name='unitPrice']"").val(),
                unitInStock: $(this).find(""input[name='unitInStock']"").val()
            };
            // Send an AJAX request to update the product
            $.ajax({
                url: ""https://localhost:5001/api/Products/"" + productId,
                type: ""put"",
                contentType: ""application/json"",
                data: JSON.stringify(updatedProduct),
                success: function (result, status, xhr) {
                    window.location.href = ""https://localhost:5002/Products"";
                    ShowAllProducts();
                    $('#editModal').modal('hidden');

                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                }
            });
        });
    });
</script>

<!-- Modal for Delete Confirmation -->
<div class=""modal fade"" id=""deleteModal"" tabinde");
            WriteLiteral(@"x=""-1"" role=""dialog"" aria-labelledby=""deleteConfirmModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""deleteConfirmModalLabel"">Delete Confirmation</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>

            </div>
            <div class=""modal-body"">
                Are you sure you want to delete this product?
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7aacc7c332b93c294c1a511d91e5ece1096ae216980", async() => {
                WriteLiteral(@"
                <input type=""hidden"" name=""productId"">
                <div class=""modal-footer"">
                 <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                 <button type=""submit"" class=""btn btn-danger"" id=""confirmDelete"">Delete</button>
                   
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>
    </div>
</div>

<!-- Modal for Editing -->
<div class=""modal"" id=""editModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""editModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"" id=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editModalLabel"">Edit Product</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7aacc7c332b93c294c1a511d91e5ece1096ae219369", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""productId"">
                    <div class=""form-group"">
                        <label for=""categoryId"">Category:</label>
                        <select id=""categoryDropdown"" class=""form-control"" required></select>
                    </div>
                    <div class=""form-group"">
                        <label for=""productName"">Product Name</label>
                        <input type=""text"" name=""productName"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label for=""weight"">Weight</label>
                        <input type=""text"" name=""weight"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label for=""unitPrice"">Unit Price</label>
                        <input type=""text"" name=""unitPrice"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
            ");
                WriteLiteral(@"            <label for=""unitInStock"">unit in Stock</label>
                        <input type=""text"" name=""unitInStock"" class=""form-control"">
                    </div>
                        <button type=""submit"" form=""editForm"" class=""btn btn-primary"">Save Changes</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
