using TheMask.Data;
using TheMask.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;


namespace TheMask.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _dbData;
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _dbData = _dbData;
        }

        //GET: /<controller>/
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginModel loginInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(loginInfo.UserName, loginInfo.Password, loginInfo.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "CustomerUser");
            }
            else
            {
                ModelState.AddModelError("", "Failed to Login");
            }
            return View(loginInfo);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "CustomerUser");
        }

        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(RegisterViewModel userEnteredData)
        {
            if (!ModelState.IsValid)
                return View();

            if (ModelState.IsValid)
            {
                User newUser = new User();
                {
                    newUser.CustomerUserName = userEnteredData.CustomerUserName;
                    newUser.CustomerFirstName = userEnteredData.CustomerFirstName;
                    newUser.CustomerLastName = userEnteredData.CustomerLastName;
                    newUser.CustomerPhoneNumber = userEnteredData.CustomerPhoneNumber;
                    newUser.CustomerEmail = userEnteredData.CustomerEmail;
                    newUser.CustomerPassword = userEnteredData.CustomerPassword;
                    newUser.ConfirmPassword = userEnteredData.ConfirmPassword;

                    //_dbData.User.Add(newUser);
                    _dbData.SaveChanges();
                };

                var result = await _userManager.CreateAsync(newUser, "CustomerUser");

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "CustomerUser");
                }
                else
                {
                    foreach (var error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(userEnteredData);
        }
    }
}