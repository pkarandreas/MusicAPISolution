﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicAPIV1.Data;

#nullable disable

namespace MusicAPIV1.Migrations
{
    [DbContext(typeof(MusicDBcontext))]
    partial class MusicDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusicAPIV1.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("GenreTBL");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            GenreName = "Heavy metal"
                        },
                        new
                        {
                            Id = 101,
                            GenreName = "Hard Rock"
                        },
                        new
                        {
                            Id = 102,
                            GenreName = "Punk Rock"
                        },
                        new
                        {
                            Id = 103,
                            GenreName = "Symphonic rock"
                        },
                        new
                        {
                            Id = 104,
                            GenreName = "Blues-Rock"
                        },
                        new
                        {
                            Id = 105,
                            GenreName = "Rock & Roll"
                        },
                        new
                        {
                            Id = 106,
                            GenreName = "Rockabilly "
                        });
                });

            modelBuilder.Entity("MusicAPIV1.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<int>("GroupGenreID")
                        .HasColumnType("int")
                        .HasColumnName("GenreID");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Groupname");

                    b.HasKey("Id");

                    b.ToTable("GroupsTBL");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Description = "Hard Rock",
                            GroupGenreID = 101,
                            GroupName = "Deep Purple"
                        },
                        new
                        {
                            Id = 1001,
                            Description = "Hard Rock",
                            GroupGenreID = 101,
                            GroupName = "Rainbow"
                        },
                        new
                        {
                            Id = 1002,
                            Description = "Heavy Metal",
                            GroupGenreID = 100,
                            GroupName = "Accept"
                        },
                        new
                        {
                            Id = 1003,
                            Description = "Heavy Metal",
                            GroupGenreID = 100,
                            GroupName = "Helloween"
                        },
                        new
                        {
                            Id = 1004,
                            Description = "Heavy Metal",
                            GroupGenreID = 103,
                            GroupName = "Nightwish"
                        },
                        new
                        {
                            Id = 1005,
                            Description = "Heavy Metal",
                            GroupGenreID = 101,
                            GroupName = "AC/DC"
                        },
                        new
                        {
                            Id = 1006,
                            Description = "Heavy Metal",
                            GroupGenreID = 100,
                            GroupName = "Metallica"
                        });
                });

            modelBuilder.Entity("MusicAPIV1.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("songURL")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("SongsTBL");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            GroupId = 1000,
                            SongName = "Child in Time",
                            songURL = "https://www.youtube.com/watch?v=OorZcOzNcgE"
                        },
                        new
                        {
                            Id = 1001,
                            GroupId = 1000,
                            SongName = "Smoke on the water",
                            songURL = "https://www.youtube.com/watch?v=zUwEIt9ez7M"
                        },
                        new
                        {
                            Id = 1002,
                            GroupId = 1000,
                            SongName = "Highway Star",
                            songURL = "https://www.youtube.com/watch?v=Wr9ie2J2690"
                        },
                        new
                        {
                            Id = 1003,
                            GroupId = 1001,
                            SongName = "Temple of the King",
                            songURL = "https://www.youtube.com/watch?v=B7nKzCRL_oo"
                        },
                        new
                        {
                            Id = 1004,
                            GroupId = 1001,
                            SongName = "Stargazer",
                            songURL = "https://www.youtube.com/watch?v=YmJIccPWnEk"
                        },
                        new
                        {
                            Id = 1005,
                            GroupId = 1004,
                            SongName = "The Phantom Of The Opera",
                            songURL = "https://www.youtube.com/watch?v=tL25rbnvM4o"
                        },
                        new
                        {
                            Id = 1006,
                            GroupId = 1004,
                            SongName = "Wish I Had An Angel",
                            songURL = "https://www.youtube.com/watch?v=wEERFBI9eCg"
                        },
                        new
                        {
                            Id = 1007,
                            GroupId = 1002,
                            SongName = "Can't Stand the Night",
                            songURL = "https://www.youtube.com/watch?v=cnwr0xsAMTo"
                        },
                        new
                        {
                            Id = 1008,
                            GroupId = 1002,
                            SongName = "Princess of the Dawn",
                            songURL = "https://www.youtube.com/watch?v=K8C-DP18-6g"
                        },
                        new
                        {
                            Id = 1009,
                            GroupId = 1006,
                            SongName = "Master of Puppets",
                            songURL = "https://www.youtube.com/watch?v=E0ozmU9cJDg"
                        },
                        new
                        {
                            Id = 1010,
                            GroupId = 1006,
                            SongName = "The Unforgiven",
                            songURL = "https://www.youtube.com/watch?v=DDGhKS6bSAE"
                        },
                        new
                        {
                            Id = 1011,
                            GroupId = 1006,
                            SongName = "Enter Sandman",
                            songURL = "https://www.youtube.com/watch?v=CD-E-LDc384"
                        },
                        new
                        {
                            Id = 1012,
                            GroupId = 1003,
                            SongName = "I Want Out",
                            songURL = "https://www.youtube.com/watch?v=FjV8SHjHvHk"
                        },
                        new
                        {
                            Id = 1013,
                            GroupId = 1003,
                            SongName = "A Tale That Wasn't Right",
                            songURL = "https://www.youtube.com/watch?v=wbGjYQsx3c8"
                        },
                        new
                        {
                            Id = 1016,
                            GroupId = 1005,
                            SongName = "T.N.T.",
                            songURL = "https://www.youtube.com/watch?v=NhsK5WExrnE"
                        },
                        new
                        {
                            Id = 1017,
                            GroupId = 1005,
                            SongName = "Thunderstruck",
                            songURL = "https://www.youtube.com/watch?v=v2AC41dglnM"
                        },
                        new
                        {
                            Id = 1018,
                            GroupId = 1005,
                            SongName = "Highway to Hell",
                            songURL = "https://www.youtube.com/watch?v=UCskpE9KGQU"
                        });
                });

            modelBuilder.Entity("MusicAPIV1.Models.Song", b =>
                {
                    b.HasOne("MusicAPIV1.Models.Group", "Group")
                        .WithMany("Songs")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("MusicAPIV1.Models.Group", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
