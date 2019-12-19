#pragma checksum "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68fb43b9b0987f6e2c0316af328a1bb8f2f2cb74"
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
#line 2 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor"
using MimeKit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor"
using SplitWise.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor"
using SplitWiseDB.Data.SplitWise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/emailsender")]
    public partial class EmailSender : OwningComponentBase<EmailSenderService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "D:\all of this\code this code\blazor_asp\SplitWise\Pages\EmailSender.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    string eMailFrom = "";
    string subject = "";
    string message = "";
    string password = "";
    string eMailTo = "";

    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;
        //bills = await @Service.GetBillSplitAsync(BillSplitService.RecipientName);
        eMailFrom = user.Identity.Name;
        eMailTo = BillSplitService.RecipientName;
    }


    async Task SendMail()
    {

        var result =
           @Service.SendEmailAsync(eMailFrom, password, eMailTo, subject, message);

        logger.LogInformation("Message is sent");

        // lbl =
        //  await @Service.SendEmailAsync(EmailService.Message);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.EmailSenderService EmailSenderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.BillService BillService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.BillSplitService BillSplitService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<EmailSender> logger { get; set; }
    }
}
#pragma warning restore 1591