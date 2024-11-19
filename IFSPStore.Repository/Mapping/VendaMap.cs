using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Vendas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Data)
                .IsRequired();
            builder.Property(x => x.ValorTotal)
                .IsRequired();
            builder.HasOne(x => x.Cliente);
            builder.HasOne(x => x.Usuario);
            builder.HasMany(x => x.Itens)
                .WithOne(x => x.Venda)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class VendaItemMap : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            builder.ToTable("VendaItens");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade)
                .IsRequired();
            builder.Property(x => x.ValorUnitario)
                .IsRequired();
            builder.Property(x => x.ValorTotal)
                .IsRequired();
            builder.HasOne(x => x.Venda)
                .WithMany(x => x.Itens)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}