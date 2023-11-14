using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckList.Database.Entities;
namespace CheckList.Database
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Board> Boards => Set<Board>();
        public DbSet<Card> Cards => Set<Card>();
        public DbSet<List> Lists => Set<List>();
        public DbSet<User> Users => Set<User>();

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) 
        { 
            Database.EnsureCreatedAsync(); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CheckList.db");
        }


    }
}
