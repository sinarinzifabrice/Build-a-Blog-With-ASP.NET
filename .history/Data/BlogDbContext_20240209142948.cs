using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Build_a_Blog_With_ASP.NET.Models.Domain;
using Microsoft.EntityFrameworkCore;


namespace Build_a_Blog_With_ASP.NET.Data
{
    public class BlogDbContext: DbContext 
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public BogDbContext(DbContextOptions options): base(options)
        {
        }
    }
}