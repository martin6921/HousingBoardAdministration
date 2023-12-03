﻿// <auto-generated />
using System;
using HousingBoardApi.SqlServerContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HousingBoardApi.SqlServerContextMigrations.Migrations
{
    [DbContext(typeof(HousingBoardDbContext))]
    [Migration("20231202220220_Test1")]
    partial class Test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.BoardMemberEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoardMember", (string)null);
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.BoardMemberRoleEntity", b =>
                {
                    b.Property<Guid>("BoardMemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BoardMemberId", "RoleId");

                    b.HasIndex("BoardMemberId")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("BoardMemberRole", (string)null);
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.DocumentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte[]>("DocumentFile")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("DocumentOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DocumentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("MeetingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DocumentOwnerId");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("MeetingId");

                    b.ToTable("Document", (string)null);
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.DocumentTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DocumentType", (string)null);
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.MeetingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedMeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("MeetingOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("MeetingTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MeetingTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MeetingOwnerId");

                    b.HasIndex("MeetingTypeId");

                    b.ToTable("Meeting", (string)null);
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.MeetingTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeetingType", (string)null);
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.RoleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.BoardMemberRoleEntity", b =>
                {
                    b.HasOne("HousingBoardApi.Domain.Entities.BoardMemberEntity", "BoardMember")
                        .WithOne("Role")
                        .HasForeignKey("HousingBoardApi.Domain.Entities.BoardMemberRoleEntity", "BoardMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingBoardApi.Domain.Entities.RoleEntity", "Role")
                        .WithMany("BoardMemberRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardMember");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.DocumentEntity", b =>
                {
                    b.HasOne("HousingBoardApi.Domain.Entities.BoardMemberEntity", "DocumentOwner")
                        .WithMany("Documents")
                        .HasForeignKey("DocumentOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingBoardApi.Domain.Entities.DocumentTypeEntity", "DocumentType")
                        .WithMany("Documents")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingBoardApi.Domain.Entities.MeetingEntity", "Meeting")
                        .WithMany("Documents")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DocumentOwner");

                    b.Navigation("DocumentType");

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.MeetingEntity", b =>
                {
                    b.HasOne("HousingBoardApi.Domain.Entities.BoardMemberEntity", "MeetingOwner")
                        .WithMany("Meetings")
                        .HasForeignKey("MeetingOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingBoardApi.Domain.Entities.MeetingTypeEntity", "MeetingType")
                        .WithMany("Meetings")
                        .HasForeignKey("MeetingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeetingOwner");

                    b.Navigation("MeetingType");
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.BoardMemberEntity", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Meetings");

                    b.Navigation("Role")
                        .IsRequired();
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.DocumentTypeEntity", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.MeetingEntity", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.MeetingTypeEntity", b =>
                {
                    b.Navigation("Meetings");
                });

            modelBuilder.Entity("HousingBoardApi.Domain.Entities.RoleEntity", b =>
                {
                    b.Navigation("BoardMemberRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
