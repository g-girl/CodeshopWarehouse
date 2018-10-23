//using CodeshopWarehouse.Data;
//using CodeshopWarehouse.Entities;
//using CodeshopWarehouse.Business;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace CodeshopWarehouse.Business.Test {
//    [TestClass]
//    public class OrderServiceTests {
//        [TestMethod]
//        void UnresolvedFillOrdersCanBeRetrieved() {
//            //arrange
//            var order = new Order {
//                Id = 14,
//                ProductId = 124,
//                DateCreated = new DateTimeOffset(2018, 09, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),

//            };

//            var orderRepo = new OrderRepo(null);
//            var orderService = new OrderService(orderRepo);

//            //act
//            orderService.GetAllOpenOrders();

//            //assert





//        }


//        [TestMethod]

//        void UnresolvedFillOrderCanBeProcessed() { }
//        [TestMethod]

//        void ProcessedFillOrderCannontBeModified() {
//            //arrange
//            var order = new Order {
//                Id = 14,
//                ProductId = 124,
//                DateCreated = new DateTimeOffset(2018, 09, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),
//                DateProcessed = new DateTimeOffset(2018, 10, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),
//            };

//            var orderRepo = new OrderRepo(null);
//            var orderService = new OrderService(orderRepo);

//            //act
            
//            //assert
//            Assert.Fail("Shouldn't have gotten here");
//        }
//    }
//}
