﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TwitterWebMVCv2.Data;

namespace TwitterWebMVCv2.Migrations
{
    [DbContext(typeof(TweetDbContext))]
    [Migration("20180211133640_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TwitterWebMVCv2.Models.Hashtag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.ToTable("Hashtags");
                });

            modelBuilder.Entity("TwitterWebMVCv2.Models.Language", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("TwitterWebMVCv2.Models.Tweet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("LanguageID");

                    b.Property<string>("TweetIdString");

                    b.HasKey("ID");

                    b.HasIndex("DateTime");

                    b.HasIndex("LanguageID");

                    b.ToTable("Tweets");
                });

            modelBuilder.Entity("TwitterWebMVCv2.Models.TweetHashtag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("HashtagID");

                    b.Property<int>("TweetID");

                    b.HasKey("ID");

                    b.HasIndex("HashtagID");

                    b.ToTable("TweetHashtags");
                });

            modelBuilder.Entity("TwitterWebMVCv2.Models.Tweet", b =>
                {
                    b.HasOne("TwitterWebMVCv2.Models.Language", "Language")
                        .WithMany("Tweets")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
