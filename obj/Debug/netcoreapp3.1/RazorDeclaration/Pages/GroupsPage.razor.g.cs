#pragma checksum "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8462308b632b84a5b20c91fb5c104f3bbfcf15"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SplitWise.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using SplitWise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\all of this\code this code\blazor_asp\SplitWise\_Imports.razor"
using SplitWise.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
using SplitWise.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
using SplitWiseDB.Data.SplitWise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/groupspage")]
    public partial class GroupsPage : OwningComponentBase<GroupService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<Group> groups;
    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;
        groups = await @Service.GetGroupAsync(user.Identity.Name);
    }

    Group objGroup = new Group();

    bool ShowPopup = false;

    void ClosePopup()
    {
        ShowPopup = false;
    }

    void AddNewGroup()
    {
        objGroup = new Group();
        objGroup.Id = 0;
        ShowPopup = true;
    }

    async Task SaveGroup()
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        if (objGroup.Id == 0)
        {
            Group objNewGroup = new Group();

            objNewGroup.Date = System.DateTime.Now;

            objNewGroup.GroupName = objGroup.GroupName;

            objNewGroup.UserName = user.Identity.Name;

            var result =
            @Service.CreateGroupAsync(objNewGroup);
        }
        else
        {
            var result =
            @Service.UpdateGroupAsync(objGroup);
        }

        groups =
        await @Service.GetGroupAsync(user.Identity.Name);
    }


    void OpenGroup(Group groupTable, int i, string name)
    {
        GroupService.Name = name;
        GroupService.IdNumber = i;
        objGroup = groupTable;
        NavigationManager.NavigateTo("billspage");

    }

    void EditGroup(Group groupTable)
    {
        objGroup = groupTable;
        ShowPopup = true;
    }

    async Task DeleteGroup()
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        var result = @Service.DeleteGroupAsync(objGroup);
        groups =
        await @Service.GetGroupAsync(user.Identity.Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.GroupService GroupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591