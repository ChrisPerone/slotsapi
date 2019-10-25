using Microsoft.EntityFrameworkCore;
using SlotsApi.Models;

namespace SlotsApi.Data
{
    public class SlotsApiContext : DbContext
    {
        public SlotsApiContext (DbContextOptions<SlotsApiContext> options)
            : base(options)
        {
        }

        public DbSet<SlotModel> SlotModel { get; set; }
    }
}