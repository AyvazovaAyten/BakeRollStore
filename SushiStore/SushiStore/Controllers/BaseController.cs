using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SushiStore.Models;
using SushiStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SushiStore.Controllers
{
    public class BaseController : Controller
    {
        public void CartCount()
        {
            if (Request.Cookies["cart"] == null)
            {
                ViewData["CartCount"] = 0;
                ViewData["TotalPrice"] = 0;
            }
            else
            {
                List<CartProduct> products = JsonConvert.DeserializeObject<List<CartProduct>>(Request.Cookies["cart"]);
                
                int TotalCount = products.Sum(p => p.Quantity);
                decimal TotalPrice = products.Sum(p => p.Quantity*p.CurrentPrice);


                ViewData["CartCount"] = TotalCount;

                ViewData["TotalPrice"] = TotalPrice;

                ViewBag.ProductList = products;

            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CallRequest(string Name, string Phone, string Option)
        {
            if (!ModelState.IsValid)
            {
                return Json(ModelState.Values.SelectMany(x => x.Errors));
            }
            EmailService emailService = new EmailService();


            await emailService.SendEmailAsync("230420asdfx@gmail.com", 
                "Call Request", "Name:  "+ Name + "  " + "Phone:  " 
                + Phone+ "  "+ "Time:  " + Option + "Time:  " 
                + DateTime.UtcNow.AddHours(4).ToShortTimeString());

            return RedirectToAction("Index", "Home");
        }
       
    }
}
