#pragma checksum "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a53dc0b1dc8776c75fd12b25b08e9db5fadc9687"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/userStatistics")]
    public partial class UserStatistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>User Statistics</h1>\r\n\r\n");
            __Blazor.eSouvenirWebApp.Pages.UserStatistics.TypeInference.CreateRadzenGrid_0(__builder, 1, 2, 
#nullable restore
#line 8 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                         true

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 8 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                               true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 8 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                            FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 9 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                      5

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 9 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                       true

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 9 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                    Users

#line default
#line hidden
#nullable disable
            , 8, "150px", 9, (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(10);
                __builder2.AddAttribute(11, "Property", "Username");
                __builder2.AddAttribute(12, "Title", "Username");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(14);
                __builder2.AddAttribute(15, "Property", "IsAdmin");
                __builder2.AddAttribute(16, "Title", "IsAdmin");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Models.User>>(18);
                __builder2.AddAttribute(19, "Title", "User statistics");
                __builder2.AddAttribute(20, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                  false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 14 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Width", "60px");
                __builder2.AddAttribute(24, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Models.User>)((user) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(25);
                    __builder3.AddAttribute(26, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 16 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                           ButtonStyle.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Icon", "assessment");
                    __builder3.AddAttribute(28, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 16 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                     ButtonSize.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Class", "m-1");
                    __builder3.AddAttribute(30, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                                                             args => GetStatistics(user)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddEventStopPropagationAttribute(31, "onclick", 
#nullable restore
#line 16 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
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
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "container");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-sm-12 my-5");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(39);
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.eSouvenirWebApp.Pages.UserStatistics.TypeInference.CreateRadzenColumnSeries_1(__builder2, 41, 42, 
#nullable restore
#line 28 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                           UserToShow

#line default
#line hidden
#nullable disable
                , 43, "Username", 44, "Visited cities", 45, 
#nullable restore
#line 28 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                                                    LineType.Dashed

#line default
#line hidden
#nullable disable
                , 46, "NbrOfVisitedCities");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __Blazor.eSouvenirWebApp.Pages.UserStatistics.TypeInference.CreateRadzenColumnSeries_2(__builder2, 48, 49, 
#nullable restore
#line 29 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                            UserToShow

#line default
#line hidden
#nullable disable
                , 50, "Username", 51, "Number of QR Codes", 52, 
#nullable restore
#line 29 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                                                         LineType.Dashed

#line default
#line hidden
#nullable disable
                , 53, "NbrOfQRCodes");
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(55);
                __builder2.AddAttribute(56, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                      0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                              6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                       2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(60);
                    __builder3.AddAttribute(61, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(63);
                __builder2.AddAttribute(64, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 33 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                             3

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(66);
                __builder2.AddAttribute(67, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 34 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
                                             400

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Teodor\Desktop\eSouvenirWebApp\eSouvenirWebApp\Pages\UserStatistics.razor"
       


    private List<Models.User> Users = new List<Models.User>();
    private List<Models.QRCode> QRCodes = new List<Models.QRCode>();
    private List<Models.City> Cities = new List<Models.City>();
    private List<Models.User> UserToShow = new List<Models.User>();


    public int BrojGradova { get; set; }
    public int BrojKodova { get; set; }
    public int IdUserClicked { get; set; }
    

    protected override async Task OnInitializedAsync()
    {

        Users = await Http.GetFromJsonAsync<List<Models.User>>("api/Users/get");
        QRCodes = await Http.GetFromJsonAsync<List<Models.QRCode>>("api/QRCode/get");
        Cities = await Http.GetFromJsonAsync<List<Models.City>>("api/Cities/get");

        foreach (var item in Users)
        {
            item.Pass = ConvertByteToString(item.Password);
        }

        Count();
        CountQRCodes();

    }

    private string ConvertByteToString(byte[] bytes)
    {
        return BitConverter.ToString(bytes).Replace("-", String.Empty);
    }

    private void GetStatistics(Models.User user)
    {
        UserToShow.Clear();
        UserToShow.Add(user);
        IdUserClicked = user.IDUser;
        BrojGradova = user.NbrOfVisitedCities;
        BrojKodova = user.NbrOfQRCodes;

    }

    private void Count()
    {
        foreach (var user in Users)
        {
            foreach (var city in Cities)
            {
                foreach (var qr in QRCodes)
                {
                    if (qr.UserID == user.IDUser && qr.CityID == city.IDCity)
                    {
                        user.NbrOfVisitedCities++;
                        break;
                    }
                }

            }
        }

    }

    private void CountQRCodes()
    {
        foreach (var user in Users)
        {

            foreach (var qr in QRCodes)
            {
                if (qr.UserID == user.IDUser)
                {
                    user.NbrOfQRCodes++;

                }
            }


        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.eSouvenirWebApp.Pages.UserStatistics
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
        public static void CreateRadzenColumnSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Radzen.Blazor.LineType __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "LineType", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenColumnSeries_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Radzen.Blazor.LineType __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "LineType", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
