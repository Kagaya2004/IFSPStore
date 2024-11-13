using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupos"); // Define nome da tabela
            builder.HasKey(prop => prop.Id); // Define chave primária
            builder.Property(prop => prop.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(50);
            //.HasColumnType("varchar(50)");
        }
    }
}