#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccb0b24e68f2c77b3b47e90096c04fcc42d11337"
// <auto-generated/>
#pragma warning disable 1591
namespace BlzMON.Pages
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OrderPage/{orderId}")]
    public partial class OrderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    <div class=\"col-md-4\"></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.OpenElement(5, "h4");
            __builder.AddMarkupContent(6, "Список инициаторов в приказе от ");
            __builder.AddContent(7, 
#nullable restore
#line 14 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
                                                               order.OrderDate.ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    <div class=\"col-md-4\"></div>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Initializers>>(10);
            __builder.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Initializers>>(
#nullable restore
#line 19 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
                   initializers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "StartsWithText", "Поиск");
            __builder.AddAttribute(16, "ColumnWidth", "200px");
            __builder.AddAttribute(17, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(19);
                __builder2.AddAttribute(20, "Width", "70px");
                __builder2.AddAttribute(21, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 22 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
                                                  TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Property", "Id");
                __builder2.AddAttribute(23, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(25);
                __builder2.AddAttribute(26, "Width", "110px");
                __builder2.AddAttribute(27, "Property", "Areak.AreaName");
                __builder2.AddAttribute(28, "Title", "Область");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(30);
                __builder2.AddAttribute(31, "Width", "150px");
                __builder2.AddAttribute(32, "Property", "GetFullName");
                __builder2.AddAttribute(33, "Title", "ФИО");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(35);
                __builder2.AddAttribute(36, "Width", "250px");
                __builder2.AddAttribute(37, "Property", "Possition.PossName");
                __builder2.AddAttribute(38, "Title", "Должность");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(40);
                __builder2.AddAttribute(41, "Width", "250px");
                __builder2.AddAttribute(42, "Property", "Education.EduName");
                __builder2.AddAttribute(43, "Title", "Образование");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(45);
                __builder2.AddAttribute(46, "Width", "150px");
                __builder2.AddAttribute(47, "Property", "WorkExpierence");
                __builder2.AddAttribute(48, "Title", "Опыт");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(50);
                __builder2.AddAttribute(51, "Width", "150px");
                __builder2.AddAttribute(52, "Property", "Areak.AreaName");
                __builder2.AddAttribute(53, "Title", "Область");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(55);
                __builder2.AddAttribute(56, "Width", "150px");
                __builder2.AddAttribute(57, "Property", "Region.RegName");
                __builder2.AddAttribute(58, "Title", "Регион");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(60);
                __builder2.AddAttribute(61, "Width", "150px");
                __builder2.AddAttribute(62, "Property", "DateOfBirth");
                __builder2.AddAttribute(63, "Title", "Дата рождения");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(65);
                __builder2.AddAttribute(66, "Width", "150px");
                __builder2.AddAttribute(67, "Property", "CellPhone");
                __builder2.AddAttribute(68, "Title", "Телефон");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(70);
                __builder2.AddAttribute(71, "Width", "250px");
                __builder2.AddAttribute(72, "Property", "EmailAddress");
                __builder2.AddAttribute(73, "Title", "E-почта");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(75);
                __builder2.AddAttribute(76, "Width", "250px");
                __builder2.AddAttribute(77, "Property", "PersonAddress");
                __builder2.AddAttribute(78, "Title", "Адрес");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(80);
                __builder2.AddAttribute(81, "Width", "250px");
                __builder2.AddAttribute(82, "Property", "Award.AwardName");
                __builder2.AddAttribute(83, "Title", "Награда");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(85, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(86, "table");
            __builder.AddAttribute(87, "class", "table");
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.OpenElement(91, "td");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "btn btn-success");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
                                                      NavigateToOrdersPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(95, "Назад");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrderPage.razor"
        // OrderId is route parameter
    [Parameter]
    public string orderId { get; set; }

    //
    public Orders order = new Orders();

    // list of inits
    public List<Initializers> initializers = new List<Initializers>();

    // on page loaded
    protected override async Task OnInitializedAsync()
    {
        CurrentUser = (await authenticationStateTask).User;
        objUser = await _userManager.FindByNameAsync(CurrentUser.Identity.Name);

        // fill inits
        // initializers = db.Initializers.Where(i => i.OrdersId == int.Parse(orderId)).OrderBy(x => x.PersonSurname).ToList();

        // loading Initiators
        initializers = db.Initializers
            .Where(i => i.OrdersId == int.Parse(orderId))
            .OrderBy(x => x.PersonSurname)
            .Include(o => o.Possition)
            .Include(o => o.Education)
            .Include(o => o.Areak)
            .Include(o => o.Region)
            .Include(o => o.Award)
            .Include(o => o.Orders)
            .ToList();

        // init order
        order = db.Order.Find(int.Parse(orderId));

    }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;

    // Method to navigate order page without refreshing page
    private void NavigateToOrdersPage()
    {
        navigationManager.NavigateTo("OrdersPage");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
