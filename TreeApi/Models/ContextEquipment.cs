using Microsoft.EntityFrameworkCore;

namespace TreeApi.Models
{
    public class ContextEquipment : DbContext
    {
        public DbSet<Equipments> Equipment { get; set; }

        public ContextEquipment(DbContextOptions<ContextEquipment> options) : base(options)
        {

        }
    }
}