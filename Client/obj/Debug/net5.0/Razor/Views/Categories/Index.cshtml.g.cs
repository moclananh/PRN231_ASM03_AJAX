#pragma checksum "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be34963d6ca916e01e69e495c87bff8baca4ee16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be34963d6ca916e01e69e495c87bff8baca4ee16", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\FU_Hub\FA23\PRN231\Asm\PRN231_ASM03_AJAX\Client\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be34963d6ca916e01e69e495c87bff8baca4ee164609", async() => {
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
    <h2> Category List</h2>
    <table class=""table table-sm table-striped table-bordered m-2"" id=""table"">
        <thead>
            <tr>
                <th>Category Id</th>
                <th>Category Name</th>
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
        ShowAllCategories();

        function ShowAllCategories() {
            $(""table tbody"").html("""");
            $.ajax({
                url: ""https://localhost:5001/api/Categories"",
                type: ""get"",
                contentType: ""json""");
            WriteLiteral(@",
                dataType: ""json"",
                success: function (result, status, xhr) {
                    $.each(result, function (index, value) {
                        $(""tbody"").append($(""<tr>""));
                        appendElement = $(""tbody tr"").last();
                        appendElement.append($(""<td>"").html(value[""categoryId""])); 
                        appendElement.append($(""<td>"").html(value[""categoryName""]));
                        appendElement.append($(""<td>"").html(""<button class='edit btn btn-primary' data-toggle='modal' data-target='#editModal'>Edit</button>""));
                        appendElement.append($(""<td>"").html(""<a href=\""javascript:void(0);\"" class=\""delete-link\"" data-id=\"""" + value[""categoryId""] + ""\"">Delete</a>""));
                        $(""tbody"").append(appendElement);
                    });
                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                }
            });
        ");
            WriteLiteral(@"}

        //delete
        $(document).on(""click"", "".delete-link"", function () {
            var deleteLink = $(this); // Capture the reference to the clicked delete link
            var categoryId = deleteLink.data(""id"");
            if (confirm(""Are you sure you want to delete this product?"")) {
                // Perform the delete action here using an AJAX request
                $.ajax({
                    url: ""https://localhost:5001/api/Categories/"" + categoryId,
                    type: ""delete"",
                    success: function (result) {
                        // Handle the success, e.g., remove the deleted row from the table
                        deleteLink.closest(""tr"").remove(); // Use the captured reference here
                    },
                    error: function (xhr, status, error) {
                        console.log(xhr);
                        alert(""Error deleting the category."");
                    }
                });
            }
        });
");
            WriteLiteral(@"
        //edit
        $(""table"").on(""click"", ""button.edit"", function () {
            var row = $(this).closest(""tr"");
            var categoryId = row.find(""td:nth-child(1)"").text();
            var categoryName = row.find(""td:nth-child(2)"").text();

            // Populate the modal form for editing
            $(""#editModal"").find(""input[name='categoryId']"").val(categoryId);
            $(""#editModal"").find(""input[name='categoryName']"").val(categoryName);
           

        });

        // Handle the edit form submission
        $(""#editModal"").on('submit', 'form#editForm', function (e) {
            e.preventDefault();
            var categoryId = $(this).find(""input[name='categoryId']"").val();
            var updatedCategory = {
                categoryId: categoryId,
                categoryName: $(this).find(""input[name='categoryName']"").val()
            };

            // Send an AJAX request to update the product
            $.ajax({
                url: ""https://localho");
            WriteLiteral(@"st:5001/api/Categories/"" + categoryId,
                type: ""put"",
                contentType: ""application/json"",
                data: JSON.stringify(updatedCategory),
                success: function (result, status, xhr) {
                    window.location.href = ""https://localhost:5002/Categories"";
                    ShowAllCategories();
                    $('#editModal').modal('hidden');

                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                }
            });
        });
    });
</script>


<!-- Modal for Editing -->
<div class=""modal"" id=""editModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""editModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"" id=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editModalLabel"">Edit Category</h5>
                <button type=""button"" class=""close"" dat");
            WriteLiteral("a-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be34963d6ca916e01e69e495c87bff8baca4ee1611488", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""categoryId"">
                   
                    <div class=""form-group"">
                        <label for=""categoryName"">Category Name</label>
                        <input type=""text"" name=""categoryName"" class=""form-control"">
                    </div>
                   

                    <button type=""submit"" form=""editForm"" class=""btn btn-primary"">Save Changes</button>
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
