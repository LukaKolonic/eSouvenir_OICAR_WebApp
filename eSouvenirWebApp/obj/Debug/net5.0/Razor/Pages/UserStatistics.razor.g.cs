#pragma checksum "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserStatistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2fb40669577cb6685efc7a718ae20fdc1e2560c"
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
#nullable restore
#line 2 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserStatistics.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userStatistics")]
    public partial class UserStatistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Radzen Blazor Chart column series</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12 my-5");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.eSouvenirWebApp.Pages.UserStatistics.TypeInference.CreateRadzenColumnSeries_0(__builder2, 9, 10, 
#nullable restore
#line 9 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserStatistics.razor"
                                           visitedCities

#line default
#line hidden
#nullable disable
                , 11, "Username", 12, "Visited cities", 13, 
#nullable restore
#line 9 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserStatistics.razor"
                                                                                                                       LineType.Dashed

#line default
#line hidden
#nullable disable
                , 14, "NbrOfVisitedCities");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __Blazor.eSouvenirWebApp.Pages.UserStatistics.TypeInference.CreateRadzenColumnSeries_1(__builder2, 16, 17, 
#nullable restore
#line 10 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserStatistics.razor"
                                           uploadedPictures

#line default
#line hidden
#nullable disable
                , 18, "Username", 19, "Uploaded pics", 20, "NbrOfPictures");
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(22);
                __builder2.AddAttribute(23, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 11 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserStatistics.razor"
                                             5

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
#line 17 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\UserStatistics.razor"
       
    class DataItem
    {
        public string Username { get; set; }
        public int NbrOfVisitedCities { get; set; }
        public int NbrOfPictures { get; set; }
    }

    

    DataItem[] visitedCities = new DataItem[] {
        new DataItem
        { Username = "Luka", NbrOfVisitedCities=1 },
        new DataItem
        { Username = "Matea", NbrOfVisitedCities=20 },
        new DataItem
        { Username = "Karlo", NbrOfVisitedCities=4 },
        new DataItem
        { Username = "Jole", NbrOfVisitedCities=2 }
    };

    DataItem[] uploadedPictures = new DataItem[] {
        new DataItem
        { Username = "Luka", NbrOfPictures=9 },
        new DataItem
        { Username = "Matea", NbrOfPictures=90 },
        new DataItem
        { Username = "Karlo", NbrOfPictures=13 },
        new DataItem
        { Username = "Jole", NbrOfPictures=2 }

    };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.eSouvenirWebApp.Pages.UserStatistics
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenColumnSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Radzen.Blazor.LineType __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "LineType", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenColumnSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
