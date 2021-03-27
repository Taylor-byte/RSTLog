#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd94a9ab661b32f5c91df58722902f392c93e23"
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
    public partial class CustomerTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor"
 if(Customers.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "<thead><tr><th scope=\"col\">Name</th>\r\n                <th scope=\"col\">Update</th>\r\n                <th scope=\"col\">Delete</th></tr></thead>\r\n        ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 13 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor"
             foreach(var customer in Customers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "/customer/" + (
#nullable restore
#line 17 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor"
                                        customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, 
#nullable restore
#line 18 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor"
                         customer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, "<td><button type=\"button\" class=\"btn btn-info\">Update</button></td>\r\n                ");
            __builder.AddMarkupContent(11, "<td><button type=\"button\" class=\"btn btn-danger\">Delete</button></td>");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<span>Loading Customers...........</span>");
#nullable restore
#line 38 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Components\CustomerTable.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591