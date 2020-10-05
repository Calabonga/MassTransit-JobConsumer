﻿// <auto-generated />
using System;
using MassTransit.EntityFrameworkCoreIntegration.JobService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobService.Service.Migrations
{
    [DbContext(typeof(JobServiceSagaDbContext))]
    [Migration("20201002065604_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MassTransit.JobService.Components.StateMachines.JobAttemptSaga", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Faulted")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstanceAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RetryAttempt")
                        .HasColumnType("int");

                    b.Property<string>("ServiceAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Started")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StatusCheckTokenId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CorrelationId");

                    b.HasIndex("JobId", "RetryAttempt")
                        .IsUnique();

                    b.ToTable("JobAttemptSaga");
                });

            modelBuilder.Entity("MassTransit.JobService.Components.StateMachines.JobSaga", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttemptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Completed")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.Property<DateTime?>("Faulted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobRetryDelayToken")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobSlotWaitToken")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan?>("JobTimeout")
                        .HasColumnType("time");

                    b.Property<Guid>("JobTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RetryAttempt")
                        .HasColumnType("int");

                    b.Property<string>("ServiceAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Started")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Submitted")
                        .HasColumnType("datetime2");

                    b.HasKey("CorrelationId");

                    b.ToTable("JobSaga");
                });

            modelBuilder.Entity("MassTransit.JobService.Components.StateMachines.JobTypeSaga", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActiveJobCount")
                        .HasColumnType("int");

                    b.Property<string>("ActiveJobs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConcurrentJobLimit")
                        .HasColumnType("int");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<int?>("OverrideJobLimit")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OverrideLimitExpiration")
                        .HasColumnType("datetime2");

                    b.HasKey("CorrelationId");

                    b.ToTable("JobTypeSaga");
                });
#pragma warning restore 612, 618
        }
    }
}
