#pragma checksum "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59ba5e36edce76579f89216a76b0dc0f5a5f88bc"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-5");
            __builder.OpenComponent<RSTLog.Components.Search>(4);
            __builder.AddAttribute(5, "OnSearchChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                 SearchChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    \r\n    \r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(7);
            __builder.AddAttribute(8, "Roles", "Administrator");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<div class=\"col-md-2\"><a class=\"btn btn-success mb-1\" href=\"/createCustomer\">New Customer</a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col");
            __builder.OpenComponent<RSTLog.Components.CustomerTable>(16);
            __builder.AddAttribute(17, "Customers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<RSTLog.Models.Customer>>(
#nullable restore
#line 20 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                  CustomerList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnDelete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 20 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                                          DeleteCustomer

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col");
            __builder.OpenComponent<RSTLog.Components.Pagination>(24);
            __builder.AddAttribute(25, "MetaData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RSTLog.Models.MetaData>(
#nullable restore
#line 25 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                              MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                                1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 25 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                                                 SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col");
            __builder.OpenComponent<RSTLog.Components.PageSizeDropdown>(31);
            __builder.AddAttribute(32, "SelectedPageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 28 "C:\UniProjects\RSTLog\RSTLog\RSTLog\Pages\Customers.razor"
                                            SetPageSize

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
