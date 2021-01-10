using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using WebBanking.Rest.Models;
using WebBanking.Web.Areas.Identity.Data;
using WebBanking.Web.Services;

namespace WebBanking.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<WebUser> _signInManager;
        private readonly UserManager<WebUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IOperationServices _operationServices;

        public RegisterModel(
            UserManager<WebUser> userManager,
            SignInManager<WebUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, IHostingEnvironment hostingEnvironment,IOperationServices operationServices)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _hostingEnvironment = hostingEnvironment;
            this._operationServices = operationServices;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            [Required]
            [MinLength(4,ErrorMessage = "The code must be at least 4 digit")]
            [MaxLength(5, ErrorMessage = "The code must Not exceed 5 digit")]
            public int Pin { get; set; }
            [Required]
            public IFormFile Photo { get; set; }
            [Required]
            [MaxLength(11, ErrorMessage = "The code must Not exceed 11 digit")]
            [MinLength(11, ErrorMessage = "The code must be at least 11 digit")]
            public double PhoneNumber { get; set; }
            [Required]
            public string Username { get; set; }
            [Required]
            public string FirstName{ get; set; }
            [Required]
            public string LastName { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                //processing photo property
                     string uniqueFileName = null;
                    string upload = _hostingEnvironment.ContentRootPath;
                    var uploadsFolder = Path.Combine(upload, "wwwroot/images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + Input.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    Input.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                //processing of photo ends here

                var genGUID = new Guid();
                string FULLNAME = Input.LastName + " " + Input.FirstName;
                var user = new WebUser { UserName = Input.Username, Email = Input.Email,
                    PhoneNumber= Input.PhoneNumber.ToString(),Pin= Input.Pin, Photopath = uniqueFileName ,CustomId= genGUID  ,FullName = FULLNAME};
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    ///Remenber to call our REST API
                    var random = new Random();
                    AcctHolder NewAcctDetails = new AcctHolder
                    {
                        AccountNumber = random.Next(100000000, 900000000),
                        Balance = 2000,
                        IdentityId = genGUID,
                        FullName = FULLNAME,
                        photopath = uniqueFileName,
                        Pin = Input.Pin,
                        CreatedAt = DateTime.UtcNow
                    };
                     var createdUser =  await  _operationServices.AddAcctHolder(NewAcctDetails);
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
