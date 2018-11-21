﻿// <auto-generated />
using EnumIdentifiers.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnumIdentifiers.Data.Migrations
{
    [DbContext(typeof(DotNetFlixDbContext))]
    partial class DotNetFlixDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnumIdentifiers.Data.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Billing");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("SubscriptionLevel")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionLevel");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EnumIdentifiers.Data.Model.SubscriptionLevel", b =>
                {
                    b.Property<string>("Name");

                    b.Property<int>("NumberDevicesWithDownloadCapability");

                    b.Property<int>("NumberOfSimultaneousDevices");

                    b.Property<decimal>("PricePerMonth");

                    b.Property<string>("Quality")
                        .IsRequired();

                    b.HasKey("Name");

                    b.ToTable("SubscriptionLevels");

                    b.HasData(
                        new { Name = "Basic", NumberDevicesWithDownloadCapability = 1, NumberOfSimultaneousDevices = 1, PricePerMonth = 7.99m, Quality = "Standard" },
                        new { Name = "Standard", NumberDevicesWithDownloadCapability = 2, NumberOfSimultaneousDevices = 2, PricePerMonth = 10.99m, Quality = "HD" },
                        new { Name = "Premium", NumberDevicesWithDownloadCapability = 4, NumberOfSimultaneousDevices = 4, PricePerMonth = 13.99m, Quality = "UHD" }
                    );
                });

            modelBuilder.Entity("EnumIdentifiers.Data.Model.Customer", b =>
                {
                    b.HasOne("EnumIdentifiers.Data.Model.SubscriptionLevel", "SubscriptionLevelRelation")
                        .WithMany()
                        .HasForeignKey("SubscriptionLevel")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
