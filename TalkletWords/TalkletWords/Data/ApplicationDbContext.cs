using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TalkletWords.Models;

namespace TalkletWords.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Word> Words { get; set; }
        public DbSet<WordType> WordTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WordData> WordDatas  { get; set; }
        public DbSet<VocabSize> VocabSizes { get; set; }
        public DbSet<MLU> MLUs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Word>().ToTable("Word");
            builder.Entity<WordData>().ToTable("WordData");
            builder.Entity<WordType>().ToTable("WordType");
            builder.Entity<VocabSize>().ToTable("VocabSize");
            builder.Entity<MLU>().ToTable("MLU");
        }


    }
}
