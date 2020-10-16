#pragma checksum "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4557d540c35b331fb8be97023346d9754edbc786"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PCHAT.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using PCHAT.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Development\PCHAT\PCHAT.UI\_Imports.razor"
using PCHAT.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserDetail/{Id}")]
    public partial class UserDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
       

    [Parameter]
    public string Id { get; set; }
    private UserDto user { get; set; }
    private List<MessageDto> messages = new List<MessageDto>();
    private string content { get; set; }
    private HubConnection hubConnection;



    protected override async Task OnInitializedAsync()
    {
        // If Id value is not supplied in the URL, use the value 1
        Id = Id ?? "1";
        user = await Http.GetFromJsonAsync<UserDto>($"http://localhost:62744/api/user/{Id}");

    }


    public async Task Send()
    {
        var data = await sessionStorage.GetItemAsync<UserDto>("data");
        var r = new { SenderId = data.Id, RecipientId = Id, Content = content };
        await hubConnection.SendAsync("SendMessage", data);
        return;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
