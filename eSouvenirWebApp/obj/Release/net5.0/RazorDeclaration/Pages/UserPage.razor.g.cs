// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace eSouvenirWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using eSouvenirWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using eSouvenirWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userPage")]
    public partial class UserPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserPage.razor"
       
    private List<Models.User> Users = new List<Models.User>();

    protected override async Task OnInitializedAsync()
    {
        //Users.Add(new Models.User("user9", "user9@mail.com", new byte[] { }, false));
       
        await Http.GetFromJsonAsync<List<Models.User>>("api/Users/get");
        Users = await Http.GetFromJsonAsync<List<Models.User>>("api/Users/get");
    }

    private string ConvertByteToString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", String.Empty);
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591