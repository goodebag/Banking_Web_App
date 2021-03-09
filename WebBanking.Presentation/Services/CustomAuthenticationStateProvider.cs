using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebBanking.Presentation.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private  ISessionStorageService sessionStorageService;

        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            this.sessionStorageService = sessionStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var EmailAddress = await sessionStorageService.GetItemAsync<string>("emailAddress");
            ClaimsIdentity identity;
            if (EmailAddress != null)
            {
                 identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, EmailAddress), }, "apiauth_type");
            }
            else
            {
                 identity = new ClaimsIdentity();
            }
            var User = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(User));
        }
        public void MarkedAsAuthenticated(string email)
        {
            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, email), }, "apiauth_type");

            var User = new ClaimsPrincipal(identity);
          NotifyAuthenticationStateChanged( Task.FromResult(new AuthenticationState(User)));
        }
    }
}
  