using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthy.Entities.ModelsMapping
{
    using BeHealthy.Entities.Models;
    using System.Data.Entity.ModelConfiguration;

    public sealed class FoodMap : EntityTypeConfiguration<Food>
    {
        public FoodMap()
        {
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(99);

            // Table & Column Mappings
            this.ToTable("Foods");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");

        }
    }
}
