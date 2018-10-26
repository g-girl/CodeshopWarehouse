using System;
using System.Threading.Tasks;
using CodeshopWarehouse.Business;
using CodeshopWarehouse.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ordershack.Web.Controllers {
    public class OrdersController : Controller {
        private readonly OrderService _os;

        public OrdersController(OrderService os) {
            _os = os;
        }

        // GET: Orders
        public IActionResult Index() {
            return View(_os.GetAllOpenOrders());
        }

        // GET: Orders/Details/5
        public IActionResult Details(int id) {
            var order = _os.GetOrderById(id);
            if (order == null) {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order) {
            order.DateCreated = DateTimeOffset.Now; 
            if (ModelState.IsValid) {
                _os.CreateOrder(order);
                return RedirectToAction("Index");
            }
            return View(order);
        }

        //// GET: Orders/Edit/5
        public IActionResult Edit(int id) {
            var order = _os.GetOrderById(id);
            if (order == null) {
                return NotFound();
            }
            return View(order);
        }

        //// POST: Orders/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [FromBody] Order order) {
        //    _os.UpdateOrder(order);
        //    return View(order);
        //}

        [HttpPost]
        public IActionResult ProcessOrder([FromForm]Order o) {
            _os.UpdateOrder(o);
            return RedirectToAction("Index");
        }


    }
}
