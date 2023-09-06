
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Micro.Services.AuthAPI.Data
{
    public class StoreContext : IdentityDbContext<IdentityUser>
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
