#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "789b6f551ab1d388d48acbeb5e9b8a9fdf218747"
// <auto-generated/>
#pragma warning disable 1591
namespace BlzMON.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login/{Errorstring}")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin, superuser");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.AddMarkupContent(4, "<p>You are admin</p>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<div class=\"row\">\r\n    <div class=\"col-md-3\"></div>\r\n    <div class=\"col-md-6\">\r\n        <h4>Вход в систему</h4>\r\n    </div>\r\n    <div class=\"col-md-3\"></div>\r\n</div>\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n    <div class=\"col-md-3\"></div>\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-6");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-body");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 29 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
                                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 29 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
                                                        Enter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "text");
                __builder2.AddAttribute(33, "placeholder", "Логин");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
                                                                                            user.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserName = __value, user.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "password");
                __builder2.AddAttribute(44, "placeholder", "Пароль");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
                                                                                                 user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "p");
                __builder2.AddAttribute(51, "class", "text-danger");
                __builder2.AddContent(52, 
#nullable restore
#line 40 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
                                            Errorstring

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Вход\">\r\n\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    <div class=\"col-md-3\"></div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Login.razor"
       


    [Parameter]
    public string Errorstring { get; set; } = "";
    public class InputUser
    {
        [Required(ErrorMessage = "Имя пользователя обязательно")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Пароль обязательно")]
        public string Password { get; set; }
    }

    private InputUser user = new InputUser();

    private void Enter()
    {
        if (!string.IsNullOrEmpty(user.UserName) && !string.IsNullOrEmpty(user.Password))
        {
            Navigation.NavigateTo($"/SignIn?Email={user.UserName}&Password={user.Password}", true);
            //UriHelper.NavigateTo($"/materials/{MaterialId}/display");
        }
        else
        {
            Errorstring = "Не удалось авторизоваться!";

        }

    }
    protected override void OnInitialized()
    {

        // janrs = _db.Janr.ToList();
    }

    //protected override  Task OnInitializedAsync()
    //{
    //    movies = await _db.Movies.();
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> _signInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
