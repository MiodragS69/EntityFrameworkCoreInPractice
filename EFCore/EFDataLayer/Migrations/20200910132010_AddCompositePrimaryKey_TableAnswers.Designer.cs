﻿// <auto-generated />
using EFDataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFDataLayer.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20200910132010_AddCompositePrimaryKey_TableAnswers")]
    partial class AddCompositePrimaryKey_TableAnswers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFDataLayer.Entities.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("AnswerText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("AnswerId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("EFDataLayer.Entities.Explanation", b =>
                {
                    b.Property<int>("ExplanationId")
                        .HasColumnType("int");

                    b.Property<string>("ExplanationText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("ExplanationId");

                    b.HasIndex("QuestionId")
                        .IsUnique();

                    b.ToTable("Explanations");
                });

            modelBuilder.Entity("EFDataLayer.Entities.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<bool>("MultiAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("EFDataLayer.Entities.Answer", b =>
                {
                    b.HasOne("EFDataLayer.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFDataLayer.Entities.Explanation", b =>
                {
                    b.HasOne("EFDataLayer.Entities.Question", null)
                        .WithOne("Explanation")
                        .HasForeignKey("EFDataLayer.Entities.Explanation", "QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
