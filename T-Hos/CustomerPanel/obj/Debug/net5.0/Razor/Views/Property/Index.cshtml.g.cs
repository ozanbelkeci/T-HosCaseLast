#pragma checksum "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9d53a2d5d7b6c3b3fd4d360b855d93866504b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Property_Index), @"mvc.1.0.view", @"/Views/Property/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9d53a2d5d7b6c3b3fd4d360b855d93866504b2", @"/Views/Property/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570d61c3fce36933c4b6da42486f8ee49faf5ccd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Property_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerPanel.Models.PropertyModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/pages-js/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9d53a2d5d7b6c3b3fd4d360b855d93866504b23826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h2>Ürün Özellikleri</h2>
<br />
<button type=""button"" class=""btn btn-success"" data-bs-toggle=""modal"" onclick=""getProperties(1)"" data-bs-target=""#createModal"">Yeni Özellik Ekle</button>
<table class=""table table-hover mt-3"">
    <thead>
        <tr>
            <th class=""d-none"">Id</th>
            <th>#</th>
            <th>#</th>
        </tr>
    </thead>
    <tbody id=""propertyTableBody"" class=""table-border-bottom-0"">
");
#nullable restore
#line 18 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"d-none\">");
#nullable restore
#line 21 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
                   Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </tbody>
</table>

<!-- Modal -->
<div class=""modal fade"" id=""updateModal"" tabindex=""-1"" aria-labelledby=""updateModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""updateModalLabel"">Özellik</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9d53a2d5d7b6c3b3fd4d360b855d93866504b27273", async() => {
                WriteLiteral(@"
                    <div class=""mb-3 d-none"">
                        <label for=""recipient-name"" class=""col-form-label"">ID:</label>
                        <input type=""text"" class=""form-control"" id=""id"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Özellik:</label>
                        <input type=""text"" class=""form-control"" id=""upKey"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Değer:</label>
                        <input type=""text"" class=""form-control"" id=""upValue"">
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
                <button onclick=""updateProperty()"" type=""button"" class=""btn btn-primary"">Güncelle</button>
            </div>
        </div>
    </div>
</div>



<div class=""modal"" id=""createModal"" tabindex=""-1"" aria-labelledby=""createModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createModalLabel"">Özellik</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9d53a2d5d7b6c3b3fd4d360b855d93866504b210120", async() => {
                WriteLiteral(@"
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Özellik:</label>
                        <input type=""text"" class=""form-control"" id=""key"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Değer:</label>
                        <input type=""text"" class=""form-control"" id=""value"">
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
                <button onclick=""createProperty()"" type=""button"" class=""btn btn-primary"">Ekle</button>
            </div>
        </div>
    </div>
</div>

<script>

    function createProperty() {
        var key = $(""#key"").val();
        var value = $(""#value"").val();
        
        $.ajax({
            url: '");
#nullable restore
#line 110 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
             Write(Url.Action("CreateProperty", "Property"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            data: {
                ""_key"": key,
                ""_value"": value
            },
            success: function (data) {
                if (data) {
                    $(function () {
                        $('#createModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Başarılı!"",
                        text: ""Özellik başarıyla eklendi."",
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
               ");
            WriteLiteral(@" }
            }
        });
    }

    function deleteProperty(_id) {
        var text = """";
        text = ""Seçtiğiniz Özellik silinecektir. Onaylıyor musunuz?"";

        Swal.fire({
            title: text,
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
#line 161 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
                     Write(Url.Action("DeleteProperty", "Property"));

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
                                text: ""Özellik başarıyla silindi."",
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
            WriteLiteral("    return;\r\n                        }\r\n                    }\r\n                });\r\n            }\r\n        });\r\n\r\n    }\r\n\r\n    function getPropertyById(_id) {\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 197 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
             Write(Url.Action("GetPropertyById", "Property"));

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
                    $(""#id"").val(data.id);
                    $(""#upKey"").val(data.key);
                    $(""#upValue"").val(data.value);
                    
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
            }
        });
    }

    function updateProperty() {
        var id = $(""#id"").val();
        var key = $(""#upKey"").val();
        var value = $(""#upValue"").val();

        $.ajax({
            url: '");
#nullable restore
#line 232 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
             Write(Url.Action("UpdateProperty", "Property"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            data: {
                ""_id"": id,
                ""_key"": key,
                ""_value"": value,

            },
            success: function (data) {
                if (data) {
                    $(function () {
                        $('#updateModal').modal('toggle');
                    });
                    Swal.fire({
                        title: ""Başarılı!"",
                        text: ""Özellik başarıyla güncellendi."",
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

         ");
            WriteLiteral("           return;\r\n                }\r\n            }\r\n        });\r\n    }\r\n\r\n    function updateTable() {\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 271 "C:\Users\belke\OneDrive\Masaüstü\Projects\T-Hos\CustomerPanel\Views\Property\Index.cshtml"
             Write(Url.Action("UpdateTable", "Property"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'json',
            success: function (data) {
                if (data) {
                    $(""#propertyTableBody"").empty();
                    var trHtml = """";
                    for(var item of data) {
                        trHtml += '<tr>';
                        trHtml += '    <td class=""d-none""> '+item.id+'</td>';
                        trHtml += '        <td> ' + item.key + '</td>'
                        trHtml += '        <td> ' + item.value + '</td>'
                        trHtml += '        <td>'
                        trHtml += '        <div class=""dropdown"" >'
                        trHtml += '            <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">'
                        trHtml += '                <i class=""bx bx-dots-vertical-rounded"" > </i>'
                        trHtml += '            </button>'
                        trHtml += '            <div class=""dropdown-me");
            WriteLiteral(@"nu"">'
                        trHtml += '                 <a onclick=""getPropertyById(' + item.id+ ')"" data-bs-toggle=""modal"" data-bs-target=""#updateModal"" class=""dropdown-item"" > <i class=""bx bx-edit-alt me-1""> </i>Edit</a>'
                        trHtml += '                 <a onclick=""deleteProperty(' + item.id + ')"" class=""dropdown-item"" > <i class=""bx bx-trash me-1"" > </i> Delete</a>'
                        trHtml += '            </div>'
                        trHtml += '        </div>'
                        trHtml += '     </td>'
                        trHtml += '</tr>';

                        
                    }

                    $(""#propertyTableBody"").append(trHtml);
                    

                }
                else {
                    Swal.fire({
                        title: ""Hata!"",
                        text: ""Tablo yüklenirken bir şeyler ters gitti lütfen tekrar deneyiniz!"",
                        icon: ""error""
                    });

       ");
            WriteLiteral("             return;\r\n                }\r\n            }\r\n        });\r\n    }\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerPanel.Models.PropertyModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591