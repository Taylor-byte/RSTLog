#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab619049843154bc45bf3518e888315d113a8a7"
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
#nullable restore
#line 3 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
using RSTLog.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer/{customerId:int}")]
    public partial class CustomerDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"mt-3\">Customer Details</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "<div class=\"col-sm-3\"><label>Name</label></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-6");
            __builder.OpenElement(6, "span");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                 Customer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "<div class=\"col-sm-3\"><label>Hours Purchased</label></div>\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-sm-6");
            __builder.OpenElement(14, "span");
            __builder.AddContent(15, 
#nullable restore
#line 13 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                 Customer.HoursPurchased

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.AddMarkupContent(19, "<div class=\"col-sm-3\"><label>Hours Remaining</label></div>\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-sm-6");
            __builder.OpenElement(22, "span");
            __builder.AddContent(23, 
#nullable restore
#line 17 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                 Customer.HoursRemaining

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.AddMarkupContent(27, "<div class=\"col-sm-3\"><label>RST Balance</label></div>\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm-6");
            __builder.OpenElement(30, "span");
            __builder.AddContent(31, 
#nullable restore
#line 23 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                 Customer.RSTBalance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.AddMarkupContent(33, "<div class=\"col-sm-6\"><span></span></div>\r\n    ");
            __builder.AddMarkupContent(34, "<div class=\"col-sm-6\"><span></span></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.AddMarkupContent(38, "<div class=\"col-sm-3\"><label>Onsite Balance</label></div>\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-sm-6");
            __builder.OpenElement(41, "span");
            __builder.AddContent(42, 
#nullable restore
#line 30 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                 Customer.OnsiteBalance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.AddMarkupContent(44, "<div class=\"col-sm-6\"><span></span></div>\r\n    ");
            __builder.AddMarkupContent(45, "<div class=\"col-sm-6\"><span></span></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n");
            __builder.AddMarkupContent(47, "<div class=\"row\"><div class=\"col-md-5\"></div>\r\n    <div class=\"col-md-2\"></div>\r\n    <div class=\"col-md-2\"></div></div>\r\n");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col");
            __builder.OpenComponent<RSTLog.Components.AuditTable>(52);
            __builder.AddAttribute(53, "Audits", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<RSTLog.Models.Audit>>(
#nullable restore
#line 46 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                AuditList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "CustomerId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                                        CustomerId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col");
            __builder.OpenComponent<RSTLog.Components.Pagination>(60);
            __builder.AddAttribute(61, "MetaData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RSTLog.Models.MetaData>(
#nullable restore
#line 111 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                              MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 111 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                                1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 111 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                                                 SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col");
            __builder.OpenComponent<RSTLog.Components.PageSizeDropdown>(67);
            __builder.AddAttribute(68, "SelectedPageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 114 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                            SetPageSize

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col");
            __builder.OpenElement(74, "a");
            __builder.AddAttribute(75, "class", "btn btn-success mb-1");
            __builder.AddAttribute(76, "href", "/recordSession/" + (
#nullable restore
#line 121 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                                              Customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "Record Session");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "row");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "class", "btn btn-info mb-1");
            __builder.AddAttribute(85, "href", "/addCredit/" + (
#nullable restore
#line 126 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                                       Customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Add Credit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
            __builder.AddMarkupContent(88, "<div class=\"row\"><div class=\"col\"><a href=\"/customers\" class=\"btn btn-success\">Back</a></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
