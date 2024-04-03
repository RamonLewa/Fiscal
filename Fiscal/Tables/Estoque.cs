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
    public class Estoque
    {
        [DisplayName("Controle")]
        public int Controle {  get; set; }

        [DisplayName("Produto")]
        public string Produto { get; set; }

        [DisplayName("Cód barras")]
        public string CodBarras { get; set; }

        [DisplayName("UN")]
        public string UN {  get; set; }

        [DisplayName("Cód aplicação")]
        public string CodAplicacao { get; set; }

        [DisplayName("NCM")]
        public string NCM { get; set; }

        [DisplayName("Alíquota ICMS")]
        public decimal? AliquotaICMS { get; set; }

        [DisplayName("CEST")]
        public string CEST { get; set; } 

    }

    public class EstoqueTypeConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("TESTOQUE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.Produto).HasColumnName("PRODUTO");

            builder.Property(e => e.CodBarras).HasColumnName("CODBARRAS");

            builder.Property(e => e.UN).HasColumnName("UNIDADE");

            builder.Property(e => e.CodAplicacao).HasColumnName("CODAPLICACAOPRODUTO");

            builder.Property(e => e.NCM).HasColumnName("NCM");

            builder.Property(e => e.AliquotaICMS).HasColumnName("ALIQUOTAICMSECF");

            builder.Property(e => e.CEST).HasColumnName("CEST");
        }
    }
}
