#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ca3320144e2b9b250e1fc0b134fa2cb764f4e50"
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
#line 2 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
using RSTLog.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers")]
    public partial class Customers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col-md-5\"></div>\r\n    <div class=\"col-md-2\"><a class=\"btn btn-success mb-1\" href=\"/createCustomer\">New Customer</a></div></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-5");
            __builder.OpenComponent<RSTLog.Components.CustomerTable>(5);
            __builder.AddAttribute(6, "Customers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<RSTLog.Models.Customer>>(
#nullable restore
#line 15 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                  CustomerList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    <div class=\"col-md-2\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-5");
            __builder.OpenComponent<RSTLog.Components.Pagination>(13);
            __builder.AddAttribute(14, "MetaData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RSTLog.Models.MetaData>(
#nullable restore
#line 23 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                              MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                                1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 23 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                                                 SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    <div class=\"col-md-2\"></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591