using Microsoft.EntityFrameworkCore;
using OnlineStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext(DbContextOptions options) : base(options)
        {}

        DbSet<Product> Products { get; set; }
    }
}
