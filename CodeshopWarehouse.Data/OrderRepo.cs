using System;
using System.Collections.Generic;
using System.Data;
using CodeshopWarehouse.Entities;

namespace CodeshopWarehouse.Data
{
   public interface IOrderRepo {
        Order GetOrderById(int id);
        List<Order> GetOpeOrders();
        void UpdateOrder(Order order);
     }
    public class OrderRepo : IOrderRepo
    {
        private readonly IDbConnection _db;
        public OrderRepo(IDbConnection db) {
            _db = db;
        }
    }
}
