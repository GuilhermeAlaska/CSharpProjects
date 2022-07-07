using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() => Expression.Empty();
        public AppDbContext(DbContextOptions options) : base(options) => Expression.Empty();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}