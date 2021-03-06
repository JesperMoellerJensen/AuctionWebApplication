﻿// <auto-generated />
using System;
using AuctionWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuctionWebAPI.Migrations
{
    [DbContext(typeof(AuctionContext))]
    partial class AuctionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuctionWebAPI.Entities.AuctionItem", b =>
                {
                    b.Property<int>("ItemNumber")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BidCustomName");

                    b.Property<string>("BidCustomPhone");

                    b.Property<long>("BidPrice");

                    b.Property<DateTime>("BidTimeStamp");

                    b.Property<string>("ItemDescription")
                        .IsRequired();

                    b.Property<long>("RatingPrice");

                    b.HasKey("ItemNumber");

                    b.ToTable("AuctionItems");
                });
#pragma warning restore 612, 618
        }
    }
}
