using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Tables
{
    public class Compra
    {
        [DisplayName("Controle")]
        public int Controle { get; set; }

        [DisplayName("Data emissão")]
        public DateTime? DataEmissao { get; set; }

        [DisplayName("Cód fornecedor")]
        public int? CodFornecedor { get; set; }

        [DisplayName("Confirmada")]
        public int? Confirmada { get; set; }
    }

    public class CompraTypeConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("TCOMPRA");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");

            builder.Property(e => e.CodFornecedor).HasColumnName("CODFORNECEDOR");

            builder.Property(e => e.Confirmada).HasColumnName("CONFIRMADA");
        }
    }
}
