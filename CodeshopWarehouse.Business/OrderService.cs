using CodeshopWarehouse.Data;
using CodeshopWarehouse.Entities;
using System;
using System.Collections.Generic;


namespace CodeshopWarehouse.Business {
    public interface IOrderService {
        Order GetOrderById(int id);
        IEnumerable<Order> GetAllOpenOrders();
        void UpdateOrder(Order order);
        void CreateOrder(Order order); //TODO: Keep in mind that you need to use a DTO
        IEnumerable<Order> GetOrdersByProductId(int productId);
    }
    public class OrderService : IOrderService {
        private readonly IOrderRepo _orderRepo;

        public OrderService(IOrderRepo orderRepo) {
            _orderRepo = orderRepo;
        }
        public void CreateOrder(Order order) {
            _orderRepo.CreateOrder(order);
        }

        public IEnumerable<Order> GetAllOpenOrders() {
            var orders = _orderRepo.GetAllOpenOrders();
            return orders;
        }

        public Order GetOrderById(int id) {
            var orderById = _orderRepo.GetOrderById(id);
            return orderById;
        }

        public IEnumerable<Order> GetOrdersByProductId(int productId) {
            var ordersByProductId = _orderRepo.GetOrdersByProductId(productId);
            return ordersByProductId;
        }

        public void UpdateOrder(Order order) {
            var currentOrder = GetOrderById(order.Id);

            if (currentOrder == null) {
                throw new Exception("Order not found");
            }

            if (currentOrder.DateProcessed != null) {
                throw new Exception("Order has already been processed");
            }

            _orderRepo.UpdateOrder(order);


        }
    }
}
