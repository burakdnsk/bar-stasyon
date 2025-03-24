using System;
using Microsoft.EntityFrameworkCore;





namespace barİstasyon.Persistence.Context
{
    public class BarIstasyonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=baristasyondb;Username=postgres;Password=230981");
        }
        
    }
}