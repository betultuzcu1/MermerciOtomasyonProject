﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OtomasyonProject.WebUI.Dtos.RegisterDto;
using OtomasyonProject.EntityLayer.Concrete;
using AppUser = OtomasyonProject.EntityLayer.Concrete.AppUser;
using Microsoft.AspNetCore.Authorization;

namespace OtomasyonProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username,
                
            };
            var result=await _userManager.CreateAsync(appUser,createNewUserDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
