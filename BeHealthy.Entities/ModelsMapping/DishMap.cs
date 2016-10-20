using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthy.Entities.ModelsMapping
{
    using BeHealthy.Entities.Models;
    using System.Data.Entity.ModelConfiguration;

    public sealed class DishMap : EntityTypeConfiguration<Dish>
    {
        public DishMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(99);

            // Table & Column Mappings
            this.ToTable("Dishes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");

        }
    }
}
