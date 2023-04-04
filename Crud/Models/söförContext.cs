using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public class söförContext :DbContext

    {
        public söförContext(DbContextOptions<söförContext> options) : base(options) 
        { 
        
        }

        public DbSet<Söförler> Söförler { get; set; }   
    }
}
