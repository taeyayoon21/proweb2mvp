#pragma checksum "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Shared\VPCS\VPCSMainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae951413ed923fcf89b2a3e499e2f0736dc1a7a4"
// <auto-generated/>
#pragma warning disable 1591
namespace ProWeb2MVP.Shared.VPCS
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class VPCSMainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<ProWeb2MVP.Shared.VPCS.VPCSLeftLayout>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 16 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Shared\VPCS\VPCSMainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
