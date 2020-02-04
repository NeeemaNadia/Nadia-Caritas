using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using RwandaShop.Models;
using RwandaShop.Services;
using RwandaShop.ViewModels;

namespace RwandaShop.Controllers
{
    public class ShopController : Controller
    {
        // GET
        /*
        public IActionResult Index()
        {
            Shop honor = new Shop();
            honor.Id = 21;
            honor.Name = "QBAR";
            honor.Description = "we are our ";
            /*honor.Type = "BAR";#1#
            return View(honor);
        }
*/
        private readonly IShop _shop;

        public ShopController(IShop shop)
        {
            _shop = shop;
        }

        public IActionResult Index()
        {
            var sho=new HomeViewModel();
            sho.Shops = _shop.GetAll();
            return View(sho);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShopEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var shop = new Shop{Name = model.Name, Description = model.Description, Type = model.Type};
                _shop.Add(shop);
                return RedirectToAction("Details", new {id = shop.Id});
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            var sho = _shop.Get(id);

            if (sho == null)
            {
                return RedirectToAction("Index");
            }

            return View(sho);
        }
        public IActionResult Delete(int id)
        {
            var sho = _shop.Get(id);
            
            if (ModelState.IsValid)
            {
                _shop.Delete(id);
                return RedirectToAction("Index", "Shop"); // TODO :fix redirection to details
            }

            if (sho == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id,Shop shop)
        {
            var sho = _shop.Get(id);
            if (sho == null)
            {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                var r = new Shop
                {
                    Id = id,
                    Name = shop.Name,
                    Description = shop.Description,
                    Type = shop.Type

                };
                _shop.Edit(id,r);
                
            }
            
            return View(sho);
        }
    }
}