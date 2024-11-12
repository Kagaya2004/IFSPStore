using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(x => x.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(x => x.Documento)
                .IsRequired()
                .HasColumnType("varchar(11)");
            builder.HasOne(x => x.Cidade)
                .WithMany()
                .HasConstraintName("FK_Cidade");
        }
    }
}
