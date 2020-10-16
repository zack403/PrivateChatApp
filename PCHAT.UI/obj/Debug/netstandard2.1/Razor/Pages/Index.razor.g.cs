#pragma checksum "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e7c4d96045459106c6c2fd388ec60cb3e8473f3"
// <auto-generated/>
#pragma warning disable 1591
namespace PCHAT.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
using PCHAT.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
 if (!loggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<div>\r\n        <label>Welcome!, Kindly register or login if you already have an account.</label>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 19 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
 if (loggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "text-center");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "label");
            __builder.AddContent(8, " Your Name: ");
            __builder.OpenElement(9, "strong");
            __builder.AddContent(10, 
#nullable restore
#line 22 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
                                    username.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<div>\r\n        <label> Users</label>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
     if (users.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, @"<thead>
                <tr>
                    <th scope=""col""></th>
                    <th scope=""col"">User Name</th>
                    <th scope=""col"">Gender</th>
                    <th scope=""col"">Actions</th>

                </tr>
            </thead>
            ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 43 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
                 foreach (var user in users)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                    ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<td>\r\n                            <img src alt=\"user image\" style=\"width:100px;\">\r\n                        </td>\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "class", "align-middle");
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.AddContent(29, 
#nullable restore
#line 50 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
                             user.UserName.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "align-middle");
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.AddContent(35, 
#nullable restore
#line 53 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
                             user.Gender.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "align-middle");
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
                                                e => gotodet(user.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-success");
            __builder.AddContent(45, "Chat");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 60 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 63 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "        ");
            __builder.AddMarkupContent(53, "<span>\r\n            Loading users...\r\n        </span>\r\n");
#nullable restore
#line 69 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private List<UserDto> users = new List<UserDto>();

    private int SenderId { get; set; }
    private int RecipientId { get; set; }
    private DateTime MessageSent { get; set; }
    private string Content { get; set; }
    private string username { get; set; }
    private bool loggedIn = false;


    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:62744/chathub")
            .Build();


        await hubConnection.StartAsync();

        var data = await sessionStorage.GetItemAsync<UserDto>("data");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
         if (data != null)
        {
            username = data.UserName;
            loggedIn = true;

            users = await Http.GetFromJsonAsync<List<UserDto>>($"http://localhost:62744/api/user?id={data.Id}");

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Development\PCHAT\PCHAT.UI\Pages\Index.razor"
         


    }

    public void gotodet(string id)
    {
        NavigationManager.NavigateTo($"/UserDetail/{id}");
    }

    async Task Send()
    {
        var data = await sessionStorage.GetItemAsync<string>("data");
        UserDto myCustomObject = JsonConvert.DeserializeObject<UserDto>(data);
        //var r = new {SenderId = myCustomObject.id, RecipientId = myCustomObject., MessageSent = Content}
        await hubConnection.SendAsync("SendMessage", data);
        return;
    }

    public bool IsConnected =>
    hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
