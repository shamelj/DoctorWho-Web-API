
using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.DB
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemys { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              $"Data Source=DESKTOP-5V0QNET;Initial Catalog=DoctorWhoCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            SeedDoctors(builder);
            SeedAuthors(builder);
            SeedCompanions(builder);
            SeedEnemy(builder);
            SeedEpisodes(builder);
            SeedEpisodeCompanions(builder);
            SeedEpisodeEnemies(builder);
        }

        private static void SeedEpisodeEnemies(ModelBuilder builder)
        {
            List<EpisodeEnemy> episodeEnemies = new()
            {
                new(){Id=1,EnemyId=1,EpisodeId=1},
                new(){Id=2,EnemyId=2,EpisodeId=2},
                new(){Id=3,EnemyId=3,EpisodeId=3},
                new(){Id=4,EnemyId=4,EpisodeId=4},
                new(){Id=5,EnemyId=5,EpisodeId=5},
            };
            builder.Entity<EpisodeEnemy>().HasData(episodeEnemies);
        }

        private static void SeedEpisodeCompanions(ModelBuilder builder)
        {
            List<EpisodeCompanion> episodeCompanions = new()
            {
                new(){Id=1,CompanionId=1,EpisodeId=1},
                new(){Id=2,CompanionId=2,EpisodeId=2},
                new(){Id=3,CompanionId=3,EpisodeId=3},
                new(){Id=4,CompanionId=4,EpisodeId=4},
                new(){Id=5,CompanionId=5,EpisodeId=5},
            };
            builder.Entity<EpisodeCompanion>().HasData(episodeCompanions);
        }

        private static void SeedEpisodes(ModelBuilder builder)
        {
            List<Episode> episodes = new()
            {
                new(){Id=1,SeriesNumber=1,EpisodeNumber=1,Title="t1",Type="type1",EpisodeDate=DateTime.MinValue,AuthorId=1,DoctorId=1,Notes="note1"},
                new(){Id=2,SeriesNumber=2,EpisodeNumber=2,Title="t2",Type="type2",EpisodeDate=DateTime.MinValue,AuthorId=2,DoctorId=2,Notes="note2"},
                new(){Id=3,SeriesNumber=3,EpisodeNumber=3,Title="t3",Type="type3",EpisodeDate=DateTime.MinValue,AuthorId=3,DoctorId=3,Notes="note3"},
                new(){Id=4,SeriesNumber=4,EpisodeNumber=4,Title="t4",Type="type4",EpisodeDate=DateTime.MinValue,AuthorId=4,DoctorId=4,Notes="note4"},
                new(){Id=5,SeriesNumber=5,EpisodeNumber=5,Title="t5",Type="type5",EpisodeDate=DateTime.MinValue,AuthorId=5,DoctorId=5,Notes="note5"},
            };
            builder.Entity<Episode>().HasData(episodes);
        }

        private static void SeedEnemy(ModelBuilder builder)
        {
            List<Enemy> enemies = new()
            {
                new(){Id=1,Name="evil1",Description="desc1"},
                new(){Id=2,Name="evil2",Description="desc2"},
                new(){Id=3,Name="evil3",Description="desc3"},
                new(){Id=4,Name="evil4",Description="desc4"},
                new(){Id=5,Name="evil5",Description="desc5"},
            };
            builder.Entity<Enemy>().HasData(enemies);
        }

        private static void SeedCompanions(ModelBuilder builder)
        {
            List<Companion> companions = new()
            {
                new(){Id=1,Name = "Comp1", WhoPlayed="none"},
                new(){Id=2,Name = "Comp2", WhoPlayed="none"},
                new(){Id=3,Name = "Comp3", WhoPlayed="none"},
                new(){Id=4,Name = "Comp4", WhoPlayed="none"},
                new(){Id=5,Name = "Comp5", WhoPlayed="none"},
            };
            builder.Entity<Companion>().HasData(companions);
        }

        private static void SeedAuthors(ModelBuilder builder)
        {
            List<Author> authors = new()
            {
                new(){Id=1,Name= "Karm"},
                new(){Id=2,Name= "Lama"},
                new(){Id=3,Name= "Sara"},
                new(){Id=4,Name= "Safadi"},
                new(){Id=5,Name= "Hisham"}
            };
            builder.Entity<Author>().HasData(authors);
        }

        private static void SeedDoctors(ModelBuilder builder)
        {
            List<Doctor> doctors = new() 
            {
            new() { Id=1,
                Name = "Shamel",
                Number=1,
                FirstEpisodeDate=DateTime.MinValue,
                BirthDate = DateTime.MinValue,
                LastEpisodeDate=DateTime.MinValue},
            new() { Id=2,
                Name = "Ahmad",
                Number=2,
                FirstEpisodeDate=DateTime.MinValue,
                BirthDate = DateTime.MinValue,
                LastEpisodeDate=DateTime.MinValue},
            new() { Id=3,
                Name = "Omar",
                Number=3,
                FirstEpisodeDate=DateTime.MinValue,
                BirthDate = DateTime.MinValue,
                LastEpisodeDate=DateTime.MinValue},
            new() {Id=4,
                Name = "Sami",
                Number=4,
                FirstEpisodeDate= DateTime.MinValue,
                BirthDate = DateTime.MinValue,
                LastEpisodeDate=DateTime.MinValue},
            new() { Id=5,
                Name = "Shamel",
                Number=5,
                FirstEpisodeDate=DateTime.MinValue,
                BirthDate = DateTime.MinValue,
                LastEpisodeDate=DateTime.MinValue},
            };
            builder.Entity<Doctor>().HasData(doctors);
        }
    }
}
