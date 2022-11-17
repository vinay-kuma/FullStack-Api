using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStack_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack_Api.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}