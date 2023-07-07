#pragma checksum "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\Compare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5100ab254587b922d340101bf4fd55291d5837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cloth_Compare), @"mvc.1.0.view", @"/Views/Cloth/Compare.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5100ab254587b922d340101bf4fd55291d5837", @"/Views/Cloth/Compare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdb078607ae16e396c33e27d41b91b8ff1e0fc8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cloth_Compare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/select2/js/select2.full.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"﻿<div class=""row"">
    <div class=""col"">
        <select class=""form-control"" id=""firstClothId""></select>
    </div>
    <div class=""col"">
        <select class=""form-control"" id=""secondClothId""></select>
    </div>
</div>

<div style=""padding: 10px;""></div>

<div class=""row"">

    <div class=""col-md-6"">
        <div class=""card-body"">
            <h5 class=""card-title"" id=""firstCardTitleId""></h5>
            <p class=""card-text"" id=""firstCardDescId""></p>
        </div>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"" id=""firstCardSizeId""></li>
            <li class=""list-group-item"" id=""firstCardPriceId""></li>
            <li class=""list-group-item"" id=""firstCardModelId""></li>
            <li class=""list-group-item"" id=""firstCardDateCreateId""></li>
        </ul>
    </div>

    <div class=""col-md-6"">
       <div class=""card-body"">
           <h5 class=""card-title"" id=""secondCardTitleId""></h5>
           <p class=""card-text"" id=""secondCardDe");
            WriteLiteral(@"scId""></p>
       </div>
       <ul class=""list-group list-group-flush"">
           <li class=""list-group-item"" id=""secondCardSizeId""></li>
           <li class=""list-group-item"" id=""secondCardPriceId""></li>
           <li class=""list-group-item"" id=""secondCardModelId""></li>
           <li class=""list-group-item"" id=""secondCardDateCreateId""></li>
       </ul> 
    </div>
</div>

<div style=""padding: 10px;""></div>

<div class=""text-white bg-secondary"" id=""warningCardId"">
    <div class=""bg-secondary card-header text-white"">
        Предупреждение
    </div>
    <div class=""card-body"">
        <blockquote class=""blockquote mb-0"">
            <p id=""warningId""></p>
        </blockquote>
    </div>
</div>

<div style=""padding: 10px;""></div>

<div id=""resultCardId"">
  <div class=""bg-secondary card-header text-white"">
    Результат
  </div>
  <div class=""card-body"">
    <ul class=""list-group list-group-flush"">
        <li class=""list-group-item"" id=""resultSizeId""></li>
        <li c");
            WriteLiteral("lass=\"list-group-item\" id=\"resultPriceId\"></li>\r\n    </ul>\r\n  </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5100ab254587b922d340101bf4fd55291d58375863", async() => {
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
<script> 
$(document).ready(function () {
    
    $('#firstCardId').hide();
    $('#secondCardId').hide();
    $('#warningCardId').hide();
    $('#resultCardId').hide();
    
    let firstCloth = null; 
    let secondCloth = null;        
    
    $('#firstClothId, #secondClothId').select2({
       placeholder: ""Выберите одежду"",
       minimumInputLength: 2,
       allowClear: true,
       ajax: {
            type: ""POST"",
            url: """);
#nullable restore
#line 86 "C:\Users\Professional\source\repos\StoreProject1\StoreProject1\Views\Cloth\Compare.cshtml"
             Write(Url.Action("GetCloth", "Cloth"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            dataType: ""json"",
            data: function (params) { 
                var query = {
                    term: params.term,
                    page: params.page || 1,
                    pageSize: params.pageSize || 5
                };
                return query;
            },
            processResults: function (result) {
                return {
                    results: $.map(result, function (val, index) {
                        return {
                            id: index, 
                            text: val
                        };
                    }),
                };
            }
        }
    });      

    function fillData(val, cardId){
            if (cardId === 'firstClothId') {
            $('#firstCardId').show();
            $('#firstCardTitleId')[0].innerText = 'Название: ' + val.name;
            $('#firstCardDescId')[0].innerText = 'Описание: ' + val.description;
            $('#firstCardSizeId')[0].innerText = 'Размер: ' +");
            WriteLiteral(@" val.size;
            $('#firstCardPriceId')[0].innerText = 'Стоимость: ' + val.price + ' тг';
            $('#firstCardModelId')[0].innerText = 'Модель: ' + val.model;
            $('#firstCardDateCreateId')[0].innerText = 'Дата создания: ' + val.dateCreate;
        } else {
            $('#secondCardId').show();
            $('#secondCardTitleId')[0].innerText = 'Название: ' + val.name;
            $('#secondCardDescId')[0].innerText = 'Описание: ' + val.description;
            $('#secondCardSizeId')[0].innerText = 'Размер: ' + val.price;
            $('#secondCardPriceId')[0].innerText = 'Стоимость: ' + val.price + ' тг';
            $('#secondCardModelId')[0].innerText = 'Модель: ' + val.model;
            $('#secondCardDateCreateId')[0].innerText = 'Дата создания: ' + val.dateCreate;
        }
        compareClothes();
    }

    
    $(""#secondClothId"").on(""change"", function(){
        const id = this.value;
        if (id === """") return;
        $.get(""/Cloth/GetCloth"", { id : id,");
            WriteLiteral(@" isJson : true }, function(data) {
            secondCloth = data;
            fillData(secondCloth, ""secondClothId"");
        });
    });
    
    $(""#firstClothId"").on(""change"", function(){
        const id = this.value;
        if (id === """") return;
        $.get(""/Cloth/GetCloth"", { id : id, isJson : true }, function(data) {
            firstCloth = data;
            fillData(firstCloth, ""firstClothId"");
        });            
    });
    
    function compareClothes(){
        if (firstCloth === null) {
            $('#warningId')[0].innerText = 'Вы не выбрали первый товар';
            $('#warningCardId').show();
            return;
        }
        
        if (secondCloth === null) {
            $('#warningId')[0].innerText = 'Вы не выбрали второй товар';
            $('#warningCardId').show();
            return;
        }    
        
        var size = $('#resultSizeId')[0];
        if (firstCloth.size > secondCloth.size) {
            size.innerText = 'Размер ' + f");
            WriteLiteral(@"irstCloth.name + ' больше, чем у ' + secondCloth.name;
        } else if (firstCloth.size === secondCloth.size) {
            size.innerText = 'Размер ' + secondCloth.name + ' и ' + firstCloth.name + ' равны';
        } else {
            size.innerText = 'Размер ' + secondCloth.name + ' больше, чем у ' + firstCloth.name;
        }
        
        var price = $('#resultPriceId')[0];
            if (firstCloth.price > secondCloth.price) {
                price.innerText = 'Стоимость ' + firstCloth.name + ' выше, чем у ' + secondCloth.name;
            } else if (firstCloth.price === secondCloth.price) {
                price.innerText = 'Стоимость ' + firstCloth.name + ' и ' + secondCloth.name + ' равны';
        } else {
                price.innerText = 'Стоимость ' + firstCloth.name + ' выше, чем у ' + secondCloth.name;
        }

        $('#resultCardId').show();
        $('#warningCardId').hide();
    }
  });
</script>");
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
