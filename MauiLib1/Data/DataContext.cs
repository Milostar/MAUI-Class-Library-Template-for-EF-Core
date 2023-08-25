using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MauiLib1.Data.Mappings;
using MauiLib1.Data.Models;
using System.Reflection;

namespace MauiLib1.Data
{
    public class DataContext :DbContext
    {
        public DbSet<Models.Device> Devices { get; set; }


        protected readonly IConfiguration Configuration;


        public DataContext()
        {

            var a = Assembly.GetExecutingAssembly();

            using var stream = a.GetManifestResourceStream("MauiLib1.appsettings.json");

            var config = new ConfigurationBuilder()
                        .AddJsonStream(stream)
                        .Build();

            Configuration = config;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DeviceMap());

        }

    }
}
