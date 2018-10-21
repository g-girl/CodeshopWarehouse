using System;
using System.Collections.Generic;
using System.Data;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOpenOrders() {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrdersByProductId(int productId) {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order) {
            throw new NotImplementedException();
        }
    }
}
