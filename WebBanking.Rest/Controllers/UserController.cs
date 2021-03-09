using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Data;
using WebBanking.Rest.Models;

namespace WebBanking.Rest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly UserManager<MyUser> _userManager;
        private readonly SignInManager<MyUser> _signInManager;
        private readonly IUsersRepo _usersRepo;

        public UserController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager, IUsersRepo usersRepo)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._usersRepo = usersRepo;
        }
        [HttpPost]
        public async Task<ActionResult<AcctHolder>> CreateUser(RegModel model)
        {
            var photoName = "/images/DefualtImage.Jpg";
            var user = new MyUser
            {
                FullName = (model.LastName.Trim() + " " + model.FirstName.Trim()),
                UserName = model.UserName.Trim(),
                Email = model.Email.Trim(),
                AcctLinkingId = Guid.NewGuid(),
                PhoneNumber = model.PhoneNumber.ToString(),
                PhotoUrl = photoName
            };
            // Store user data in AspNetUsers database table
            var result = await _userManager.CreateAsync(user, model.Password.Trim());
            AcctHolder holder = new AcctHolder
            {
                IdentityId = user.AcctLinkingId,
                Pin = model.Pin,
                AccountNumber = 05059698066,
                Balance = 5000,
                photopath = user.PhotoUrl,
                FullName = user.FullName,
                phonenumber = model.PhoneNumber,
                CreatedAt = DateTime.UtcNow

            };
            //  If user is successfully created, sign-in the user using
            // SignInManager and redirect to index action of HomeController
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return holder;
            }
            else
            {
                return null;
            }
        }
        [HttpGet]
        public async Task<ActionResult<AcctHolder>> SigninUser(LoginModel model)
        {
            AcctHolder founduser = null;

         var result =  await  _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (result.Succeeded)
            {
                 founduser = await _usersRepo.GetAcctByEmail(model.Email);
            }
            return founduser;
        }
        [HttpGet]
        public async Task<ActionResult<bool>> EmailExistance(string email)
        {
            var YesORno = await _usersRepo.CheckEmailExistance(email);
            return YesORno;
        }
        public async Task<ActionResult<AcctHolder>> GetThisUserByEmail(string model)
        {
            AcctHolder holder = await _usersRepo.GetAcctByEmail(model);
            return holder;
        }
     }
}
