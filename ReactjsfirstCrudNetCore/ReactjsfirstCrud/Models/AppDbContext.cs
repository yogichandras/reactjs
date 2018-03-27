using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ReactjsfirstCrud.Models.Mainmodels;

namespace ReactjsfirstCrud.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Define any composite PKs here*/
            modelBuilder.Entity<MovieActor>()
                .HasKey(m => new { m.MovieId, m.ActorId });
        }

        //public  DbSet<Actor> Actors { get; set; }
        public  DbSet<Movie> Movies { get; set; }
        public  DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<ActorModel> Actors { get; set; }
    }
}
