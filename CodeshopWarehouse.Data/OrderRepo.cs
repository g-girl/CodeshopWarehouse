using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CodeshopWarehouse.Entities;

namespace CodeshopWarehouse.Data {
    public interface IOrderRepo {
        Order GetOrderById(int id);
        IEnumerable<Order> GetAllOpenOrders();
        Order Update(Order order);
        Order Create(Order order); //TODO: Keep in mind that you need to use a DTO
        IEnumerable<Order> GetOrdersByProductId(int productId);
    }
    public class OrderRepo : IOrderRepo {
        private readonly IDbConnection _db;
        public OrderRepo(IDbConnection db) {
            _db = db;
        }

        public IEnumerable<Order> GetAllOpenOrders() {
            return OrdersFakeDatabase.Orders;
        }

        public Order GetOrderById(int id) {
            return OrdersFakeDatabase.Orders.Find(o => o.Id == id);

        }

        public Order Update(Order order) {

            //SQL DB find where ID == order.id Set values
            var actualData = OrdersFakeDatabase.Orders.Find(o => o.Id == order.Id);
            actualData.DateProcessed = order.DateProcessed;
            return actualData;
        }

        public Order Create(Order order) {
            order.Id = OrdersFakeDatabase.NextId;
            OrdersFakeDatabase.NextId += 1;
            OrdersFakeDatabase.Orders.Add(order);
            return order;
        }

        public IEnumerable<Order> GetOrdersByProductId(int productId) {

            return GetAllOpenOrders();
            
        }
    }
}
