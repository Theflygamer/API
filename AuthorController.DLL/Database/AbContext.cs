using AuthorController.DLL.Database.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorController.DLL.Database
{
    public class AbContext : DbContext
    {
        public AbContext(DbContextOptions<AbContext> options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FTF-LAPTOP;Database=FF; Trusted_Connection=True");
        }

        public DbSet<Author> Author { get; set; }
    }
}
