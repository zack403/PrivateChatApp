#pragma checksum "C:\Development\PCHAT\PCHAT.UI\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494a52a72ec4cb81cb8cb6e1d36cfa455afd33bb"
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
#line 2 "C:\Development\PCHAT\PCHAT.UI\Pages\Register.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Development\PCHAT\PCHAT.UI\Pages\Register.razor"
       
    private string UserName { get; set; }
    private string Gender { get; set; }
    private string Password { get; set; }
    private string message { get; set; } = null;


    public async void Create()
    {
        var postBody = new { UserName = UserName, Password = Password, Gender = Gender };
        var result = await Http.PostAsJsonAsync("http://localhost:62744/api/auth/register", postBody);
        var content = await result.Content.ReadAsStringAsync();
        if (content != null)
        {
            message = content;
            NavigationManager.NavigateTo("login");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
