#pragma checksum "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fba7cd5719b519266cd312f5b3c62e4f8bbd7f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\_ViewImports.cshtml"
using CustomerPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\_ViewImports.cshtml"
using CustomerPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fba7cd5719b519266cd312f5b3c62e4f8bbd7f8", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570d61c3fce36933c4b6da42486f8ee49faf5ccd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerPanel.Models.ProductModel>>
    #nullable disable
    {
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
            WriteLiteral(@"
<h2>Ürünler</h2>
<br />
<button type=""button"" class=""btn btn-success"" data-bs-toggle=""modal"" onclick=""getCategories(1)"" data-bs-target=""#createModal"">Yeni Ürün Ekle</button>

<div class=""row"">
</div>
<table id=""productTable"" class=""table table-hover mt-3"">
    <thead>
        <tr>
            <th class=""d-none"">Id</th>
            <th>Ürün Adı</th>
            <th>Kategori</th>
            <th>Fiyat</th>
            <th>#</th>
        </tr>
    </thead>
    <tbody id=""productTableBody"" class=""table-border-bottom-0"">
");
#nullable restore
#line 22 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"d-none\">");
#nullable restore
#line 25 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                <td>
                    <div class=""dropdown"">
                        <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                            <i class=""bx bx-dots-vertical-rounded""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1215, "\"", 1249, 3);
            WriteAttributeValue("", 1225, "getProductById(", 1225, 15, true);
#nullable restore
#line 35 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
WriteAttributeValue("", 1240, item.Id, 1240, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1248, ")", 1248, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#updateModal\" class=\"dropdown-item\"><i class=\"bx bx-edit-alt me-1\"></i> Güncelle</a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1406, "\"", 1439, 3);
            WriteAttributeValue("", 1416, "deleteProduct(", 1416, 14, true);
#nullable restore
#line 36 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
WriteAttributeValue("", 1430, item.Id, 1430, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1438, ")", 1438, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\"><i class=\"bx bx-trash me-1\"></i> Sil</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<!-- Update Modal -->
<div class=""modal fade"" id=""updateModal"" tabindex=""-1"" aria-labelledby=""updateModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""updateModalLabel"">Ürün</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba7cd5719b519266cd312f5b3c62e4f8bbd7f87799", async() => {
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 2219, "\"", 2225, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"upPhoto\" class=\"rounded mx-auto d-block\"");
                BeginWriteAttribute("alt", " alt=\"", 2271, "\"", 2277, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""250"" height=""350"">
                        <div class=""col"">
                            <div class=""mb-3"">
                                <label for=""recipient-name"" class=""col-form-label"">Ürün Adı</label>
                                <input type=""text"" class=""form-control"" id=""upProductName"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""message-text"" class=""col-form-label"">Fiyat</label>
                                <input id=""upPrice"" class=""form-control"" type=number step=0.01 />
                            </div>
                            <div class=""mb-3"">
                                <label for=""recipient-name"" class=""col-form-label"">Fotoğraf</label>
                                <input type=""file"" class=""form-control"" id=""upProductPhoto"" aria-describedby=""inputGroupFileAddon03"" aria-label=""Upload"" accept=""image/*"">
                            </div>
                            <div class=");
                WriteLiteral(@"""mb-3"">
                                <label for=""recipient-name"" class=""col-form-label"">Kategori Adı</label>
                                <select class=""form-select"" id=""upCategory"">
                                </select>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Kapat</button>
                <button onclick=""updateProduct()"" type=""button"" class=""btn btn-primary"">Güncelle</button>
            </div>
        </div>
    </div>
</div>


<!-- Create Modal -->
<div class=""modal"" id=""createModal"" tabindex=""-1"" aria-labelledby=""createModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createModalLabel"">Ürün</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba7cd5719b519266cd312f5b3c62e4f8bbd7f811783", async() => {
                WriteLiteral(@"
                    <div class=""mb-3 d-none"">
                        <label for=""recipient-name"" class=""col-form-label"">ID:</label>
                        <input type=""text"" class=""form-control"" id=""id"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Ürün Adı</label>
                        <input type=""text"" class=""form-control"" id=""productName"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""message-text"" class=""col-form-label"">Fiyat</label>
                        <input id=""price"" class=""form-control"" type=number step=0.01 />
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Fotoğraf</label>
                        <input type=""file"" class=""form-control"" id=""productPhoto"" aria-describedby=""inputGroupFileAddon03"" aria-label=""Upload"" accept=""image/*"">
 ");
                WriteLiteral(@"                   </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Kategori Adı</label>
                        <select class=""form-select"" id=""category"">
                        </select>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Kapat</button>
                <button onclick=""createProduct()"" type=""button"" class=""btn btn-primary"">Ekle</button>
            </div>
        </div>
    </div>
</div>


<script>
    function createProduct() {
        var doc = $(""#productPhoto"");

        var productName = $(""#productName"").val();
        var price = $(""#price"").val();
        var stock = parseInt($(""#stock"").val());
        var category = parseInt($(""#category"").val());
        var productPhoto = doc[0].files[0];

        var formData = new FormData();
        formData.append(""_name"", productName);
        formData.append(""_price"", price);
        formData.append(""_photo"", productPhoto);
        formData.append(""_categoryId"", category);

        $.ajax({
            url: '");
#nullable restore
#line 147 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
             Write(Url.Action("CreateProduct", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            data: formData,
            contentType: false,
            processData: false,
            success: function (data) {
                if (data) {
                    $(function () {
                        $('#createModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Başarılı!"",
                        text: ""Ürün başarıyla eklendi."",
                        icon: ""success""
                    });
                    updateTable();
                }
                else {
                    $(function () {
                        $('#createModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
                    });

                    return;
                }
    ");
            WriteLiteral("        }\r\n        });\r\n    }\r\n\r\n    function getCategories(val, categoryId = null) {\r\n\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 184 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
             Write(Url.Action("GetCategories", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            success: function (data) {
                if (data) {
                    if (val === 1) {
                        $(""#category"").empty();
                        var trHtml = """";
                        for (var item of data) {
                            trHtml += '<option value=""' + item.id + '"">' + item.name + '</option>';
                        }
                        $(""#category"").append(trHtml);
                    }
                    if (val === 2 && categoryId !== null) {
                        $(""#upCategory"").empty();
                        var trHtml = """";
                        for (var item of data) {
                            if (item.id === categoryId)
                                trHtml += '<option selected value=""' + item.id + '"">' + item.name + '</option>';
                            else
                                trHtml += '<option value=""' + item.id + '"">' + item.name + '</opti");
            WriteLiteral(@"on>';

                        }
                        $(""#upCategory"").append(trHtml);
                    }
                }
                else {

                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
                    });

                    return;
                }
            }
        });
    }

    function updateTable() {
        $.ajax({
            url: '");
#nullable restore
#line 226 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
             Write(Url.Action("UpdateTable", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            success: function (data) {
                if (data) {
                    $(""#productTableBody"").empty();
                    var trHtml = """";
                    for (var item of data) {
                        trHtml += '<tr>';
                        trHtml += '    <td class=""d-none""> ' + item.id + '</td>';
                        trHtml += '        <td> ' + item.name + '</td>'
                        trHtml += '        <td> ' + item.category.name + '</td>'
                        trHtml += '        <td> ' + item.price + '</td>'
                        trHtml += '        <td>'
                        trHtml += '        <div class=""dropdown"">'
                        trHtml += '            <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">'
                        trHtml += '                <i class=""bx bx-dots-vertical-rounded"" > </i>'
                        trHtml += '        ");
            WriteLiteral(@"    </button>'
                        trHtml += '            <div class=""dropdown-menu"">'
                        trHtml += '                 <a onclick=""getProductById(' + item.id + ')"" data-bs-toggle=""modal"" data-bs-target=""#updateModal"" class=""dropdown-item"" > <i class=""bx bx-edit-alt me-1""> </i>Edit</a>'
                        trHtml += '                 <a onclick=""deleteProduct(' + item.id + ')"" class=""dropdown-item"" > <i class=""bx bx-trash me-1"" > </i> Delete</a>'
                        trHtml += '            </div>'
                        trHtml += '        </div>'
                        trHtml += '     </td>'
                        trHtml += '</tr>';
                    }
                    $(""#productTableBody"").append(trHtml);
                }
                else {
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Tablo yüklenirken bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
    ");
            WriteLiteral(@"                });

                    return;
                }
            }
        });
    }

    function deleteProduct(_id) {
        Swal.fire({
            title: ""Seçtiğiniz ürün silinecektir. Onaylıyor musunuz?"",
            text: ""Bunu geri alamazsınız!"",
            icon: ""warning"",
            showCancelButton: true,
            confirmButtonColor: ""#3085d6"",
            cancelButtonColor: ""#d33"",
            confirmButtonText: ""Evet, sil!"",
            cancelButtonText: ""Kapat""
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '");
#nullable restore
#line 280 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
                     Write(Url.Action("DeleteProduct", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        ""_id"": _id
                    },
                    success: function (data) {
                        if (data) {
                            Swal.fire({
                                title: ""Silindi!"",
                                text: ""Ürün başarıyla silindi."",
                                icon: ""success""
                            });
                            updateTable();
                        }
                        else {
                            $(function () {
                                $('#modal').modal('toggle');
                            });
                            Swal.fire({
                                title: ""Hata!"",
                                text: ""Bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                                icon: ""error""
                            });

                           ");
            WriteLiteral(" return;\r\n                        }\r\n                    }\r\n                });\r\n            }\r\n        });\r\n\r\n    }\r\n\r\n    function getProductById(_id) {\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 316 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
             Write(Url.Action("GetProductById", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            data: {
                ""_id"": _id
            },
            success: function (data) {
                if (data) {
                    console.log(data);
                    $(""#id"").val(data.id);
                    $(""#upPhoto"").attr(""src"", ""/productPhotos/"" + data.imagePath);
                    $(""#upProductName"").val(data.name);
                    $(""#upPrice"").val(data.price);
                    $(""#upStock"").val(data.stock);

                    getCategories(2, data.categoryId);

                }
                else {
                    $(function () {
                        $('#modal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
                    });

                    return;
                }
           ");
            WriteLiteral(@" }
        });
    }

    function updateProduct() {
        var doc = $(""#upProductPhoto"");

        var id = $(""#id"").val();
        var productName = $(""#upProductName"").val();
        var price = $(""#upPrice"").val();
        var category = parseInt($(""#upCategory"").val());
        var productPhoto = doc[0].files[0];

        var formData = new FormData();
        formData.append(""_id"", id);
        formData.append(""_name"", productName);
        formData.append(""_price"", price);
        formData.append(""_photo"", productPhoto);
        formData.append(""_categoryId"", category);

        $.ajax({
            url: '");
#nullable restore
#line 367 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Product\Index.cshtml"
             Write(Url.Action("UpdateProduct", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            data: formData,
            contentType: false,
            processData: false,
            success: function (data) {
                if (data) {
                    $(function () {
                        $('#updateModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Başarılı!"",
                        text: ""Ürün başarıyla güncellendi."",
                        icon: ""success""
                    });
                    updateTable();
                }
                else {
                    $(function () {
                        $('#updateModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
                    });

                    return;
                }
");
            WriteLiteral("            }\r\n        });\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerPanel.Models.ProductModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591