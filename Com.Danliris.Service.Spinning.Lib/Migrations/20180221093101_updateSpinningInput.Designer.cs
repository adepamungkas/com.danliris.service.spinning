﻿// <auto-generated />
using Com.Danliris.Service.Spinning.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Danliris.Service.Spinning.Lib.Migrations
{
    [DbContext(typeof(SpinningDbContext))]
    [Migration("20180221093101_updateSpinningInput")]
    partial class updateSpinningInput
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.LotYarn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Lot")
                        .HasMaxLength(500);

                    b.Property<string>("MachineCode")
                        .HasMaxLength(100);

                    b.Property<string>("MachineId")
                        .HasMaxLength(100);

                    b.Property<string>("MachineName")
                        .HasMaxLength(100);

                    b.Property<string>("Remark");

                    b.Property<string>("UnitCode")
                        .HasMaxLength(100);

                    b.Property<string>("UnitId")
                        .HasMaxLength(100);

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.Property<string>("YarnCode")
                        .HasMaxLength(100);

                    b.Property<int>("YarnId");

                    b.Property<string>("YarnName")
                        .HasMaxLength(100);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("LotYarns");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.SpinningInputProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<double>("Bale");

                    b.Property<double>("Counter");

                    b.Property<DateTime>("Date");

                    b.Property<double>("Hank");

                    b.Property<string>("Lot");

                    b.Property<string>("MachineId")
                        .HasMaxLength(500);

                    b.Property<string>("MachineName")
                        .HasMaxLength(500);

                    b.Property<double>("Ne");

                    b.Property<string>("NomorInputProduksi")
                        .HasMaxLength(100);

                    b.Property<string>("Shift")
                        .HasMaxLength(500);

                    b.Property<string>("UnitId")
                        .HasMaxLength(500);

                    b.Property<string>("UnitName")
                        .HasMaxLength(500);

                    b.Property<int>("YarnId")
                        .HasMaxLength(100);

                    b.Property<string>("YarnName")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("SpinningInputProductions");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.Yarn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<double>("Ne");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Yarns");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.YarnOutputProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<double>("BadOutput");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Date");

                    b.Property<double>("DrumTotal");

                    b.Property<double>("GoodOutput");

                    b.Property<string>("LotYarnCode")
                        .HasMaxLength(100);

                    b.Property<int>("LotYarnId");

                    b.Property<string>("LotYarnName")
                        .HasMaxLength(500);

                    b.Property<string>("MachineCode")
                        .HasMaxLength(500);

                    b.Property<string>("MachineId")
                        .HasMaxLength(500);

                    b.Property<string>("MachineName")
                        .HasMaxLength(500);

                    b.Property<string>("Shift")
                        .HasMaxLength(500);

                    b.Property<string>("SpinningCode")
                        .HasMaxLength(500);

                    b.Property<string>("SpinningId")
                        .HasMaxLength(500);

                    b.Property<string>("SpinningName")
                        .HasMaxLength(500);

                    b.Property<string>("YarnCode")
                        .HasMaxLength(100);

                    b.Property<int>("YarnId");

                    b.Property<string>("YarnName")
                        .HasMaxLength(500);

                    b.Property<double>("YarnWeightPerCone");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("YarnOutputProductions");
                });
#pragma warning restore 612, 618
        }
    }
}
