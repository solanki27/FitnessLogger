#pragma checksum "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "456c418ac01e5a7ed79dfc5a9828b47c4ae7b0d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workout_edit), @"mvc.1.0.view", @"/Views/Workout/edit.cshtml")]
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
#line 1 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\_ViewImports.cshtml"
using FitnessTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\_ViewImports.cshtml"
using FitnessTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456c418ac01e5a7ed79dfc5a9828b47c4ae7b0d7", @"/Views/Workout/edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e081a33eb6a9c4e995c42a87f314ce209a1026e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Workout_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkoutPlan>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Workout/edit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Workout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Summary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("formPreSubmit();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
  
    ViewData["Title"] = "Edit Workout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456c418ac01e5a7ed79dfc5a9828b47c4ae7b0d76220", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456c418ac01e5a7ed79dfc5a9828b47c4ae7b0d77377", async() => {
                WriteLiteral("\r\n    <div class=\"card\">\r\n        <div class=\"card-header bg-primary text-white\">\r\n            <h2 id=\"PlanNameHeader\" class=\"my-0\">");
#nullable restore
#line 14 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n                <div class=\"col-3 border-right\">\r\n                    <h3 class=\"border-bottom\">Plan</h3>\r\n\r\n                    <input type=\"hidden\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 626, "\"", 643, 1);
#nullable restore
#line 21 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 634, Model.ID, 634, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/>\r\n                    <input type=\"hidden\" id=\"SessionJSONInput\" name=\"SessionsJSON\"");
                BeginWriteAttribute("value", " value=\"", 739, "\"", 766, 1);
#nullable restore
#line 22 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 747, Model.SessionsJSON, 747, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n\r\n                    <div class=\"form-group form-inline\">\r\n                        <label class=\"mr-2\">Name</label>\r\n                        <input type=\"text\" name=\"Name\" class=\"form-control\" oninput=\"planName_Input(this);\"");
                BeginWriteAttribute("value", " value=\"", 996, "\"", 1015, 1);
#nullable restore
#line 26 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 1004, Model.Name, 1004, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                    </div>\r\n\r\n\r\n                    <a href=\"#\" class=\"font-weight-bold\" onclick=\"addNewSession();\">+Add Session</a>\r\n\r\n                    <ul id=\"SessionList\" class=\"list-group\">\r\n");
#nullable restore
#line 33 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                         for (int i = 0; i < Model.Sessions?.Length; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"list-group-item\" style=\"cursor:pointer;\" onclick=\"sessionListItem_Clicked(this);\">");
#nullable restore
#line 35 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                                                                                                                    Write(Model.Sessions[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 36 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <div class=\"col-3 border-right\" id=\"SessionContainer\">\r\n                    <h3 class=\"border-bottom\">Session</h3>\r\n");
#nullable restore
#line 41 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                     for (int i = 0; i < Model.Sessions?.Length; i++)
                    {
                        WorkoutSession session = Model.Sessions[i];

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table class=""sessionForm d-none table table-borderless"">
                            <tbody>
                                <tr>
                                    <td><label class=""mr-2"">Name</label></td>
                                    <td><input type=""text""");
                BeginWriteAttribute("value", " value=\"", 2149, "\"", 2170, 1);
#nullable restore
#line 48 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 2157, session.Name, 2157, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class="" form-control"" oninput=""sessionName_Input(this)"" required /></td>
                                </tr>
                                <tr>
                                    <td><label class=""mr-2"">Day Number</label></td>
                                    <td><input type=""number"" step=""1"" min=""1"" max=""28""");
                BeginWriteAttribute("value", " value=\"", 2494, "\"", 2520, 1);
#nullable restore
#line 52 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 2502, session.DayNumber, 2502, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class="" form-control"" required/></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td><a href=""#"" class=""text-danger font-weight-bold float-right"" onclick=""deleteSession_Clicked(this);"">Delete</a></td>
                                </tr>
                            </tbody>
                        </table>
");
#nullable restore
#line 60 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"col-6\" id=\"ActivityContainer\">\r\n                    <h3 class=\"border-bottom\">Activities</h3>\r\n");
#nullable restore
#line 64 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                     for (int sessionIndex = 0; sessionIndex < Model.Sessions?.Length; sessionIndex++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table class=""table d-none activityForm"">
                            <thead>
                                <tr>
                                    <th>Name</th>
                                    <th>Quantity</th>
                                    <th>Sets</th>
                                    <th>Rest</th>
                                    <th></th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 78 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                                 for (int activityIndex = 0; activityIndex < Model.Sessions?[sessionIndex].Activities?.Length; activityIndex++)
                                {
                                    WorkoutActivity activity = Model.Sessions[sessionIndex].Activities[activityIndex];

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td><input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4180, "\"", 4202, 1);
#nullable restore
#line 82 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 4188, activity.Name, 4188, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/></td>\r\n                                    <td><input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4300, "\"", 4326, 1);
#nullable restore
#line 83 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 4308, activity.Quantity, 4308, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/></td>\r\n                                    <td><input type=\"number\" min=\"1\" step=\"1\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4443, "\"", 4465, 1);
#nullable restore
#line 84 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 4451, activity.Sets, 4451, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/></td>\r\n                                    <td><input type=\"number\" min=\"0\" max=\"120\" step=\"1\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4592, "\"", 4627, 1);
#nullable restore
#line 85 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
WriteAttributeValue("", 4600, activity.RestPeriodSeconds, 4600, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/></td>\r\n                                    <td><a href=\"#\" class=\"text-danger font-weight-bold\" onclick=\"deleteActivity_Clicked(this)\">Remove</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 88 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 91 "C:\Users\KAR1288\source\repos\FitnessTrackerProj\FitnessTracker\Views\Workout\edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <a id=""AddActivityButton"" href=""#"" class=""font-weight-bold d-none float-right"" onclick=""addActivity_Clicked();"">+Add Activity</a>

                </div>
            </div>
        </div>
        <div class=""card-footer"">   
            <div class=""float-right"">
                <input type=""submit"" class=""btn btn-primary"" value=""Save"" />
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456c418ac01e5a7ed79dfc5a9828b47c4ae7b0d718480", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table id=""SessionTemplate"" class=""d-none sessionForm table table-borderless"">
    <tbody>
        <tr>
            <td><label>Name</label></td>
            <td><input type=""text"" value=""New Session"" class=""sessionNameInput form-control"" oninput=""sessionName_Input(this)""/></td>
        </tr>
        <tr>
            <td><label>Day Number</label></td>
            <td><input type=""number"" step=""1"" min=""1"" max=""28"" value=""1"" class=""sessionDayInput form-control"" /></td>
        </tr>
        <tr>
            <td></td>
            <td><a href=""#"" class=""text-danger font-weight-bold float-right"" onclick=""deleteSession_Clicked(this);"">Delete</a></td>
        </tr>
    </tbody>
</table>

<table id=""ActivityTemplate"" class=""table d-none activityForm"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Quantity</th>
            <th>Sets</th>
            <th>Rest</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

<table class=""d-non");
            WriteLiteral(@"e"">
    <tbody>
        <tr id=""ActivityRowTemplate"">
            <td><input type=""text"" class=""form-control"" required/></td>
            <td><input type=""text"" class=""form-control"" required/></td>
            <td><input type=""number"" min=""1"" step=""1"" class=""form-control"" required/></td>
            <td><input type=""number"" min=""0"" max=""120"" step=""1"" class=""form-control""/></td>
            <td><a href=""#"" class=""text-danger font-weight-bold"" onclick=""deleteActivity_Clicked(this)"">Remove</a></td>
        </tr>
    </tbody>
</table>

<ul id=""SessionListTemplate"" class=""d-none"">
    <li class=""list-group-item"" style=""cursor:pointer;"" onclick=""sessionListItem_Clicked(this);""></li>

</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkoutPlan> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591