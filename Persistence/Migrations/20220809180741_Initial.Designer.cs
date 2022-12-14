// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220809180741_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Domain.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Domain.GrossWrittenPremium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("LineOfBusinessId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("LineOfBusinessId");

                    b.ToTable("GrossWrittenPremia");
                });

            modelBuilder.Entity("Domain.LineOfBusiness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LineOfBusinesses");
                });

            modelBuilder.Entity("Domain.GrossWrittenPremium", b =>
                {
                    b.HasOne("Domain.Country", "Country")
                        .WithMany("CountryLineOfBusinesses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.LineOfBusiness", "LineOfBusiness")
                        .WithMany("CountryLineOfBusinesses")
                        .HasForeignKey("LineOfBusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("LineOfBusiness");
                });

            modelBuilder.Entity("Domain.Country", b =>
                {
                    b.Navigation("CountryLineOfBusinesses");
                });

            modelBuilder.Entity("Domain.LineOfBusiness", b =>
                {
                    b.Navigation("CountryLineOfBusinesses");
                });
#pragma warning restore 612, 618
        }
    }
}
