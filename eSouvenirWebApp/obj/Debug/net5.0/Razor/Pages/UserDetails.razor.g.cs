#pragma checksum "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe93d2f71eb247b0812c00cb2435e13ab471ed4e"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/userDetails")]
    public partial class UserDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Users details</h1>\r\n\r\n");
            __Blazor.eSouvenirWebApp.Pages.UserDetails.TypeInference.CreateRadzenGrid_0(__builder, 1, 2, 
#nullable restore
#line 7 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                          true

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 7 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 7 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                                             FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 8 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                      5

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 8 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                       true

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 8 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                    Users

#line default
#line hidden
#nullable disable
            , 8, "150px", 9, (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(10);
                __builder2.AddAttribute(11, "Property", "IDUser");
                __builder2.AddAttribute(12, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(14);
                __builder2.AddAttribute(15, "Property", "Username");
                __builder2.AddAttribute(16, "Title", "Username");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(18);
                __builder2.AddAttribute(19, "Property", "Email");
                __builder2.AddAttribute(20, "Title", "Email");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(22);
                __builder2.AddAttribute(23, "Property", "PassString");
                __builder2.AddAttribute(24, "Title", "Pasword");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(26);
                __builder2.AddAttribute(27, "Property", "IsAdmin");
                __builder2.AddAttribute(28, "Title", "IsAdmin");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(30);
                __builder2.AddAttribute(31, "Title", "Remove user");
                __builder2.AddAttribute(32, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 15 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                                                                                 TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Width", "60px");
                __builder2.AddAttribute(36, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Models.User>)((user) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(37);
                    __builder3.AddAttribute(38, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 17 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Icon", "delete_forever");
                    __builder3.AddAttribute(40, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 17 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                                                           ButtonSize.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Class", "m-1");
                    __builder3.AddAttribute(42, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                                                                                                  args => RemoveUser(user)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddEventStopPropagationAttribute(43, "onclick", 
#nullable restore
#line 17 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
                                                                                                                                                                                       true

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserDetails.razor"
       



    private List<Models.User> Users = new List<Models.User>();

    protected override async Task OnInitializedAsync()
    {
        //Users.Add(new Models.User("user9", "user9@mail.com", new byte[] { }, false));

        //await Http.GetFromJsonAsync<List<Models.User>>("api/Users/get");
        Users = await Http.GetFromJsonAsync<List<Models.User>>("api/Users/get");

        foreach (var item in Users)
        {
            item.PassString = ConvertByteToString(item.Pass);
        }
    }

    private string ConvertByteToString(byte[] bytes)
    {
        return BitConverter.ToString(bytes).Replace("-", String.Empty);
    }

    async Task RemoveUser(Models.User user)
    {

        await JsRuntime.InvokeVoidAsync("alert", "Warning!"); // Alert

        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?"); // Confirm
        if (confirmed)
        {
            await Http.PostAsJsonAsync("api/Users/updateUser", user);
            await OnInitializedAsync();

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.eSouvenirWebApp.Pages.UserDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::Radzen.FilterCaseSensitivity __arg2, int __seq3, global::System.Int32 __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Collections.Generic.IEnumerable<TItem> __arg5, int __seq6, global::System.String __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "AllowPaging", __arg0);
        __builder.AddAttribute(__seq1, "AllowFiltering", __arg1);
        __builder.AddAttribute(__seq2, "FilterCaseSensitivity", __arg2);
        __builder.AddAttribute(__seq3, "PageSize", __arg3);
        __builder.AddAttribute(__seq4, "AllowSorting", __arg4);
        __builder.AddAttribute(__seq5, "Data", __arg5);
        __builder.AddAttribute(__seq6, "ColumnWidth", __arg6);
        __builder.AddAttribute(__seq7, "Columns", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
