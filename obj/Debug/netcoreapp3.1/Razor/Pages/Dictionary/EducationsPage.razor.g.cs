#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab1ec0bd5f82a2ea304d9290d4dd3f4742bb6d7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlzMON.Pages.Dictionary
{
    #line hidden
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
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/educationpage")]
    public partial class EducationsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col-md-4\"></div>\r\n    <div class=\"col-md-4\"><h4>Образование</h4></div>\r\n    <div class=\"col-md-4\"></div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-success");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                      AddNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "Добавить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Educations>>(14);
            __builder.AddAttribute(15, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 26 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                         Radzen.FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                                                                    4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Educations>>(
#nullable restore
#line 27 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                       сonclusions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ColumnWidth", "150px");
            __builder.AddAttribute(22, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Educations>>(24);
                __builder2.AddAttribute(25, "Property", "EduName");
                __builder2.AddAttribute(26, "Title", "Образование");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Educations>>(28);
                __builder2.AddAttribute(29, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                         false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 32 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                            Radzen.TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Width", "40px");
                __builder2.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Educations>)((сonclusion) => (__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(35);
                    __builder3.AddAttribute(36, "Icon", "edit");
                    __builder3.AddAttribute(37, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 34 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                       ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                   args => Edit(сonclusion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Educations>>(41);
                __builder2.AddAttribute(42, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                         false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 37 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                            Radzen.TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Width", "40px");
                __builder2.AddAttribute(46, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Educations>)((сonclusion) => (__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(48);
                    __builder3.AddAttribute(49, "Icon", "delete");
                    __builder3.AddAttribute(50, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 39 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                         ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                     args => Delete(сonclusion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n");
#nullable restore
#line 47 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
 if (ShowPopup)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal");
            __builder.AddAttribute(58, "tabindex", "-1");
            __builder.AddAttribute(59, "style", "display:block");
            __builder.AddAttribute(60, "role", "dialog");
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-dialog");
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal-content p-4");
            __builder.AddMarkupContent(67, "\r\n\r\n                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "div");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.OpenElement(73, "p");
            __builder.AddAttribute(74, "class", "p-2");
            __builder.AddContent(75, 
#nullable restore
#line 56 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                        title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "div");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(80);
            __builder.AddAttribute(81, "Icon", "close");
            __builder.AddAttribute(82, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 59 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                ButtonStyle.Light

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                           ClosePopup

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                <br>\r\n\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "form-group");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.AddMarkupContent(90, "<label for=\"e1\" class=\"p-2 font-weight-bold\">Образование</label>\r\n                    ");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "class", "form-control");
            __builder.AddAttribute(94, "id", "e1");
            __builder.AddAttribute(95, "placeholder", "Образование");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                            сonclusion.EduName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => сonclusion.EduName = __value, сonclusion.EduName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n                <br>\r\n\r\n\r\n                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "d-flex justify-content-center p-1");
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.OpenElement(103, "button");
            __builder.AddAttribute(104, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                     Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(106, "\r\n                        Сохранить\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
#nullable restore
#line 81 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
       

    private List<Educations> сonclusions = new List<Educations>();

    private Educations сonclusion = new Educations();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    string title = "";
    bool ShowPopup = false;


    void AddNew()
    {
        сonclusion = new Educations();
        сonclusion.Id = 0;
        title = "Новоя запись";
        ShowPopup = true;
    }
    async Task Save()
    {
        try
        {
            if (сonclusion.Id != 0)
            {
                Educations lt = await db.Education.FindAsync(сonclusion.Id);
                lt.Id = сonclusion.Id;
                lt.EduName = сonclusion.EduName;
                await db.SaveChangesAsync();
            }
            else
            {
                db.Education.Add(сonclusion);
                await db.SaveChangesAsync();
            }

            ShowPopup = false;
            LoadData();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task Edit(Educations lt)
    {
        title = "Редактирование";
        сonclusion = lt;
        ShowPopup = true;
    }
    async Task Delete(Educations lt)
    {
        ShowPopup = false;
        var obj = await db.Education.FindAsync(lt.Id);
        if (obj != null)
        {
            db.Education.Remove(obj);
            await db.SaveChangesAsync();
        }
        LoadData();
    }
    void ClosePopup()
    {
        ShowPopup = false;
    }

    protected override async Task OnInitializedAsync()
    {
        // CurrentUser = (await authenticationStateTask).User;
        // objUser = await _userManager.FindByNameAsync(CurrentUser.Identity.Name);
        LoadData();
    }

    public void LoadData()
    {
        сonclusion = new Educations();
        сonclusions = db.Education.OrderBy(x => x.EduName).ToList();

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
