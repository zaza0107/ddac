﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ddac.Models;

namespace ddac.Migrations
{
    [DbContext(typeof(ddacContext))]
    [Migration("20200122135946_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ddac.Models.Hotel", b =>
                {
                    b.Property<int>("Hid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HDateCheckInDate");

                    b.Property<DateTime>("HDateCheckOutDate");

                    b.Property<int>("HQty");

                    b.Property<string>("HotelName");

                    b.Property<decimal>("HotelPrice");

                    b.HasKey("Hid");

                    b.ToTable("Hotel");
                });
#pragma warning restore 612, 618
        }
    }
}
