#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17344f9eabcc27d4a1db856f79e1b6c4442f85a9"
// <auto-generated/>
#pragma warning disable 1591
namespace RSTLog.Components
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
    public partial class AuditTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
 if (Audits.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, @"<thead><tr><th scope=""col"">Transaction Type</th>
                <th scope=""col"">Completed</th>
                <th scope=""col"">Comments</th>
                <th scope=""col"">Qty</th>
                <th scope=""col"">Record Details</th>
                <th scope=""col"">Update</th></tr></thead>
        ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 16 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
             foreach (var audit in Audits.Where(a => a.CustomerId == CustomerId))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 22 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
                         audit.TransType.Trans_Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
                     audit.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 32 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
                         audit.Comments

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 37 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
                         audit.Qty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "/audit/" + (
#nullable restore
#line 41 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
                                     audit.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n                        Details\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<td><a class=\"btn btn-info\">\r\n                        Update\r\n                    </a></td>");
            __builder.CloseElement();
#nullable restore
#line 51 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
                                                                     

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<span>Loading Audit Records...........</span>");
#nullable restore
#line 61 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\AuditTable.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
