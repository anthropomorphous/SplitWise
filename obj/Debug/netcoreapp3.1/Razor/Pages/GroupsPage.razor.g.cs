#pragma checksum "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8462308b632b84a5b20c91fb5c104f3bbfcf15"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<h1>Мои группы</h1>\r\n        <br>\r\n");
#nullable restore
#line 13 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
         if (groups == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(4, "            ");
                __builder2.AddMarkupContent(5, "<p><em>Загружаем данные...</em></p>\r\n");
#nullable restore
#line 16 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "            ");
                __builder2.OpenElement(7, "table");
                __builder2.AddAttribute(8, "class", "table");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.AddMarkupContent(10, @"<thead>
                    <tr>
                        <th> Дата </th>
                        <th> Название </th>
                        <th> Создатель </th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(11, "tbody");
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 31 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                     foreach (var group in groups)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "                        ");
                __builder2.OpenElement(14, "tr");
                __builder2.AddMarkupContent(15, "\r\n                            ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 34 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                 group.Date.Value.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 35 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                 group.GroupName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 36 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                 group.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
                __builder2.AddMarkupContent(26, "\r\n                                ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn btn-primary");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                                  (() => OpenGroup(group, group.Id, group.GroupName))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(30, "\r\n                                    Открыть\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "td");
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "class", "btn btn-primary");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                                  (() => EditGroup(group))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(38, "\r\n                                    Редактировать\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                                \r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.OpenElement(41, "td");
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "class", "btn btn-primary");
                __builder2.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                                  DeleteGroup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(46, "\r\n                                    Удалить\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n");
#nullable restore
#line 57 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(50, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenElement(53, "p");
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "class", "btn btn-primary");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                  AddNewGroup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(58, "\r\n                    Создать группу\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
#nullable restore
#line 66 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(61, "                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "modal");
                __builder2.AddAttribute(64, "tabindex", "-1");
                __builder2.AddAttribute(65, "style", "display:block");
                __builder2.AddAttribute(66, "role", "dialog");
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "modal-dialog");
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "modal-content");
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "modal-header");
                __builder2.AddMarkupContent(76, "\r\n                                ");
                __builder2.AddMarkupContent(77, "<h3 class=\"modal-title\">Редактировать</h3>\r\n                                ");
                __builder2.OpenElement(78, "button");
                __builder2.AddAttribute(79, "type", "button");
                __builder2.AddAttribute(80, "class", "close");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(82, "\r\n                                    ");
                __builder2.AddMarkupContent(83, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "modal-body");
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.OpenElement(89, "input");
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "type", "text");
                __builder2.AddAttribute(92, "placeholder", "Название группы");
                __builder2.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                              objGroup.GroupName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objGroup.GroupName = __value, objGroup.GroupName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                                <br>\r\n                                ");
                __builder2.OpenElement(96, "button");
                __builder2.AddAttribute(97, "class", "btn btn-primary");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
                                                  SaveGroup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(99, "\r\n                                    Сохранить\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                                \r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n");
#nullable restore
#line 92 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\GroupsPage.razor"
             

        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "    ");
            }
            ));
            __builder.AddAttribute(106, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(107, "\r\n        ");
                __builder2.AddMarkupContent(108, "<p>Войдите в приложение.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
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