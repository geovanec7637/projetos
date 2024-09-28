using Microsoft.EntityFrameworkCore;
using cadastrocli.Models;


namespace cadastrocli.context
{
    public class principal : DbContext
    {
        public principal(DbContextOptions<principal> options) :base(options)
            {


            }

    public DbSet<Cliente> clientes { get; set; }

    }
}
