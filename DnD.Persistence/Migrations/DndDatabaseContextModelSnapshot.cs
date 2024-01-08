﻿// <auto-generated />
using System;
using DnD.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnD.Persistence.Migrations
{
    [DbContext(typeof(DndDatabaseContext))]
    partial class DndDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DnD.Domain.AbilityScores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Abilities", (string)null);
                });

            modelBuilder.Entity("DnD.Domain.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AbilityScoresId")
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DescriptionId")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int?>("RaceId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AbilityScoresId");

                    b.HasIndex("ClassId");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("RaceId");

                    b.ToTable("Characters", (string)null);
                });

            modelBuilder.Entity("DnD.Domain.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Classes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Guid = new Guid("2d927dc9-9568-4554-9b42-2aae2a026409"),
                            Name = "Warrior"
                        });
                });

            modelBuilder.Entity("DnD.Domain.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aligment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Background")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bonds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Flaws")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Ideals")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalityTraits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Descriptions", (string)null);
                });

            modelBuilder.Entity("DnD.Domain.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Damage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("Guid")
                        .IsUnique();

                    b.ToTable("Equipments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 1000,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Damage = "1d8",
                            Description = "-",
                            Guid = new Guid("2fbe30b3-5224-4d3e-880a-226f128ff24e"),
                            Name = "BattleAxe",
                            Weight = 4f
                        });
                });

            modelBuilder.Entity("DnD.Domain.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Races", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Guid = new Guid("7f699f15-a972-404c-b2cc-f54315a87442"),
                            Name = "Human"
                        });
                });

            modelBuilder.Entity("DnD.Domain.WeaponProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.ToTable("WeaponProperties", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("13e4e1c8-9548-44ec-bd09-4c1c2ca29257"),
                            Name = "Ammunition"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("934fc7fe-1fcc-4600-a7b0-46dd1624b953"),
                            Name = "Finese"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("a379b070-07f0-4ea3-b06d-4effb3eb5caa"),
                            Name = "Heavy"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("e47f5ba5-4830-435c-9041-12f8af485396"),
                            Name = "Light"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("c79679dc-59ab-4c88-afeb-a9f65fdaabcb"),
                            Name = "Loading"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("90e5449b-9d24-4618-a40c-26731204a3dc"),
                            Name = "Range"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("9d941ecd-e212-4852-8231-f040f15f11f5"),
                            Name = "Reach"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("43790d45-7251-45df-ae26-9107345b495d"),
                            Name = "Special"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("395fd1d3-4a34-44da-b50c-74bc85149e47"),
                            Name = "Thrown"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("5088da03-2e65-4c63-8a13-27c31d2b7593"),
                            Name = "TwoHanded"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "ToDo",
                            Guid = new Guid("523b4c22-aa24-4aef-962f-7831ec531360"),
                            Name = "Versatile"
                        });
                });

            modelBuilder.Entity("DnD.Domain.Character", b =>
                {
                    b.HasOne("DnD.Domain.AbilityScores", "AbilityScores")
                        .WithMany()
                        .HasForeignKey("AbilityScoresId");

                    b.HasOne("DnD.Domain.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("DnD.Domain.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

                    b.HasOne("DnD.Domain.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId");

                    b.Navigation("AbilityScores");

                    b.Navigation("Class");

                    b.Navigation("Description");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("DnD.Domain.Equipment", b =>
                {
                    b.HasOne("DnD.Domain.Character", null)
                        .WithMany("Equipment")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("DnD.Domain.WeaponProperty", b =>
                {
                    b.HasOne("DnD.Domain.Equipment", null)
                        .WithMany("Properties")
                        .HasForeignKey("EquipmentId");
                });

            modelBuilder.Entity("DnD.Domain.Character", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("DnD.Domain.Equipment", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
