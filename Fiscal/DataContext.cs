using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using FirebirdSql.Data.FirebirdClient;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new DadoContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<DadoContabilista>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseFirebird($"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;" +
                $"Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000");
    
    }
}
