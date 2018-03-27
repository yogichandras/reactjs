﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ReactjsfirstCrud.Models;
using System;

namespace ReactjsfirstCrud.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180327053057_crudreact")]
    partial class crudreact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ReactjsfirstCrud.Models.Mainmodels+Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age");

                    b.Property<string>("Gender")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Picture")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("ReactjsfirstCrud.Models.Mainmodels+Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateReleased");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Genre")
                        .HasMaxLength(50);

                    b.Property<decimal?>("GrossRevenue");

                    b.Property<string>("Rating")
                        .HasMaxLength(10);

                    b.Property<string>("ReleasedBy")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("ReactjsfirstCrud.Models.Mainmodels+MovieActor", b =>
                {
                    b.Property<int>("MovieId");

                    b.Property<int>("ActorId");

                    b.HasKey("MovieId", "ActorId");

                    b.HasAlternateKey("ActorId", "MovieId");

                    b.ToTable("MovieActor");
                });
#pragma warning restore 612, 618
        }
    }
}
