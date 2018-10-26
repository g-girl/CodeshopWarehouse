using CodeshopWarehouse.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeshopWarehouse.Data {
    public static class OrdersFakeDatabase {

        public static int NextId = 4;
        static Random random = new Random();

        public static List<Order> Orders = new List<Order>() {
            new Order() {
                Id = random.Next(500),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },
            new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },new Order() {
                Id = random.Next(),
                ProductId = random.Next(100),
                DateCreated =  DateTimeOffset.Now.AddDays(-random.Next(365))
            },

        };

    }
}
