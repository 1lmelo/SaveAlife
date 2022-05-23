using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Save.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Infrastructure.Entity.Mapping
{
    public class CovidMap : IEntityTypeConfiguration<Covid>
    {
        public void Configure(EntityTypeBuilder<Covid> builder)
        {
            builder.ToTable("SearchCovid");
            builder.Property(x => x.Id).HasColumnName("ID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Country).HasColumnName("COUNTRY").HasColumnType("varchar2").HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Cases).HasColumnName("CASES").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Confirmed).HasColumnName("CONFIRMED").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Deaths).HasColumnName("DEATHS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Recovered).HasColumnName("RECOVERED").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Update_at).HasColumnName("UPDATE_AT").HasColumnType("date").IsRequired(false);
        }
    }
}
