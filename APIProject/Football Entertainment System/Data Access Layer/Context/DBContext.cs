using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Context
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=FootballEntertainmentSystem;Trusted_Connection=true;");
            /*
             
             Specify on delete behavior.
             
             */
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<HistoricalQuestion> HistoricalQuestions { get; set; }
        public DbSet<TeamPhotoQuestion> TeamPhotoQuestions { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admin { get; set; }

    }
}
