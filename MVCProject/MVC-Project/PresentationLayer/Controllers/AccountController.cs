using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Helpers;
using PresentationLayer.Models;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        #region Register

        // Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
                return View(registerViewModel);

            var User = new ApplicationUser
            {
                UserName = registerViewModel.FName + registerViewModel.LName,
                Email = registerViewModel.Email,
                IsAgree = registerViewModel.IsAgree,
                FName = registerViewModel.FName,
                LName = registerViewModel.LName,
            };

            var Result = await userManager.CreateAsync(User, registerViewModel.Password);

            if (Result.Succeeded)
                return RedirectToAction("Login");
            else
            {
                foreach (var error in Result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(registerViewModel);
        }
        #endregion


        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await userManager.FindByEmailAsync(loginViewModel.Email);

            if (user is null)
            {
                ModelState.AddModelError(string.Empty, "Email is not exist!");
                return View(loginViewModel);
            }

            var ValidPassword = await userManager.CheckPasswordAsync(user, loginViewModel.Password);

            if (!ValidPassword)
            {
                ModelState.AddModelError(string.Empty, "Password is not correct");
                return View(loginViewModel);
            }

            var ValidLogin = await signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);

            if (!ValidLogin.Succeeded)
                return View(loginViewModel);

            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region Signout

        public async Task<IActionResult> Signout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        #endregion


        #region Forgot Password

        public IActionResult ForgotPassword()
        {
            return View();
        }
        #endregion

        [HttpPost]
        public async Task<IActionResult> SendEmail(ForgotPasswordViewModel forgotPasswordViewModel)
        {
            if (!ModelState.IsValid)
                return View(nameof(ForgotPassword), forgotPasswordViewModel);

            var user = await userManager.FindByEmailAsync(forgotPasswordViewModel.Email);

            if (user is null)
            {
                ModelState.AddModelError(string.Empty, "Email is not exist!");
                return View(forgotPasswordViewModel);
            }
            var token = userManager.GeneratePasswordResetTokenAsync(user);
            string PasswordLink = Url.Action("ResetPassword", "Account", new { email = user.Email, Token = token });

            Email email = new Email
            {
                Subject = "Reset Password",
                To = user.Email,
                Body = PasswordLink
            };

            EmailSettings.SendEmail(email);
            return RedirectToAction(nameof(CheckYourInbox));
        }


        public IActionResult CheckYourInbox()
        {
            return View();
        }


        public IActionResult ResetPassword(string email, string token)
        {
            TempData["email"] = email;
            TempData["token"] = token;
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModelView resetPasswordModelView)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(TempData["email"].ToString());
                var Result = await userManager.ResetPasswordAsync(user, TempData["token"].ToString(), resetPasswordModelView.NewPassword);

                if (Result.Succeeded)
                    return RedirectToAction(nameof(Login));
            }
            return View(resetPasswordModelView);
        }
    }
}
