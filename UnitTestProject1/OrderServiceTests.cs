using CodeshopWarehouse.Data;
using CodeshopWarehouse.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace CodeshopWarehouse.Business.Test {
    [TestClass]
    public class OrderServiceTests {
        [TestMethod]
        void UnresolvedFillOrdersCanBeRetrieved() {
            //arrange
            var order = new Order {
                Id = 14,
                ProductId = 124,
                DateCreated = new DateTimeOffset(2018, 09, 21, 0, 0, 0, TimeSpan.FromSeconds(0)),
            };


            //act

            //assert
        }


        [TestMethod]

        void UnresolvedFillOrderCanBeProcessed() { }
        [TestMethod]

        void ProcessedFillOrderCannontBeModified() { }
    }
}
