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
    public partial class CmaddressconfigMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cmaddressconfig>
    {
        public CmaddressconfigMap()
        {
            // table
            ToTable("cmaddressconfig");

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
            Property(t => t.SensorId)
                .HasColumnName("SensorId")
                .IsOptional();
            Property(t => t.SysType)
                .HasColumnName("SysType")
                .IsRequired();
            Property(t => t.ObjectType)
                .HasColumnName("ObjectType")
                .IsRequired();
            Property(t => t.Code)
                .HasColumnName("Code")
                .HasMaxLength(150)
                .IsRequired();
            Property(t => t.CreationTime)
                .HasColumnName("CreationTime")
                .IsRequired();

            // Relationships
            HasRequired(t => t.AddressCmaddress)
                .WithMany(t => t.AddressCmaddressconfigs)
                .HasForeignKey(d => d.AddressId)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.SensorCmsensorinfo)
                .WithMany(t => t.SensorCmaddressconfigs)
                .HasForeignKey(d => d.SensorId)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}