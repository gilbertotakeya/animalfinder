#pragma checksum "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fe81d238a09bf33fdaf2f4f5a9487cebcc0a243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Index), @"mvc.1.0.view", @"/Views/Animal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animal/Index.cshtml", typeof(AspNetCore.Views_Animal_Index))]
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
#line 1 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\_ViewImports.cshtml"
using AnimalFinder;

#line default
#line hidden
#line 2 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\_ViewImports.cshtml"
using AnimalFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe81d238a09bf33fdaf2f4f5a9487cebcc0a243", @"/Views/Animal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf52c6989bbe6d9aaf63876eb8238837a05a9eae", @"/Views/_ViewImports.cshtml")]
    public class Views_Animal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AnimalFinder.Models.Animal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Find", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
  
    ViewData["Title"] = "Listagem de animais desaparecidos";

#line default
#line hidden
            BeginContext(119, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(126, 17, false);
#line 7 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(143, 18, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(161, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe81d238a09bf33fdaf2f4f5a9487cebcc0a2435387", async() => {
                BeginContext(184, 34, true);
                WriteLiteral("Cadastrar novo animal desaparecido");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(315, 40, false);
#line 16 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 41, false);
#line 19 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(452, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(508, 53, false);
#line 22 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InformacoesExtras));

#line default
#line hidden
            EndContext();
            BeginContext(561, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(617, 42, false);
#line 25 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(659, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(715, 42, false);
#line 28 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(757, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(813, 42, false);
#line 31 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(855, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(911, 40, false);
#line 34 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dono));

#line default
#line hidden
            EndContext();
            BeginContext(951, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1086, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1147, 39, false);
#line 44 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1254, 40, false);
#line 47 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1362, 52, false);
#line 50 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.InformacoesExtras));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1482, 41, false);
#line 53 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1591, 41, false);
#line 56 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1700, 41, false);
#line 59 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1809, 44, false);
#line 62 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dono.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1920, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe81d238a09bf33fdaf2f4f5a9487cebcc0a24313327", async() => {
                BeginContext(1968, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1980, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 67 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                     if (item.Status == Definicoes.SituacaoAnimal.Perdido)
                    {
                        

#line default
#line hidden
            BeginContext(2108, 16, false);
#line 69 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                   Write(Html.Label(" |"));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2150, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe81d238a09bf33fdaf2f4f5a9487cebcc0a24316299", async() => {
                BeginContext(2195, 9, true);
                WriteLiteral("Encontrei");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 71 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2233, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                     if (ViewBag.IdUsuarioLogado != null && ViewBag.IdUsuarioLogado == item.IdDono)
                    {
                        

#line default
#line hidden
            BeginContext(2384, 15, false);
#line 75 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                   Write(Html.Label("|"));

#line default
#line hidden
            EndContext();
            BeginContext(2401, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2425, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe81d238a09bf33fdaf2f4f5a9487cebcc0a24319549", async() => {
                BeginContext(2470, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2480, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2482, 15, false);
#line 76 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                                                                           Write(Html.Label("|"));

#line default
#line hidden
            EndContext();
            BeginContext(2499, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2523, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe81d238a09bf33fdaf2f4f5a9487cebcc0a24322314", async() => {
                BeginContext(2570, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ifp-route-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 77 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
AddHtmlAttributeValue("", 2560, item.Id, 2560, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2581, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2583, 15, false);
#line 77 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                                                                              Write(Html.Label("|"));

#line default
#line hidden
            EndContext();
#line 77 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
                                                                                                   

                    }

#line default
#line hidden
            BeginContext(2625, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 82 "E:\Sistema\projetosGIT\C#\NETCore\AnimalFinder\AnimalFinder\Views\Animal\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2678, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AnimalFinder.Models.Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
