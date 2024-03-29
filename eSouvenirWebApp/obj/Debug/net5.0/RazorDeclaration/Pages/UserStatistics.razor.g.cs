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
#line 1 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using eSouvenirWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using eSouvenirWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userStatistics")]
    public partial class UserStatistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
       

    private List<Models.User> Users = new List<Models.User>();
    private List<Models.QRCode> QRCodes = new List<Models.QRCode>();
    private List<Models.City> Cities = new List<Models.City>();

    public int Broj { get; set; }
    public int IdUserClicked { get; set; }

    protected override async Task OnInitializedAsync()
    {

        Users = await Http.GetFromJsonAsync<List<Models.User>>("api/Users/get");
        QRCodes = await Http.GetFromJsonAsync<List<Models.QRCode>>("api/QRCode/get");
        Cities = await Http.GetFromJsonAsync<List<Models.City>>("api/Cities/get");

        foreach (var item in Users)
        {
            item.PassString = ConvertByteToString(item.Pass);
        }
    }

    private string ConvertByteToString(byte[] bytes)
    {
        return BitConverter.ToString(bytes).Replace("-", String.Empty);
    }

    private void GetStatistics(Models.User user)
    {
        IdUserClicked = user.IDUser;
        foreach (var city in Cities)
        {
            foreach (var qr in QRCodes)
            {
                if (qr.UserID==user.IDUser && qr.CityID==city.IDCity)
                {
                    user.NbrOfVisitedCities++;
                    break;
                }
            }
        }

        Broj = user.NbrOfVisitedCities;

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
