using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore

namespace Build_a_Blog_With_ASP.NET..vscode.Data
{
    public class BogDbContext: DbContext 
    {
        public DbSet<BolgPst> BolgPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public BogDbContext(DbContextOptions options): base(options)
        {
        }
    }
}