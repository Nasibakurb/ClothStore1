#pragma checksum "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a478b9fb189323d95d7f09c1bc547663e4a7670a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cloth_GetClothes), @"mvc.1.0.view", @"/Views/Cloth/GetClothes.cshtml")]
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
#line 1 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\_ViewImports.cshtml"
using StoreProject1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\_ViewImports.cshtml"
using StoreProject1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
using StoreProject1.Domain.ViewModel.Cloth;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a478b9fb189323d95d7f09c1bc547663e4a7670a", @"/Views/Cloth/GetClothes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdb078607ae16e396c33e27d41b91b8ff1e0fc8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cloth_GetClothes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StoreProject1.Domain.Entity.Cloth>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/models/H&M.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-start rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cloth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
  
    ViewBag.Title = "Список Одежды";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
  
    var cardStyle = "col-md-12";
    if (Model != null)
    {
        switch (Model.Count)
        {
            case 2:
                cardStyle = "col-md-6";
                break;
            case 3:
                cardStyle = "col-md-4";
                break;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card-buttons-group {
        text-align: right;
        padding: 10px;
    }
</style>

<div class=""card col-md-12"" style=""margin: 10px;"">
    <div class=""card-buttons-group"">
        <button class='btn btn-primary' id='compareBtnId'>Сравнение</button>
");
#nullable restore
#line 36 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\'btn btn-success\' id=\'addClothId\'>Добавить</button>\r\n");
#nullable restore
#line 39 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div style=\"padding: 10px;\"></div>\r\n");
#nullable restore
#line 44 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card col-md-12\">\r\n        <div class=\"row g-0\">\r\n            <div class=\"col-md-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a478b9fb189323d95d7f09c1bc547663e4a7670a8662", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-md-8"">
                <div class=""card-body"">
                    <h5 class=""card-title text-center"">Список Одежды пуст :(</h5>
                    <p class=""card-text"">
                        Список пополниться позже, не расстраивайтесь
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div style=""padding: 10px;""></div>
    <div class=""card text-center"">
        <div class=""card-header"">
            <ul class=""nav nav-pills card-header-pills"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" href=""#"">Active</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Link</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link disabled"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Disabled</a>
                </li>
            </ul>
        </div>
       ");
            WriteLiteral(@" <div class=""card-body"">
            <h5 class=""card-title"">Особая обработка титула</h5>
            <p class=""card-text"">С сопровождающим текстом ниже, как естественным вводом к дополнительному контенту.</p>
            <a href=""#"" class=""btn btn-primary"">Перенаправление </a>
        </div>
    </div>
");
#nullable restore
#line 83 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 87 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
         foreach (var cloth in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 2616, "\"", 2661, 4);
            WriteAttributeValue("", 2624, "row", 2624, 3, true);
            WriteAttributeValue(" ", 2627, "row-cols-1", 2628, 11, true);
#nullable restore
#line 89 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
WriteAttributeValue(" ", 2638, cardStyle, 2639, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2649, "text-center", 2650, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col\" style=\"padding: 10px;\">\r\n                    <div class=\"card\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2791, "\"", 2881, 2);
            WriteAttributeValue("", 2797, "data:image/jpeg;base64,", 2797, 23, true);
#nullable restore
#line 92 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
WriteAttributeValue("", 2820, Convert.ToBase64String(cloth?.Avatar ?? Array.Empty<byte>()), 2820, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2882, "\"", 2899, 1);
#nullable restore
#line 92 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
WriteAttributeValue("", 2888, cloth.Name, 2888, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">Название: ");
#nullable restore
#line 94 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                                                        Write(cloth.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">Краткое описание: ");
#nullable restore
#line 95 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                                                              Write(cloth.Description.Substring(0, 40));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</p>\r\n                        </div>\r\n                        <ul class=\"list-group list-group-flush\">\r\n                            <li class=\"list-group-item\">Стоимость: ");
#nullable restore
#line 98 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                                                              Write(cloth.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" тг</li>\r\n                            <li class=\"list-group-item\">Модель: ");
#nullable restore
#line 99 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                                                           Write(cloth.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <div class=\"card-body\">\r\n                            <button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3554, "\"", 3620, 8);
            WriteAttributeValue("", 3564, "openModal({", 3564, 11, true);
            WriteAttributeValue(" ", 3575, "url:", 3576, 5, true);
            WriteAttributeValue(" ", 3580, "\'/Cloth/GetCloth\',", 3581, 19, true);
            WriteAttributeValue(" ", 3599, "data:", 3600, 6, true);
            WriteAttributeValue(" ", 3605, "\'", 3606, 2, true);
#nullable restore
#line 102 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
WriteAttributeValue("", 3607, cloth.Id, 3607, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3616, "\'", 3616, 1, true);
            WriteAttributeValue(" ", 3617, "})", 3618, 3, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                    data-toggle=\"ajax-modal\" data-target=\"Modal\">\r\n                                Открыть\r\n                            </button>\r\n");
#nullable restore
#line 106 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                             if (User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a478b9fb189323d95d7f09c1bc547663e4a7670a16451", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                                                                                WriteLiteral(cloth.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                                                                                                                                             
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a478b9fb189323d95d7f09c1bc547663e4a7670a19355", async() => {
                WriteLiteral("В корзину");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                                                                                 WriteLiteral(cloth.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 116 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 118 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("pageScripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a478b9fb189323d95d7f09c1bc547663e4a7670a22516", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        let modal = $(\'#modalWhButtons\');\r\n\r\n        $(\'#compareBtnId\').on(\'click\', function () {\r\n            $.ajax({\r\n                type: \'GET\',\r\n                url: \'");
#nullable restore
#line 129 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\GetClothes.cshtml"
                 Write(Url.Action("Compare"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                success: function (response) {
                    $('.modal-dialog').addClass(""modal-lg"");
                    modal.find("".modal-body"").html(response);
                    modal.modal('show')
                }
            });
        });

        $("".btn-close"").click(function () {
            modal.modal('hide');
        });

        $('#addClothId').on('click', function () {
            $.ajax({
                type: 'GET',
                url: '/Cloth/Save',
                success: function (response) {
                    $('.modal-dialog').removeClass(""modal-lg"");
                    modal.find("".modal-body"").html(response);
                    modal.modal('show')
                },
                failure: function () {
                    modal.modal('hide')
                },
                error: function (response) {
                    alert(response.responseText);
                }
            });
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StoreProject1.Domain.Entity.Cloth>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591