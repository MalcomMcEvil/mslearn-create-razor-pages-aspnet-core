<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }
        public DbSet<ContosoPizza.Models.Pizza>? Pizzas { get; set; }
    }
}
=======
﻿using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }
        public DbSet<ContosoPizza.Models.Pizza>? Pizzas { get; set; }
    }
}
>>>>>>> 0e29c3d60325e0b7ed09d7399c5be12de4f6b4e8
