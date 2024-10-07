using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KamilaRevelo_EjercicioCF.Models;

    public class KamilaRevelo_EjercicioCFContext : DbContext
    {
        public KamilaRevelo_EjercicioCFContext (DbContextOptions<KamilaRevelo_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<KamilaRevelo_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }
