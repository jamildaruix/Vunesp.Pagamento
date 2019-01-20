using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vunesp.Pagamento.Data.Context
{
    /// <summary>
    /// Conexto para conetar banco de dados EF Core
    /// </summary>
    public class ContextEF : DbContext
    {
        //Aqui vai o DbSet

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configuração da connection string
        }
    }
}
