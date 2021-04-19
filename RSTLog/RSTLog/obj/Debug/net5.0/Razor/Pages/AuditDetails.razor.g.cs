#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\AuditDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313f59eafe9f74f6ffadb55fd67a9ab7e86fbc2f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/audit/{auditId:int}")]
    public partial class AuditDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"mt-3\" b-4vfci7hzhj>Ticket Details</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "b-4vfci7hzhj");
            __builder.AddMarkupContent(4, "<div class=\"col-sm-3\" b-4vfci7hzhj><label b-4vfci7hzhj>Date</label></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-6");
            __builder.AddAttribute(7, "b-4vfci7hzhj");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "b-4vfci7hzhj");
            __builder.AddContent(10, 
#nullable restore
#line 6 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\AuditDetails.razor"
                                 Audit.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddAttribute(14, "b-4vfci7hzhj");
            __builder.AddMarkupContent(15, "<div class=\"col-sm-3\" b-4vfci7hzhj><label b-4vfci7hzhj>Record Date</label></div>\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-sm-6");
            __builder.AddAttribute(18, "b-4vfci7hzhj");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "b-4vfci7hzhj");
            __builder.AddContent(21, 
#nullable restore
#line 10 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\AuditDetails.razor"
                                 Audit.RecordDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddAttribute(25, "b-4vfci7hzhj");
            __builder.AddMarkupContent(26, "<div class=\"col-sm-3\" b-4vfci7hzhj><label b-4vfci7hzhj>Qty</label></div>\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-6");
            __builder.AddAttribute(29, "b-4vfci7hzhj");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "b-4vfci7hzhj");
            __builder.AddContent(32, 
#nullable restore
#line 14 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\AuditDetails.razor"
                                 Audit.Qty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.AddAttribute(36, "b-4vfci7hzhj");
            __builder.AddMarkupContent(37, "<div class=\"col-sm-3\" b-4vfci7hzhj><label b-4vfci7hzhj>Comments</label></div>\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-sm-6");
            __builder.AddAttribute(40, "b-4vfci7hzhj");
            __builder.AddContent(41, 
#nullable restore
#line 20 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\AuditDetails.razor"
                           Audit.Comments

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, "<span b-4vfci7hzhj></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.AddMarkupContent(44, "<div class=\"col-sm-6\" b-4vfci7hzhj><span b-4vfci7hzhj></span></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.AddMarkupContent(46, @"<div class=""row"" b-4vfci7hzhj><div class=""col-sm-3"" b-4vfci7hzhj><label b-4vfci7hzhj></label>Work Completed By</div>
    <div class=""col-sm-6"" b-4vfci7hzhj><span b-4vfci7hzhj></span></div>
    <div class=""col-sm-6"" b-4vfci7hzhj><span b-4vfci7hzhj></span></div>
    <div class=""col-sm-6"" b-4vfci7hzhj><span b-4vfci7hzhj></span></div></div>


<br b-4vfci7hzhj>
");
            __builder.AddMarkupContent(47, "<div class=\"row\" b-4vfci7hzhj><div class=\"col\" b-4vfci7hzhj><a href=\"/customers\" class=\"btn btn-success\" b-4vfci7hzhj>Back</a></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
