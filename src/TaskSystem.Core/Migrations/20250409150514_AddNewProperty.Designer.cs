﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeTarefas.Data;

#nullable disable

namespace TaskSystem.Core.Migrations
{
    [DbContext(typeof(TaskSystemDBContext))]
    [Migration("20250409150514_AddNewProperty")]
    partial class AddNewProperty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("ChallengeComplexity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("challenge_complexity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("challenge_createdAt");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("challenge_created_By");

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

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("challenge_status");

                    b.HasKey("Id");

                    b.ToTable("Challenge");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.UserChallengeProgress.ChallengeUserProgressEntity", b =>
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

                    b.HasIndex("ChallengeId");

                    b.HasIndex("UserId");

                    b.ToTable("ChallengeUserProgressEntity");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.UserTaskCompletion.UserTaskCompletionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("completion_id");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("completion_date");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit")
                        .HasColumnName("is_validated");

                    b.Property<int>("Score")
                        .HasColumnType("int")
                        .HasColumnName("completion_score");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("task_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTaskCompletion");
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

                    b.Property<string>("Complexity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
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

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.User.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

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

                    b.ToTable("User");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.UserChallengeProgress.ChallengeUserProgressEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", "Challenge")
                        .WithMany("ChallengeUserProgress")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskSystem.Core.Domain.Models.User.UserEntity", "User")
                        .WithMany("ChallengeUserProgress")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.UserTaskCompletion.UserTaskCompletionEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Models.Task.TaskEntity", "Task")
                        .WithMany("UserTaskCompletions")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskSystem.Core.Domain.Models.User.UserEntity", "User")
                        .WithMany("UserTaskCompletions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.Task.TaskEntity", b =>
                {
                    b.HasOne("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", "Challenge")
                        .WithMany("Tasks")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Entities.Challenge.ChallengeEntity", b =>
                {
                    b.Navigation("ChallengeUserProgress");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.Task.TaskEntity", b =>
                {
                    b.Navigation("UserTaskCompletions");
                });

            modelBuilder.Entity("TaskSystem.Core.Domain.Models.User.UserEntity", b =>
                {
                    b.Navigation("ChallengeUserProgress");

                    b.Navigation("UserTaskCompletions");
                });
#pragma warning restore 612, 618
        }
    }
}
