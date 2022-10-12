﻿// <auto-generated />
using System;
using DoctorWho.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20220914002240_seedUpdated")]
    partial class seedUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DoctorWho.DB.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Karm"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Lama"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Sara"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Safadi"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Hisham"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Comp1",
                            WhoPlayed = "none"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Comp2",
                            WhoPlayed = "none"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Comp3",
                            WhoPlayed = "none"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Comp4",
                            WhoPlayed = "none"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Comp5",
                            WhoPlayed = "none"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Shamel",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Ahmad",
                            DoctorNumber = 2,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Omar",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Sami",
                            DoctorNumber = 4,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Shamel",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemys");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "desc1",
                            EnemyName = "evil1"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "desc2",
                            EnemyName = "evil2"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "desc3",
                            EnemyName = "evil3"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "desc4",
                            EnemyName = "evil4"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "desc5",
                            EnemyName = "evil5"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "type1",
                            Notes = "note1",
                            SeriesNumber = 1,
                            Title = "t1"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "type2",
                            Notes = "note2",
                            SeriesNumber = 2,
                            Title = "t2"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "type3",
                            Notes = "note3",
                            SeriesNumber = 3,
                            Title = "t3"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "type4",
                            Notes = "note4",
                            SeriesNumber = 4,
                            Title = "t4"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "type5",
                            Notes = "note5",
                            SeriesNumber = 5,
                            Title = "t5"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"), 1L, 1);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"), 1L, 1);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemys");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Episode", b =>
                {
                    b.HasOne("DoctorWho.DB.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.DB.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.DB.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.DB.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.DB.Enemy", "Enemy")
                        .WithMany("EpisodeEnemys")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.DB.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.DB.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.DB.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.DB.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemys");
                });

            modelBuilder.Entity("DoctorWho.DB.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
