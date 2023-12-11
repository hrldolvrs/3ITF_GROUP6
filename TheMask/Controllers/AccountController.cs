using TheMask.Data;
using TheMask.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using TheMask.ViewModels;

namespace TheMask.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        //GET: /<controller>/
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel loginInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(loginInfo.UserName, loginInfo.Password, loginInfo.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Index");
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
            return RedirectToAction("Index", "Login");
        }



        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel userEnteredData)
        {
            if (!ModelState.IsValid)
                return View();

            if (ModelState.IsValid)
            {
                User newUser = new User();
                newUser.Firstname = userEnteredData.FirstName;
                newUser.Lastname = userEnteredData.LastName;
                newUser.UserName = userEnteredData.UserName;
                newUser.PhoneNumber = userEnteredData.Phone;
                newUser.Email = userEnteredData.Email;
                newUser.Password = userEnteredData.Password;
                newUser.ConfirmPassword = userEnteredData.ConfirmPassword;


                var result = await _userManager.CreateAsync(newUser, userEnteredData.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
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
