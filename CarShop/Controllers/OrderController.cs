using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Chekout(Order order)
        {
            shopCart.ListShopItems = shopCart.GetShopItems();

            if (shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError(string.Empty, "The Cart is empty");
            }

            if (ModelState.IsValid)
            {
                allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "The Car is ordered";
            return View();
        }
    }
}
