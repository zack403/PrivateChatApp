#pragma checksum "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c61c11daf8b8077cbd7222cc663ff8c23dcb8bb"
// <auto-generated/>
#pragma warning disable 1591
namespace PCHAT.UI.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<PCHAT.UI.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 12 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
         if (!loggedIn)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.AddMarkupContent(13, "<a href=\"login\" class=\"ml-md-auto\">Login</a>\r\n            ");
            __builder.AddMarkupContent(14, "<a href=\"register\" class>Register</a>\r\n");
#nullable restore
#line 16 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
                         logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "");
            __builder.AddContent(19, "Logout");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 20 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "content px-4");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddContent(26, 
#nullable restore
#line 26 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
       

    private bool loggedIn = false;

    protected override async Task OnInitializedAsync()
    {

        var data = await sessionStorage.GetItemAsync<UserDto>("data");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
         if (data != null)
        {
            loggedIn = true;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Development\PCHAT\PCHAT.UI\Shared\MainLayout.razor"
         


    }


    async Task logout()
    {
        await sessionStorage.RemoveItemAsync("data");
        NavigationManager.NavigateTo("/");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
