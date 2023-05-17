﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230516080401_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DersAciklama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DersImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DersID");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Duyurular", b =>
                {
                    b.Property<int>("DuyuruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DuyuruBaslik")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DuyuruMekan")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DuyuruTarih")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DuyuruID");

                    b.ToTable("Duyurulars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Egitmenler", b =>
                {
                    b.Property<int>("EgitmenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EgitmenAciklama")
                        .HasColumnType("longtext");

                    b.Property<string>("EgitmenAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EgitmenFacebook")
                        .HasColumnType("longtext");

                    b.Property<string>("EgitmenGorsel")
                        .HasColumnType("longtext");

                    b.Property<string>("EgitmenInstagram")
                        .HasColumnType("longtext");

                    b.Property<bool>("EgitmenStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EgitmenTwitter")
                        .HasColumnType("longtext");

                    b.HasKey("EgitmenID");

                    b.ToTable("Egitmenlers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Galeri", b =>
                {
                    b.Property<int>("GaleriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GaleryImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GaleriID");

                    b.ToTable("Galeris");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hakkimizda", b =>
                {
                    b.Property<int>("HakkimizdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HakkimizdaBaslik")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HakkimizdaYazi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("HakkimizdaID");

                    b.ToTable("Hakkimizdas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.KayitForm", b =>
                {
                    b.Property<int>("KayitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OgrenciAdSoyad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VeliAdSoyad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("KayitID");

                    b.ToTable("KayitForms");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Slider", b =>
                {
                    b.Property<int>("SliderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SliderImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SliderYazi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SliderID");

                    b.ToTable("Sliders");
                });
#pragma warning restore 612, 618
        }
    }
}