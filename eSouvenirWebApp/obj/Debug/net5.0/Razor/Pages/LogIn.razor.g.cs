#pragma checksum "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\LogIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd2b84bc3520a239394ac39c1c89bf84e5b9ddd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LogIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LogIn</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "p-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-3");
            __builder.AddMarkupContent(5, "<label class=\"form-label\">Username</label>\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\LogIn.razor"
                                           username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-3");
            __builder.AddMarkupContent(13, "<label class=\"form-label\">Password</label>\r\n        ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "password");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\LogIn.razor"
                                                           password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-3");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "style", "color:" + (
#nullable restore
#line 14 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\LogIn.razor"
                         Color

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(24, "b");
            __builder.AddContent(25, 
#nullable restore
#line 14 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\LogIn.razor"
                                    text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-md-3");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "submit");
            __builder.AddAttribute(31, "class", "btn btn-success");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\LogIn.razor"
                                                                Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\josko\OneDrive\Desktop\WebAppOICAR\eSouvenirWebApp\Pages\LogIn.razor"
       
    private string username { get; set; }
    private string password { get; set; }

    string Color = "black";
    string text = "Hello Admin";

    private void Submit()
    {
        if (username =="Kola" && password=="0000")
        {
            Color = "green";
            text = "Welcome Kola";
            username = "";
            password = "";
        }
        else
        {
            Color = "red";
            text = "Username wrong!";
            username = "";
            password = "";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
