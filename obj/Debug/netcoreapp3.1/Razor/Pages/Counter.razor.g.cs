#pragma checksum "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53c9e3a1bc224eae4447032f41b78ad9ffc92ae1"
// <auto-generated/>
#pragma warning disable 1591
namespace ProWeb2MVP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using ProWeb2MVP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using ProWeb2MVP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using ProWeb2MVP.Shared.VPCS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using ProWeb2MVP.Shared.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Oracle.ManagedDataAccess.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using Oracle.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\_Imports.razor"
using ProWeb2MVP.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CommonMainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content px-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h1>Counter</h1>\r\n\r\n        ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Current count: ");
            __builder.AddContent(9, 
#nullable restore
#line 8 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\Counter.razor"
                           currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\Counter.razor"
                                                  IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591