#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2286d7beea187c9a1a2b3463c5856d4bdee828b9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlzMON.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 7 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OrderPage")]
    public partial class OrderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 153 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/OrderPage.razor"
       

    List<Possitions> possitions = new List<Possitions>();
    List<Educations> educations = new List<Educations>();
    List<Areass> areas = new List<Areass>();
    //List<Regions> regions = new List<Regions>();
    // List<Documents> documents = new List<Documents>();
    List<Initializers> initializers = new List<Initializers>();
    List<Awards> awards = new List<Awards>();
    private int CurrentValue { get; set; }
    public string itemValue { get; set; }
    public string item
    {
        get { return itemValue; }
        set
        {
            CurrentValue = orders.Count();
            if (value.Length > 0)
            {
                orders = orders2.Where(x => x.Areak.AreaName.ToLower().Contains(value)).ToList();//wtf
            }
            else
            {
                orders = orders2;
            }
            itemValue = value;
        }
    }
    private List<Orders> orders = new List<Orders>();
    private List<Orders> orders2;
    private Orders order = new Orders();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    bool ShowPopup = false;


    void AddNew()
    {
        order = new Orders();
        order.Id = 0;
        ShowPopup = true;
        possitions = db.Possition.ToList();
        educations = db.Education.ToList();
        areas = db.Areaq.ToList();
        initializers = db.Initializers.ToList();
        awards = db.Award.ToList();
        //regions = db.Region.ToList();
    }
    async Task Save()
    {
        try
        {
            // Is this an existing user?
            if (order.Id != 0)
            {
                Orders secdep = await db.Order.FindAsync(order.Id);

                //...IG dont forget this one

                await db.SaveChangesAsync();
            }
            else
            {
                //  int maxId = db.Order.Max(x => x.Id);
                //  order.Id = (maxId + 1);
                db.Order.Add(order);
                await db.SaveChangesAsync();
            }

            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            LoadData();
            order = new Orders();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task Edit(Orders rc)
    {
        order = rc;
        //products = db.Products.Where(x => x.CategoryId == ).ToList();
        ShowPopup = true;
    }
    async Task Delete()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var rc = await db.Order.FindAsync(order.Id);
        if (rc != null)
        {
            db.Order.Remove(rc);
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

        order = new Orders();
        LoadData();
    }

    public void LoadData()
    {
        orders = db.Order.OrderBy(x => x.Areak).ToList();
    }
    private async Task Insert()
    {
        db.Order.Add(order);
        await db.SaveChangesAsync();
        orders.Add(order);
        order = new Orders();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591