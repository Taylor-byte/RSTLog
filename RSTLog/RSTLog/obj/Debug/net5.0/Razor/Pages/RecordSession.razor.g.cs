#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d45fbe3ba5848e298d08192a09fec212b8b314"
// <auto-generated/>
#pragma warning disable 1591
namespace RSTLog.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using RSTLog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using RSTLog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recordSession/{customerId:int}")]
    public partial class RecordSession : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Record A Session</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 6 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                       _editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                    Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-10");
                __Blazor.RSTLog.Pages.RecordSession.TypeInference.CreateInputNumber_0(__builder2, 10, 11, "id", 12, "hidden", 13, 
#nullable restore
#line 9 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                              CustomerId

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CustomerId = __value, CustomerId)), 15, () => CustomerId);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group row");
                __builder2.AddMarkupContent(19, "<label for=\"name\" class=\"col-md-5 col-form-label\">Transaction Type</label>\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-10");
                __Blazor.RSTLog.Pages.RecordSession.TypeInference.CreateInputSelect_1(__builder2, 22, 23, "TransType", 24, "form-control", 25, 
#nullable restore
#line 17 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                                          _audit.TransTypeId

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _audit.TransTypeId = __value, _audit.TransTypeId)), 27, () => _audit.TransTypeId, 28, (__builder3) => {
#nullable restore
#line 18 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                 if (recordSessionList != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                     foreach (var ttype in recordSessionList)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(29, "option");
                    __builder3.AddAttribute(30, "value", 
#nullable restore
#line 22 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                        ttype.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(31, 
#nullable restore
#line 22 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                   ttype.Trans_Type

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                     
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.AddMarkupContent(35, "<label for=\"name\" class=\"col-md-5 col-form-label\">Employee</label>\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-md-10");
                __Blazor.RSTLog.Pages.RecordSession.TypeInference.CreateInputSelect_2(__builder2, 38, 39, "Employee", 40, "form-control", 41, 
#nullable restore
#line 32 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                                         _audit.EmployeeId

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _audit.EmployeeId = __value, _audit.EmployeeId)), 43, () => _audit.EmployeeId, 44, (__builder3) => {
#nullable restore
#line 33 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                 if (employeeList != null)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                     foreach (var emp in employeeList.OrderBy(e => e.Name))
                    {


#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(45, "option");
                    __builder3.AddAttribute(46, "value", 
#nullable restore
#line 39 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                        emp.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(47, 
#nullable restore
#line 39 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                 emp.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 40 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                     
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group row");
                __builder2.AddMarkupContent(51, "<label for=\"name\" class=\"col-md-5 col-form-label\">Qty</label>\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-md-10");
                __Blazor.RSTLog.Pages.RecordSession.TypeInference.CreateInputNumber_3(__builder2, 54, 55, "qty", 56, "form-control", 57, "1", 58, 
#nullable restore
#line 49 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                                            _audit.Qty

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _audit.Qty = __value, _audit.Qty)), 60, () => _audit.Qty);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group row");
                __builder2.AddMarkupContent(64, "<label for=\"name\" class=\"col-md-5 col-form-label\">Comments</label>\r\n        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "id", "name");
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                                   _audit.Comments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _audit.Comments = __value, _audit.Comments))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _audit.Comments));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group row");
                __builder2.AddMarkupContent(76, "<label for=\"name\" class=\"col-md-5 col-form-label\">Session Date</label>\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-md-10");
                __Blazor.RSTLog.Pages.RecordSession.TypeInference.CreateInputDate_4(__builder2, 79, 80, "name", 81, "form-control", 82, 
#nullable restore
#line 63 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                                   _audit.Date

#line default
#line hidden
#nullable disable
                , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _audit.Date = __value, _audit.Date)), 84, () => _audit.Date);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "row");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-md-12 text-right");
                __builder2.OpenElement(90, "button");
                __builder2.AddAttribute(91, "type", "submit");
                __builder2.AddAttribute(92, "class", "btn btn-success");
                __builder2.AddAttribute(93, "disabled", 
#nullable restore
#line 69 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                                                                     formInvalid

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(94, "Create");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n\r\n");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "row");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col");
            __builder.OpenElement(100, "a");
            __builder.AddAttribute(101, "href", "/customer/" + (
#nullable restore
#line 76 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\RecordSession.razor"
                            Customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "btn btn-success");
            __builder.AddContent(103, "Back");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RSTLog.Pages.RecordSession
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "hidden", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "min", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
