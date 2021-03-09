// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebBanking.Presentation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Presentation.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Rest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using WebBanking.Rest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class RegisterView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Goodebag\source\Projects\WebBanking\WebBanking.Presentation\Pages\RegisterView.razor"
      

    protected RegModel registerModel { get; set; } = new RegModel();
    public string photoName { get; set; } = "Sorry No Image Here";


    public async Task createUser()
    {
        var exist = await _Operations.EmailExistance(registerModel.Email);
        if (exist.Equals(false))
        {
            var details = await _Operations.SignUp(registerModel);
            if (details != null)
            {
                ((CustomAuthenticationStateProvider)Authentication).MarkedAsAuthenticated(registerModel.Email);
                Navigation.NavigateTo($"/Dashboard/{details.Email}");
               await sessionStorage.SetItemAsync("emailAddress", registerModel.Email);
            }
        }
        else
        {
            registerModel = new RegModel();
        }
    }

    public void GotoLogin()
    {
        Navigation.NavigateTo("/Login");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider Authentication { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOperationServices _Operations { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
