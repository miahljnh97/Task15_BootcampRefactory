using System;
using Microsoft.EntityFrameworkCore;
using Task15_BootcampRefactory.Models;

namespace Task15_BootcampRefactory
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options) { }

        public DbSet<Posts> post { get; set; }
    }
}
