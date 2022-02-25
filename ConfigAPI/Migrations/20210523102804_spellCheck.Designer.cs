﻿// <auto-generated />
using ConfigAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConfigAPI.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210523102804_spellCheck")]
    partial class spellCheck
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("ConfigAPI.Model.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("TEXT");

                    b.Property<string>("ManufacturerPartId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("ConfigAPI.Model.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("VersionNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("ConfigAPI.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ConfigAPI.Models.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("ConfigAPI.Models.CollectionsConfigs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollectionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConfigurationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.HasIndex("ConfigurationId");

                    b.ToTable("CollectionsConfigurations");
                });

            modelBuilder.Entity("ConfigAPI.Models.ConfigurationsItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConfigurationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ConfigurationId");

                    b.HasIndex("ItemId");

                    b.ToTable("ConfigurationsItems");
                });

            modelBuilder.Entity("ConfigAPI.Models.ItemsComponents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComponentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemsComponents");
                });

            modelBuilder.Entity("ConfigAPI.Models.CollectionsConfigs", b =>
                {
                    b.HasOne("ConfigAPI.Models.Collection", "Collection")
                        .WithMany()
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConfigAPI.Model.Configuration", "Configuration")
                        .WithMany()
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");

                    b.Navigation("Configuration");
                });

            modelBuilder.Entity("ConfigAPI.Models.ConfigurationsItems", b =>
                {
                    b.HasOne("ConfigAPI.Model.Configuration", "Configuration")
                        .WithMany()
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConfigAPI.Model.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Configuration");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ConfigAPI.Models.ItemsComponents", b =>
                {
                    b.HasOne("ConfigAPI.Model.Component", "Component")
                        .WithMany()
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConfigAPI.Model.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Component");

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
