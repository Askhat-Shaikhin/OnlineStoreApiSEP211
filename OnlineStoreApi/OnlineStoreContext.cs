using Microsoft.EntityFrameworkCore;
using OnlineStore.Model;

namespace OnlineStoreApi
{
    public class OnlineStoreContext : DbContext
    {
        DbSet<Product> Products { get; set; }

        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) : base(options)
        { }
    }
}
