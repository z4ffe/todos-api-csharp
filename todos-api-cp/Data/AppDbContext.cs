using System;
using Microsoft.EntityFrameworkCore;
using todos_api_cp.Models;

namespace todos_api_cp.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
		}

		public DbSet<Users> Users { get; set; }
        public DbSet<Todos> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
               .HasMany(users => users.Todos)
               .WithOne(todos => todos.User)
               .HasForeignKey(todos => todos.UserId);
        }
    }
}