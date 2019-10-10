﻿// <auto-generated />
using CoffeeReview;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeReview.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    partial class CoffeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeReview.Models.Coffee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Kind");

                    b.HasKey("Id");

                    b.ToTable("Coffees");

                    b.HasData(
                        new { Id = 1, Brand = "Cleveland Coffee", Description = "happyhappy stuff", ImageUrl = "/images/brightsideblend.jpg", Kind = "Bright Side Blend" },
                        new { Id = 2, Brand = "Cleveland Coffee", Description = "really good stuff", ImageUrl = "/images/tanzanianpeaberry.jpg", Kind = "Tanzanian Peaberry" },
                        new { Id = 3, Brand = "Rising Star", Description = "makes happy", ImageUrl = "/images/apocooperative.jpg", Kind = "Apo Cooperative" },
                        new { Id = 4, Brand = "Starbucks", Description = "happyhappy stuff", ImageUrl = "/images/komododragon.jpg", Kind = "Komodo Dragon" },
                        new { Id = 5, Brand = "8 O'Clock", Description = "great cheap coffee", ImageUrl = "/images/theoriginal.jpg", Kind = "The Original" },
                        new { Id = 6, Brand = "Brioso", Description = "Pretty Solid", ImageUrl = "/images/colombiasantabarbara.jpg", Kind = "Santa Barbara Estate" },
                        new { Id = 7, Brand = "8 O'Clock", Description = "excellent for the cost", ImageUrl = "/images/redeyeroast.jpg", Kind = "Red Eye Roast" },
                        new { Id = 8, Brand = "Peets", Description = "Deliciousness", ImageUrl = "/images/costaricapeaberry.jpg", Kind = "Costa Rica Peaberry" },
                        new { Id = 9, Brand = "Dunkin' Donuts", Description = "Horrible", ImageUrl = "/images/dunkindecaf.jpg", Kind = "Dunkin Decaf" }
                    );
                });

            modelBuilder.Entity("CoffeeReview.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoffeeId");

                    b.Property<string>("Content");

                    b.HasKey("Id");

                    b.HasIndex("CoffeeId");

                    b.ToTable("Review");

                    b.HasData(
                        new { Id = 1, CoffeeId = 1, Content = "Splendid, I must say. Gracious upon the first sip jolly ole chaps." },
                        new { Id = 2, CoffeeId = 2, Content = "Quite awful in taste and overall quality mate. Do not recommend this one for a night out with the chaps" },
                        new { Id = 3, CoffeeId = 3, Content = "Good for a wee bit of a wakeup but not a particular favorite of mine" },
                        new { Id = 4, CoffeeId = 4, Content = "Absolutely splendid chaps!!" },
                        new { Id = 5, CoffeeId = 5, Content = "Golly gee, this was a wee bit AWFUL" },
                        new { Id = 6, CoffeeId = 6, Content = "I was absolutely stunned when I tried this! Will definitely be sharing with a few of my chaps" },
                        new { Id = 7, CoffeeId = 7, Content = "Oh I hate to be a damper here but gosh I hated this one, an awful aftertaste ruins an otherwise ok taste" },
                        new { Id = 8, CoffeeId = 8, Content = "I almost thought I enjoyed this one but after about half a cup and a crumpet, my tummy hurt. 10/10 would not recommend to the chaps" },
                        new { Id = 9, CoffeeId = 9, Content = "Another favorite for my chaps and I. Good for a biscuit in the morning or a crumpet at night" },
                        new { Id = 10, CoffeeId = 4, Content = "James loves this coffee" },
                        new { Id = 11, CoffeeId = 5, Content = "OMG THIS IS THE BEST COFFEE EVER" }
                    );
                });

            modelBuilder.Entity("CoffeeReview.Models.Review", b =>
                {
                    b.HasOne("CoffeeReview.Models.Coffee", "Coffee")
                        .WithMany()
                        .HasForeignKey("CoffeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
