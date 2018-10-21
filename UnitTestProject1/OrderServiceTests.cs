using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeshopWarehouse.Business.Test {
    [TestClass]
    public class OrderServiceTests {
        [TestMethod]
        void UnresolvedFillOrdersCanBeRetrieved() {
            //arrange
            var userOrder = new Order {
                Id = 1
            };

            var mockOrderRepo = Substitute.For<IOrderRepo>();
            mockOrderRepo.GetOrderById(userOrder.Id).Returns(new Order {
                Id = 1,
                ClosedAt = null
            });

            var OrderService = new OrderService(mockOrderRepo);

            //act
            var expectedOrder = OrderService.CloseOrder(userOrder);

            //assert
            Assert.IsNotNull(expectedOrder.ClosedAt, "ClosedAt was not set");
            mockOrderRepo.Received(1).GetOrderById(userOrder.Id);
            mockOrderRepo.ReceivedWithAnyArgs(1).UpdateOrder(expectedOrder);
        }
           

        [TestMethod]

        void UnresolvedFillOrderCanBeProcessed() { }
        [TestMethod]

        void ProcessedFillOrderCannontBeModified() { }
    }
}
