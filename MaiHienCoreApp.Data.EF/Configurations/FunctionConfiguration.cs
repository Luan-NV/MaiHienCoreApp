using MaiHienCoreApp.Data.EF.Extensions;
using MaiHienCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaiHienCoreApp.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(128).IsRequired().HasColumnType("varchar(128)");
            //entity.HasKey(c => c.Id);
            //entity.Property(c => c.Id).IsRequired()
            //.HasColumnType("varchar(128)");
            // etc.
        }
    }
}