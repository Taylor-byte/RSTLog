#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ddfb7fac5e8a77bffaec0c82713b4a6308eec59"
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
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using RSTLog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using RSTLog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\UniProjects\RSTLog\RSTLog\RSTLog\_Imports.razor"
using Blazored.Toast.Configuration;

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
#line 6 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
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
#line 10 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
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
#line 14 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
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
#line 20 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\CustomerDetails.razor"
                                 Customer.Audit.Where(a => a.TransTypeId == 0 || a.TransTypeId == 1).Sum(a => a.Qty)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.AddMarkupContent(33, "<div class=\"col-sm-6\"><span></span></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.AddMarkupContent(35, "<div class=\"row\"><div class=\"col-sm-3\"><label>Onsite Balance</label></div>\r\n    \r\n    <div class=\"col-sm-6\"><span></span></div></div>\r\n\r\n\r\n<br>\r\n");
            __builder.AddMarkupContent(36, "<div class=\"row\"><div class=\"col\"><a href=\"/customers\" class=\"btn btn-success\">Back</a></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
