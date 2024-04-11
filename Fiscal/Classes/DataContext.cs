using Fiscal.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Fiscal
{
    public class ConnectionParams
    {
        public static string ConnectionString(string configSoftMaster)
        {
            string caminhoBancoDados = "C:\\SGBR\\Master\\ConfigSoftMaster.ini";

            if (File.Exists(configSoftMaster))
            {
                string[] linhas = File.ReadAllLines(configSoftMaster);
                foreach (string linha in linhas)
                {
                    if (linha.StartsWith("Conexao="))
                    {
                        caminhoBancoDados = linha.Substring("Conexao=".Length);
                        break;
                    }
                }

                if (string.IsNullOrEmpty(caminhoBancoDados))
                {
                    throw new Exception("Banco de dados não encontrado");
                }
            }
            else
            {
                throw new FileNotFoundException("Arquivo ConfigSoftMaster não encontrado", configSoftMaster);
            }

            return $"DataSource=localhost;Database={caminhoBancoDados};Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
        }
    }

    public class DataContext : DbContext
    {
        public DbSet<DadoContabilista> DadoContabilista { get; set; }
        public DbSet<Emitente> Emitente { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<VendaNFCe> VendaNFCe { get; set; }
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
        {
            base.OnConfiguring(optionsBuilder);
            string configSoftMaster = "C:\\SGBR\\Master\\ConfigSoftMaster.ini";
            optionsBuilder.UseFirebird(ConnectionParams.ConnectionString(configSoftMaster));
        }
    }
}