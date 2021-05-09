﻿// <auto-generated />
using Atlantic.MasterData.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atlantic.MasterData.Data.Migrations
{
    [DbContext(typeof(MasterDataContext))]
    partial class MasterDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.BusinessServices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<short>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BusinessServices");
                });

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.Cities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountriesId")
                        .HasColumnType("INTEGER");

                    b.Property<short>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.HasIndex("StatesId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<short>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.States", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountriesId")
                        .HasColumnType("INTEGER");

                    b.Property<short>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.Cities", b =>
                {
                    b.HasOne("Atlantic.MasterData.Domain.Models.Countries", "Countries")
                        .WithMany("Cities")
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Atlantic.MasterData.Domain.Models.States", "States")
                        .WithMany("Cities")
                        .HasForeignKey("StatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");

                    b.Navigation("States");
                });

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.States", b =>
                {
                    b.HasOne("Atlantic.MasterData.Domain.Models.Countries", "Countries")
                        .WithMany("States")
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.Countries", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("States");
                });

            modelBuilder.Entity("Atlantic.MasterData.Domain.Models.States", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
