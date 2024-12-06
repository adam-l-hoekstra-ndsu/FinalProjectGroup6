using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup6.Models;

namespace FinalProjectGroup6.Data
{
    public class FinalProjectGroup6Context : DbContext
    {
        public FinalProjectGroup6Context (DbContextOptions<FinalProjectGroup6Context> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectGroup6.Models.Application> Application { get; set; } = default!;
    }
}
