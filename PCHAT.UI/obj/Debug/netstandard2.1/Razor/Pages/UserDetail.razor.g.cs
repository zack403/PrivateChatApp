#pragma checksum "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63e98fe6bd51c39cc4a5d33dec528375e355b0e7"
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
#nullable restore
#line 6 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
 if (user != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Chatting with user ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                            user.UserName.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 9 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "panel panel-primary");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "panel-body");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 14 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
         if (messages.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.AddMarkupContent(13, "<div>\r\n                <p> No messages yet, say hi by using the message box below</p>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "chat");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "li");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 24 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                 foreach (var message in messages)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                     if (message.SenderId == Id)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                        ");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.AddMarkupContent(23, "<span class=\"chat-img pull-left\">\r\n                                <img src class=\"img-circle\" alt>\r\n                            </span>\r\n                            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "chat-body");
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "header");
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "small");
            __builder.AddAttribute(31, "class", "text-muted pull-right");
            __builder.AddMarkupContent(32, "\r\n                                        ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "fa fa-clock-o");
            __builder.AddContent(35, 
#nullable restore
#line 35 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                                                                     message.MessageSent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, 
#nullable restore
#line 38 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                                    message.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 41 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                        ");
            __builder.OpenElement(45, "div");
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.AddMarkupContent(47, "<span class=\"chat-img pull-right\">\r\n                                <img src class=\"img-circle\" alt>\r\n                            </span>\r\n                            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "chat-body");
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "header");
            __builder.AddMarkupContent(53, "\r\n                                    ");
            __builder.OpenElement(54, "small");
            __builder.AddAttribute(55, "class", "text-muted pull-right");
            __builder.AddMarkupContent(56, "\r\n                                        ");
            __builder.OpenElement(57, "span");
            __builder.AddAttribute(58, "class", "fa fa-clock-o");
            __builder.AddContent(59, 
#nullable restore
#line 51 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                                                                     message.MessageSent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, 
#nullable restore
#line 57 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                                    message.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 60 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                     

                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "panel-footer");
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "form");
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "input-group");
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "text");
            __builder.AddAttribute(82, "name", "sendmessage");
            __builder.AddAttribute(83, "class", "form-control input-sm");
            __builder.AddAttribute(84, "required", true);
            __builder.AddAttribute(85, "placeholder", "send a private message");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                              content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => content = __value, content));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "span");
            __builder.AddAttribute(90, "class", "input-group-btn");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
                                                                Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "class", "btn btn-primary btn-sm");
            __builder.AddContent(94, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Development\PCHAT\PCHAT.UI\Pages\UserDetail.razor"
       

    [Parameter]
    public string Id { get; set; }
    private UserDto user { get; set; }
    private List<MessageDto> messages = new List<MessageDto>();
    private string content { get; set; }
    private HubConnection hubConnection;



    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
           .WithUrl("http://localhost:62744/chathub")
           .Build();


        hubConnection.On<MessageDto>("MessageReceived", (msg) =>
        {
            messages.Add(msg);
            //StateHasChanged();
        });

        await hubConnection.StartAsync();
        Console.WriteLine("connected in details");
        // If Id value is not supplied in the URL, use the value 1
        Id = Id ?? "1";
        user = await Http.GetFromJsonAsync<UserDto>($"http://localhost:62744/api/user/{Id}");

    }


    async void Send()
    {
        var data = await sessionStorage.GetItemAsync<UserDto>("data");
        if (data != null)
        {
            var result = new { SenderId = data.Id, RecipientId = Id, Content = content };
            var postBody = new { SenderId = data.Id, RecipientId = Id, Content = content };
            await hubConnection.SendAsync("SendMessage", postBody);
            //await Http.PostAsJsonAsync("http://localhost:62744/api/message", postBody);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
