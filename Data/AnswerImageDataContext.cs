using System;
using Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class AnswerImageDataContext : DbContext
    {

        public AnswerImageDataContext(){}

        public AnswerImageDataContext(DbContextOptions<AnswerImageDataContext> options) :
        base(options)
        {

        }

        public DbSet<AnswerImage> images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerImage>().ToTable("Answer Images");
        }
    }
}
