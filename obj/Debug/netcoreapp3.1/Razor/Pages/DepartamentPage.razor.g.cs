#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c1cf10a6bbfc52bcb81b9c7e28c9f58bd0b5053"
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
#line 2 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DepartamentPage")]
    public partial class DepartamentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col-md-4\"></div>\r\n    <div class=\"col-md-4\"><h4>Список  Учреждений</h4></div>\r\n    <div class=\"col-md-4\"></div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.AddAttribute(7, "width", "30%");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "Поиск");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                             item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item = __value, item));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        <td width=\"40%\"></td>\r\n        ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "width", "30%");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-success");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                  AddNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "Добавить новый");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n\r\n");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-striped");
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.AddMarkupContent(26, @"<thead>
        <tr>
            <th>ID</th>
            <th>Наименование</th>
            <th>Контактное лицо</th>
            <th>Телефон</th>
            <th>Почта</th>
            <th>Адрес</th>

            <th></th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 39 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
         foreach (var item in departaments)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 42 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                 item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 43 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 44 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                 item.Person

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 45 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                 item.InitPhone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 46 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                 item.InitEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 47 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                 item.InitAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "td");
            __builder.AddMarkupContent(51, "\r\n                \r\n                ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "btn btn-primary");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                  (() => Edit(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "\r\n                    Редактировать\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 56 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n\r\n");
#nullable restore
#line 61 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal");
            __builder.AddAttribute(65, "tabindex", "-1");
            __builder.AddAttribute(66, "style", "display:block");
            __builder.AddAttribute(67, "role", "dialog");
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal-dialog");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-content");
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "modal-header");
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.AddMarkupContent(78, "<h3 class=\"modal-title\">Редактирование</h3>\r\n                    ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "type", "button");
            __builder.AddAttribute(81, "class", "close");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.AddMarkupContent(84, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "modal-body");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "span");
            __builder.AddAttribute(91, "style", "color:red");
            __builder.AddContent(92, 
#nullable restore
#line 74 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                             strError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "table");
            __builder.AddAttribute(95, "class", "table");
            __builder.AddMarkupContent(96, "\r\n                      \r\n                        ");
            __builder.OpenElement(97, "tr");
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.AddMarkupContent(99, "<td>Наименование</td>\r\n                            ");
            __builder.OpenElement(100, "td");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "type", "text");
            __builder.AddAttribute(103, "class", "form-control");
            __builder.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                                departament.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => departament.Name = __value, departament.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.OpenElement(108, "tr");
            __builder.AddMarkupContent(109, "\r\n                            ");
            __builder.AddMarkupContent(110, "<td>Контактное лицо</td>\r\n                            ");
            __builder.OpenElement(111, "td");
            __builder.OpenElement(112, "input");
            __builder.AddAttribute(113, "type", "text");
            __builder.AddAttribute(114, "class", "form-control");
            __builder.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                                departament.Person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => departament.Person = __value, departament.Person));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.OpenElement(119, "tr");
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.AddMarkupContent(121, "<td>Номер</td>\r\n                            ");
            __builder.OpenElement(122, "td");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "type", "text");
            __builder.AddAttribute(125, "class", "form-control");
            __builder.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                                departament.InitPhone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => departament.InitPhone = __value, departament.InitPhone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "tr");
            __builder.AddMarkupContent(131, "\r\n                            ");
            __builder.AddMarkupContent(132, "<td>Почта</td>\r\n                            ");
            __builder.OpenElement(133, "td");
            __builder.OpenElement(134, "input");
            __builder.AddAttribute(135, "type", "text");
            __builder.AddAttribute(136, "class", "form-control");
            __builder.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                                departament.InitEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => departament.InitEmail = __value, departament.InitEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                        ");
            __builder.OpenElement(141, "tr");
            __builder.AddMarkupContent(142, "\r\n                            ");
            __builder.AddMarkupContent(143, "<td>Адрес</td>\r\n                            ");
            __builder.OpenElement(144, "td");
            __builder.OpenElement(145, "input");
            __builder.AddAttribute(146, "type", "text");
            __builder.AddAttribute(147, "class", "form-control");
            __builder.AddAttribute(148, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                                departament.InitAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => departament.InitAddress = __value, departament.InitAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                     \r\n                    \r\n                        ");
            __builder.OpenElement(152, "tr");
            __builder.AddMarkupContent(153, "\r\n                            ");
            __builder.OpenElement(154, "td");
            __builder.AddMarkupContent(155, "\r\n");
#nullable restore
#line 101 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                 if (departament.Id != 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(156, "                                    \r\n                                    ");
            __builder.OpenElement(157, "button");
            __builder.AddAttribute(158, "class", "btn btn-danger");
            __builder.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                             Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(160, "\r\n                                        Удалить\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n");
#nullable restore
#line 107 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(162, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                            ");
            __builder.OpenElement(164, "td");
            __builder.AddMarkupContent(165, "\r\n                                ");
            __builder.OpenElement(166, "button");
            __builder.AddAttribute(167, "class", "btn btn-primary");
            __builder.AddAttribute(168, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
                                                                          Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(169, "\r\n                                    Сохранить\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n");
#nullable restore
#line 121 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/DepartamentPage.razor"
       
    private int CurrentValue { get; set; }
    public string itemValue { get; set; }
    public string item
    {
        get { return itemValue; }
        set
        {
            CurrentValue = departaments.Count();
            if (value.Length > 0)
            {
                departaments = departaments2.Where(x => x.Person.ToLower().Contains(value)).ToList();//wtf
            }
            else
            {
                departaments = departaments2;
            }
            itemValue = value;
        }
    }
    private List<Departaments> departaments = new List<Departaments>();
    private List<Departaments> departaments2;
    private Departaments departament = new Departaments();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    bool ShowPopup = false;


    void AddNew()
    {
        departament = new Departaments();
        //initializer.Code = "Test";   // What is it? double shit :0
        departament.Id = 0;
        ShowPopup = true;
    }
    async Task Save()
    {
        try
        {
            // Is this an existing user?
            if (departament.Id != 0)
            {
                Departaments depart = await db.Departaments.FindAsync(departament.Id);

                //...IG dont forget this one
                depart.Name = departament.Name;
                depart.Person = departament.Person;
                depart.InitPhone = departament.InitPhone;
                depart.InitEmail = departament.InitEmail;
                depart.InitAddress = departament.InitAddress;
                await db.SaveChangesAsync();
            }
            else
            {
               // int maxId = db.Departaments.Max(x => x.Id);
                //departament.Id = (maxId + 1);
                db.Departaments.Add(departament);
                await db.SaveChangesAsync();
            }

            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            LoadData();
            departament = new Departaments();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task Edit(Departaments rc)
    {
        departament = rc;
        //products = db.Products.Where(x => x.CategoryId == ).ToList();
        ShowPopup = true;
    }
    async Task Delete()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var rc = await db.Departaments.FindAsync(departament.Id);
        if (rc != null)
        {
            db.Departaments.Remove(rc);
            await db.SaveChangesAsync();
        }
        LoadData();
    }
    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }

    protected override async Task OnInitializedAsync()
    {
        CurrentUser = (await authenticationStateTask).User;
        objUser = await _userManager.FindByNameAsync(CurrentUser.Identity.Name);

        departament = new Departaments();
        LoadData();
    }

    public void LoadData()
    {
        departaments = db.Departaments.OrderBy(x => x.Person).ToList();
        // initializers2 initializer= db.Initializers.OrderBy(x => x.PersonName).ToList(); double shit :)
    }



    private async Task Insert()
    {
        db.Departaments.Add(departament);
        await db.SaveChangesAsync();
        departaments.Add(departament);
        departament = new Departaments();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
