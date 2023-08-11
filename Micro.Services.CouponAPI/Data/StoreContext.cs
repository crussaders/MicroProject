using Micro.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.Services.CouponAPI.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Coupon> Coupons { get; set; }

    }
}
