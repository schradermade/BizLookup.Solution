﻿// <auto-generated />
using BizLookupApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BizLookupApi.Migrations
{
    [DbContext(typeof(BizLookupApiContext))]
    partial class BizLookupApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BizLookupApi.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Hours")
                        .IsRequired();

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("URL");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Address = "Newberg, Oregon",
                            Hours = "8am-6pm, 7 days/Week",
                            Industry = "Retail",
                            Name = "Blue Dolphin Wash"
                        },
                        new
                        {
                            BusinessId = 2,
                            Address = "Tualatin, Oregon",
                            Hours = "8am-6pm, Mon-Fri",
                            Industry = "Food & Beverage",
                            Name = "Christian's Bakery"
                        },
                        new
                        {
                            BusinessId = 3,
                            Address = "Newberg, Oregon",
                            Hours = "24 Hours/Day, 7 days/week",
                            Industry = "Retail",
                            Name = "Alaska Airlines"
                        },
                        new
                        {
                            BusinessId = 4,
                            Address = "Wilsonville, Oregon",
                            Hours = "8am-5pm, 7 days/Week",
                            Industry = "Hospitality",
                            Name = "RV's To-Go"
                        },
                        new
                        {
                            BusinessId = 5,
                            Address = "Wilsonville, Oregon",
                            Hours = "8am-6pm, Mon-Thurs",
                            Industry = "Retail",
                            Name = "Chanel's Hair Choppin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
