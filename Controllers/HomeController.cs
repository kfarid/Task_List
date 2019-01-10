using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_List_Dylan.ViewModels;

namespace Task_List_Dylan.Controllers
{
    public class HomeController : Controller
    {
        private IAccauntRepository _accrepository;

        public HomeController(IAccauntRepository repo)
        {
            this._accrepository = repo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(_accrepository.GetAccaunts());
        }

        [HttpPost]
        [Route("Home/check")]
        public IActionResult CheckInput()
        {
            //данные через запрос от формы,пока простой вариант
            string login = Request.Form.FirstOrDefault(x => x.Key == "login").Value;
            string password = Request.Form.FirstOrDefault(x => x.Key == "password").Value;
            if (login == "admin" && password == "admin")
                return new RedirectToActionResult("all", "job", null);
            else
                return new RedirectToActionResult("Index", "Home", null);
        }
    }
}