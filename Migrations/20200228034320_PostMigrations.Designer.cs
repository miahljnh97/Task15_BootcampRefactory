﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Task15_BootcampRefactory;

namespace Task15_BootcampRefactory.Migrations
{
    [DbContext(typeof(PostContext))]
    [Migration("20200228034320_PostMigrations")]
    partial class PostMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Task15_BootcampRefactory.Models.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Tags")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime>("Update_time")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("post");
                });
#pragma warning restore 612, 618
        }
    }
}
