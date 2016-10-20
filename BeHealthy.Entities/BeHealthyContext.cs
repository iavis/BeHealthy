namespace BeHealthy.Entities
{
    using BeHealthy.Entities.Models;
    using BeHealthy.Entities.ModelsMapping;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BeHealthyContext : DbContext
    {
        public BeHealthyContext() : base("name=BeHealthyContext")
        {
            //
        }

        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new DishMap());
            modelBuilder.Configurations.Add(new FoodMap());

        }


    }

}