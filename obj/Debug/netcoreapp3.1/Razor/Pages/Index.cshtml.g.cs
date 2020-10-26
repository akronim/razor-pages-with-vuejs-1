#pragma checksum "C:\Users\marac\Desktop\RazorVueJs\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be7b3ced1d355cee2d9f26d6fe305031df5665fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorVueJs.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace RazorVueJs.Pages
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
#line 1 "C:\Users\marac\Desktop\RazorVueJs\Pages\_ViewImports.cshtml"
using RazorVueJs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be7b3ced1d355cee2d9f26d6fe305031df5665fd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb45f04bf62fe3024911bcc480d37b395c0e9b8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\marac\Desktop\RazorVueJs\Pages\Index.cshtml"
  
    Layout = "_Layout_Example1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    <style>\r\n        .elementWrap {\r\n            margin-top: 20px\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"
<div>
    <h1>Example 2</h1>
    Message from vue: <span v-text=""appMessage""></span><br />

    <div class=""elementWrap"">
        Element 1 Visibility: <button type=""button"" v-on:click=""displayElement1=!displayElement1"">Toggle 1</button><br />
        Element 2 Visibility: <button type=""button"" v-on:click=""displayElement2=!displayElement2"">Toggle 2</button><br />
    </div>

    <div class=""elementWrap"">
        <span v-if=""displayElement1"">Element 1</span>
        <span v-if=""displayElement2"">Element 2</span>
    </div>

    <privacy text=""barfoo""></privacy>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var pageMixin = {
            data: function () {
                return {
                    displayElement1: true,
                    displayElement2: false
                };
            },
            methods: {
                //vue methods can be added here
            }
        };
        mixinArray.push(pageMixin);
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
