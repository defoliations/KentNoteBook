﻿// <auto-generated />
using System;
using KentNoteBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KentNoteBook.Data.Migrations
{
    [DbContext(typeof(KentNoteBookDbContext))]
    [Migration("20180802085738_Add_SystemPermission_Code")]
    partial class Add_SystemPermission_Code
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KentNoteBook.Data.Entities.MenusInRole", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("MenuId");

                    b.HasKey("RoleId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenusInRole");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.OperationsInPermission", b =>
                {
                    b.Property<Guid>("PermissionId");

                    b.Property<Guid>("OperationId");

                    b.HasKey("PermissionId", "OperationId");

                    b.HasIndex("OperationId");

                    b.ToTable("OperationsInPermission");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.PermissionsInMenu", b =>
                {
                    b.Property<Guid>("PermissionId");

                    b.Property<Guid>("MenuId");

                    b.HasKey("PermissionId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("PermissionsInMenu");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.RolesInUserGroup", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserGroupId");

                    b.HasKey("RoleId", "UserGroupId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("RolesInUserGroup");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.SystemMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("ParentId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("SystemMenu");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.SystemOperation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("SystemOperation");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.SystemPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PermissionType");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("SystemPermission");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.SystemRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("SystemRole");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.SystemUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar")
                        .HasMaxLength(150);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Discription")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Mobile")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NickName")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(30);

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("SystemUser");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.SystemUserGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("SystemUserGroup");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.UsersInRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UsersInRole");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.UsersInUserGroup", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("UserGroupId");

                    b.HasKey("UserId", "UserGroupId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("UsersInUserGroup");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.MenusInRole", b =>
                {
                    b.HasOne("KentNoteBook.Data.Entities.SystemMenu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KentNoteBook.Data.Entities.SystemRole", "Role")
                        .WithMany("MenusInRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.OperationsInPermission", b =>
                {
                    b.HasOne("KentNoteBook.Data.Entities.SystemOperation", "Operation")
                        .WithMany()
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KentNoteBook.Data.Entities.SystemPermission", "Permission")
                        .WithMany("OperationsInPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.PermissionsInMenu", b =>
                {
                    b.HasOne("KentNoteBook.Data.Entities.SystemMenu", "Menu")
                        .WithMany("PermissionsInMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KentNoteBook.Data.Entities.SystemPermission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.RolesInUserGroup", b =>
                {
                    b.HasOne("KentNoteBook.Data.Entities.SystemRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KentNoteBook.Data.Entities.SystemUserGroup", "UserGroup")
                        .WithMany("RolesInUserGroups")
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.SystemMenu", b =>
                {
                    b.HasOne("KentNoteBook.Data.Entities.SystemMenu", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.UsersInRole", b =>
                {
                    b.HasOne("KentNoteBook.Data.Entities.SystemRole", "Role")
                        .WithMany("UsersInRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KentNoteBook.Data.Entities.SystemUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KentNoteBook.Data.Entities.UsersInUserGroup", b =>
                {
                    b.HasOne("KentNoteBook.Data.Entities.SystemUserGroup", "UserGroup")
                        .WithMany("UsersInUserGroups")
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KentNoteBook.Data.Entities.SystemUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
