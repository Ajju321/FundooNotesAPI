﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer.Context;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(AuthenticationContext))]
    [Migration("20200110141535_services")]
    partial class services
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommonLayer.Model.AccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<bool>("IsFacebook");

                    b.Property<bool>("IsGoogle");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("MobileNumber");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Services");

                    b.Property<string>("TypeOfUser");

                    b.HasKey("Id");

                    b.ToTable("UserAccountTable");
                });

            modelBuilder.Entity("CommonLayer.Model.CollabratorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NotesId");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Collabrator");
                });

            modelBuilder.Entity("CommonLayer.Model.LabelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Label");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("NoteId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("CommonLayer.Model.NoteLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LabelData");

                    b.Property<int>("LabelId");

                    b.Property<int>("NotesId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("NoteLabel");
                });

            modelBuilder.Entity("CommonLayer.Model.NotesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Image");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsArchive");

                    b.Property<bool>("IsNotes");

                    b.Property<bool>("IsPin");

                    b.Property<bool>("IsTrash");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<DateTime?>("Reminder");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
