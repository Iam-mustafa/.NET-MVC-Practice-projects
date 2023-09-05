using OdeToFood.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services.cs
{
    public class OdeToFoodDbContext: DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
