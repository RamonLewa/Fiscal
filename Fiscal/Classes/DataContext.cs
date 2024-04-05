using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using FirebirdSql.Data.FirebirdClient;
using Fiscal.Tables;

namespace Fiscal
{
    public class ConnectionParams
    {
        public string ConnectionString()
        {
            return $"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
        }
    }

    public class DataContext : DbContext
    {
        public DbSet<DadoContabilista> DadoContabilista {  get; set; }
        public DbSet<Emitente> Emitente { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<VendaNFCe> VendaNFCe{ get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<VendaNFe> VendaNFe { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Compra> Compra { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new DadoContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<DadoContabilista>());
            new EmitenteEntityTypeConfiguration().Configure(modelBuilder.Entity<Emitente>());
            new FornecedorTypeConfiguration().Configure(modelBuilder.Entity<Fornecedor>());
            new VendaNFCeTypeConfiguration().Configure(modelBuilder.Entity<VendaNFCe>());
            new ClienteTypeConfiguration().Configure(modelBuilder.Entity<Cliente>());
            new VendaNFeTypeConfiguration().Configure(modelBuilder.Entity<VendaNFe>());
            new EstoqueTypeConfiguration().Configure(modelBuilder.Entity<Estoque>());
            new CompraTypeConfiguration().Configure(modelBuilder.Entity<Compra>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseFirebird($"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;" +
                $"Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000");
    
    }
}
