using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System;

namespace CarShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            foreach (var element in shopCart.ListShopItems)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = element.Car.Id,
                    OrderId = order.Id,
                    Price = element.Car.Price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
