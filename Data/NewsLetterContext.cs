using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsLetter6.Models;

namespace NewsLetter6.Data
{
    public class NewsLetterContext : IdentityDbContext<IdentityUser>
    {
        
        //public NewsLetterContext(DbContextOptions options) : base(options) { }

        public NewsLetterContext(DbContextOptions<NewsLetterContext> options) : base(options){}



        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<NewsletterArticle>().Property(p => p.Name).HasMaxLength(100);
            builder.Entity<NewsletterArticle>().Property(p => p.Description).HasMaxLength(1000);
           

            builder.Entity<NewsLetterTitle>().ToTable("NewsLetterTitles");
            builder.Entity<NewsletterArticle>().ToTable("NewsletterArticles");
            

            builder.Entity<NewsLetterTitle>().HasData(SampleData.GetArticles());
            builder.Entity<NewsletterArticle>().HasData(SampleData.GetArticleDetails());

            builder.Entity<IdentityRole>().HasData(
                new {Id = "1", Name = "Admin", NormalizedName = "ADMIN"},
                new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
            );

            
        }

        public DbSet<NewsLetterTitle>? Titles { get; set; }
        public DbSet<NewsletterArticle>? Articles { get; set; }

    }
}