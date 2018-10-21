using System;

namespace CodeshopWarehouse.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public DateTimeOffset DateProcessed { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
