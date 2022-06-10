﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoAulaBackEnd.Models;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220608142217_cris02")]
    partial class cris02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Hospede", b =>
                {
                    b.Property<int>("IdHospede")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHospede"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdHospede");

                    b.ToTable("Hospede");
                });

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Imovel", b =>
                {
                    b.Property<int>("IdImovel")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto1")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("QtdeHospedes")
                        .HasColumnType("int");

                    b.Property<int>("TipoAc")
                        .HasColumnType("int");

                    b.Property<int>("TipoEsp")
                        .HasColumnType("int");

                    b.HasKey("IdImovel");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Imovel", b =>
                {
                    b.HasOne("ProjetoAulaBackEnd.Models.Hospede", "IdHospede")
                        .WithMany()
                        .HasForeignKey("IdImovel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdHospede");
                });
#pragma warning restore 612, 618
        }
    }
}
