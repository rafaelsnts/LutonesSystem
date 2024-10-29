﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using LutonesSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LutonesSystem.Context { };

public partial class LutonesSystemContext : DbContext
{
    public LutonesSystemContext()
    {
    }

    public LutonesSystemContext(DbContextOptions<LutonesSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<tb_clientes> tb_clientes { get; set; }

    public virtual DbSet<tb_fornecedores> tb_fornecedores { get; set; }

    public virtual DbSet<tb_funcionarios> tb_funcionarios { get; set; }

    public virtual DbSet<tb_insumos> tb_insumos { get; set; }

    public virtual DbSet<tb_produtos> tb_produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RAFAEL\\SQLEXPRESS;Initial Catalog=LutonesSystem;User ID=sa;Password=9173rafa;TrustServerCertificate=True\r\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tb_insumos>(entity =>
        {
            entity.HasKey(e => e.in_id).HasName("PK__tb_mater__72C1AF320FF7A5E9");

            entity.HasOne(d => d.in_fk_id_fornecedoresNavigation).WithMany(p => p.tb_insumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_insumos_tb_fornecedores");
        });

        modelBuilder.Entity<tb_produtos>(entity =>
        {
            entity.HasKey(e => e.prd_id).HasName("PK__tb_produ__CE5CB948399D068F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}