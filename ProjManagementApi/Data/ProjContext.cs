using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjManagementApi.Models;

namespace ProjManagementApi.Data
{
    public class ProjContext : DbContext
    {
        public ProjContext (DbContextOptions<ProjContext> options)
            : base(options)
        {
        }

        public DbSet<ProjManagementApi.Models.Developer> Developers { get; set; }

        public DbSet<ProjManagementApi.Models.Project> Projects { get; set; }

        public DbSet<ProjManagementApi.Models.Assignment> Assignments { get; set; }
    }
}
