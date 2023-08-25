using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MauiLib1.Data.Models;

namespace MauiLib1.Data.Mappings
{
    public class DeviceMap : IEntityTypeConfiguration<Models.Device>
    {
        public void Configure(EntityTypeBuilder<Models.Device> builder)
        {
            builder
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();

            builder
                .Property<string>(s => s.Name)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property<string>(s => s.Description)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property<string>(s => s.IpAddress)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property<string>(s => s.Process)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property<string>(s => s.Operator)
                .IsRequired()
                .HasMaxLength(25);

            builder
                .Property<bool>(s => s.Enabled)
                .IsRequired();

            //....... Indexes .............................
            builder
                .HasIndex(e => new { e.Name })
                .IsUnique();

            builder
                .HasIndex(e => new { e.IpAddress })
                .IsUnique();

            builder
                .HasIndex(e => new { e.Process });
        }
    }
}
