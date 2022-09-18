﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroVendas.Data;

namespace RegistroVendas.Migrations
{
    [DbContext(typeof(RegistroVendasContext))]
    partial class RegistroVendasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RegistroVendas.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("RegistroVendas.Models.Vendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataVenda");

                    b.Property<int>("Status");

                    b.Property<double>("Valor");

                    b.Property<int?>("VendedorId");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("RegistroVendas.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalarial");

                    b.Property<string>("CPF");

                    b.Property<int?>("DepartamentoId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("RegistroVendas.Models.Vendas", b =>
                {
                    b.HasOne("RegistroVendas.Models.Vendedor", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("RegistroVendas.Models.Vendedor", b =>
                {
                    b.HasOne("RegistroVendas.Models.Departamento", "Departamento")
                        .WithMany("Vendedores")
                        .HasForeignKey("DepartamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
