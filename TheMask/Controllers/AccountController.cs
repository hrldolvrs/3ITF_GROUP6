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
        private readonly AppDbContext _dbData;
        public AccountController(SignInManager<User> signInManager, Microsoft.AspNetCore.Identity.UserManager<User> userManager, AppDbContext dbData)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _dbData = dbData;
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
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Failed to Login");
            }
            return View(loginInfo);
        }



        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminLogin(AdminLoginModel loginInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(loginInfo.UserName, loginInfo.Password, loginInfo.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
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
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UserRegister(RegisterViewModel userCredentials)
        {
            if (!ModelState.IsValid)
                return View();

            User newUser = new User();

            newUser.Firstname = userCredentials.FirstName;
            newUser.Lastname = userCredentials.LastName;
            newUser.Email = userCredentials.Email;
            newUser.PhoneNumber = userCredentials.PhoneNumber;
            newUser.Password = userCredentials.Password;

            var result = await _userManager.CreateAsync(newUser, userCredentials.Password);

            if (result.Succeeded)
            {
                CustomerUser newCustomerInfo = new CustomerUser();

                newCustomerInfo.CustomerFirstName = userCredentials.FirstName;
                newCustomerInfo.CustomerLastName = userCredentials.LastName;
                newCustomerInfo.CustomerUserName = userCredentials.UserName;
                newCustomerInfo.CustomerPhoneNumber = userCredentials.PhoneNumber;
                newCustomerInfo.CustomerEmail = userCredentials.Email;
                newCustomerInfo.CustomerPassword = userCredentials.Password;
                _dbData.Add(newCustomerInfo);
                _dbData.SaveChanges();


                result = await _userManager.AddToRoleAsync(newUser, "Customer");
                return RedirectToAction("UserLogin", "Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(userCredentials);
            }

            return View(userCredentials);


        }
    }
}
