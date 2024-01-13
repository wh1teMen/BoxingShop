using Microsoft.EntityFrameworkCore;
using System;

namespace BoxingShop.ContextDB
{
    public  class AppContext :DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
        public DbSet<Model.Product> Products=>Set<Model.Product>();
        public DbSet<Model.ShopingCart> Carts=>Set<Model.ShopingCart>();
        public DbSet<Model.Order> Orders=>Set<Model.Order>();

     
    }
}
