
namespace BeHealthy.Entities.Models
{
    using BeHealthy.Entities.Interfaces;

    public abstract class EntityModel : IEntityModel
    {
        public int Id { get; set; }

    }
}
