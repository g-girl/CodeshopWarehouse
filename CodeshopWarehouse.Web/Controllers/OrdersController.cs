using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeshopWarehouse.Business;
using CodeshopWarehouse.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeshopWarehouse.Web.Controllers {
    [Route("api/[controller]")]
    public class OrdersController : Controller {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService) {
            _orderService = orderService;
        }
        // GET api/values
        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id) {
            return Ok(_orderService.GetOrderById(id));
        }

        [HttpGet]
        public IActionResult GetAllOpenOrders() {
            return Ok(_orderService.GetAllOpenOrders());
        }

        [HttpPut]
        public IActionResult UpdateOrder([FromBody] Order order) {
            _orderService.UpdateOrder(order);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order order) {
            _orderService.CreateOrder(order);
            return Ok();
        } //TODO: Keep in mind that you need to use a DTO

        [HttpGet ("byProductId/{productId}")]
        public IActionResult GetOrdersByProductId(int productId) {
            return Ok(_orderService.GetOrdersByProductId(productId));
        }

    }
}
