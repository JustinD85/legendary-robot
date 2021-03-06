﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200119005558_Initial Data")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Domain.Concrete.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PawnId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PawnId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Domain.Concrete.KanjiAliveAPI.KanjiAliveAPI", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("KanjiId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RadicalId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ReferencesId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KanjiId");

                    b.HasIndex("RadicalId");

                    b.HasIndex("ReferencesId");

                    b.ToTable("Kanji");
                });

            modelBuilder.Entity("Domain.Concrete.Pawn", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AC")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pawns");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Animation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RadicalId")
                        .HasColumnType("TEXT");

                    b.Property<string>("animation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RadicalId");

                    b.ToTable("Animation");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Audio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("aac")
                        .HasColumnType("TEXT");

                    b.Property<string>("mp3")
                        .HasColumnType("TEXT");

                    b.Property<string>("ogg")
                        .HasColumnType("TEXT");

                    b.Property<string>("opus")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Audio");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Example", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AudioId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Japanese")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("KanjiAliveAPIId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MeaningId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AudioId");

                    b.HasIndex("KanjiAliveAPIId");

                    b.HasIndex("MeaningId");

                    b.ToTable("Example");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("StrokesId")
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StrokesId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Kanji", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("character")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("kunyomiId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("meaningId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("onyomiId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("strokesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("videoId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("kunyomiId");

                    b.HasIndex("meaningId");

                    b.HasIndex("onyomiId");

                    b.HasIndex("strokesId");

                    b.HasIndex("videoId");

                    b.ToTable("Kanji1");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Kunyomi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("hiragana")
                        .HasColumnType("TEXT");

                    b.Property<string>("romaji")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kunyomi");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Meaning", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("english")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Meaning");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Name", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("hiragana")
                        .HasColumnType("TEXT");

                    b.Property<string>("romaji")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Name");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Onyomi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("katakana")
                        .HasColumnType("TEXT");

                    b.Property<string>("romaji")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Onyomi");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("hiragana")
                        .HasColumnType("TEXT");

                    b.Property<string>("icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("romaji")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Radical", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("character")
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("meaningId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("nameId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("positionId")
                        .HasColumnType("TEXT");

                    b.Property<int>("strokes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("meaningId");

                    b.HasIndex("nameId");

                    b.HasIndex("positionId");

                    b.ToTable("Radical");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.References", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<short>("classicNelson")
                        .HasColumnType("INTEGER");

                    b.Property<short>("grade")
                        .HasColumnType("INTEGER");

                    b.Property<short>("kodansha")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("References");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Strokes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("count")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Strokes");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Timing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("StrokesId")
                        .HasColumnType("TEXT");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StrokesId");

                    b.ToTable("Timing");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("mp4")
                        .HasColumnType("TEXT");

                    b.Property<string>("poster")
                        .HasColumnType("TEXT");

                    b.Property<string>("webm")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("Domain.Concrete.Item", b =>
                {
                    b.HasOne("Domain.Concrete.Pawn", null)
                        .WithMany("Items")
                        .HasForeignKey("PawnId");
                });

            modelBuilder.Entity("Domain.Concrete.KanjiAliveAPI.KanjiAliveAPI", b =>
                {
                    b.HasOne("Domain.Interfaces.Japanese.Kanji", "Kanji")
                        .WithMany()
                        .HasForeignKey("KanjiId");

                    b.HasOne("Domain.Interfaces.Japanese.Radical", "Radical")
                        .WithMany()
                        .HasForeignKey("RadicalId");

                    b.HasOne("Domain.Interfaces.Japanese.References", "References")
                        .WithMany()
                        .HasForeignKey("ReferencesId");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Animation", b =>
                {
                    b.HasOne("Domain.Interfaces.Japanese.Radical", null)
                        .WithMany("animation")
                        .HasForeignKey("RadicalId");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Example", b =>
                {
                    b.HasOne("Domain.Interfaces.Japanese.Audio", "Audio")
                        .WithMany()
                        .HasForeignKey("AudioId");

                    b.HasOne("Domain.Concrete.KanjiAliveAPI.KanjiAliveAPI", null)
                        .WithMany("Examples")
                        .HasForeignKey("KanjiAliveAPIId");

                    b.HasOne("Domain.Interfaces.Japanese.Meaning", "Meaning")
                        .WithMany()
                        .HasForeignKey("MeaningId");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Image", b =>
                {
                    b.HasOne("Domain.Interfaces.Japanese.Strokes", null)
                        .WithMany("images")
                        .HasForeignKey("StrokesId");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Kanji", b =>
                {
                    b.HasOne("Domain.Interfaces.Japanese.Kunyomi", "kunyomi")
                        .WithMany()
                        .HasForeignKey("kunyomiId");

                    b.HasOne("Domain.Interfaces.Japanese.Meaning", "meaning")
                        .WithMany()
                        .HasForeignKey("meaningId");

                    b.HasOne("Domain.Interfaces.Japanese.Onyomi", "onyomi")
                        .WithMany()
                        .HasForeignKey("onyomiId");

                    b.HasOne("Domain.Interfaces.Japanese.Strokes", "strokes")
                        .WithMany()
                        .HasForeignKey("strokesId");

                    b.HasOne("Domain.Interfaces.Japanese.Video", "video")
                        .WithMany()
                        .HasForeignKey("videoId");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Radical", b =>
                {
                    b.HasOne("Domain.Interfaces.Japanese.Meaning", "meaning")
                        .WithMany()
                        .HasForeignKey("meaningId");

                    b.HasOne("Domain.Interfaces.Japanese.Name", "name")
                        .WithMany()
                        .HasForeignKey("nameId");

                    b.HasOne("Domain.Interfaces.Japanese.Position", "position")
                        .WithMany()
                        .HasForeignKey("positionId");
                });

            modelBuilder.Entity("Domain.Interfaces.Japanese.Timing", b =>
                {
                    b.HasOne("Domain.Interfaces.Japanese.Strokes", null)
                        .WithMany("timings")
                        .HasForeignKey("StrokesId");
                });
#pragma warning restore 612, 618
        }
    }
}
