#pragma checksum "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf8b5e91eceeb728a94cef30435efa58cb5404a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Detail), @"mvc.1.0.view", @"/Views/Basket/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf8b5e91eceeb728a94cef30435efa58cb5404a", @"/Views/Basket/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdb078607ae16e396c33e27d41b91b8ff1e0fc8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Basket_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StoreProject1.Domain.ViewModel.order.OrderViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
  
    ViewBag.Title = "Корзина";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
  
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
#nullable restore
#line 23 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
 if (Model == null || Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""padding:40px;""></div>
    <div class=""card col-md-12"">
        <div class=""row g-0"">
            <div class=""col-md-12"">
                <div class=""card-body"">
                    <h5 class=""card-title text-center"">Список заказов пуст :(</h5>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 35 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 39 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 919, "\"", 964, 4);
            WriteAttributeValue("", 927, "row", 927, 3, true);
            WriteAttributeValue(" ", 930, "row-cols-1", 931, 11, true);
#nullable restore
#line 41 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
WriteAttributeValue(" ", 941, cardStyle, 942, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 952, "text-center", 953, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col\" style=\"padding: 10px;\">\r\n                    <div class=\"card\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1094, "\"", 1182, 2);
            WriteAttributeValue("", 1100, "data:image/jpeg;base64,", 1100, 23, true);
#nullable restore
#line 44 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
WriteAttributeValue("", 1123, Convert.ToBase64String(item?.Image ?? Array.Empty<byte>()), 1123, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                             class=\"img-fluid rounded-start rounded\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">Название: ");
#nullable restore
#line 47 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
                                                        Write(item.ClothName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">Тип одежды: ");
#nullable restore
#line 48 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
                                                        Write(item.TypeCloth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <ul class=\"list-group list-group-flush\">\r\n                            <li class=\"list-group-item\">Модель: ");
#nullable restore
#line 51 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
                                                           Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <div class=\"card-body\">\r\n                            <button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1789, "\"", 1854, 8);
            WriteAttributeValue("", 1799, "openModal({", 1799, 11, true);
            WriteAttributeValue(" ", 1810, "url:", 1811, 5, true);
            WriteAttributeValue(" ", 1815, "\'/Basket/GetItem\',", 1816, 19, true);
            WriteAttributeValue(" ", 1834, "data:", 1835, 6, true);
            WriteAttributeValue(" ", 1840, "\'", 1841, 2, true);
#nullable restore
#line 54 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
WriteAttributeValue("", 1842, item.Id, 1842, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1850, "\'", 1850, 1, true);
            WriteAttributeValue(" ", 1851, "})", 1852, 3, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                    data-toggle=\"ajax-modal\" data-target=\"Modal\">\r\n                                Открыть\r\n                            </button>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccf8b5e91eceeb728a94cef30435efa58cb5404a9751", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 65 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Basket\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StoreProject1.Domain.ViewModel.order.OrderViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
