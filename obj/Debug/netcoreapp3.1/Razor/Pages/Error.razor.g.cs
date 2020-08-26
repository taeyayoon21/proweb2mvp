#pragma checksum "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\Error.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeca9cdb6fde0c11029a10d88f1c7e7dadae8a5c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/error")]
    public partial class Error : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Error.</h1>\r\n");
            __builder.AddMarkupContent(1, "<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            __builder.AddMarkupContent(2, "<h3>Development Mode</h3>\r\n");
            __builder.AddMarkupContent(3, "<p>\r\n    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.\r\n</p>\r\n");
            __builder.AddMarkupContent(4, @"<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
