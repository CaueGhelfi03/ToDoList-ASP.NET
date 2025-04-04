﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeTarefas.Data;

#nullable disable

namespace TaskSystem.Core.Migrations
{
    [DbContext(typeof(TaskSystemDBContext))]
    partial class TaskSystemDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("challenge_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("challenge_createdAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("challenge_description");

                    b.Property<int>("DurationDays")
                        .HasColumnType("int")
                        .HasColumnName("challenge_duration");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("challenge_end");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("challenge_name");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("challenge_start");

                    b.Property<int>("status")
                        .HasColumnType("int")
                        .HasColumnName("challenge_status");

                    b.HasKey("Id");

                    b.ToTable("Challenge");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.Ranking.RankingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChallengeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ranking_challengeId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("ranking_createdAt");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("ranking_updatedAt");

                    b.HasKey("Id");

                    b.ToTable("Ranking");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.Score.ScoreEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("score_id");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("score_points");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.UserChallengeProgress.UserProgressEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("progress_id");

                    b.Property<Guid>("ChallengeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("challenge_id");

                    b.Property<DateTime?>("LastActiveDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_active_date");

                    b.Property<int>("StreakCount")
                        .HasColumnType("int")
                        .HasColumnName("streak_count");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int")
                        .HasColumnName("progress_total_score");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserChallengeProgress");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.Task.TaskEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("task_id");

                    b.Property<Guid>("ChallengeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("challenge_id");

                    b.Property<int>("Complexity")
                        .HasColumnType("int")
                        .HasColumnName("task_complexity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("task_createdAt");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("task_description");

                    b.Property<DateTime?>("LastCompletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("task_lastCompletedAt");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("task_status");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("task_name");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("UserId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.User.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<Guid?>("ChallengeEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("user_createdAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_password");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeEntityId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.Ranking.RankingEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", "Challenge")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.Score.ScoreEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Models.User.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.UserChallengeProgress.UserProgressEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", "Challenge")
                        .WithMany("UserProgress")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskSystem.Core.Domain.Models.User.UserEntity", "User")
                        .WithMany("UserProgress")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.Task.TaskEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskSystem.Core.Domain.Models.User.UserEntity", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.User.UserEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", null)
                        .WithMany("Users")
                        .HasForeignKey("ChallengeEntityId");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", b =>
                {
                    b.Navigation("UserProgress");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.User.UserEntity", b =>
                {
                    b.Navigation("Tasks");

                    b.Navigation("UserProgress");
                });
#pragma warning restore 612, 618
        }
    }
}
