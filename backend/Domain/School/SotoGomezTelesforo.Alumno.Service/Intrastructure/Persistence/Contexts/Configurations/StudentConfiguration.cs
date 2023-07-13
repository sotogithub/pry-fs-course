﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts.Configurations
{
    public partial class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3214EC07D1387945");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Address)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.Phone)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Student> entity);
    }
}
