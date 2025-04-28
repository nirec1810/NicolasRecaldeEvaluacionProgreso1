using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NicolasRecaldeEvaluacionProgreso1.Models;

    public class NicolasRecaldeEvaluacionProgreso1ContextSQLServer : DbContext
    {
        public NicolasRecaldeEvaluacionProgreso1ContextSQLServer (DbContextOptions<NicolasRecaldeEvaluacionProgreso1ContextSQLServer> options)
            : base(options)
        {
        }

        public DbSet<NicolasRecaldeEvaluacionProgreso1.Models.Clientes> Clientes { get; set; } = default!;

public DbSet<NicolasRecaldeEvaluacionProgreso1.Models.Reserva> Reserva { get; set; } = default!;
    }
