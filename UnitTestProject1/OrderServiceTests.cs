using CodeshopWarehouse.Data;
using CodeshopWarehouse.Entities;
using CodeshopWarehouse.Business;
using System;
using System.Linq;
using NSubstitute;
using Xunit;


namespace CodeshopWarehouse.Business.Test {
    public class OrderServiceTests {
        [Fact]
        private void UnresolvedFillOrdersCanBeRetrieved() {
            //arrange
            var order = new Order {
                Id = 14,
                ProductId = 124,
                DateCreated = new DateTimeOffset(2018, 09, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),

            };

            var orderRepo = new OrderRepo(null);
            var orderService = new OrderService(orderRepo);

            //act
            var expectedOrders = orderService.GetAllOpenOrders();

            //assert
            Assert.Equal(8, expectedOrders.Count());

        }


        [Fact]

        void UnresolvedFillOrderCanBeProcessed() {
            //arrange
            var order = new Order {
                Id = 14,
                ProductId = 124,
                DateCreated = new DateTimeOffset(2018, 09, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),
            };

            var mockOrderRepo = Substitute.For<IOrderRepo>();
            mockOrderRepo.GetOrderById(order.Id).Returns(order);

            var orderService = new OrderService(mockOrderRepo);

            //act
            orderService.UpdateOrder(order);

            //assert
            Assert.True(true);
        }


        [Fact]
        void ProcessedFillOrderCannotBeModified() {
            //arrange
            var order = new Order {
                Id = 14,
                ProductId = 124,
                DateCreated = new DateTimeOffset(2018, 09, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),
                DateProcessed = new DateTimeOffset(2018, 10, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),
            };

            var orderRepo = new OrderRepo(null);
            var orderService = new OrderService(orderRepo);

            //act

            //assert
            Assert.Throws<Exception>(() => orderService.UpdateOrder(order));
        }
    }
}
