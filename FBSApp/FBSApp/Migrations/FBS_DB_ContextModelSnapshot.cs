﻿// <auto-generated />
using FBSApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FBSApp.Migrations
{
    [DbContext(typeof(FBS_DB_Context))]
    partial class FBS_DB_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FBSApp.Model.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "admin@gmail.com",
                            Password = "A09CE485059AB8DAA9DEBE3067FF0FF4E167345220867F191D03F6653D51C9C4238F5ADF171ED8437ABA49A582874F4FFF198C85188F25F0B5149F4A44AF9278",
                            Role = "ADMIN",
                            Salt = new byte[] { 75, 191, 154, 59, 62, 200, 26, 119, 83, 147, 168, 62, 43, 173, 70, 190, 34, 154, 54, 37, 163, 49, 206, 177, 156, 35, 47, 179, 226, 105, 84, 44, 29, 9, 224, 138, 196, 69, 148, 229, 217, 54, 134, 73, 107, 128, 195, 92, 208, 255, 43, 15, 191, 157, 38, 220, 35, 30, 201, 114, 67, 151, 187, 248 }
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
