using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Circu_Carina_Lab2.Models;

namespace Circu_Carina_Lab2.Data
{
    public class Circu_Carina_Lab2Context : DbContext
    {
        public Circu_Carina_Lab2Context (DbContextOptions<Circu_Carina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Circu_Carina_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
