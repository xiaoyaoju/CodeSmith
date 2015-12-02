﻿//------------------------------------------------------------------------------
// <autogenerated>
//     此代码是由 CodeSmith 模板生成的。
//
//     做不该文件的修改内容。更改此
//     如果重新生成代码，文件将会丢失。
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Abp.EntityFramework;
using CodeSmith.Abp.Template.Test.Core;

// ReSharper disable once CheckNamespace
namespace CodeSmith.Abp.Template.Test.EntityFramework
{
    public partial class ZtholeMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Zthole>
    {
        public ZtholeMap()
        {
            // table
            ToTable("zthole");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.ConstructionSiteId)
                .HasColumnName("ConstructionSiteId")
                .IsRequired();
            Property(t => t.DrillingRig)
                .HasColumnName("DrillingRig")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.DayStage)
                .HasColumnName("DayStage")
                .IsOptional();
            Property(t => t.DrillingFootage)
                .HasColumnName("DrillingFootage")
                .HasPrecision(18, 2)
                .IsOptional();
            Property(t => t.DayTotal)
                .HasColumnName("DayTotal")
                .HasPrecision(18, 2)
                .IsOptional();
            Property(t => t.MonthTotal)
                .HasColumnName("MonthTotal")
                .HasPrecision(18, 2)
                .IsOptional();
            Property(t => t.CurrentMonthPlan)
                .HasColumnName("CurrentMonthPlan")
                .HasPrecision(18, 2)
                .IsOptional();
            Property(t => t.PersonInCharge)
                .HasColumnName("PersonInCharge")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.CurrentPeopleNum)
                .HasColumnName("CurrentPeopleNum")
                .IsOptional();
            Property(t => t.No)
                .HasColumnName("No")
                .HasMaxLength(765)
                .IsOptional();
            Property(t => t.HoleType)
                .HasColumnName("HoleType")
                .IsOptional();
            Property(t => t.PoreSize)
                .HasColumnName("PoreSize")
                .HasPrecision(18, 1)
                .IsOptional();
            Property(t => t.Position)
                .HasColumnName("Position")
                .HasMaxLength(765)
                .IsOptional();
            Property(t => t.DipAngle)
                .HasColumnName("DipAngle")
                .HasPrecision(10, 4)
                .IsOptional();
            Property(t => t.DesignHoleDepth)
                .HasColumnName("DesignHoleDepth")
                .HasPrecision(10, 4)
                .IsOptional();
            Property(t => t.Coal)
                .HasColumnName("Coal")
                .HasPrecision(10, 4)
                .IsOptional();
            Property(t => t.Rock)
                .HasColumnName("Rock")
                .HasPrecision(10, 4)
                .IsOptional();
            Property(t => t.ConstructionSituation)
                .HasColumnName("ConstructionSituation")
                .HasMaxLength(765)
                .IsOptional();
            Property(t => t.SpaceBefore)
                .HasColumnName("SpaceBefore")
                .HasMaxLength(765)
                .IsOptional();
            Property(t => t.IsEndHole)
                .HasColumnName("IsEndHole")
                .IsRequired();
            Property(t => t.Team)
                .HasColumnName("Team")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.CollectionTime)
                .HasColumnName("CollectionTime")
                .IsRequired();
            Property(t => t.CreationTime)
                .HasColumnName("CreationTime")
                .IsRequired();
            Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasMaxLength(765)
                .IsOptional();

            // Relationships
            HasRequired(t => t.ConstructionSiteZtconstructionsite)
                .WithMany(t => t.ConstructionSiteZtholes)
                .HasForeignKey(d => d.ConstructionSiteId)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}