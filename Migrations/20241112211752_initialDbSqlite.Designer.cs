﻿// <auto-generated />
using System;
using EstoqueVendasSQLITE.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstoqueVendasSQLITE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241112211752_initialDbSqlite")]
    partial class initialDbSqlite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.EntradaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("PrecoCusto")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("EntradaProduto");
                });

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FornecedorNome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.LoginModel", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Login");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProdutoNome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.SaidaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Ativado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("LucroVenda")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("SaidaProduto");
                });

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.EntradaProduto", b =>
                {
                    b.HasOne("EstoqueVendasSQLITE.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.Produto", b =>
                {
                    b.HasOne("EstoqueVendasSQLITE.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("EstoqueVendasSQLITE.Models.SaidaProduto", b =>
                {
                    b.HasOne("EstoqueVendasSQLITE.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
