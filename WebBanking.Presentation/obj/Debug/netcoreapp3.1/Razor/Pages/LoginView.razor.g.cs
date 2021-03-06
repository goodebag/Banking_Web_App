#pragma checksum "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d34e0d89c0a7bfc64a9d384b72663012e812cd35"
// <auto-generated/>
#pragma warning disable 1591
namespace WebBanking.Presentation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Rest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Rest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class LoginView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                 registerModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                               SiginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "style", "margin:auto");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "Customize-2");
                __builder2.AddMarkupContent(8, "<h3 class=\"position-relative text-center\">Login</h3>\r\n            <hr>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n            ");
                __builder2.AddMarkupContent(13, "<label for=\"Email\" class=\"col-sm-10 col-form-label\" style=\"width:inherit\">\r\n                Email\r\n            </label>\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-10");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(16);
                __builder2.AddAttribute(17, "id", "Email");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Your Email");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                            registerModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Email = __value, registerModel.Email))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n            ");
                __builder2.AddMarkupContent(24, "<label for=\"password\" class=\"col-sm-10 col-form-label\" style=\"width:inherit\">\r\n                Password\r\n            </label>\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-sm-10");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(27);
                __builder2.AddAttribute(28, "id", "password");
                __builder2.AddAttribute(29, "class", " form-control");
                __builder2.AddAttribute(30, "placeholder", "Your Password");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                            registerModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Password = __value, registerModel.Password))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n            <hr>\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-sm-10");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(37);
                __builder2.AddAttribute(38, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 32 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                          Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Text", "Login");
                __builder2.AddAttribute(40, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 32 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                                                                              Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "class", "btn-block mr-2");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            <hr>\r\n            ");
                __builder2.AddMarkupContent(43, "<label class=\"col-sm-10 position-relative text-center text-danger\">Not yet User?</label>\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-sm-10");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(46);
                __builder2.AddAttribute(47, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 37 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                          Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Text", "Register");
                __builder2.AddAttribute(49, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 38 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                           Radzen.ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "class", "btn-block mr-2");
                __builder2.AddAttribute(51, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
                                                                                                       GotoRegister

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Mr-Goodebag\source\repos\WebBanking\WebBanking.Presentation\Pages\LoginView.razor"
      

    protected LoginModel registerModel { get; set; } = new LoginModel();

    public async Task SiginUser()
    {
        var UserSignedIn = await _Operations.SignIn(registerModel);
        if (UserSignedIn != null)
        {
            Navigation.NavigateTo($"/Dashboard/{UserSignedIn.IdentityId}");
        }
    }

    public void GotoRegister()
    {
        Navigation.NavigateTo("/Register");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOperationServices _Operations { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
