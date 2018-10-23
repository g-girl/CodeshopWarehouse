using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeshopWarehouse.Entities;

namespace CodeshopWarehouse.Web.Models
{
    public class CodeshopWarehouseWebContext : DbContext
    {
        public CodeshopWarehouseWebContext (DbContextOptions<CodeshopWarehouseWebContext> options)
            : base(options)
        {
        }

        public DbSet<CodeshopWarehouse.Entities.Order> Order { get; set; }
    }
}
