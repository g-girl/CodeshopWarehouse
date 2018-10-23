using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CodeshopWarehouse.Entities;

namespace CodeshopWarehouse.Data {
    public interface IOrderRepo {
        Order GetOrderById(int id);
        IEnumerable<Order> GetAllOpenOrders();
        void UpdateOrder(Order order);
        void CreateOrder(Order order); //TODO: Keep in mind that you need to use a DTO
        IEnumerable<Order> GetOrdersByProductId(int productId);
    }
    public class OrderRepo : IOrderRepo {
        private readonly IDbConnection _db;
        public OrderRepo(IDbConnection db) {
            _db = db;
        }

        public void CreateOrder(Order order) {
            Console.WriteLine("Order has been created it! Carry on");
        }

        public IEnumerable<Order> GetAllOpenOrders() {
            Random random = new Random();

            return new List<Order>
           {

                GetOrderById(random.Next(1000)),
                GetOrderById(random.Next(1000)),
                GetOrderById(random.Next(1000)),
                GetOrderById(random.Next(1000)),
                GetOrderById(random.Next(1000)),
                GetOrderById(random.Next(1000)),
                GetOrderById(random.Next(1000)),
                GetOrderById(random.Next(1000)),

            };
        }

        public Order GetOrderById(int id) {
            return new Order {
                Id = id,
                ProductId = 124,
                DateCreated = new DateTimeOffset(2018, 05, 18, 0, 0, 0, TimeSpan.FromSeconds(0)),
                DateProcessed =  DateTimeOffset.Now 
            };

        }

        public IEnumerable<Order> GetOrdersByProductId(int productId) {

            return GetAllOpenOrders();
            
        }

        public void UpdateOrder(Order order) {
            Console.WriteLine("Your order has been updated, carry on!");
        }
    }
}
