#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb20ae7eaa34fcbbd4d7d397d4e631ae832894b"
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
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist")]
    public partial class UserPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Пользователи</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                          AddNewUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "Добавить новый");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<thead>\r\n        <tr>\r\n            <th>Наименование</th>\r\n            <th>Учреждения</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 21 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
         foreach (var item in users)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 24 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                     item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 25 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                     item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                    \r\n                    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                      (() => EditUser(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n                        Редактировать\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 34 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 37 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "    \r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "modal");
            __builder.AddAttribute(37, "tabindex", "-1");
            __builder.AddAttribute(38, "style", "display:block");
            __builder.AddAttribute(39, "role", "dialog");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-dialog");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-content");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-header");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.AddMarkupContent(50, "<h3 class=\"modal-title\">Редактирование</h3>\r\n                    \r\n                    ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "close");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.AddMarkupContent(56, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                \r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal-body");
            __builder.AddMarkupContent(61, "\r\n                    \r\n");
#nullable restore
#line 54 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                     if (objUser.Id != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                        ");
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, 
#nullable restore
#line 56 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                            objUser.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 57 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "                    \r\n");
#nullable restore
#line 59 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                     if (objUser.Id != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                        ");
            __builder.OpenElement(68, "p");
            __builder.AddContent(69, 
#nullable restore
#line 61 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                            objUser.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 62 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                        ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "class", "form-control");
            __builder.AddAttribute(74, "type", "text");
            __builder.AddAttribute(75, "placeholder", "UserName");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                      objUser.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.UserName = __value, objUser.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 68 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "                    <br>\r\n                    ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "class", "form-control");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "placeholder", "Email");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                                                                       objUser.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.Email = __value, objUser.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "type", "password");
            __builder.AddAttribute(90, "placeholder", "Password");
            __builder.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                                                                              objUser.PasswordHash

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.PasswordHash = __value, objUser.PasswordHash));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    <br>\r\n                    \r\n                    <br><br>\r\n                    \r\n                    ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-primary");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                                              SaveUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\r\n                        Сохранить\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    \r\n");
#nullable restore
#line 81 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                     if (objUser.Id != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(99, "                        \r\n                        ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "class", "btn btn-danger");
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                                                 DeleteUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(103, "\r\n                            Удалить\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 87 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(105, "                    <br>\r\n                    ");
            __builder.OpenElement(106, "span");
            __builder.AddAttribute(107, "style", "color:red");
            __builder.AddContent(108, 
#nullable restore
#line 89 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
                                             strError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 94 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/UserPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Admin";
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    IdentityUser objUser = new IdentityUser();
    // Tracks the selected role for the currently selected user
    string CurrentUserRole { get; set; } = "Manager";
    int InitializerId = 0;
    // Collection to display the existing users
    // Options to display in the roles dropdown when editing a user
    //List<string> Options = new List<string>() { "Manager", "Member" };
    // To hold any possible errors
    string strError = "";
    // To enable showing the Popup
    bool ShowPopup = false;
    List<ApplicationUser> users = new List<ApplicationUser>();
    List<Initializers> initializers = new List<Initializers>();

    public void GetUsers()
    {
        // Collection to hold users
        users = new List<ApplicationUser>();
        // get users from _UserManager
        var user = _userManager.Users.Select(x => new ApplicationUser
        {
            Id = x.Id,
            UserName = x.UserName,
            //InitializerlsId = x.InitializerlsId,
            PasswordHash = "*****"
        });
        foreach (var item in user)
        {
            users.Add(item);
        }
    }

    void AddNewUser()
    {
        // Make new user
        objUser = new ApplicationUser();
        objUser.PasswordHash = "*****";
        // Set Id to blank so we know it is a new record
        objUser.Id = "";
        // Open the Popup
        ShowPopup = true;
    }
    async Task SaveUser()
    {
        try
        {
            // Is this an existing user?
            if (objUser.Id != "")
            {
                // Get the user
                var user = await _userManager.FindByIdAsync(objUser.Id);
                // Update Email
                user.Email = objUser.Email;
                //user.HospitalsId = HospitalId;//  HospitalId???
                //user.InitializerlsId = InitializerId;
                // Update the user
                await _userManager.UpdateAsync(user);
                // Only update password if the current value
                // is not the default value
                if (objUser.PasswordHash != "*****")
                {
                    var resetToken =await _userManager.GeneratePasswordResetTokenAsync(user);
                    var passworduser =await _userManager.ResetPasswordAsync(
                            user,
                            resetToken,
                            objUser.PasswordHash);
                    if (!passworduser.Succeeded)
                    {
                        if (passworduser.Errors.FirstOrDefault() != null)
                        {
                            strError =passworduser.Errors.FirstOrDefault().Description;
                        }
                        else
                        {
                            strError = "Pasword error";
                        }
                        // Keep the popup opened
                        return;
                    }
                }
                // Handle Roles // Is user in administrator role?
                var UserResult = await _userManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
                // Is Administrator role selected // but user is not an Administrator?
                if ((CurrentUserRole == ADMINISTRATION_ROLE) & (!UserResult))
                {
                    // Put admin in Administrator role
                    await _userManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
                }
                else
                {
                    await _userManager.AddToRoleAsync(user, CurrentUserRole);
                    //// Is Administrator role not selected // but user is an Administrator?
                    //if ((CurrentUserRole != ADMINISTRATION_ROLE) & (UserResult))
                    //{
                    //    // Remove user from Administrator role
                    //    await _userManager.RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
                    //}
                }
            }
            else
            {
                // Insert new user
                var NewUser = new ApplicationUser
                {
                    UserName = objUser.UserName,
                    Email = objUser.Email,
                   // InitializerlsId = InitializerId
                };
                var CreateResult = await _userManager.CreateAsync(NewUser, objUser.PasswordHash);
                if (!CreateResult.Succeeded)
                {
                    if (CreateResult.Errors.FirstOrDefault() != null)
                    {
                        strError =CreateResult.Errors.FirstOrDefault().Description;
                    }
                    else
                    {
                        strError = "Create error";
                    }
                    // Keep the popup opened
                    return;
                }
                else
                {
                    // Handle Roles
                    //if (CurrentUserRole == ADMINISTRATION_ROLE)
                    //{
                    // Put admin in Administrator role
                    await _userManager.AddToRoleAsync(NewUser, CurrentUserRole);
                    //}
                }
            }
            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task EditUser(ApplicationUser _IdentityUser)
    {
        // Set the selected user as the current user
        objUser = _IdentityUser;
        // Get the user
        var user = await _userManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            CurrentUserRole = "Manager";
            // Is user in administrator role?
            //var UserResult =await _userManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            //if (UserResult)
            //{
            //    CurrentUserRole = ADMINISTRATION_ROLE;
            //}
            //else
            //{
            //    CurrentUserRole = "Manager";
            //}
        }
        // Open the Popup
        ShowPopup = true;
    }
    async Task DeleteUser()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var user = await _userManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            // Delete the user
            await _userManager.DeleteAsync(user);
        }
        // Refresh Users
        GetUsers();
    }
    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }


    protected override async Task OnInitializedAsync()
    {
        initializers = db.Initializers.ToList();
        GetUsers();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
    }
}
#pragma warning restore 1591
