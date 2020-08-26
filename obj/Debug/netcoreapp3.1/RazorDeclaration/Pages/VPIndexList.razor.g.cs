#pragma checksum "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\VPIndexList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4683976ae01fa8c66a980a1d7f931bb26c20fec"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 8 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\VPIndexList.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(VPCSMainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/VPCS")]
    public partial class VPIndexList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\05.SVN_Source\DOTNETCORE\ProWeb2MVP\ProWeb2MVP\Pages\VPIndexList.razor"
           
    private System.Data.DataTable dt;

    protected override async Task OnInitializedAsync()
    {
        ////containerSize 를 수정
        //containerSize = "81vh";

        var entity = new ProWeb2MVP.Models.POMainEntity();

        entity.P_PJT_ID = "t00123";
        entity.P_NEW_VER_YN = "Y";
        entity.P_SORT_COL = "ITEM_NO";
        entity.P_SORT_DIRECTION = "ASC";
        entity.P_START_IDX = "0";
        entity.P_PAGE_SIZE = "100";
        entity.P_LIKE_SEARCH_YN = "N";

        dt = await context.GetAsyncVPList(entity);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#TableContainer", "#example");
    }

    void IDisposable.Dispose()
    {
        JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#example");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProWeb2MVP.Data.DataAccess.OracleDBContext context { get; set; }
    }
}
#pragma warning restore 1591
