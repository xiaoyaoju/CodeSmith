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
    public partial class TfpointclosedwallMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tfpointclosedwall>
    {
        public TfpointclosedwallMap()
        {
            // table
            ToTable("tfpointclosedwall");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.AddressId)
                .HasColumnName("AddressId")
                .IsRequired();
            Property(t => t.Co)
                .HasColumnName("CO")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.Co2)
                .HasColumnName("CO2")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.C2h4)
                .HasColumnName("C2H4")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.Ch4)
                .HasColumnName("CH4")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.C2h6)
                .HasColumnName("C2H6")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.C2h2)
                .HasColumnName("C2H2")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.O2)
                .HasColumnName("O2")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.N2)
                .HasColumnName("N2")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.T)
                .HasColumnName("T")
                .HasPrecision(18, 4)
                .IsOptional();
            Property(t => t.RiskSituation)
                .HasColumnName("RiskSituation")
                .IsOptional();
            Property(t => t.EffectArea)
                .HasColumnName("EffectArea")
                .IsOptional();
            Property(t => t.ProcessMeasure)
                .HasColumnName("ProcessMeasure")
                .IsOptional();
            Property(t => t.CreationTime)
                .HasColumnName("CreationTime")
                .IsRequired();
            Property(t => t.CollectionTime)
                .HasColumnName("CollectionTime")
                .IsRequired();

            // Relationships
            HasRequired(t => t.AddressCmaddress)
                .WithMany(t => t.AddressTfpointclosedwalls)
                .HasForeignKey(d => d.AddressId)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
